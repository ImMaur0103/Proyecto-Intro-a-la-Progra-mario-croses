﻿using System;
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
    public partial class siguiente_nivel : Form
    {
        Form1 formprincipal;
        bool preciono_boton = false;
        public siguiente_nivel(Form1 form)
        {
            formprincipal = form;
            InitializeComponent();
        }

        private void siguiente_nivel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nivel2 obj = new nivel2(formprincipal);
            obj.Visible = true;
            preciono_boton = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            formprincipal.Close();
        }

        private void siguiente_nivel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (preciono_boton == false )
            {
                formprincipal.Close();
            }
        }
    }
}
