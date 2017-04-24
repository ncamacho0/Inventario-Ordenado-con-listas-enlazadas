using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Inventario miInventario = new Inventario();
        Producto miProducto;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miProducto = new Producto(Convert.ToInt32( txtCodigo.Text),txtNombre.Text,Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            miInventario.agregar(miProducto);
            txtCodigo.Text = "";
            txtNombre.Text="";
            txtCantidad.Text = "";
            txtCosto.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                Producto buscado=miInventario.buscar(txtNombre.Text);
                if (buscado==null)
                    txtNombre.Text = "";
                else
                {
                    txtReporte.Text = buscado.ToString() + Environment.NewLine +"----------";
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miInventario.eliminar(txtNombre.Text);
            MessageBox.Show("Archivo Eliminado");
            txtNombre.Text = "";


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = miInventario.reporte()+ Environment.NewLine;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            miProducto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            miProducto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
        }
    }
}
