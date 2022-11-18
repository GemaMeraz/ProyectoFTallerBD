﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalTallerBD
{
    class conexion
    {
        public SqlConnection conectarbd;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt;
        public conexion()
        {
            try
            {
                conectarbd = new SqlConnection("Data Source=JAFET;Initial Catalog=PROYECTO;User ID=admon;Password=admon");
                conectarbd.Open();
                MessageBox.Show("Conexión Realizada Correctamente");
            }
            catch (Exception x)
            {
                MessageBox.Show("No se conectó con la base de datos: " + x.Message);
                throw;
            }
        }
    }
}
