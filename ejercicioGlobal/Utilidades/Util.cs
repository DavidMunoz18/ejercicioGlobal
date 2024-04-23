using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Utilidades
{
    internal class Util
    {
        public static long calcularIdBiblioteca(List<BibliotecaDto> listaBibliotecas)
        {
            long id;

            int tamanioLista = listaBibliotecas.Count;

            if(tamanioLista == 0)
            {
                id = 1;
            }
            else
            {
                id = listaBibliotecas[tamanioLista - 1].Id + 1;
            }
            return id;
        }
        public static long calcularIdLibro(List<LibroDto> listaLibros) 
        {
            long id;

            int tamanioLista = listaLibros.Count;

            if (tamanioLista == 0)
            {
                id = 1;
            }
            else
            {
                id = listaLibros[tamanioLista - 1].Id + 1;
            }
            return id;
        }
        public static long calcularIdCliente(List<ClienteDto> listaCliente)
        {
            long id;

            int tamanioLista = listaCliente.Count;

            if (tamanioLista == 0)
            {
                id = 1;
            }
            else
            {
                id = listaCliente[tamanioLista - 1].Id + 1;
            }
            return id;
        }
        public static long calcularIdPrestamo(List<PrestamoDto> listaPrestamos)
        {
            long id;

            int tamanioLista = listaPrestamos.Count;

            if (tamanioLista == 0)
            {
                id = 1;
            }
            else
            {
                id = listaPrestamos[tamanioLista - 1].Id + 1;
            }
            return id;
        }
    }
}
