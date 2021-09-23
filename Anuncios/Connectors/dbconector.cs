using Mensajes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;


namespace Anuncios.Connectors
{
    public class dbconector
    {
        public AnuncioCollection listarAnuncios()
        {
            string API_URL = "https://jsonplaceholder.typicode.com/comments?_limit=500";
            var client = new WebClient();
            var json = client.DownloadString(API_URL);
            dynamic posts = JsonConvert.DeserializeObject(json);
           
            AnuncioCollection lista = new AnuncioCollection();
            foreach (var post in posts)
            {
                string cadena1 = post["id"];
                string cadena2 = post["name"];
                string cadena3 = post["body"];
                lista.Add(new Anuncio(cadena1, cadena2, cadena3));

            }
            lista.Add(new Anuncio("1", "Daniel", "Hola Mexico"));
            lista.Add(new Anuncio("2", "Ricardo", "Hola Xalapa"));
            lista.Add(new Anuncio("3", "Juan", "Hola Veracruz"));
            lista.Add(new Anuncio("4", "Ernesto", "Hola Tlaxcala"));
            lista.Add(new Anuncio("5", "Gustavo", "Hola Japón"));
            return lista;
        }
    }
}

