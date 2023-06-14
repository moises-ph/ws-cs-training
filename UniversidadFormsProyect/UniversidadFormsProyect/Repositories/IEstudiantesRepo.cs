using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadFormsProyect.Tables;

namespace UniversidadFormsProyect.Repositories
{
    public interface IEstudiantesRepo
    {
        List<Estudiantes> GetEstudiantes();
        bool AddEstudiante(Estudiantes estudiantes);
    }
}
