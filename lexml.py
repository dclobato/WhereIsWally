__author__ = 'dclobato'
from lxml import etree
from urllib2 import urlopen
from progressbar import ProgressBar, Percentage, Bar
import heapq
import numpy

USER_SECRET    = "[secret-key-here]"
CHECKIN_COUNTS = 5000
URL            = "https://feeds.foursquare.com/history/" + USER_SECRET + ".rss?count=" + str(CHECKIN_COUNTS)

NUM_ITERACOES  = 500
TOP_K          = 5
R_EPSILON      = 1e-05 #1e-05
A_EPSILON      = 1e-08 #1e-08

#raiz = etree.parse(urlopen(URL))
raiz = etree.parse("dclobato.xml")

itens  = raiz.xpath("/rss/channel/item/title/text()")
quando = raiz.xpath("/rss/channel/item/pubDate/text()")

unicos = list(set(itens))

total_de_checkins = len(itens)
locais_unicos     = len(unicos)

matriz_saltos         = numpy.zeros(locais_unicos*locais_unicos, dtype=int).reshape(locais_unicos,locais_unicos)
matriz_probabilidades = numpy.zeros(locais_unicos*locais_unicos, dtype=float).reshape(locais_unicos,locais_unicos)
vetor                 = numpy.zeros(locais_unicos, dtype=float).reshape(locais_unicos)

pbar = ProgressBar(widgets=["Efetuando saltos... ", Percentage(), " ", Bar(marker='#',left='[',right=']')], maxval=total_de_checkins, term_width=100).start()
for k in range (1, total_de_checkins):
    i = unicos.index(itens[k])
    j = unicos.index(itens[k-1])
    pbar.update(k)
    matriz_saltos[i][j] = matriz_saltos[i][j]+1
pbar.finish()

pbar = ProgressBar(widgets=["Calculando matriz de probabilidades... ", Percentage(), " ", Bar(marker='#',left='[',right=']')], maxval=locais_unicos, term_width=100).start()
for i in range(0, locais_unicos):
    soma = 0.0
    for j in range (0, locais_unicos):
        soma = soma + matriz_saltos[i][j]
    if (soma > 0.0):
        for j in range (0, locais_unicos):
            matriz_probabilidades[i][j] = matriz_saltos[i][j] / soma
    pbar.update(i)
pbar.finish()

print("============================================")
print("Locais unicos")
for i in range (0, locais_unicos):
    print("[%4d]: %s" % (i, unicos[i]))#.encode(encoding="iso-8859-1", errors="replace")

while True:
    print("Ultimo checkin em %s [%d]" % (itens[0], unicos.index(itens[0])))
    comeca = int(raw_input("Qual o ponto de partida (menor que o total de checkins unicos)? "))

    if (comeca >= 0 and comeca <= locais_unicos):
        print ("Comecamos em %s? " % unicos[comeca])
        sim = raw_input("(S/N)? ")
        if (sim.lower() == "s"):
            break

print("Definindo o ponto de partida: %s" % (unicos[comeca]))
vetor[unicos.index(unicos[comeca])] = 1.0

ultimo = numpy.zeros(TOP_K, dtype=float).reshape(TOP_K)

for iteracao in range (1, NUM_ITERACOES+1):
    vetor = vetor.dot(matriz_probabilidades)
    maiores = heapq.nlargest(TOP_K, vetor)
    #print(maiores)
    if (numpy.allclose(maiores, ultimo, R_EPSILON, A_EPSILON)):
        break
    ultimo = maiores

maiores = vetor.argsort()[-TOP_K:]
maiores = maiores[::-1]
print ("TOP %d locais mais provaveis:" % (TOP_K))
for i in maiores:
    print ("    %s: %.3f%%" % (unicos[i], vetor[i]*100))

print("")
if (iteracao == NUM_ITERACOES):
    print("Paramos depois de %d iteracoes sem convergencia" % (iteracao))
else:
    print("Convergimos em %d iteracoes" % (iteracao))
