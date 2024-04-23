using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class ClienteDto
    {
        long id;
        string nombre = "aaaaa";
        string apellido = "aaaaa";
        string fchanac = "9999/12/31";
        string dni = "aaaaa";
        string email = "aaaaa";
        DateTime fechainsus = DateTime.Today;
        DateTime fechafinsus = DateTime.Today.AddDays(7);
        long idBiblio;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Fchanac { get => fchanac; set => fchanac = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Fechainsus { get => fechainsus; set => fechainsus = value; }
        public DateTime Fechafinsus { get => fechafinsus; set => fechafinsus = value; }
        public long IdBiblio { get => idBiblio; set => idBiblio = value; }

        public ClienteDto()
        {
        }

        public ClienteDto(string nombre, string apellido, string fchanac, string dni, string email, DateTime fechainsus, DateTime fechafinsus)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fchanac = fchanac;
            this.dni = dni;
            this.email = email;
            this.fechainsus = fechainsus;
            this.fechafinsus = fechafinsus;
        }
    }
}
