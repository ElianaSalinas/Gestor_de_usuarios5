using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Capa_Negocios
{
    public interface ICapa_de_Negocios
    {
        DataTable MostrarUsu();
        void InsertarUsu(string nombre, string direccion, string telefono, string edad);
        void EditarUsu(int id, string nombre, string direccion, string telefono, string edad);
        void EliminarUsu(int id);
    }
}
