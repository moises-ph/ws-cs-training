using Prueba1.Repositories;
using Prueba1.Tables;
using Prueba1.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1.ProductosForms
{
    public partial class CreateProductForm : Form
    {
        IProveedoresRepository proveedoresRepo;
        public CreateProductForm()
        {
            InitializeComponent();
            this.proveedoresRepo = new ProveedoresRepository();
        }

        public void FormOnLoad(object sender, EventArgs e)
        {
            ComboProveedor.Items.Clear();
            List<Proveedores> proveedores = proveedoresRepo.GetProveedores();
            proveedores.ForEach(p =>
            {
                ComboProveedor.Items.Add(new ComboValue(p.NOMBREPROV, p.PROVEEDORID));
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos newProduct = new Productos();
            newProduct.PRODUCTOID = int.Parse(InIdProducto.Text);
            newProduct.DESCRIPCION = InDescripcio.Text;
            newProduct.EXISTENCIA = int.Parse(InExistencia.Text);
            newProduct.PRECIOUNIT = int.Parse(InUnitP.Text);
            newProduct.CATEGORIAID = 100;
            this.Close(); 
        }
    }
}
