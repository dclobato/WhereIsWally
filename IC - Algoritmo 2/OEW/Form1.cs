using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using MultiplicarMatrizes;

namespace OEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            txtlocalizar.Text = op.FileName;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(txtlocalizar.Text);
            ArrayList Estados = new ArrayList();
            ArrayList EstadosN2 = new ArrayList();
            float[,] M2 = new float[100,100]; 
            int i = -1;
            int conta = 0;

            int estadoanterior = -1;

            lblnome.Text = xmldoc.ChildNodes[1].FirstChild.FirstChild.InnerText;

            lblnome.Text = "Usuário: " + lblnome.Text.Substring(31, lblnome.Text.Length - 31);

            foreach (XmlElement x in xmldoc.ChildNodes[1])
            {
                float[,] M1 = new float[x.SelectNodes("item").Count,x.SelectNodes("item").Count];
                 
                foreach (XmlElement z in x.SelectNodes("item"))
                {
                    if (conta == 1)
                    {
                        lblestado2.Text = "Estado Anterior: " + z.FirstChild.InnerText;
                        conta = 2;
                    }
                    if (conta == 0)
                    {
                        lblestado1.Text = "Estado Atual: " + z.FirstChild.InnerText;
                        conta = 1;
                    }


                   //verifica se tem  o index desse estado 
                   int index = Estados.IndexOf(z.FirstChild.InnerText);
                    
                   //se não tiver adiciona a array Estados
                   if (index == -1)
                   {
                       Estados.Add(z.FirstChild.InnerText);
                       //grid.Columns.Add(z.FirstChild.InnerText, z.FirstChild.InnerText);
                     //  grid2.Columns.Add(z.FirstChild.InnerText + Estados.IndexOf(z.FirstChild.InnerText), z.FirstChild.InnerText + Estados.IndexOf(z.FirstChild.InnerText));
                   }


                    index = Estados.IndexOf(z.FirstChild.InnerText);

                    if ((EstadosN2.IndexOf(i & index) == -1) && (i!= -1))
                   { 

                        EstadosN2.Add(i.ToString() + index.ToString());
                   
               
                   }




                   if ((i != -1) && (estadoanterior != -1))
                       M1[EstadosN2.IndexOf(i.ToString() + Estados.IndexOf(z.FirstChild.InnerText).ToString()), estadoanterior] = M1[EstadosN2.IndexOf(i.ToString() + Estados.IndexOf(z.FirstChild.InnerText).ToString()), estadoanterior] + 1;
                                           
                  



                  
                   estadoanterior = i;
                   i = Estados.IndexOf(z.FirstChild.InnerText);
                }// end for2


                //for (int j = 0; j <= Estados.Count; j = j + 1)
                //{
                //    grid2.Rows.Add();
                //    grid2.Rows[j].Cells[0].Value = j;
                //    for (int y = 0; y < Estados.Count; y = y + 1)
                //    {
                //        grid2.Rows[j].Cells[y + 1].Value = M1[j, y];
                //    }
                //}





                float[,] MF = new float[EstadosN2.Count, Estados.Count];

                float[,] MF2 = new float[1, EstadosN2.Count];
                MF2[0,0] = 1;

                float contE = 0;

                for (int j = 0; j <= EstadosN2.Count; j = j + 1)
                {

                    for (int y = 0; y <= Estados.Count; y = y + 1)
                    {
                        if (M1[ j , y] > 0)
                            contE = contE + M1[ j , y];
                    }

                    for (int y = 0; y <= Estados.Count; y = y + 1)
                    {
                        if (M1[j , y] > 0)
                        {
                            MF[ j, y] = M1[j , y] / contE;

                        }
                    }
                    contE = 0;
                }





                    MF2  = Matriz.MultiplicarMatrizes(MF2, MF, 1, EstadosN2.Count, EstadosN2.Count, Estados.Count);


                    grid.Rows.Clear();
                    int w = -1;
                    float maior2 = 0;

                    for (int d = 0; d < Estados.Count; d = d + 1)
                    {
                        w = -1;
                        maior2 = 0;
                    for (int j = 0; j < Estados.Count; j = j + 1)
                    {
                        if (MF2[0, j] > maior2)
                        {
                            maior2 = MF2[0, j];
                            w = j;


                        }
                    }
                    if (w != -1) { 
                    if (MF2[0, w] == 0)
                        d = Estados.Count;

                    grid.Rows.Add(Estados[w],  MF2[0, w] * 100);
                    MF2[0, w] = 0;
                    }
            }


                









                    
                    // aux = variável que usaremos para guardar o maior valor de cada comparação 
      
        

            }//end for 1


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }

}
