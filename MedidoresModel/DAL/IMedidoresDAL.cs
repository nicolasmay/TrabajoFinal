using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    internal interface IMedidoresDAL
    {
        List<Medidore> ObtenerMedidores();
    }
}
