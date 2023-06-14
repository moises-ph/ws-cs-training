using Dapper;
using Prueba1.Connections;
using Prueba1.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Repositories
{
    public class ProveedoresRepository : IProveedoresRepository
    {
        IDbConnection _connection;

        public ProveedoresRepository()
        {
            _connection = new SqlConnection(AppConnection.ConnectionString);
        }
        public bool CreateProveedor(Proveedores proveedor)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProveedor(int proveedorId)
        {
            throw new NotImplementedException();
        }

        public List<Proveedores> GetProveedores()
        {
            using (_connection)
            {
                if (_connection.State == ConnectionState.Closed) _connection.Open();
                return (List<Proveedores>)_connection.Query<Proveedores>("GetAllProveedores", commandType: CommandType.StoredProcedure);
            }
        }

        public bool UpdateProveedor(Proveedores newProveedor)
        {
            throw new NotImplementedException();
        }
    }
}
