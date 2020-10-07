using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCrud.DAL;
using BasicCrud.PL;
using BasicCrud.BLL;

namespace BasicCrud
{
    public partial class Main : Form
    {
        private Auto auto;
        private int rowIdx;
        public Main()
        {
            rowIdx = 0;
            InitializeComponent();
            CargarAutos("", "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAuto formAuto = new FormAuto(new Auto(), this);
            formAuto.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count > 0)
            {
                FormAuto formAuto = new FormAuto(auto, this);
                formAuto.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un auto para continuar", "Seleccione un auto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar auto " + auto.Marca + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                AutoDAL autoDAL = new AutoDAL();
                ConnectionDAL connection = new ConnectionDAL();
                int idAuto = auto.ID;
                autoDAL.deleteAuto(idAuto, connection.GetConnection());
                CargarAutos("", "");
            }
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.auto = new Auto();
            rowIdx = e.RowIndex;
            Console.WriteLine("INDEX SELECTED: " + rowIdx);
            this.auto.ID = int.Parse(dgvAutos.Rows[rowIdx].Cells[0].Value.ToString());
            this.auto.Marca = dgvAutos.Rows[rowIdx].Cells[1].Value.ToString();
            this.auto.Modelo = dgvAutos.Rows[rowIdx].Cells[2].Value.ToString();
            this.auto.Anio = int.Parse(dgvAutos.Rows[rowIdx].Cells[3].Value.ToString());
            this.auto.Precio = int.Parse(dgvAutos.Rows[rowIdx].Cells[4].Value.ToString());
            this.auto.FechaVenta = dgvAutos.Rows[rowIdx].Cells[5].Value.ToString();
            Console.WriteLine("AUTO: " + auto.ID + auto.Marca + auto.Modelo + auto.Anio);
        }

        private void Buscar(object sender, KeyEventArgs e)
        {

            if (txtBuscar.Text.Length > 0)
            {
                string filterBy = cmbFiltrar.GetItemText(cmbFiltrar.SelectedItem).ToLower();
                if (e.KeyData == Keys.Enter)
                {
                    CargarAutos(filterBy, txtBuscar.Text);
                }
            }
        }

        private void btnRestaura_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            CargarAutos("", "");
        }

        public void CargarAutos(string f, string v)
        {
            AutoDAL autoDAL = new AutoDAL();
            ConnectionDAL connection = new ConnectionDAL();
            dgvAutos.DataSource = autoDAL.QueryData(connection.GetConnection(), f, v).Tables[0];
        }
    }
}
