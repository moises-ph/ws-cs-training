using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Prueba1.Connections
{
    public static class AppConnection
    {
        public static String ConnectionString => ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
    }
}
