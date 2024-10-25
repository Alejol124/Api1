using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProductos
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            txSalida.ScrollBars = ScrollBars.Both;
        }
        string url = "http://localhost:58894/api/Producto";
        private void btnConGeneral_Click(object sender, EventArgs e)
        {
            dynamic respuesta = DBApi.Get(url);
            txSalida.Text = respuesta.ToString();
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            string urlProv = "http://localhost:58894/api/Proveedor";
            dynamic respuesta = DBApi.Get(urlProv);
            txSalida.Text = respuesta.ToString();
        }
    }
}
