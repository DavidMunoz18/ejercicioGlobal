using ejercicioGlobal.Dtos;
using ejercicioGlobal.Servicios;

namespace ejercicioGlobal.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            BibliotecaInterfaz bi = new BibliotecaImplementacion();
            DateTime fechahoy = DateTime.Today;

            List<PrestamoDto> listaPrestamos = new List<PrestamoDto>();
            List<BibliotecaDto> listaBibliotecas = new List<BibliotecaDto>();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<LibroDto> listaLibros = new List<LibroDto>();
            try
            {
                
                string ruta = fechahoy.ToString("dd-MM-yyyy");
                bool cerrarMenu = false;
                int opcion;
                while (!cerrarMenu)
                {
                    opcion = mi.mostrarMenuPrincipal();
                    switch (opcion)
                    {
                        case 0:

                            using(StreamWriter sw = new StreamWriter(ruta))
                            {
                                foreach(var b in listaBibliotecas)
                                {
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("BIBLIOTECA");
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("id: " + b.Id);
                                    sw.WriteLine("Nombre: " + b.Nombre);
                                    sw.WriteLine("Direccion: " + b.Dirección);
                                   
                                }

                                foreach(var c in listaClientes)
                                {
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("CLIENTES");
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("Nombre: " + c.Nombre);
                                    sw.WriteLine("Apellidos: " + c.Apellido);
                                    sw.WriteLine("Fecha de nacimiento: " + c.Fchanac);
                                    sw.WriteLine("Dni: " + c.Dni);
                                    sw.WriteLine("Email: " + c.Email);
                                    
                                }
                                foreach(var l in listaLibros)
                                {
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("LIBROS");
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("título: " + l.Título);
                                    sw.WriteLine("Subtítulo: " + l.Subtítulo);
                                    sw.WriteLine("Autor: " + l.Autor);
                                    sw.WriteLine("ISBN: " + l.ISBN1);
                                    sw.WriteLine("Numedicion: " + l.Numedicion);
                                    sw.WriteLine("Editorial: " + l.Editorial);
                                    sw.WriteLine("Stock: " + l.Stock);
                                }
                                foreach(var p in listaPrestamos)
                                {
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("PRESTAMOS");
                                    sw.WriteLine("--------------------");
                                    sw.WriteLine("FchaPrestamo: " + p.FchaPrestamo);
                                    sw.WriteLine("FchaEntrega: " + p.FchaEntrega);
                                    sw.WriteLine("EstadoPrestamo: " + p.EstadoPrestamo);
                                }

                            }

                            cerrarMenu = true;
                            break;
                        case 1:
                            bi.darAltaBiblioteca(listaBibliotecas);
                            break;
                        case 2:
                            mi.buscarBibliotecaYMostrarMenu(listaBibliotecas, listaPrestamos, listaClientes, listaLibros);
                            break;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}