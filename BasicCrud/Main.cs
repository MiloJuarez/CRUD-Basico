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
using System.IO;

namespace BasicCrud
{
    public partial class Main : Form
    {
        BindingList<Auto> listAutos;
        private Auto auto;
        private int rowIdx;
        public Main()
        {
            listAutos = new BindingList<Auto>();
            rowIdx = 0;
            InitializeComponent();
            CargarAutos();
            dgvAutos.Columns[0].ValueType = typeof(bool);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAuto formAuto = new FormAuto(new Auto(), this);
            formAuto.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (auto != null)
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
            bool isChecked = false;
            foreach (DataGridViewRow row in dgvAutos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    isChecked = true;
                    GetAuto(row.Index);
                    break;
                }
            }
            if (isChecked)
            {
                if (MessageBox.Show("¿Eliminar auto " + auto.Marca + "?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AutoDAL autoDAL = new AutoDAL();
                    int idAuto = auto.ID;
                    autoDAL.deleteAuto(idAuto, ConnectionDAL.GetConnection());
                    listAutos.Remove(auto);
                    CargarAutos();
                    if (auto.Imagen != "default_car_image.png")
                    {
                        File.Delete(AutoDAL.pathImageFolder + auto.Imagen);
                    }
                    auto = null;
                    dgvAutos.CurrentRow.Selected = false;
                }
            } else
            {
                MessageBox.Show("Selecciona un auto para continuar", "No hay selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetAuto(e.RowIndex);
            }
        }

        private void GetAuto(int index)
        {
            auto = new Auto();
            rowIdx = index;
            auto.ID = int.Parse(dgvAutos.Rows[rowIdx].Cells[1].Value.ToString());
            auto.Marca = dgvAutos.Rows[rowIdx].Cells[2].Value.ToString();
            auto.Modelo = dgvAutos.Rows[rowIdx].Cells[3].Value.ToString();
            auto.Anio = int.Parse(dgvAutos.Rows[rowIdx].Cells[4].Value.ToString());
            auto.Precio = int.Parse(dgvAutos.Rows[rowIdx].Cells[5].Value.ToString());
            auto.FechaVenta = dgvAutos.Rows[rowIdx].Cells[6].Value.ToString();
            auto.Imagen = dgvAutos.Rows[rowIdx].Cells[8].Value.ToString();
            auto.Detalles = dgvAutos.Rows[rowIdx].Cells[9].Value.ToString();
        }

        private void Buscar(object sender, KeyEventArgs e)
        {

            if (txtBuscar.Text.Length > 0)
            {
                string filterBy = cmbFiltrar.GetItemText(cmbFiltrar.SelectedItem).ToLower();
                List<Auto> _filter = new List<Auto>();
                BindingList<Auto> _newBindingList = new BindingList<Auto>();
                if (e.KeyData == Keys.Enter)
                {
                    switch (filterBy)
                    {
                        case "id":
                            _filter = listAutos.ToList().Where((auto) => auto.ID.ToString().StartsWith(txtBuscar.Text)).ToList();
                            break;
                        case "marca":
                            _filter = listAutos.ToList().Where((auto) => auto.Marca.StartsWith(txtBuscar.Text)).ToList();
                            break;
                        case "modelo":
                            _filter = listAutos.ToList().Where((auto) => auto.Modelo.StartsWith(txtBuscar.Text)).ToList();
                            break;
                        case "año":
                            _filter = listAutos.ToList().Where((auto) => auto.Anio.ToString().StartsWith(txtBuscar.Text)).ToList();
                            break;
                        case "precio":
                            _filter = listAutos.ToList().Where((auto) => auto.Precio.ToString().StartsWith(txtBuscar.Text)).ToList();
                            break;
                        case "fecha venta":
                            _filter = listAutos.ToList().Where((auto) => auto.FechaVenta.StartsWith(txtBuscar.Text)).ToList();
                            break;
                    }
                    _newBindingList = new BindingList<Auto>(_filter);
                    FillTable(_newBindingList);
                }
            }
        }

        private void btnRestaura_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            FillTable(listAutos);
        }

        public void CargarAutos()
        {
            AutoDAL autoDAL = new AutoDAL();
            listAutos = new BindingList<Auto>(autoDAL.GetAll(ConnectionDAL.GetConnection()));
            FillTable(listAutos);
        }

        private void FillTable(BindingList<Auto> autos)
        {
            dgvAutos.Rows.Clear();
            dgvAutos.Refresh();
            for (int idx = 0; idx < autos.Count; idx++)
            {
                FileStream fileStream = new FileStream(AutoDAL.pathImageFolder + autos[idx].Imagen, FileMode.Open);
                Image imageAuto = new Bitmap(fileStream);
                dgvAutos.Rows.Add(0, autos[idx].ID, autos[idx].Marca, autos[idx].Modelo,
                    autos[idx].Anio, autos[idx].Precio, autos[idx].FechaVenta, imageAuto,
                    autos[idx].Imagen, autos[idx].Detalles);
                fileStream.Close();
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvAutos.Rows[e.RowIndex].Cells[0].Value) == true)
                {
                    dgvAutos.Rows[e.RowIndex].Cells[0].Value = false;
                } else
                {
                    for (int row = 0; row < dgvAutos.Rows.Count; row++)
                    {
                        dgvAutos.Rows[row].Cells[0].Value = false;
                    }
                    dgvAutos.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }
    }
}
