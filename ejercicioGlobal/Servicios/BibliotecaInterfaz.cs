using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal interface BibliotecaInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecaDto> listaBibliotecas); 
    }
}
