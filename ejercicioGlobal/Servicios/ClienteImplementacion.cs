using ejercicioGlobal.Dtos;
using ejercicioGlobal.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        
        public void crearNuevoCliente(List<ClienteDto> listaClientes, long id)
        {
            try
            {
                ClienteDto cliente = darAltaCliente(listaClientes, id);

                listaClientes.Add(cliente);
            }catch (Exception ex)
            {
                throw;
            }
            
        }
        private ClienteDto darAltaCliente(List<ClienteDto> listaClientes , long id)
        {
            ClienteDto cliente = new ClienteDto();

            try
            {
                char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                Console.WriteLine("Introduce tu numero del dni");
                int numeroDni = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce la letra del dni");
                char letraDni = Convert.ToChar(Console.ReadLine());

                int resto = numeroDni % 23;



                if (letras[resto] == letraDni)
                {
                    Console.WriteLine("El dni es correcto");

                    cliente.Id = Util.calcularIdCliente(listaClientes);

                    Console.WriteLine("Id: " + cliente.Id);

                    Console.WriteLine("Introduzca el nombre");
                    cliente.Nombre = Console.ReadLine();

                    Console.WriteLine("Introduzca el apellido");
                    cliente.Apellido = Console.ReadLine();

                    Console.WriteLine("Introduzca la fecha de nacimiento");
                    cliente.Fchanac = Console.ReadLine();

                    Console.WriteLine("Introduzca el email");
                    cliente.Email = Console.ReadLine();


                    cliente.IdBiblio = id;

                    Console.WriteLine("id de la biblioteca a la que pertenece" + cliente.IdBiblio);

                }








            }catch(Exception ex)
            {
                throw;
            }



            return cliente;
        }
     
    }
}
