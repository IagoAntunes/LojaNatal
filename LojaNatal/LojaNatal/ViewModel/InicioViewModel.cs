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
        public string ItensAdicionados { get; set; }

        public InicioViewModel()
        {
            Dados.PrecoTotal.ToString().Replace(",", ".");
            this.ItensAdicionados = String.Format("{0} Itens Adicionados", Dados.QtdItens);
            this.TotalPreco = String.Format("R$ " +Dados.PrecoTotal.ToString().Replace(",","."));
            this.QtdItens = Dados.QtdItens;
            ListaItens = new ObservableCollection<Item>
            {
                new Item{Titulo = "By Fluffmonger",Nome = "Corgi Bear Supplies",Preco ="R$ 50,99",Quantidade = "5",Imagem = "Detail1.png" },
                new Item{Titulo = "By EmmasToys",Nome = "Reindeer Crochet Hat",Preco = "R$ 15,20",Quantidade = "15",Imagem = "Detail2.png" },
                new Item{Titulo = "By TheWarmCats",Nome = "Reindeer Socks Blue",Preco = "R$ 10,50",Quantidade = "25",Imagem = "Detail3.png" }
            };
        }
    }
}
