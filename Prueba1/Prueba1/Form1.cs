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

        private void closeActualMdiForm()
        {
            Form activeChild = this.ActiveMdiChild;
            if(activeChild != null)
            {
                activeChild.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void VerProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeActualMdiForm();
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        private void verExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeActualMdiForm();
            ExcelForm excelForm = new ExcelForm();
            excelForm.MdiParent = this;
            excelForm.Show();
        }
    }
}
