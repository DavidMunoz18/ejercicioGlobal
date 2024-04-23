using ejercicioGlobal.Dtos;
using ejercicioGlobal.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class BibliotecaImplementacion : BibliotecaInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecaDto> listaBibliotecas)
        {
            try
            {
                BibliotecaDto biblioteca = crearNuevaBiblioteca(listaBibliotecas);

                listaBibliotecas.Add(biblioteca);
            }catch (Exception ex)
            {
                throw;
            }
           
        }
        private BibliotecaDto crearNuevaBiblioteca(List<BibliotecaDto> listaBibliotecas)
        {
            BibliotecaDto biblioteca = new BibliotecaDto();
            try
            {
                

                biblioteca.Id = Util.calcularIdBiblioteca(listaBibliotecas);

                Console.WriteLine("Id: " + biblioteca.Id);

                Console.WriteLine("Introduzca el nombre");
                biblioteca.Nombre = Console.ReadLine();

                Console.WriteLine("Introduzca la direccion");
                biblioteca.Dirección = Console.ReadLine();
            }catch(Exception ex) 
            {
                throw;
            }

            


            return biblioteca;
        }
    }
}
