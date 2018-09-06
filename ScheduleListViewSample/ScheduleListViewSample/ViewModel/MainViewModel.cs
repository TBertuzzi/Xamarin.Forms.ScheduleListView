using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PaginaIIntroducaoExemplo.Model;

namespace PaginaIIntroducaoExemplo.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        public ObservableCollection<CarouselItem> Itens { get; }

        private int _position;
        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        public MainViewModel()
        {
            CarouselItem item = new CarouselItem
            {
                Titulo = "Bem vindo",
                Detalhe = "Aqui temos diversos médicos a disposição",
                Imagem = "onboarding-bg-01.png"
            };

            Itens.Add(item);

            item = new CarouselItem
            {
                Titulo = "Gaste seu dinheiro",
                Detalhe = "Contratando eles eu ficarei muito rico",
                Imagem = "onboarding-bg-02.png"
            };

            Itens.Add(item);

            item = new CarouselItem
            {
                Titulo = "Sua saude não é importante",
                Detalhe = "Coma mais bacon meu amigo, é vida!",
                Imagem = "onboarding-bg-03.png"
            };

            Itens.Add(item);

            item = new CarouselItem
            {
                Titulo = "Crossfit raiz é pedreiro",
                Detalhe = "É como diz o titulo :P",
                Imagem = "onboarding-bg-04.png"
            };

            Itens.Add(item);


        }
    }
}
