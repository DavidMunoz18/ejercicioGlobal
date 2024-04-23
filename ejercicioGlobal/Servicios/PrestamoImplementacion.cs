using ejercicioGlobal.Dtos;
using ejercicioGlobal.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class PrestamoImplementacion : PrestamoInterfaz
    {
        public void darAltaPrestamo(List<PrestamoDto> listaPrestamos, List<ClienteDto> listaClientes, long id)
        {
            try
            {
                Console.WriteLine("Introduzca el id de la biblioteca ");
                long idBiblio = Convert.ToInt64(Console.ReadLine());


                foreach (ClienteDto cliente in listaClientes)
                {
                    if (id.Equals(idBiblio))
                    {
                        Console.WriteLine("El cliente pertenece");
                    }
                    else
                    {
                        Console.WriteLine("El cliente no pertenece");
                    }
                }




                long idP = Util.calcularIdPrestamo(listaPrestamos);
                Console.WriteLine("ID prestamo: " + idP);


                DateTime fechaPrestamo = DateTime.Today.AddDays(1);
                Console.WriteLine("Fecha prestamo" + fechaPrestamo);

                DateTime fechaFinPrestamo = fechaPrestamo.AddDays(7);
                Console.WriteLine("Fecha fin prestamo:" + fechaFinPrestamo);

                Console.WriteLine("Introduce el estado del prestamo");
                string Estado = Console.ReadLine();

                PrestamoDto prestamo = new PrestamoDto(id, fechaPrestamo, fechaFinPrestamo, Estado);

                listaPrestamos.Add(prestamo);
            }
            catch(Exception ex)
            {
                throw;
            }
           

        } 
    }
}
