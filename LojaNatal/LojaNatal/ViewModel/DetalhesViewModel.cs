using LojaNatal.Armazenamento;
using LojaNatal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LojaNatal.ViewModel
{
    public class DetalhesViewModel : INotifyPropertyChanged
    {
        private string _Imagem;
        public string Imagem { get { return _Imagem; } set { _Imagem = value;OnPropertyChanged("Imagem"); } }
        private string _Titulo;
        public string Titulo { get { return _Titulo; } set { _Titulo = value;OnPropertyChanged("Titulo"); } }
        private string _Nome;
        public string Nome { get { return _Nome; } set { _Nome = value;OnPropertyChanged("Nome"); } }
        private string _Preco;
        public string Preco { get { return _Preco;} set { _Preco = value;OnPropertyChanged("Preco"); } }
        private string _Quantidade;
        public string Quantidade {get { return _Quantidade; } set { _Quantidade = value;OnPropertyChanged("Quantidade"); } }
        private int _QtdItens;
        public int QtdItens { get { return _QtdItens; }set { _QtdItens = value;OnPropertyChanged("QtdItens"); } }

        public Command AdicionarCarrinho;
        public DetalhesViewModel(Item item)
        {
            this.Titulo = item.Titulo;
            this.Nome = item.Nome;
            this.Preco = item.Preco.Replace(",",".");
            this.Imagem = item.Imagem;
            this.Quantidade = item.Quantidade;

            this.QtdItens = Dados.QtdItens;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(nameProperty);
            }
        }
    }
}
