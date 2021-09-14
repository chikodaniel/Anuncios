using Mensajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anuncios.Connectors
{
    public class dbconector
    {
       public AnuncioCollection listarAnuncios()
        {
            AnuncioCollection lista = new AnuncioCollection();
            lista.Add(new Anuncio(1, "Daniel", "Hola Mexico"));
            lista.Add(new Anuncio(2, "Ricardo", "Hola Xalapa"));
            lista.Add(new Anuncio(3, "Juan", "Hola Veracruz"));
            lista.Add(new Anuncio(4, "Ernesto", "Hola Tlaxcala"));
            lista.Add(new Anuncio(5, "Gustavo", "Hola Japón"));
            return lista;
        }
    }
}

