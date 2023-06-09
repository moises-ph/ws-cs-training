using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba1.Repositories;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        IProductRepository productRepository;
        public Form1()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DVProductos.DataSource = productRepository.GetProductos();
            label1.Text = $"Total Producots: {DVProductos.RowCount}";
        }
    }
}
