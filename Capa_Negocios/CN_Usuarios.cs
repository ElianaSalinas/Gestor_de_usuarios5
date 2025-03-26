using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;

namespace Capa_Negocios
{
    public class CN_Usuarios : ICapa_de_Negocios
       
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        public DataTable MostrarUsu()
        {
            return objetoCD.Mostrar();
        }

        public void InsertarUsu(string nombre, string telefono, string edad)
        {
            objetoCD.Insertar(nombre, telefono, edad);
        }

        public void EditarUsu(int id, string nombre, string telefono, string edad)
        {
            objetoCD.Editar(id, nombre, telefono, edad);
        }

        public void EliminarUsu(int id)
        {
            objetoCD.Eliminar(id);
        }
    }
}
