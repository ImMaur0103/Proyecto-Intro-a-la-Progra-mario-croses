using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/************************************
 Creador: Mauricio Lopez
 Fecha: 01/04/2018
 ultima modificacion: 19/10/2020
************************************/
namespace interfas
{
    public partial class top10 : Form
    {
        Form1 _1;
        bool preciono_boton = false ;
        public top10(Form1 _2)
        {
            _1 = _2;
            InitializeComponent();
        }

        private void top10_Load(object sender, EventArgs e)
        {
            llenartop10 top10 = new llenartop10();
            if (top10.top_ordenado == false)
            {
                top10.llenar1();
            }
            StreamReader s1 = new StreamReader("datos1.txt");
            string line = "";
            string[] label = new string[30];
            int contador = 0;
            while(s1.EndOfStream == false)
            {
                line = s1.ReadLine();
                string[] split = line.Split(';');
                for (int b = 0; b <= 2; b++ )
                {
                    label[contador] = split[b];
                    if(contador != 30)
                    {
                        contador++;
                    }
                   
                }
            }
            

            s1.Close();
            label1.Text = label[0];
            label2.Text = label[1];
            label3.Text = label[2];

            label4.Text = label[3];
            label5.Text = label[4];
            label6.Text = label[5];

            label7.Text = label[6];
            label8.Text = label[7];
            label9.Text = label[8];

            label10.Text = label[9];
            label11.Text = label[10];
            label12.Text = label[11];

            label13.Text = label[12];
            label14.Text = label[13];
            label15.Text = label[14];

            label16.Text = label[15];
            label17.Text = label[16];
            label18.Text = label[17];

            label19.Text = label[18];
            label20.Text = label[19];
            label21.Text = label[20];

            label22.Text = label[21];
            label23.Text = label[22];
            label24.Text = label[23];

            label25.Text = label[24];
            label26.Text = label[25];
            label27.Text = label[26];

            label28.Text = label[27];
            label29.Text = label[28];
            label30.Text = label[29];
        }
        private void top10_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (preciono_boton == false)
            {
                _1.Close();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Crear_usuario obj = new Crear_usuario(_1);
            obj.Visible = true;
            preciono_boton = true;
            this.Close();
        }
    }
}
