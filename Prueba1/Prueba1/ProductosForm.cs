using Prueba1.ProductosForms;
using Prueba1.Repositories;
using Prueba1.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class ProductosForm : Form
    {
        private IProductRepository productRepository;
        private List<List<Productos>> productsPages;
        private int pageIndex = 0;
        public ProductosForm()
        {
            InitializeComponent();
            this.productRepository = new ProductRepository();
            DVProductos.Visible = false;
        }

        public void Form_OnLoad(object sender, EventArgs e)
        {
            DVProductos.DataSource = productRepository.GetProductos();
            DVProductos.Visible = true;
            CountLabel.Text = $"Total productos: {DVProductos.RowCount}";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.Show();
        }
    }
}
