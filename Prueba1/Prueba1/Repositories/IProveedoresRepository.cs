using Prueba1.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Repositories
{
    public interface IProveedoresRepository
    {
        List<Proveedores> GetProveedores();
        bool CreateProveedor(Proveedores proveedor);
        bool UpdateProveedor(Proveedores newProveedor);
        bool DeleteProveedor(int proveedorId);
    }
}
