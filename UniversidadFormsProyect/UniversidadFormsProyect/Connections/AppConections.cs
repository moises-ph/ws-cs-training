using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UniversidadFormsProyect.Connections
{
    public static class AppConections
    {
        public static String ConnectionString => ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
    }
}
