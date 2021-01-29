using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace interfas
{
    class llenartop10
    {
        private string nombre;
        private string apellido;
        private int puntaje;
        public bool top_ordenado = false;
        public string[,] NombreApellidoPuntaje = new string[20, 3];
        int[] puntajes = new int[20];
        public void llenar1()
        {
            
            StreamReader s1 = new StreamReader("datos1.txt");
            string line = "";
            string[] label = new string[30];
            int contador = 0;
            while (s1.EndOfStream == false)
            {
                line = s1.ReadLine();
                string[] split = line.Split(';');
                for (int b = 0; b <= 2; b++)
                {
                    if(split[b] == "" || split[b] == null)
                    {
                        
                    }
                    else
                    {
                    label[contador] = split[b];
                    }
                    if (contador != 30)
                    {
                        contador++;
                    }

                }
            }
            s1.Close();
            NombreApellidoPuntaje[0, 0] = label[0];
            NombreApellidoPuntaje[1, 0] = label[3];
            NombreApellidoPuntaje[2, 0] = label[6];
            NombreApellidoPuntaje[3, 0] = label[9];
            NombreApellidoPuntaje[4, 0] = label[12];
            NombreApellidoPuntaje[5, 0] = label[15];
            NombreApellidoPuntaje[6, 0] = label[18];
            NombreApellidoPuntaje[7, 0] = label[21];
            NombreApellidoPuntaje[8, 0] = label[24];
            NombreApellidoPuntaje[9, 0] = label[27];

            NombreApellidoPuntaje[0, 1] = label[1];
            NombreApellidoPuntaje[1, 1] = label[4];
            NombreApellidoPuntaje[2, 1] = label[7];
            NombreApellidoPuntaje[3, 1] = label[10];
            NombreApellidoPuntaje[4, 1] = label[13];
            NombreApellidoPuntaje[5, 1] = label[16];
            NombreApellidoPuntaje[6, 1] = label[19];
            NombreApellidoPuntaje[7, 1] = label[22];
            NombreApellidoPuntaje[8, 1] = label[25];
            NombreApellidoPuntaje[9, 1] = label[28];

            NombreApellidoPuntaje[0, 2] = label[2];
            NombreApellidoPuntaje[1, 2] = label[5];
            NombreApellidoPuntaje[2, 2] = label[8];
            NombreApellidoPuntaje[3, 2] = label[11];
            NombreApellidoPuntaje[4, 2] = label[14];
            NombreApellidoPuntaje[5, 2] = label[17];
            NombreApellidoPuntaje[6, 2] = label[20];
            NombreApellidoPuntaje[7, 2] = label[23];
            NombreApellidoPuntaje[8, 2] = label[26];
            NombreApellidoPuntaje[9, 2] = label[29];

            bool cambio = false;
            puntajes[0] = Convert.ToInt16(NombreApellidoPuntaje[0, 2]);
            puntajes[1] = Convert.ToInt16(NombreApellidoPuntaje[1, 2]);
            puntajes[2] = Convert.ToInt16(NombreApellidoPuntaje[2, 2]);
            puntajes[3] = Convert.ToInt16(NombreApellidoPuntaje[3, 2]);
            puntajes[4] = Convert.ToInt16(NombreApellidoPuntaje[4, 2]);
            puntajes[5] = Convert.ToInt16(NombreApellidoPuntaje[5, 2]);
            puntajes[6] = Convert.ToInt16(NombreApellidoPuntaje[6, 2]);
            puntajes[7] = Convert.ToInt16(NombreApellidoPuntaje[7, 2]);
            puntajes[8] = Convert.ToInt16(NombreApellidoPuntaje[8, 2]);
            puntajes[9] = Convert.ToInt16(NombreApellidoPuntaje[9, 2]);

            for (int x = 0; x <= 9; x++)
            {
                if (puntajes[x] > puntajes[x + 1])
                {
                    if (puntajes[x] > puntajes[x + 2])
                    {
                        if (puntajes[x] > puntajes[x + 3])
                        {
                            if (puntajes[x] > puntajes[x + 4])
                            {
                                if (puntajes[x] > puntajes[x + 5])
                                {
                                    if (puntajes[x] > puntajes[x + 6])
                                    {
                                        if (puntajes[x] > puntajes[x + 7])
                                        {
                                            if (puntajes[x] > puntajes[x + 8])
                                            {
                                                if (puntajes[x] > puntajes[x + 9])
                                                {
                                                    if (cambio)
                                                    {
                                                        x = 0;
                                                        cambio = false;
                                                    }
                                                }
                                                else if (puntajes[x] < puntajes[x + 9])
                                                {
                                                    NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                                    NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                                    NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                                    NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                                    NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                                    NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                                    NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                                    NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                                    NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                                    NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                                    NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                                    NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                                    NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                                    NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                                    NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                                    NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                                    NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                                    NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];
                                                    NombreApellidoPuntaje[17, 0] = NombreApellidoPuntaje[x + 6, 0];
                                                    NombreApellidoPuntaje[17, 1] = NombreApellidoPuntaje[x + 6, 1];
                                                    NombreApellidoPuntaje[17, 2] = NombreApellidoPuntaje[x + 6, 2];
                                                    NombreApellidoPuntaje[18, 0] = NombreApellidoPuntaje[x + 7, 0];
                                                    NombreApellidoPuntaje[18, 1] = NombreApellidoPuntaje[x + 7, 1];
                                                    NombreApellidoPuntaje[18, 2] = NombreApellidoPuntaje[x + 7, 2];
                                                    NombreApellidoPuntaje[19, 0] = NombreApellidoPuntaje[x + 8, 0];
                                                    NombreApellidoPuntaje[19, 1] = NombreApellidoPuntaje[x + 8, 1];
                                                    NombreApellidoPuntaje[19, 2] = NombreApellidoPuntaje[x + 8, 2];

                                                    NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 9, 0];
                                                    NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 9, 1];
                                                    NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 9, 2];
                                                    NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                                    NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                                    NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                                    NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                                    NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                                    NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                                    NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                                    NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                                    NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                                    NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                                    NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                                    NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                                    NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                                    NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                                    NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                                    NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                                    NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                                    NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];
                                                    NombreApellidoPuntaje[x + 7, 0] = NombreApellidoPuntaje[17, 0];
                                                    NombreApellidoPuntaje[x + 7, 1] = NombreApellidoPuntaje[17, 1];
                                                    NombreApellidoPuntaje[x + 7, 2] = NombreApellidoPuntaje[17, 2];
                                                    NombreApellidoPuntaje[x + 8, 0] = NombreApellidoPuntaje[18, 0];
                                                    NombreApellidoPuntaje[x + 8, 1] = NombreApellidoPuntaje[18, 1];
                                                    NombreApellidoPuntaje[x + 8, 2] = NombreApellidoPuntaje[18, 2];
                                                    NombreApellidoPuntaje[x + 9, 0] = NombreApellidoPuntaje[19, 0];
                                                    NombreApellidoPuntaje[x + 9, 1] = NombreApellidoPuntaje[19, 1];
                                                    NombreApellidoPuntaje[x + 9, 2] = NombreApellidoPuntaje[19, 2];


                                                    NombreApellidoPuntaje[11, 0] = "";
                                                    NombreApellidoPuntaje[11, 1] = "";
                                                    NombreApellidoPuntaje[11, 2] = "";
                                                    NombreApellidoPuntaje[12, 0] = "";
                                                    NombreApellidoPuntaje[12, 1] = "";
                                                    NombreApellidoPuntaje[12, 2] = "";
                                                    NombreApellidoPuntaje[13, 0] = "";
                                                    NombreApellidoPuntaje[13, 1] = "";
                                                    NombreApellidoPuntaje[13, 2] = "";
                                                    NombreApellidoPuntaje[14, 0] = "";
                                                    NombreApellidoPuntaje[14, 1] = "";
                                                    NombreApellidoPuntaje[14, 2] = "";
                                                    NombreApellidoPuntaje[15, 0] = "";
                                                    NombreApellidoPuntaje[15, 1] = "";
                                                    NombreApellidoPuntaje[15, 2] = "";
                                                    NombreApellidoPuntaje[16, 0] = "";
                                                    NombreApellidoPuntaje[16, 1] = "";
                                                    NombreApellidoPuntaje[16, 2] = "";
                                                    NombreApellidoPuntaje[17, 0] = "";
                                                    NombreApellidoPuntaje[17, 1] = "";
                                                    NombreApellidoPuntaje[17, 2] = "";
                                                    NombreApellidoPuntaje[18, 0] = "";
                                                    NombreApellidoPuntaje[18, 1] = "";
                                                    NombreApellidoPuntaje[18, 2] = "";
                                                    NombreApellidoPuntaje[19, 0] = "";
                                                    NombreApellidoPuntaje[19, 1] = "";
                                                    NombreApellidoPuntaje[19, 2] = "";

                                                    puntajes[11] = puntajes[x];
                                                    puntajes[12] = puntajes[x + 1];
                                                    puntajes[13] = puntajes[x + 2];
                                                    puntajes[14] = puntajes[x + 3];
                                                    puntajes[15] = puntajes[x + 4];
                                                    puntajes[16] = puntajes[x + 5];
                                                    puntajes[17] = puntajes[x + 6];
                                                    puntajes[18] = puntajes[x + 7];
                                                    puntajes[19] = puntajes[x + 8];

                                                    puntajes[x] = puntajes[x + 9];
                                                    puntajes[x + 1] = puntajes[11];
                                                    puntajes[x + 2] = puntajes[12];
                                                    puntajes[x + 3] = puntajes[13];
                                                    puntajes[x + 4] = puntajes[14];
                                                    puntajes[x + 5] = puntajes[15];
                                                    puntajes[x + 6] = puntajes[16];
                                                    puntajes[x + 7] = puntajes[17];
                                                    puntajes[x + 8] = puntajes[18];
                                                    puntajes[x + 9] = puntajes[19];

                                                    puntajes[11] = 0;
                                                    puntajes[12] = 0;
                                                    puntajes[13] = 0;
                                                    puntajes[14] = 0;
                                                    puntajes[15] = 0;
                                                    puntajes[16] = 0;
                                                    puntajes[17] = 0;
                                                    puntajes[18] = 0;
                                                    puntajes[19] = 0;

                                                    cambio = true;
                                                    x = 0;
                                                    x = x + 9;
                                                }
                                            }
                                            else if (puntajes[x] < puntajes[x + 8])
                                            {
                                                NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                                NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                                NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                                NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                                NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                                NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                                NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                                NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                                NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                                NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                                NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                                NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                                NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                                NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                                NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                                NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                                NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                                NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];
                                                NombreApellidoPuntaje[17, 0] = NombreApellidoPuntaje[x + 6, 0];
                                                NombreApellidoPuntaje[17, 1] = NombreApellidoPuntaje[x + 6, 1];
                                                NombreApellidoPuntaje[17, 2] = NombreApellidoPuntaje[x + 6, 2];
                                                NombreApellidoPuntaje[18, 0] = NombreApellidoPuntaje[x + 7, 0];
                                                NombreApellidoPuntaje[18, 1] = NombreApellidoPuntaje[x + 7, 1];
                                                NombreApellidoPuntaje[18, 2] = NombreApellidoPuntaje[x + 7, 2];

                                                NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 8, 0];
                                                NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 8, 1];
                                                NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 8, 2];
                                                NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                                NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                                NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                                NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                                NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                                NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                                NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                                NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                                NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                                NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                                NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                                NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                                NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                                NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                                NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                                NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                                NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                                NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];
                                                NombreApellidoPuntaje[x + 7, 0] = NombreApellidoPuntaje[17, 0];
                                                NombreApellidoPuntaje[x + 7, 1] = NombreApellidoPuntaje[17, 1];
                                                NombreApellidoPuntaje[x + 7, 2] = NombreApellidoPuntaje[17, 2];
                                                NombreApellidoPuntaje[x + 8, 0] = NombreApellidoPuntaje[18, 0];
                                                NombreApellidoPuntaje[x + 8, 1] = NombreApellidoPuntaje[18, 1];
                                                NombreApellidoPuntaje[x + 8, 2] = NombreApellidoPuntaje[18, 2];


                                                NombreApellidoPuntaje[11, 0] = "";
                                                NombreApellidoPuntaje[11, 1] = "";
                                                NombreApellidoPuntaje[11, 2] = "";
                                                NombreApellidoPuntaje[12, 0] = "";
                                                NombreApellidoPuntaje[12, 1] = "";
                                                NombreApellidoPuntaje[12, 2] = "";
                                                NombreApellidoPuntaje[13, 0] = "";
                                                NombreApellidoPuntaje[13, 1] = "";
                                                NombreApellidoPuntaje[13, 2] = "";
                                                NombreApellidoPuntaje[14, 0] = "";
                                                NombreApellidoPuntaje[14, 1] = "";
                                                NombreApellidoPuntaje[14, 2] = "";
                                                NombreApellidoPuntaje[15, 0] = "";
                                                NombreApellidoPuntaje[15, 1] = "";
                                                NombreApellidoPuntaje[15, 2] = "";
                                                NombreApellidoPuntaje[16, 0] = "";
                                                NombreApellidoPuntaje[16, 1] = "";
                                                NombreApellidoPuntaje[16, 2] = "";
                                                NombreApellidoPuntaje[17, 0] = "";
                                                NombreApellidoPuntaje[17, 1] = "";
                                                NombreApellidoPuntaje[17, 2] = "";
                                                NombreApellidoPuntaje[18, 0] = "";
                                                NombreApellidoPuntaje[18, 1] = "";
                                                NombreApellidoPuntaje[18, 2] = "";

                                                puntajes[11] = puntajes[x];
                                                puntajes[12] = puntajes[x + 1];
                                                puntajes[13] = puntajes[x + 2];
                                                puntajes[14] = puntajes[x + 3];
                                                puntajes[15] = puntajes[x + 4];
                                                puntajes[16] = puntajes[x + 5];
                                                puntajes[17] = puntajes[x + 6];
                                                puntajes[18] = puntajes[x + 7];

                                                puntajes[x] = puntajes[x + 8];
                                                puntajes[x + 1] = puntajes[11];
                                                puntajes[x + 2] = puntajes[12];
                                                puntajes[x + 3] = puntajes[13];
                                                puntajes[x + 4] = puntajes[14];
                                                puntajes[x + 5] = puntajes[15];
                                                puntajes[x + 6] = puntajes[16];
                                                puntajes[x + 7] = puntajes[17];
                                                puntajes[x + 8] = puntajes[18];

                                                puntajes[11] = 0;
                                                puntajes[12] = 0;
                                                puntajes[13] = 0;
                                                puntajes[14] = 0;
                                                puntajes[15] = 0;
                                                puntajes[16] = 0;
                                                puntajes[17] = 0;
                                                puntajes[18] = 0;

                                                cambio = true;
                                                x = 0;
                                                x = x + 8;
                                            }
                                        }
                                        else if (puntajes[x] < puntajes[x + 7])
                                        {
                                            NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                            NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                            NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                            NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                            NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                            NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                            NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                            NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                            NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                            NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                            NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                            NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                            NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                            NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                            NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                            NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                            NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                            NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];
                                            NombreApellidoPuntaje[17, 0] = NombreApellidoPuntaje[x + 6, 0];
                                            NombreApellidoPuntaje[17, 1] = NombreApellidoPuntaje[x + 6, 1];
                                            NombreApellidoPuntaje[17, 2] = NombreApellidoPuntaje[x + 6, 2];

                                            NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 7, 0];
                                            NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 7, 1];
                                            NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 7, 2];
                                            NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                            NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                            NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                            NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                            NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                            NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                            NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                            NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                            NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                            NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                            NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                            NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                            NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                            NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                            NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                            NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                            NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                            NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];
                                            NombreApellidoPuntaje[x + 7, 0] = NombreApellidoPuntaje[17, 0];
                                            NombreApellidoPuntaje[x + 7, 1] = NombreApellidoPuntaje[17, 1];
                                            NombreApellidoPuntaje[x + 7, 2] = NombreApellidoPuntaje[17, 2];


                                            NombreApellidoPuntaje[11, 0] = "";
                                            NombreApellidoPuntaje[11, 1] = "";
                                            NombreApellidoPuntaje[11, 2] = "";
                                            NombreApellidoPuntaje[12, 0] = "";
                                            NombreApellidoPuntaje[12, 1] = "";
                                            NombreApellidoPuntaje[12, 2] = "";
                                            NombreApellidoPuntaje[13, 0] = "";
                                            NombreApellidoPuntaje[13, 1] = "";
                                            NombreApellidoPuntaje[13, 2] = "";
                                            NombreApellidoPuntaje[14, 0] = "";
                                            NombreApellidoPuntaje[14, 1] = "";
                                            NombreApellidoPuntaje[14, 2] = "";
                                            NombreApellidoPuntaje[15, 0] = "";
                                            NombreApellidoPuntaje[15, 1] = "";
                                            NombreApellidoPuntaje[15, 2] = "";
                                            NombreApellidoPuntaje[16, 0] = "";
                                            NombreApellidoPuntaje[16, 1] = "";
                                            NombreApellidoPuntaje[16, 2] = "";
                                            NombreApellidoPuntaje[17, 0] = "";
                                            NombreApellidoPuntaje[17, 1] = "";
                                            NombreApellidoPuntaje[17, 2] = "";

                                            puntajes[11] = puntajes[x];
                                            puntajes[12] = puntajes[x + 1];
                                            puntajes[13] = puntajes[x + 2];
                                            puntajes[14] = puntajes[x + 3];
                                            puntajes[15] = puntajes[x + 4];
                                            puntajes[16] = puntajes[x + 5];
                                            puntajes[17] = puntajes[x + 6];

                                            puntajes[x] = puntajes[x + 7];
                                            puntajes[x + 1] = puntajes[11];
                                            puntajes[x + 2] = puntajes[12];
                                            puntajes[x + 3] = puntajes[13];
                                            puntajes[x + 4] = puntajes[14];
                                            puntajes[x + 5] = puntajes[15];
                                            puntajes[x + 6] = puntajes[16];
                                            puntajes[x + 7] = puntajes[17];

                                            puntajes[11] = 0;
                                            puntajes[12] = 0;
                                            puntajes[13] = 0;
                                            puntajes[14] = 0;
                                            puntajes[15] = 0;
                                            puntajes[16] = 0;
                                            puntajes[17] = 0;

                                            cambio = true;
                                            x = 0;
                                            x = x + 7;
                                        }
                                    }
                                    else if (puntajes[x] < puntajes[x + 6])
                                    {
                                        NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                        NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                        NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                        NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                        NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                        NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                        NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                        NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                        NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                        NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                        NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                        NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                        NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                        NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                        NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                        NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                        NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                        NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];

                                        NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 6, 0];
                                        NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 6, 1];
                                        NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 6, 2];
                                        NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                        NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                        NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                        NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                        NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                        NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                        NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                        NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                        NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                        NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                        NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                        NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                        NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                        NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                        NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                        NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                        NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                        NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];


                                        NombreApellidoPuntaje[11, 0] = "";
                                        NombreApellidoPuntaje[11, 1] = "";
                                        NombreApellidoPuntaje[11, 2] = "";
                                        NombreApellidoPuntaje[12, 0] = "";
                                        NombreApellidoPuntaje[12, 1] = "";
                                        NombreApellidoPuntaje[12, 2] = "";
                                        NombreApellidoPuntaje[13, 0] = "";
                                        NombreApellidoPuntaje[13, 1] = "";
                                        NombreApellidoPuntaje[13, 2] = "";
                                        NombreApellidoPuntaje[14, 0] = "";
                                        NombreApellidoPuntaje[14, 1] = "";
                                        NombreApellidoPuntaje[14, 2] = "";
                                        NombreApellidoPuntaje[15, 0] = "";
                                        NombreApellidoPuntaje[15, 1] = "";
                                        NombreApellidoPuntaje[15, 2] = "";
                                        NombreApellidoPuntaje[16, 0] = "";
                                        NombreApellidoPuntaje[16, 1] = "";
                                        NombreApellidoPuntaje[16, 2] = "";

                                        puntajes[11] = puntajes[x];
                                        puntajes[12] = puntajes[x + 1];
                                        puntajes[13] = puntajes[x + 2];
                                        puntajes[14] = puntajes[x + 3];
                                        puntajes[15] = puntajes[x + 4];
                                        puntajes[16] = puntajes[x + 5];

                                        puntajes[x] = puntajes[x + 6];
                                        puntajes[x + 1] = puntajes[11];
                                        puntajes[x + 2] = puntajes[12];
                                        puntajes[x + 3] = puntajes[13];
                                        puntajes[x + 4] = puntajes[14];
                                        puntajes[x + 5] = puntajes[15];
                                        puntajes[x + 6] = puntajes[16];

                                        puntajes[11] = 0;
                                        puntajes[12] = 0;
                                        puntajes[13] = 0;
                                        puntajes[14] = 0;
                                        puntajes[15] = 0;
                                        puntajes[16] = 0;

                                        cambio = true;
                                        x = 0;
                                        x = x + 6;
                                    }
                                }
                                else if (puntajes[x] < puntajes[x + 5])
                                {
                                    NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                    NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                    NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                    NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                    NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                    NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                    NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                    NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                    NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                    NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                    NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                    NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                    NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                    NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                    NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];

                                    NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 5, 0];
                                    NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 5, 1];
                                    NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 5, 2];
                                    NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                    NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                    NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                    NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                    NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                    NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                    NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                    NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                    NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                    NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                    NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                    NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                    NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                    NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                    NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];


                                    NombreApellidoPuntaje[11, 0] = "";
                                    NombreApellidoPuntaje[11, 1] = "";
                                    NombreApellidoPuntaje[11, 2] = "";
                                    NombreApellidoPuntaje[12, 0] = "";
                                    NombreApellidoPuntaje[12, 1] = "";
                                    NombreApellidoPuntaje[12, 2] = "";
                                    NombreApellidoPuntaje[13, 0] = "";
                                    NombreApellidoPuntaje[13, 1] = "";
                                    NombreApellidoPuntaje[13, 2] = "";
                                    NombreApellidoPuntaje[14, 0] = "";
                                    NombreApellidoPuntaje[14, 1] = "";
                                    NombreApellidoPuntaje[14, 2] = "";
                                    NombreApellidoPuntaje[15, 0] = "";
                                    NombreApellidoPuntaje[15, 1] = "";
                                    NombreApellidoPuntaje[15, 2] = "";

                                    puntajes[11] = puntajes[x];
                                    puntajes[12] = puntajes[x + 1];
                                    puntajes[13] = puntajes[x + 2];
                                    puntajes[14] = puntajes[x + 3];
                                    puntajes[15] = puntajes[x + 4];

                                    puntajes[x] = puntajes[x + 5];
                                    puntajes[x + 1] = puntajes[11];
                                    puntajes[x + 2] = puntajes[12];
                                    puntajes[x + 3] = puntajes[13];
                                    puntajes[x + 4] = puntajes[14];
                                    puntajes[x + 5] = puntajes[15];

                                    puntajes[11] = 0;
                                    puntajes[12] = 0;
                                    puntajes[13] = 0;
                                    puntajes[14] = 0;
                                    puntajes[15] = 0;

                                    cambio = true;
                                    x = 0;
                                    x = x + 5;
                                }
                            }
                            else if (puntajes[x] < puntajes[x + 4])
                            {
                                NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];

                                NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 4, 0];
                                NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 4, 1];
                                NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 4, 2];
                                NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];

                                NombreApellidoPuntaje[11, 0] = "";
                                NombreApellidoPuntaje[11, 1] = "";
                                NombreApellidoPuntaje[11, 2] = "";
                                NombreApellidoPuntaje[12, 0] = "";
                                NombreApellidoPuntaje[12, 1] = "";
                                NombreApellidoPuntaje[12, 2] = "";
                                NombreApellidoPuntaje[13, 0] = "";
                                NombreApellidoPuntaje[13, 1] = "";
                                NombreApellidoPuntaje[13, 2] = "";
                                NombreApellidoPuntaje[14, 0] = "";
                                NombreApellidoPuntaje[14, 1] = "";
                                NombreApellidoPuntaje[14, 2] = "";

                                puntajes[11] = puntajes[x];
                                puntajes[12] = puntajes[x + 1];
                                puntajes[13] = puntajes[x + 2];
                                puntajes[14] = puntajes[x + 3];

                                puntajes[x] = puntajes[x + 4];
                                puntajes[x + 1] = puntajes[11];
                                puntajes[x + 2] = puntajes[12];
                                puntajes[x + 3] = puntajes[13];
                                puntajes[x + 4] = puntajes[14];

                                puntajes[11] = 0;
                                puntajes[12] = 0;
                                puntajes[13] = 0;
                                puntajes[14] = 0;

                                cambio = true;
                                x = 0;
                                x = x + 4;
                            }
                        }
                        else if (puntajes[x] < puntajes[x + 3])
                        {
                            NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                            NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                            NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                            NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                            NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                            NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                            NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                            NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                            NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];

                            NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 3, 0];
                            NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 3, 1];
                            NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 3, 2];
                            NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                            NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                            NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                            NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                            NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                            NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];

                            NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                            NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                            NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];

                            NombreApellidoPuntaje[11, 0] = "";
                            NombreApellidoPuntaje[11, 1] = "";
                            NombreApellidoPuntaje[11, 2] = "";
                            NombreApellidoPuntaje[12, 0] = "";
                            NombreApellidoPuntaje[12, 1] = "";
                            NombreApellidoPuntaje[12, 2] = "";
                            NombreApellidoPuntaje[13, 0] = "";
                            NombreApellidoPuntaje[13, 1] = "";
                            NombreApellidoPuntaje[13, 2] = "";

                            puntajes[11] = puntajes[x];
                            puntajes[12] = puntajes[x + 1];
                            puntajes[13] = puntajes[x + 2];

                            puntajes[x] = puntajes[x + 3];
                            puntajes[x + 1] = puntajes[11];
                            puntajes[x + 2] = puntajes[12];

                            puntajes[x + 3] = puntajes[13];

                            puntajes[11] = 0;
                            puntajes[12] = 0;
                            puntajes[13] = 0;

                            cambio = true;
                            x = 0;
                            x = x + 3;
                        }
                    }
                    else if (puntajes[x] < puntajes[x + 2])
                    {
                        NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                        NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                        NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                        NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                        NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                        NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];

                        NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 2, 0];
                        NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 2, 1];
                        NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 2, 2];
                        NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                        NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                        NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];

                        NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                        NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                        NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];

                        NombreApellidoPuntaje[11, 0] = "";
                        NombreApellidoPuntaje[11, 1] = "";
                        NombreApellidoPuntaje[11, 2] = "";
                        NombreApellidoPuntaje[12, 0] = "";
                        NombreApellidoPuntaje[12, 1] = "";
                        NombreApellidoPuntaje[12, 2] = "";

                        puntajes[11] = puntajes[x];
                        puntajes[12] = puntajes[x + 1];

                        puntajes[x] = puntajes[x + 2];
                        puntajes[x + 1] = puntajes[11];

                        puntajes[x + 2] = puntajes[12];

                        puntajes[11] = 0;
                        puntajes[12] = 0;

                        cambio = true;
                        x = 0;
                        x = x + 2;
                    }
                }
                else if (puntajes[x] < puntajes[x + 1])
                {
                    NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                    NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                    NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];

                    NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 1, 0];
                    NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 1, 1];
                    NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 1, 2];

                    NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                    NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                    NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];

                    NombreApellidoPuntaje[11, 0] = "";
                    NombreApellidoPuntaje[11, 1] = "";
                    NombreApellidoPuntaje[11, 2] = "";

                    puntajes[11] = puntajes[x];

                    puntajes[x] = puntajes[x + 1];

                    puntajes[x + 1] = puntajes[11];

                    puntajes[11] = 0;

                    cambio = true;
                    x = 0;
                    x++;
                }
            }
            StreamWriter sr1 = new StreamWriter("datos1.txt");

            for (int i = 0; i < 11; i++)
            {
                if (NombreApellidoPuntaje[i, 0] == null)
                {
                    i = 11;
                }
                else
                {
                    sr1.WriteLine(NombreApellidoPuntaje[i, 0] + ";" + NombreApellidoPuntaje[i, 1] + ";" + NombreApellidoPuntaje[i, 2]);
                }
            }
            sr1.Close();
            top_ordenado = true;
        }
        public void llenar(string a, string b, int c)
        {
            bool orden = false;
            bool cambio = false;

            nombre = a;
            apellido = b;
            puntaje = c;
            StreamReader s1 = new StreamReader("datos1.txt");
            string line = "";
            string[] label = new string[30];
            int contador = 0;
            while (s1.EndOfStream == false)
            {
                line = s1.ReadLine();
                string[] split = line.Split(';');
                for (int d = 0; d <= 2; d++)
                {
                    if (split[d] == "" || split[d] == null)
                    {

                    }
                    else
                    {
                        label[contador] = split[d];
                    }
                    if (contador != 30)
                    {
                        contador++;
                    }

                }
            }
            s1.Close();
            NombreApellidoPuntaje[0, 0] = label[0];
            NombreApellidoPuntaje[1, 0] = label[3];
            NombreApellidoPuntaje[2, 0] = label[6];
            NombreApellidoPuntaje[3, 0] = label[9];
            NombreApellidoPuntaje[4, 0] = label[12];
            NombreApellidoPuntaje[5, 0] = label[15];
            NombreApellidoPuntaje[6, 0] = label[18];
            NombreApellidoPuntaje[7, 0] = label[21];
            NombreApellidoPuntaje[8, 0] = label[24];
            NombreApellidoPuntaje[9, 0] = label[27];

            NombreApellidoPuntaje[0, 1] = label[1];
            NombreApellidoPuntaje[1, 1] = label[4];
            NombreApellidoPuntaje[2, 1] = label[7];
            NombreApellidoPuntaje[3, 1] = label[10];
            NombreApellidoPuntaje[4, 1] = label[13];
            NombreApellidoPuntaje[5, 1] = label[16];
            NombreApellidoPuntaje[6, 1] = label[19];
            NombreApellidoPuntaje[7, 1] = label[22];
            NombreApellidoPuntaje[8, 1] = label[25];
            NombreApellidoPuntaje[9, 1] = label[28];

            NombreApellidoPuntaje[0, 2] = label[2];
            NombreApellidoPuntaje[1, 2] = label[5];
            NombreApellidoPuntaje[2, 2] = label[8];
            NombreApellidoPuntaje[3, 2] = label[11];
            NombreApellidoPuntaje[4, 2] = label[14];
            NombreApellidoPuntaje[5, 2] = label[17];
            NombreApellidoPuntaje[6, 2] = label[20];
            NombreApellidoPuntaje[7, 2] = label[23];
            NombreApellidoPuntaje[8, 2] = label[26];
            NombreApellidoPuntaje[9, 2] = label[29];

            puntajes[0] = Convert.ToInt16(NombreApellidoPuntaje[0, 2]);
            puntajes[1] = Convert.ToInt16(NombreApellidoPuntaje[1, 2]);
            puntajes[2] = Convert.ToInt16(NombreApellidoPuntaje[2, 2]);
            puntajes[3] = Convert.ToInt16(NombreApellidoPuntaje[3, 2]);
            puntajes[4] = Convert.ToInt16(NombreApellidoPuntaje[4, 2]);
            puntajes[5] = Convert.ToInt16(NombreApellidoPuntaje[5, 2]);
            puntajes[6] = Convert.ToInt16(NombreApellidoPuntaje[6, 2]);
            puntajes[7] = Convert.ToInt16(NombreApellidoPuntaje[7, 2]);
            puntajes[8] = Convert.ToInt16(NombreApellidoPuntaje[8, 2]);
            puntajes[9] = Convert.ToInt16(NombreApellidoPuntaje[9, 2]);

            for (int x = 0; x <= 9; x++)
            {
                if (puntajes[x] > puntajes[x + 1])
                {
                    if (puntajes[x] > puntajes[x + 2])
                    {
                        if (puntajes[x] > puntajes[x + 3])
                        {
                            if (puntajes[x] > puntajes[x + 4])
                            {
                                if (puntajes[x] > puntajes[x + 5])
                                {
                                    if (puntajes[x] > puntajes[x + 6])
                                    {
                                        if (puntajes[x] > puntajes[x + 7])
                                        {
                                            if (puntajes[x] > puntajes[x + 8])
                                            {
                                                if (puntajes[x] > puntajes[x + 9])
                                                {
                                                    if (x == 9)
                                                    {
                                                        orden = true;
                                                    }
                                                    if (cambio)
                                                    {
                                                        x = 0;
                                                        cambio = false;
                                                    }
                                                }
                                                else if (puntajes[x] < puntajes[x + 9])
                                                {
                                                    NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                                    NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                                    NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                                    NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                                    NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                                    NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                                    NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                                    NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                                    NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                                    NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                                    NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                                    NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                                    NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                                    NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                                    NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                                    NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                                    NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                                    NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];
                                                    NombreApellidoPuntaje[17, 0] = NombreApellidoPuntaje[x + 6, 0];
                                                    NombreApellidoPuntaje[17, 1] = NombreApellidoPuntaje[x + 6, 1];
                                                    NombreApellidoPuntaje[17, 2] = NombreApellidoPuntaje[x + 6, 2];
                                                    NombreApellidoPuntaje[18, 0] = NombreApellidoPuntaje[x + 7, 0];
                                                    NombreApellidoPuntaje[18, 1] = NombreApellidoPuntaje[x + 7, 1];
                                                    NombreApellidoPuntaje[18, 2] = NombreApellidoPuntaje[x + 7, 2];
                                                    NombreApellidoPuntaje[19, 0] = NombreApellidoPuntaje[x + 8, 0];
                                                    NombreApellidoPuntaje[19, 1] = NombreApellidoPuntaje[x + 8, 1];
                                                    NombreApellidoPuntaje[19, 2] = NombreApellidoPuntaje[x + 8, 2];

                                                    NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 9, 0];
                                                    NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 9, 1];
                                                    NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 9, 2];
                                                    NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                                    NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                                    NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                                    NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                                    NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                                    NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                                    NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                                    NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                                    NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                                    NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                                    NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                                    NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                                    NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                                    NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                                    NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                                    NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                                    NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                                    NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];
                                                    NombreApellidoPuntaje[x + 7, 0] = NombreApellidoPuntaje[17, 0];
                                                    NombreApellidoPuntaje[x + 7, 1] = NombreApellidoPuntaje[17, 1];
                                                    NombreApellidoPuntaje[x + 7, 2] = NombreApellidoPuntaje[17, 2];
                                                    NombreApellidoPuntaje[x + 8, 0] = NombreApellidoPuntaje[18, 0];
                                                    NombreApellidoPuntaje[x + 8, 1] = NombreApellidoPuntaje[18, 1];
                                                    NombreApellidoPuntaje[x + 8, 2] = NombreApellidoPuntaje[18, 2];
                                                    NombreApellidoPuntaje[x + 9, 0] = NombreApellidoPuntaje[19, 0];
                                                    NombreApellidoPuntaje[x + 9, 1] = NombreApellidoPuntaje[19, 1];
                                                    NombreApellidoPuntaje[x + 9, 2] = NombreApellidoPuntaje[19, 2];


                                                    NombreApellidoPuntaje[11, 0] = "";
                                                    NombreApellidoPuntaje[11, 1] = "";
                                                    NombreApellidoPuntaje[11, 2] = "";
                                                    NombreApellidoPuntaje[12, 0] = "";
                                                    NombreApellidoPuntaje[12, 1] = "";
                                                    NombreApellidoPuntaje[12, 2] = "";
                                                    NombreApellidoPuntaje[13, 0] = "";
                                                    NombreApellidoPuntaje[13, 1] = "";
                                                    NombreApellidoPuntaje[13, 2] = "";
                                                    NombreApellidoPuntaje[14, 0] = "";
                                                    NombreApellidoPuntaje[14, 1] = "";
                                                    NombreApellidoPuntaje[14, 2] = "";
                                                    NombreApellidoPuntaje[15, 0] = "";
                                                    NombreApellidoPuntaje[15, 1] = "";
                                                    NombreApellidoPuntaje[15, 2] = "";
                                                    NombreApellidoPuntaje[16, 0] = "";
                                                    NombreApellidoPuntaje[16, 1] = "";
                                                    NombreApellidoPuntaje[16, 2] = "";
                                                    NombreApellidoPuntaje[17, 0] = "";
                                                    NombreApellidoPuntaje[17, 1] = "";
                                                    NombreApellidoPuntaje[17, 2] = "";
                                                    NombreApellidoPuntaje[18, 0] = "";
                                                    NombreApellidoPuntaje[18, 1] = "";
                                                    NombreApellidoPuntaje[18, 2] = "";
                                                    NombreApellidoPuntaje[19, 0] = "";
                                                    NombreApellidoPuntaje[19, 1] = "";
                                                    NombreApellidoPuntaje[19, 2] = "";

                                                    puntajes[11] = puntajes[x];
                                                    puntajes[12] = puntajes[x + 1];
                                                    puntajes[13] = puntajes[x + 2];
                                                    puntajes[14] = puntajes[x + 3];
                                                    puntajes[15] = puntajes[x + 4];
                                                    puntajes[16] = puntajes[x + 5];
                                                    puntajes[17] = puntajes[x + 6];
                                                    puntajes[18] = puntajes[x + 7];
                                                    puntajes[19] = puntajes[x + 8];

                                                    puntajes[x] = puntajes[x + 9];
                                                    puntajes[x + 1] = puntajes[11];
                                                    puntajes[x + 2] = puntajes[12];
                                                    puntajes[x + 3] = puntajes[13];
                                                    puntajes[x + 4] = puntajes[14];
                                                    puntajes[x + 5] = puntajes[15];
                                                    puntajes[x + 6] = puntajes[16];
                                                    puntajes[x + 7] = puntajes[17];
                                                    puntajes[x + 8] = puntajes[18];
                                                    puntajes[x + 9] = puntajes[19];

                                                    puntajes[11] = 0;
                                                    puntajes[12] = 0;
                                                    puntajes[13] = 0;
                                                    puntajes[14] = 0;
                                                    puntajes[15] = 0;
                                                    puntajes[16] = 0;
                                                    puntajes[17] = 0;
                                                    puntajes[18] = 0;
                                                    puntajes[19] = 0;

                                                    cambio = true;
                                                    x = 0;
                                                    x = x + 9;
                                                }
                                                else if (x == 9)
                                                {
                                                    orden = true;
                                                }
                                            }
                                            else if (puntajes[x] < puntajes[x + 8])
                                            {
                                                NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                                NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                                NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                                NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                                NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                                NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                                NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                                NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                                NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                                NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                                NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                                NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                                NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                                NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                                NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                                NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                                NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                                NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];
                                                NombreApellidoPuntaje[17, 0] = NombreApellidoPuntaje[x + 6, 0];
                                                NombreApellidoPuntaje[17, 1] = NombreApellidoPuntaje[x + 6, 1];
                                                NombreApellidoPuntaje[17, 2] = NombreApellidoPuntaje[x + 6, 2];
                                                NombreApellidoPuntaje[18, 0] = NombreApellidoPuntaje[x + 7, 0];
                                                NombreApellidoPuntaje[18, 1] = NombreApellidoPuntaje[x + 7, 1];
                                                NombreApellidoPuntaje[18, 2] = NombreApellidoPuntaje[x + 7, 2];

                                                NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 8, 0];
                                                NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 8, 1];
                                                NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 8, 2];
                                                NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                                NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                                NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                                NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                                NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                                NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                                NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                                NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                                NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                                NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                                NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                                NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                                NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                                NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                                NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                                NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                                NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                                NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];
                                                NombreApellidoPuntaje[x + 7, 0] = NombreApellidoPuntaje[17, 0];
                                                NombreApellidoPuntaje[x + 7, 1] = NombreApellidoPuntaje[17, 1];
                                                NombreApellidoPuntaje[x + 7, 2] = NombreApellidoPuntaje[17, 2];
                                                NombreApellidoPuntaje[x + 8, 0] = NombreApellidoPuntaje[18, 0];
                                                NombreApellidoPuntaje[x + 8, 1] = NombreApellidoPuntaje[18, 1];
                                                NombreApellidoPuntaje[x + 8, 2] = NombreApellidoPuntaje[18, 2];


                                                NombreApellidoPuntaje[11, 0] = "";
                                                NombreApellidoPuntaje[11, 1] = "";
                                                NombreApellidoPuntaje[11, 2] = "";
                                                NombreApellidoPuntaje[12, 0] = "";
                                                NombreApellidoPuntaje[12, 1] = "";
                                                NombreApellidoPuntaje[12, 2] = "";
                                                NombreApellidoPuntaje[13, 0] = "";
                                                NombreApellidoPuntaje[13, 1] = "";
                                                NombreApellidoPuntaje[13, 2] = "";
                                                NombreApellidoPuntaje[14, 0] = "";
                                                NombreApellidoPuntaje[14, 1] = "";
                                                NombreApellidoPuntaje[14, 2] = "";
                                                NombreApellidoPuntaje[15, 0] = "";
                                                NombreApellidoPuntaje[15, 1] = "";
                                                NombreApellidoPuntaje[15, 2] = "";
                                                NombreApellidoPuntaje[16, 0] = "";
                                                NombreApellidoPuntaje[16, 1] = "";
                                                NombreApellidoPuntaje[16, 2] = "";
                                                NombreApellidoPuntaje[17, 0] = "";
                                                NombreApellidoPuntaje[17, 1] = "";
                                                NombreApellidoPuntaje[17, 2] = "";
                                                NombreApellidoPuntaje[18, 0] = "";
                                                NombreApellidoPuntaje[18, 1] = "";
                                                NombreApellidoPuntaje[18, 2] = "";

                                                puntajes[11] = puntajes[x];
                                                puntajes[12] = puntajes[x + 1];
                                                puntajes[13] = puntajes[x + 2];
                                                puntajes[14] = puntajes[x + 3];
                                                puntajes[15] = puntajes[x + 4];
                                                puntajes[16] = puntajes[x + 5];
                                                puntajes[17] = puntajes[x + 6];
                                                puntajes[18] = puntajes[x + 7];

                                                puntajes[x] = puntajes[x + 8];
                                                puntajes[x + 1] = puntajes[11];
                                                puntajes[x + 2] = puntajes[12];
                                                puntajes[x + 3] = puntajes[13];
                                                puntajes[x + 4] = puntajes[14];
                                                puntajes[x + 5] = puntajes[15];
                                                puntajes[x + 6] = puntajes[16];
                                                puntajes[x + 7] = puntajes[17];
                                                puntajes[x + 8] = puntajes[18];

                                                puntajes[11] = 0;
                                                puntajes[12] = 0;
                                                puntajes[13] = 0;
                                                puntajes[14] = 0;
                                                puntajes[15] = 0;
                                                puntajes[16] = 0;
                                                puntajes[17] = 0;
                                                puntajes[18] = 0;

                                                cambio = true;
                                                x = 0;
                                                x = x + 8;
                                            }
                                            else if (x == 9)
                                            {
                                                orden = true;
                                            }
                                        }
                                        else if (puntajes[x] < puntajes[x + 7])
                                        {
                                            NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                            NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                            NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                            NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                            NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                            NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                            NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                            NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                            NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                            NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                            NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                            NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                            NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                            NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                            NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                            NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                            NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                            NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];
                                            NombreApellidoPuntaje[17, 0] = NombreApellidoPuntaje[x + 6, 0];
                                            NombreApellidoPuntaje[17, 1] = NombreApellidoPuntaje[x + 6, 1];
                                            NombreApellidoPuntaje[17, 2] = NombreApellidoPuntaje[x + 6, 2];

                                            NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 7, 0];
                                            NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 7, 1];
                                            NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 7, 2];
                                            NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                            NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                            NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                            NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                            NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                            NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                            NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                            NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                            NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                            NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                            NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                            NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                            NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                            NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                            NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                            NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                            NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                            NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];
                                            NombreApellidoPuntaje[x + 7, 0] = NombreApellidoPuntaje[17, 0];
                                            NombreApellidoPuntaje[x + 7, 1] = NombreApellidoPuntaje[17, 1];
                                            NombreApellidoPuntaje[x + 7, 2] = NombreApellidoPuntaje[17, 2];


                                            NombreApellidoPuntaje[11, 0] = "";
                                            NombreApellidoPuntaje[11, 1] = "";
                                            NombreApellidoPuntaje[11, 2] = "";
                                            NombreApellidoPuntaje[12, 0] = "";
                                            NombreApellidoPuntaje[12, 1] = "";
                                            NombreApellidoPuntaje[12, 2] = "";
                                            NombreApellidoPuntaje[13, 0] = "";
                                            NombreApellidoPuntaje[13, 1] = "";
                                            NombreApellidoPuntaje[13, 2] = "";
                                            NombreApellidoPuntaje[14, 0] = "";
                                            NombreApellidoPuntaje[14, 1] = "";
                                            NombreApellidoPuntaje[14, 2] = "";
                                            NombreApellidoPuntaje[15, 0] = "";
                                            NombreApellidoPuntaje[15, 1] = "";
                                            NombreApellidoPuntaje[15, 2] = "";
                                            NombreApellidoPuntaje[16, 0] = "";
                                            NombreApellidoPuntaje[16, 1] = "";
                                            NombreApellidoPuntaje[16, 2] = "";
                                            NombreApellidoPuntaje[17, 0] = "";
                                            NombreApellidoPuntaje[17, 1] = "";
                                            NombreApellidoPuntaje[17, 2] = "";

                                            puntajes[11] = puntajes[x];
                                            puntajes[12] = puntajes[x + 1];
                                            puntajes[13] = puntajes[x + 2];
                                            puntajes[14] = puntajes[x + 3];
                                            puntajes[15] = puntajes[x + 4];
                                            puntajes[16] = puntajes[x + 5];
                                            puntajes[17] = puntajes[x + 6];

                                            puntajes[x] = puntajes[x + 7];
                                            puntajes[x + 1] = puntajes[11];
                                            puntajes[x + 2] = puntajes[12];
                                            puntajes[x + 3] = puntajes[13];
                                            puntajes[x + 4] = puntajes[14];
                                            puntajes[x + 5] = puntajes[15];
                                            puntajes[x + 6] = puntajes[16];
                                            puntajes[x + 7] = puntajes[17];

                                            puntajes[11] = 0;
                                            puntajes[12] = 0;
                                            puntajes[13] = 0;
                                            puntajes[14] = 0;
                                            puntajes[15] = 0;
                                            puntajes[16] = 0;
                                            puntajes[17] = 0;

                                            cambio = true;
                                            x = 0;
                                            x = x + 7;
                                        }
                                        else if (x == 9)
                                        {
                                            orden = true;
                                        }
                                    }
                                    else if (puntajes[x] < puntajes[x + 6])
                                    {
                                        NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                        NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                        NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                        NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                        NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                        NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                        NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                        NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                        NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                        NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                        NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                        NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                        NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                        NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                        NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];
                                        NombreApellidoPuntaje[16, 0] = NombreApellidoPuntaje[x + 5, 0];
                                        NombreApellidoPuntaje[16, 1] = NombreApellidoPuntaje[x + 5, 1];
                                        NombreApellidoPuntaje[16, 2] = NombreApellidoPuntaje[x + 5, 2];

                                        NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 6, 0];
                                        NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 6, 1];
                                        NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 6, 2];
                                        NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                        NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                        NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                        NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                        NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                        NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                        NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                        NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                        NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                        NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                        NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                        NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                        NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                        NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                        NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];
                                        NombreApellidoPuntaje[x + 6, 0] = NombreApellidoPuntaje[16, 0];
                                        NombreApellidoPuntaje[x + 6, 1] = NombreApellidoPuntaje[16, 1];
                                        NombreApellidoPuntaje[x + 6, 2] = NombreApellidoPuntaje[16, 2];


                                        NombreApellidoPuntaje[11, 0] = "";
                                        NombreApellidoPuntaje[11, 1] = "";
                                        NombreApellidoPuntaje[11, 2] = "";
                                        NombreApellidoPuntaje[12, 0] = "";
                                        NombreApellidoPuntaje[12, 1] = "";
                                        NombreApellidoPuntaje[12, 2] = "";
                                        NombreApellidoPuntaje[13, 0] = "";
                                        NombreApellidoPuntaje[13, 1] = "";
                                        NombreApellidoPuntaje[13, 2] = "";
                                        NombreApellidoPuntaje[14, 0] = "";
                                        NombreApellidoPuntaje[14, 1] = "";
                                        NombreApellidoPuntaje[14, 2] = "";
                                        NombreApellidoPuntaje[15, 0] = "";
                                        NombreApellidoPuntaje[15, 1] = "";
                                        NombreApellidoPuntaje[15, 2] = "";
                                        NombreApellidoPuntaje[16, 0] = "";
                                        NombreApellidoPuntaje[16, 1] = "";
                                        NombreApellidoPuntaje[16, 2] = "";

                                        puntajes[11] = puntajes[x];
                                        puntajes[12] = puntajes[x + 1];
                                        puntajes[13] = puntajes[x + 2];
                                        puntajes[14] = puntajes[x + 3];
                                        puntajes[15] = puntajes[x + 4];
                                        puntajes[16] = puntajes[x + 5];

                                        puntajes[x] = puntajes[x + 6];
                                        puntajes[x + 1] = puntajes[11];
                                        puntajes[x + 2] = puntajes[12];
                                        puntajes[x + 3] = puntajes[13];
                                        puntajes[x + 4] = puntajes[14];
                                        puntajes[x + 5] = puntajes[15];
                                        puntajes[x + 6] = puntajes[16];

                                        puntajes[11] = 0;
                                        puntajes[12] = 0;
                                        puntajes[13] = 0;
                                        puntajes[14] = 0;
                                        puntajes[15] = 0;
                                        puntajes[16] = 0;

                                        cambio = true;
                                        x = 0;
                                        x = x + 6;
                                    }
                                    else if (x == 9)
                                    {
                                        orden = true;
                                    }
                                }
                                else if (puntajes[x] < puntajes[x + 5])
                                {
                                    NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                    NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                    NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                    NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                    NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                    NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                    NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                    NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                    NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                    NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                    NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                    NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];
                                    NombreApellidoPuntaje[15, 0] = NombreApellidoPuntaje[x + 4, 0];
                                    NombreApellidoPuntaje[15, 1] = NombreApellidoPuntaje[x + 4, 1];
                                    NombreApellidoPuntaje[15, 2] = NombreApellidoPuntaje[x + 4, 2];

                                    NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 5, 0];
                                    NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 5, 1];
                                    NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 5, 2];
                                    NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                    NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                    NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                    NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                    NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                    NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                    NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                    NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                    NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                    NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                    NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                    NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];
                                    NombreApellidoPuntaje[x + 5, 0] = NombreApellidoPuntaje[15, 0];
                                    NombreApellidoPuntaje[x + 5, 1] = NombreApellidoPuntaje[15, 1];
                                    NombreApellidoPuntaje[x + 5, 2] = NombreApellidoPuntaje[15, 2];


                                    NombreApellidoPuntaje[11, 0] = "";
                                    NombreApellidoPuntaje[11, 1] = "";
                                    NombreApellidoPuntaje[11, 2] = "";
                                    NombreApellidoPuntaje[12, 0] = "";
                                    NombreApellidoPuntaje[12, 1] = "";
                                    NombreApellidoPuntaje[12, 2] = "";
                                    NombreApellidoPuntaje[13, 0] = "";
                                    NombreApellidoPuntaje[13, 1] = "";
                                    NombreApellidoPuntaje[13, 2] = "";
                                    NombreApellidoPuntaje[14, 0] = "";
                                    NombreApellidoPuntaje[14, 1] = "";
                                    NombreApellidoPuntaje[14, 2] = "";
                                    NombreApellidoPuntaje[15, 0] = "";
                                    NombreApellidoPuntaje[15, 1] = "";
                                    NombreApellidoPuntaje[15, 2] = "";

                                    puntajes[11] = puntajes[x];
                                    puntajes[12] = puntajes[x + 1];
                                    puntajes[13] = puntajes[x + 2];
                                    puntajes[14] = puntajes[x + 3];
                                    puntajes[15] = puntajes[x + 4];

                                    puntajes[x] = puntajes[x + 5];
                                    puntajes[x + 1] = puntajes[11];
                                    puntajes[x + 2] = puntajes[12];
                                    puntajes[x + 3] = puntajes[13];
                                    puntajes[x + 4] = puntajes[14];
                                    puntajes[x + 5] = puntajes[15];

                                    puntajes[11] = 0;
                                    puntajes[12] = 0;
                                    puntajes[13] = 0;
                                    puntajes[14] = 0;
                                    puntajes[15] = 0;

                                    cambio = true;
                                    x = 0;
                                    x = x + 5;
                                }
                                else if (x == 9)
                                {
                                    orden = true;
                                }
                            }
                            else if (puntajes[x] < puntajes[x + 4])
                            {
                                NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                                NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                                NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                                NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                                NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                                NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                                NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                                NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                                NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];
                                NombreApellidoPuntaje[14, 0] = NombreApellidoPuntaje[x + 3, 0];
                                NombreApellidoPuntaje[14, 1] = NombreApellidoPuntaje[x + 3, 1];
                                NombreApellidoPuntaje[14, 2] = NombreApellidoPuntaje[x + 3, 2];

                                NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 4, 0];
                                NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 4, 1];
                                NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 4, 2];
                                NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                                NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                                NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                                NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                                NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                                NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];
                                NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                                NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                                NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];
                                NombreApellidoPuntaje[x + 4, 0] = NombreApellidoPuntaje[14, 0];
                                NombreApellidoPuntaje[x + 4, 1] = NombreApellidoPuntaje[14, 1];
                                NombreApellidoPuntaje[x + 4, 2] = NombreApellidoPuntaje[14, 2];

                                NombreApellidoPuntaje[11, 0] = "";
                                NombreApellidoPuntaje[11, 1] = "";
                                NombreApellidoPuntaje[11, 2] = "";
                                NombreApellidoPuntaje[12, 0] = "";
                                NombreApellidoPuntaje[12, 1] = "";
                                NombreApellidoPuntaje[12, 2] = "";
                                NombreApellidoPuntaje[13, 0] = "";
                                NombreApellidoPuntaje[13, 1] = "";
                                NombreApellidoPuntaje[13, 2] = "";
                                NombreApellidoPuntaje[14, 0] = "";
                                NombreApellidoPuntaje[14, 1] = "";
                                NombreApellidoPuntaje[14, 2] = "";

                                puntajes[11] = puntajes[x];
                                puntajes[12] = puntajes[x + 1];
                                puntajes[13] = puntajes[x + 2];
                                puntajes[14] = puntajes[x + 3];

                                puntajes[x] = puntajes[x + 4];
                                puntajes[x + 1] = puntajes[11];
                                puntajes[x + 2] = puntajes[12];
                                puntajes[x + 3] = puntajes[13];
                                puntajes[x + 4] = puntajes[14];

                                puntajes[11] = 0;
                                puntajes[12] = 0;
                                puntajes[13] = 0;
                                puntajes[14] = 0;

                                cambio = true;
                                x = 0;
                                x = x + 4;
                            }
                            else if (x == 9)
                            {
                                orden = true;
                            }
                        }
                        else if (puntajes[x] < puntajes[x + 3])
                        {
                            NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                            NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                            NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                            NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                            NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                            NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];
                            NombreApellidoPuntaje[13, 0] = NombreApellidoPuntaje[x + 2, 0];
                            NombreApellidoPuntaje[13, 1] = NombreApellidoPuntaje[x + 2, 1];
                            NombreApellidoPuntaje[13, 2] = NombreApellidoPuntaje[x + 2, 2];

                            NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 3, 0];
                            NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 3, 1];
                            NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 3, 2];
                            NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                            NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                            NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];
                            NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                            NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                            NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];

                            NombreApellidoPuntaje[x + 3, 0] = NombreApellidoPuntaje[13, 0];
                            NombreApellidoPuntaje[x + 3, 1] = NombreApellidoPuntaje[13, 1];
                            NombreApellidoPuntaje[x + 3, 2] = NombreApellidoPuntaje[13, 2];

                            NombreApellidoPuntaje[11, 0] = "";
                            NombreApellidoPuntaje[11, 1] = "";
                            NombreApellidoPuntaje[11, 2] = "";
                            NombreApellidoPuntaje[12, 0] = "";
                            NombreApellidoPuntaje[12, 1] = "";
                            NombreApellidoPuntaje[12, 2] = "";
                            NombreApellidoPuntaje[13, 0] = "";
                            NombreApellidoPuntaje[13, 1] = "";
                            NombreApellidoPuntaje[13, 2] = "";

                            puntajes[11] = puntajes[x];
                            puntajes[12] = puntajes[x + 1];
                            puntajes[13] = puntajes[x + 2];

                            puntajes[x] = puntajes[x + 3];
                            puntajes[x + 1] = puntajes[11];
                            puntajes[x + 2] = puntajes[12];

                            puntajes[x + 3] = puntajes[13];

                            puntajes[11] = 0;
                            puntajes[12] = 0;
                            puntajes[13] = 0;

                            cambio = true;
                            x = 0;
                            x = x + 3;
                        }
                        else if (x == 9)
                        {
                            orden = true;
                        }
                    }
                    else if (puntajes[x] < puntajes[x + 2])
                    {
                        NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                        NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                        NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];
                        NombreApellidoPuntaje[12, 0] = NombreApellidoPuntaje[x + 1, 0];
                        NombreApellidoPuntaje[12, 1] = NombreApellidoPuntaje[x + 1, 1];
                        NombreApellidoPuntaje[12, 2] = NombreApellidoPuntaje[x + 1, 2];

                        NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 2, 0];
                        NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 2, 1];
                        NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 2, 2];
                        NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                        NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                        NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];

                        NombreApellidoPuntaje[x + 2, 0] = NombreApellidoPuntaje[12, 0];
                        NombreApellidoPuntaje[x + 2, 1] = NombreApellidoPuntaje[12, 1];
                        NombreApellidoPuntaje[x + 2, 2] = NombreApellidoPuntaje[12, 2];

                        NombreApellidoPuntaje[11, 0] = "";
                        NombreApellidoPuntaje[11, 1] = "";
                        NombreApellidoPuntaje[11, 2] = "";
                        NombreApellidoPuntaje[12, 0] = "";
                        NombreApellidoPuntaje[12, 1] = "";
                        NombreApellidoPuntaje[12, 2] = "";

                        puntajes[11] = puntajes[x];
                        puntajes[12] = puntajes[x + 1];

                        puntajes[x] = puntajes[x + 2];
                        puntajes[x + 1] = puntajes[11];

                        puntajes[x + 2] = puntajes[12];

                        puntajes[11] = 0;
                        puntajes[12] = 0;

                        cambio = true;
                        x = 0;
                        x = x + 2;
                    }
                    else if (x == 9)
                    {
                        orden = true;
                    }
                }
                else if (puntajes[x] < puntajes[x + 1])
                {
                    NombreApellidoPuntaje[11, 0] = NombreApellidoPuntaje[x, 0];
                    NombreApellidoPuntaje[11, 1] = NombreApellidoPuntaje[x, 1];
                    NombreApellidoPuntaje[11, 2] = NombreApellidoPuntaje[x, 2];

                    NombreApellidoPuntaje[x, 0] = NombreApellidoPuntaje[x + 1, 0];
                    NombreApellidoPuntaje[x, 1] = NombreApellidoPuntaje[x + 1, 1];
                    NombreApellidoPuntaje[x, 2] = NombreApellidoPuntaje[x + 1, 2];

                    NombreApellidoPuntaje[x + 1, 0] = NombreApellidoPuntaje[11, 0];
                    NombreApellidoPuntaje[x + 1, 1] = NombreApellidoPuntaje[11, 1];
                    NombreApellidoPuntaje[x + 1, 2] = NombreApellidoPuntaje[11, 2];

                    NombreApellidoPuntaje[11, 0] = "";
                    NombreApellidoPuntaje[11, 1] = "";
                    NombreApellidoPuntaje[11, 2] = "";

                    puntajes[11] = puntajes[x];

                    puntajes[x] = puntajes[x + 1];

                    puntajes[x + 1] = puntajes[11];

                    puntajes[11] = 0;

                    cambio = true;
                    x = 0;
                    x++;
                }
                else if(x == 9)
                {
                    orden = true;

                }
            }

            if (orden)
            {
                if(puntajes[9] < puntaje)
                {
                    NombreApellidoPuntaje[9, 0] = NombreApellidoPuntaje[8, 0];
                    NombreApellidoPuntaje[8, 0] = NombreApellidoPuntaje[7, 0];
                    NombreApellidoPuntaje[7, 0] = NombreApellidoPuntaje[6, 0];
                    NombreApellidoPuntaje[6, 0] = NombreApellidoPuntaje[5, 0];
                    NombreApellidoPuntaje[5, 0] = NombreApellidoPuntaje[4, 0];
                    NombreApellidoPuntaje[4, 0] = NombreApellidoPuntaje[3, 0];
                    NombreApellidoPuntaje[3, 0] = NombreApellidoPuntaje[2, 0];
                    NombreApellidoPuntaje[2, 0] = NombreApellidoPuntaje[1, 0];
                    NombreApellidoPuntaje[1, 0] = NombreApellidoPuntaje[0, 0];
                    NombreApellidoPuntaje[0, 0] = nombre;

                    NombreApellidoPuntaje[9, 1] = NombreApellidoPuntaje[8, 1];
                    NombreApellidoPuntaje[8, 1] = NombreApellidoPuntaje[7, 1];
                    NombreApellidoPuntaje[7, 1] = NombreApellidoPuntaje[6, 1];
                    NombreApellidoPuntaje[6, 1] = NombreApellidoPuntaje[5, 1];
                    NombreApellidoPuntaje[5, 1] = NombreApellidoPuntaje[4, 1];
                    NombreApellidoPuntaje[4, 1] = NombreApellidoPuntaje[3, 1];
                    NombreApellidoPuntaje[3, 1] = NombreApellidoPuntaje[2, 1];
                    NombreApellidoPuntaje[2, 1] = NombreApellidoPuntaje[1, 1];
                    NombreApellidoPuntaje[1, 1] = NombreApellidoPuntaje[0, 1];
                    NombreApellidoPuntaje[0, 1] = apellido;

                    NombreApellidoPuntaje[9, 2] = NombreApellidoPuntaje[8, 2];
                    NombreApellidoPuntaje[8, 2] = NombreApellidoPuntaje[7, 2];
                    NombreApellidoPuntaje[7, 2] = NombreApellidoPuntaje[6, 2];
                    NombreApellidoPuntaje[6, 2] = NombreApellidoPuntaje[5, 2];
                    NombreApellidoPuntaje[5, 2] = NombreApellidoPuntaje[4, 2];
                    NombreApellidoPuntaje[4, 2] = NombreApellidoPuntaje[3, 2];
                    NombreApellidoPuntaje[3, 2] = NombreApellidoPuntaje[2, 2];
                    NombreApellidoPuntaje[2, 2] = NombreApellidoPuntaje[1, 2];
                    NombreApellidoPuntaje[1, 2] = NombreApellidoPuntaje[0, 2];
                    NombreApellidoPuntaje[0, 2] = Convert.ToString(puntaje);
                }

            }
            StreamWriter sr1 = new StreamWriter("datos1.txt");
            for (int i = 0; i < 11; i++)
            {
                if (NombreApellidoPuntaje[i, 0] == null)
                {
                    i = 11;
                }
                else
                {
                    sr1.WriteLine(NombreApellidoPuntaje[i, 0] + ";" + NombreApellidoPuntaje[i, 1] + ";" + NombreApellidoPuntaje[i, 2]);
                }

            }
            sr1.Close();
            llenar1();
        }
    }
}
