using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversidadFormsProyect.Repositories;
using UniversidadFormsProyect.Tables;

namespace UniversidadFormsProyect.SubForms
{
    public partial class EstudianteForm : Form
    {

        private IEstudiantesRepo estudiantesRepo;

        public EstudianteForm()
        {
            InitializeComponent();
        }

        private void GetEstudiantesToDV()
        {
            estudiantesRepo = new EstudiantesRepo();
            DVEstudiantes.DataSource = estudiantesRepo.GetEstudiantes();
            countLabel.Text = DVEstudiantes.Rows.Count > 0 ? $"Total Estudiantes: {DVEstudiantes.Rows.Count}" : "No hay ningún estudiante registrado";
        }

        public void OnLoad(object sender, EventArgs e)
        {
            GetEstudiantesToDV();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            GetEstudiantesToDV();
        }
    }
}
