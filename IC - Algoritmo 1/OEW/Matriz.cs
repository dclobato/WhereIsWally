using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicarMatrizes
{
    static class Matriz
    {



        public static float[,] MultiplicarMatrizes(float[,] A, float[,] B, int LinhasA, int LinhasB, int ColunasA, int ColunasB)
        {
            float[,] C = new float[LinhasA, ColunasB];

            for (int i = 0; i < LinhasA; i++)
                for (int j = 0; j < ColunasB; j++)
                    for (int k = 0; k < LinhasB; k++)
                        C[i, j] += A[i, k] * B[k, j];

            return C;

        }


        public static Boolean ComparaMatrizes(float[,] A, float[,] B, int LinhasA, int LinhasB, int ColunasA, int ColunasB)
        {
            float[,] C = new float[LinhasA, ColunasB];

            for (int i = 0; i < LinhasA; i++)
                for (int j = 0; j < ColunasB; j++)
                    if (A[i, j] != B[i, j])
                        return false;


            return true;

        }

        public static int MaiorMatrizes(float[,] A, int LinhasA, int ColunasA)
        {
            float[,] C = new float[LinhasA, ColunasA];
            float maior = 0;
            int coluna = 0;
            for (int i = 0; i < LinhasA; i++)
                for (int j = 0; j < ColunasA; j++)
                    if (A[i, j] > maior)
                    {
                        maior = A[i, j];
                        coluna = j;
                    }

            return coluna;

        }


    }
}
