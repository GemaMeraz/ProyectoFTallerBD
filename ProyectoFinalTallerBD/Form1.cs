﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTallerBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            //prueba para mostrar otros formularios
            pantallaAdministrador pantAdmin = new pantallaAdministrador();
            if (txtUsuario.Texts=="Admin" & txtPassword.Texts=="123")
            {
                pantAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrecto");
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
