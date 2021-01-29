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

namespace interfas
{
    public partial class Crear_usuario : Form
    {
        Form1 obj;
        bool precionar_boton = false;
        bool boton = false;
        public Crear_usuario(Form1 form)
        {
            InitializeComponent();
            obj = form;
        }

        private void Crear_usuario_Load(object sender, EventArgs e)
        {

        }

        private void Crear_usuario_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (precionar_boton)
            {
                nivel1 nivel1 = new nivel1(obj);
                nivel1.Show();
            }
            else if (boton)
            {
                top10 _1 = new top10(obj);
                _1.Show();
            }
            else
            {
                obj.Close();
            }
            
        }

        private void Crear_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            string name;
            string apodo;
            apodo = textBox3.Text;
            name = textBox1.Text;
            bool re = name.Equals("");
            bool ra = apodo.Equals("");
            if (re)
            {
                name = "usuario1";
            }
            if (ra)
            {
                apodo = "apodo1";
            }
            using (StreamWriter sr = new StreamWriter("puntaje.txt"))
            {
                sr.WriteLine(name + ";" +  apodo );

            }
            precionar_boton = true;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            boton = true;
            this.Close();
        }

        private void crear_Click(object sender, EventArgs e)
        {

                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
