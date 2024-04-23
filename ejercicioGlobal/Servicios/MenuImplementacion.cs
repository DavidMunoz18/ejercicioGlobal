using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        
        ClienteInterfaz ci = new ClienteImplementacion();
        PrestamoInterfaz pr = new PrestamoImplementacion();
        LibroInterfaz li = new LibroImplementacion();
        
        public void buscarBibliotecaYMostrarMenu(List<BibliotecaDto> listaBibliotecas, List<PrestamoDto> listaPrestamos, List<ClienteDto> listaClientes, List<LibroDto> listaLibros)
        {
            try
            {


                Console.WriteLine("Introduzca el nombre de la biblioteca");
                string nomBiblioteca = Console.ReadLine();
                int opcion = menuBiblioteca();
                foreach (BibliotecaDto biblioteca in listaBibliotecas)
                {
                    if (nomBiblioteca.Equals(biblioteca.Nombre))
                    {
                        long id = biblioteca.Id;
                        switch (opcion)
                        {
                            case 1:
                                ci.crearNuevoCliente(listaClientes, id);
                                break;
                            case 2:
                                pr.darAltaPrestamo(listaPrestamos, listaClientes, id);
                                break;
                            case 3:
                                li.darAltaLibro(listaLibros, id);
                                break;
                        }


                    }
                }
            }catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            }
        }

        public int mostrarMenuPrincipal()
        {
            int opcion;
            Console.WriteLine("##########################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Dar de alta una nueva biblioteca");
            Console.WriteLine("2. Buscar la existencia de esa biblioteca");
            Console.WriteLine("##########################");
            Console.WriteLine("¿Que opcion desea?");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        private int menuBiblioteca()
        {
            int opcion;
            Console.WriteLine("#######################");
            Console.WriteLine("1. Dar de alta cliente");
            Console.WriteLine("2. Dar de alta prestamo");
            Console.WriteLine("3. Dar de alta libro");
            Console.WriteLine("#######################");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
