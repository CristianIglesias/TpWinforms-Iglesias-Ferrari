using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
namespace Ventana1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvGrilla.DataSource = negocio.Listar();
           dgvGrilla.Columns[0].Visible = false;

        }


        private void dgvGrilla_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulos art = (Articulos)dgvGrilla.CurrentRow.DataBoundItem;
                pbImagen.Load(art.Imagen);
            }
            catch (Exception)
            {

            }
        }
       

        /// ZONA DE LOS EVENTOS GENERADOS SIN QUERER :)


        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
         private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
