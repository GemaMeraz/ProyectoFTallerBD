using System;
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
    public partial class pantallaAdministrador : Form
    {
        public pantallaAdministrador()
        {
            InitializeComponent();
        }

        private void pantallaAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void SubPanel()
        {
            //mostrar u ocultar el submenu de clientes
            if (pnlSubmenuClientes.Visible == false)
                pnlSubmenuClientes.Visible = true;
            else
                pnlSubmenuClientes.Visible = false;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            SubPanel();
        }

        private void btnTdClientes_Click(object sender, EventArgs e)
        {
            SubPanel();
        }

        private void btnClCreditos_Click(object sender, EventArgs e)
        {
            SubPanel();
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            openFormSecundario(new FormEmpleados());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private Form activarForm = null;
        private void openFormSecundario(Form segundoForm)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            activarForm = segundoForm;
            segundoForm.TopLevel = false;
            segundoForm.FormBorderStyle = FormBorderStyle.None;
            segundoForm.Dock = DockStyle.Fill;
            pnlVistasDatos.Controls.Add(segundoForm);
            pnlVistasDatos.Tag = segundoForm;
            segundoForm.BringToFront();
            segundoForm.Show();
        }
    }
}
