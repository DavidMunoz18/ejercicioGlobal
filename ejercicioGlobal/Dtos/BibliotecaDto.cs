using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class BibliotecaDto
    {
        long id;
        string nombre = "aaaaa";
        string dirección = "aaaaa";

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dirección { get => dirección; set => dirección = value; }

        public BibliotecaDto()
        {
        }

        public BibliotecaDto(string nombre, string dirección)
        {
            this.nombre = nombre;
            this.dirección = dirección;
        }
    }
}
