using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class PrestamoDto
    {
        long id;
        long idCliente;
        long idLibro;
        long idBiblioteca;
        DateTime fchaPrestamo = new DateTime(9999 / 12 / 31);
        DateTime fchaEntrega = new DateTime(9999 / 12 / 31);
        string estadoPrestamo = "aaaaa";

        public long Id { get => id; set => id = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public DateTime FchaPrestamo { get => fchaPrestamo; set => fchaPrestamo = value; }
        public DateTime FchaEntrega { get => fchaEntrega; set => fchaEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }

        public PrestamoDto(long id, DateTime fchaPrestamo, DateTime fchaEntrega, string estadoPrestamo)
        {
            this.id = id;
            this.fchaPrestamo = fchaPrestamo;
            this.fchaEntrega = fchaEntrega;
            this.estadoPrestamo = estadoPrestamo;
        }
    }
}
