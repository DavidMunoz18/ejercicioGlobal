using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class LibroDto
    {
        long id;
        string título = "aaaaa";
        string subtítulo = "aaaaa";
        string autor = "aaaaa";
        string ISBN = "aaaaa";
        int numedicion = 11111;
        string editorial = "aaaaa";
        int stock = 11111;
        long idBiblio;

        public long Id { get => id; set => id = value; }
        public string Título { get => título; set => título = value; }
        public string Subtítulo { get => subtítulo; set => subtítulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int Numedicion { get => numedicion; set => numedicion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdBiblio { get => idBiblio; set => idBiblio = value; }

        public LibroDto()
        {
        }

        public LibroDto(string título, string subtítulo, string autor, string iSBN, int numedicion, string editorial, int stock)
        {
            this.título = título;
            this.subtítulo = subtítulo;
            this.autor = autor;
            ISBN = iSBN;
            this.numedicion = numedicion;
            this.editorial = editorial;
            this.stock = stock;
        }
    }
}
