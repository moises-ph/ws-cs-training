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
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductosForm newMDIChild = new ProductosForm();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void ventanasEnCascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void verExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelForm excelForm= new ExcelForm();
            excelForm.MdiParent = this;
            excelForm.Show();
        }
    }
}
