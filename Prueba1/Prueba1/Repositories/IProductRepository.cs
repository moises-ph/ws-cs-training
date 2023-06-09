using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba1.Tables;

namespace Prueba1.Repositories
{
    public interface IProductRepository
    {
        List<Productos> GetProductos();
        bool InsertProduct(Productos newProduct);
        bool UpdateProduct(Productos newProduct);
        bool DeleteProduct(Productos newProduct);
    }
}
