using LojaNatal.Armazenamento;
using LojaNatal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace LojaNatal.ViewModel
{
    public class InicioViewModel
    {
        public ObservableCollection<Item> ListaItens { get; set; }
        public int QtdItens { get; set; }
        public string TotalPreco { get; set; }

        public InicioViewModel()
        {
            Dados.PrecoTotal.ToString().Replace(",", ".");
            this.TotalPreco = String.Format("R$ " +Dados.PrecoTotal.ToString());
            this.QtdItens = Dados.QtdItens;
            ListaItens = new ObservableCollection<Item>
            {
                new Item{Titulo = "Um",Nome = "Urso",Preco = 50.99,Quantidade = "5",Imagem = "Detail1.png" },
                new Item{Titulo = "Dois",Nome = "Coelho",Preco = 10.20,Quantidade = "15",Imagem = "Detail2.png" },
                new Item{Titulo = "Tres",Nome = "Meia",Preco = 5.50,Quantidade = "25",Imagem = "Detail3.png" }
            };
        }
    }
}
