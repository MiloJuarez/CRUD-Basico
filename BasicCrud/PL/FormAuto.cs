using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCrud.BLL;
using BasicCrud.DAL;

namespace BasicCrud.PL
{
    public partial class FormAuto : Form
    {
        private Auto auto;
        private Main main;

        public FormAuto(Auto auto, Main main)
        {
            this.auto = auto;
            this.main = main;
            InitializeComponent();
            LlenarForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDAL connectionDAL = new ConnectionDAL();
            AutoDAL autoDAL = new AutoDAL();
            if (auto.ID > 0)
            {
                autoDAL.UpdateAuto(ObtenerAuto(), connectionDAL.GetConnection());
            } else
            {
                autoDAL.InsertAuto(ObtenerAuto(), connectionDAL.GetConnection());
            }
            main.CargarAutos("","");
            Dispose();
        }

        private Auto ObtenerAuto()
        {
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            auto.Anio = int.Parse(txtAnio.Text);
            auto.Precio = double.Parse(txtPrecio.Text);
            auto.FechaVenta = txtFecha.Text;
            return auto;
        }

        private void LlenarForm()
        {
            if (auto.ID > 0)
            {
                txtMarca.Text = auto.Marca;
                txtModelo.Text = auto.Modelo;
                txtAnio.Text = auto.Anio.ToString();
                txtPrecio.Text = auto.Precio.ToString();
                txtFecha.Text = auto.FechaVenta;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
