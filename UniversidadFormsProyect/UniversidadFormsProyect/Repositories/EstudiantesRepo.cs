using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadFormsProyect.Connections;
using UniversidadFormsProyect.Tables;

namespace UniversidadFormsProyect.Repositories
{
    public class EstudiantesRepo : IEstudiantesRepo
    {
        private IDbConnection _connection;
        
        public EstudiantesRepo()
        {
            _connection = new SqlConnection(AppConections.ConnectionString);
        }

        public List<Estudiantes> GetEstudiantes()
        {
            using (_connection)
            {
                if (_connection.State == ConnectionState.Closed) _connection.Open();
                return (List<Estudiantes>)_connection.Query<Estudiantes>("GetAllEstudiantes", commandType: CommandType.StoredProcedure);
            }
        }

        public bool AddEstudiante(Estudiantes estudiantes)
        {
            try
            {
                using (_connection)
                {
                    if (_connection.State == ConnectionState.Closed) _connection.Open();
                    _connection.Execute("AddEstudent", estudiantes, commandType: CommandType.StoredProcedure);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
