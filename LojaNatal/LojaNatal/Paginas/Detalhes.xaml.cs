using LojaNatal.Armazenamento;
using LojaNatal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LojaNatal.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        public Detalhes(Item item)
        {
            InitializeComponent();

            BindingContext = item;
            DefinirCor(item);
        }
        private void Voltar(object sender,EventArgs args)
        {
            App.Current.MainPage = new Paginas.Home();
        }
        private void DefinirCor(Item item)
        {
            if (item.Imagem.Equals("Detail1")){
                GridHead.BackgroundColor = Color.FromHex("#FFEBE4");
            }else if (item.Imagem.Equals("Detail2")){
                GridHead.BackgroundColor = Color.FromHex("#FFF8DC");
            }else if (item.Imagem.Equals("Detail3")){
                GridHead.BackgroundColor = Color.FromHex("#DAF2F9");
            }
        }
        private void AddCart(object sender,EventArgs args)
        {
            Dados.QtdItens++;
        }
    }
}