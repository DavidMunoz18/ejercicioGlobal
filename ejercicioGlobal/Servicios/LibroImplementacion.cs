using ejercicioGlobal.Dtos;
using ejercicioGlobal.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class LibroImplementacion : LibroInterfaz
    {
        public void darAltaLibro(List<LibroDto> listaLibros, long id)
        {
            try
            {
                LibroDto libro = crearNuevoLibro(listaLibros, id);

                listaLibros.Add(libro);
            }catch (Exception ex)
            {
                throw;
            }
            
        }
        private LibroDto crearNuevoLibro(List<LibroDto> listaLibros, long id)
        {
            LibroDto libro = new LibroDto();
            try
            {
                

                libro.Id = Util.calcularIdLibro(listaLibros);

                Console.WriteLine("Introduzca el titulo");
                libro.Título = Console.ReadLine();

                Console.WriteLine("Introduzca el subtitulo");
                libro.Subtítulo = Console.ReadLine();

                Console.WriteLine("Introduzca el autor");
                libro.Autor = Console.ReadLine();
                Console.WriteLine("Introduzca el ISBN");
                libro.ISBN1 = Console.ReadLine();

                Console.WriteLine("Introduzca el numero de la edicion");
                libro.Numedicion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca la editorial");
                libro.Editorial = Console.ReadLine();

                Console.WriteLine("Introduzca el stock");
                libro.Stock = Convert.ToInt32(Console.ReadLine());

                libro.IdBiblio = id;
                Console.WriteLine("ID BIBLIOTECA" + id);
            }catch (Exception ex)
            {
                throw;
            }
           


            return libro;
        }
    }
}
