using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversidadFormsProyect.SubForms;

namespace UniversidadFormsProyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeActualMdiForm()
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                activeChild.Close();
            }
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeActualMdiForm();
            EstudianteForm estudianteForm = new EstudianteForm();
            estudianteForm.MdiParent = this;
            estudianteForm.Show();
        }
    }
}
