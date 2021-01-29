using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfas
{
    public partial class ultimo_nivel : Form
    {
        Form1 formprincipal;
        bool preciono_boton = false;
        public ultimo_nivel(Form1 form)
        {
            formprincipal = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nivel3 obj = new nivel3(formprincipal);
            obj.Visible = true;
            preciono_boton = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            formprincipal.Close();
        }

        private void ultimo_nivel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (preciono_boton == false)
            {
                formprincipal.Close();
            }
        }
    }
}
