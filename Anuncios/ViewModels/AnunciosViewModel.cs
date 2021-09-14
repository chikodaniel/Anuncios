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
                if (value != null && value.Count > 0)
                {
                    CurrentAnuncio = value[0];
                }
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
                RaisePropertyChanged("CanShowInfo");
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

        private ICommand _verInfoCommand;

        public ICommand verInfoCommand
        {
            get
            {
                if (_verInfoCommand == null)
                    _verInfoCommand = new RelayCommand(new Action(verInfo), () => CanShowInfo);
                return _verInfoCommand;
            }
        }

        private bool CanShowInfo
        {
            get
            {
                return CurrentAnuncio != null;
            }
        }

        public AnunciosViewModel()
        {

        }

        private void ListarAnuncios()
        {
            ListaAnuncios = App.dbconector.listarAnuncios();
        }

        private void verInfo()
        {
            MessageBox.Show(CurrentAnuncio.Cuerpo);
        }
    }
}
