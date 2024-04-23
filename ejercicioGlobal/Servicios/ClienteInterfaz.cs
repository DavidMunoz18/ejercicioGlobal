using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal interface ClienteInterfaz
    {
        public void crearNuevoCliente(List<ClienteDto> listaClientes, long id);
    }
}
