using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
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
        private string selectedIMG = "";
        private string pathSelectedIMG = "";
        private string defaultIMG = "default_car_image.png";
        int currentYear = 0;

        public FormAuto(Auto auto, Main main)
        {
            this.auto = auto;
            this.main = main;
            currentYear = DateTime.Now.Year;
            InitializeComponent();
            LlenarForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowaffected = 0;
            AutoDAL autoDAL = new AutoDAL();
            rowaffected = autoDAL.InsertUpdateAuto(ObtenerAuto(), ConnectionDAL.GetConnection());
            if (rowaffected != 0)
            {
                main.CargarAutos();
                Dispose();
            } else
            {
                string accion = auto.ID == 0 ? "inserción" : "modificación";
                MessageBox.Show("Error de " + accion, "Fallo de operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Auto ObtenerAuto()
        {
            string newImageName = DateTime.Now.ToString().Replace('/', '-').Replace(' ', '-').Replace(':', '-')+ selectedIMG;
            string newPath = AutoDAL.pathImageFolder + newImageName;
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            auto.Anio = int.Parse(txtAnio.Text);
            auto.Precio = double.Parse(txtPrecio.Text);
            auto.FechaVenta = dtFechaVenta.Text;
            if (selectedIMG.Length > 0)
            {
                if (auto.Imagen != defaultIMG && auto.ID != 0)
                    File.Delete(AutoDAL.pathImageFolder+auto.Imagen);
                File.Copy(pathSelectedIMG, newPath);
                auto.Imagen = newImageName;
            } else
            {
                if (auto.ID == 0)
                    auto.Imagen = defaultIMG;
            }
            return auto;
        }

        private void LlenarForm()
        {
            dtFechaVenta.MaxDate = DateTime.Now;
            if (auto.ID > 0)
            {
                txtMarca.Text = auto.Marca;
                txtModelo.Text = auto.Modelo;
                txtAnio.Text = auto.Anio.ToString();
                txtPrecio.Text = auto.Precio.ToString();
                dtFechaVenta.Text = auto.FechaVenta;
                if (auto.Imagen != defaultIMG)
                {
                    picBoxAutoImg.Image = new Bitmap(File.Open(AutoDAL.pathImageFolder + auto.Imagen, FileMode.Open));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarAño(object sender, KeyEventArgs e)
        {
            if (txtAnio.Text.Length > 0)
            {
                int typedYear = int.Parse(txtAnio.Text);
                if (typedYear > currentYear)
                {
                    txtAnio.Text = currentYear.ToString();
                }
            }
        }

        private void btnPickImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Selecciona la imagen";
            fileDialog.Filter = "jpg files (*.jpg)|*.jpg|*.png|*.jpeg";
            if (Directory.Exists(AutoDAL.pathImageFolder) == false)
            {
                Directory.CreateDirectory(AutoDAL.pathImageFolder);
            }
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedIMG = fileDialog.SafeFileName;
                    pathSelectedIMG = fileDialog.FileName;
                    picBoxAutoImg.Image = new Bitmap(fileDialog.OpenFile());
                } catch (Exception ex)
                {
                    MessageBox.Show("No se puede abrir el archivo\nError: " + ex.Message);
                }
            } else
            {
                fileDialog.Dispose();
            }
        }
    }
}