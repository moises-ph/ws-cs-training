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
            DVProductos.DataSource = productsPages;
        }

        public void Form_OnLoad(object sender, EventArgs e)
        {
            List<Productos> productos = productRepository.GetProductos();
            if(productos.Count <= 10)
            {
                productsPages.Add(productos);
            }
            else
            {
                List<Productos> tempProductos = new List<Productos>();
                
            }
        }
    }
}
