using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Prueba1.Connections;
using Prueba1.Tables;

namespace Prueba1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        IDbConnection _connection;
        public ProductRepository()
        {
            _connection = new SqlConnection(AppConnection.ConnectionString);
        }
        public bool DeleteProduct(Productos newProduct)
        {
            throw new NotImplementedException();
        }

        public List<Productos> GetProductos()
        {
            using (_connection)
            {
                if (_connection.State == ConnectionState.Closed) _connection.Open();
                return (List<Productos>)_connection.Query<Productos>("GetAllProducts", commandType: CommandType.StoredProcedure);
            };
        }

        public bool InsertProduct(Productos newProduct)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Productos newProduct)
        {
            throw new NotImplementedException();
        }
    }
}
