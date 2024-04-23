using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal interface MenuInterfaz
    {
        public int mostrarMenuPrincipal();

        public void buscarBibliotecaYMostrarMenu(List<BibliotecaDto> listaBibliotecas, List<PrestamoDto> listaPrestamos, List<ClienteDto> listaClientes, List<LibroDto> listaLibros);
    }
}
