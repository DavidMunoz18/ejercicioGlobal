using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal interface LibroInterfaz
    {
        public void darAltaLibro(List<LibroDto> listaLibros, long id);
    }
}
