using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Mensajes.Models
{
    public class AnuncioCollection : ObservableCollection<Anuncio>
    {

    }

    public class Anuncio
    {


        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _cuerpo;

        public string Cuerpo
        {
            get { return _cuerpo; }
            set { _cuerpo = value; }
        }

        public Anuncio()
        {

        }

        public Anuncio(int id, string nombre, string cuerpo)
        {
            Id = id;
            Nombre = nombre;
            Cuerpo = cuerpo;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
