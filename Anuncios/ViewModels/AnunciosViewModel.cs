using Anuncios.Connectors;
using Anuncios.Core.Commands;
using Mensajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Anuncios.ViewModels
{
    public class AnunciosViewModel : IGeneric 
    {
       
        private AnuncioCollection _ListaAnuncios = new AnuncioCollection();
        public AnuncioCollection ListaAnuncios
        {
            get { return _ListaAnuncios; }
            set 
            { 
                _ListaAnuncios = value;
                RaisePropertyChanged("ListaAnuncios");
            }
        }

        private Anuncio _CurrentAnuncio;

        public Anuncio CurrentAnuncio
        {
            get { return _CurrentAnuncio; }
            set {
                _CurrentAnuncio = value;
                RaisePropertyChanged("CurrentAnuncio");
            }
        }

        private ICommand _listarAnunciosCommand;

        public ICommand ListarAnunciosCommand
        {
            get
            {
                if (_listarAnunciosCommand == null)
                    _listarAnunciosCommand = new RelayCommand(new Action(ListarAnuncios));
                return _listarAnunciosCommand;
            }
        }

        public AnunciosViewModel()
        {

        }

        public void ListarAnuncios()
        {
            ListaAnuncios = App.dbconector.listarAnuncios();
        }
    }
}
