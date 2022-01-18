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
        Item item;
        public Detalhes(Item item)
        {
            this.item = item;
            InitializeComponent();
            DefinirCor(item);
            BindingContext = new ViewModel.DetalhesViewModel(item);
        }
        private void Voltar(object sender,EventArgs args)
        {
            App.Current.MainPage = new Paginas.Home();
        }
        private void DefinirCor(Item item)
        {
            if (item.Imagem.Equals("Detail1.png")){
                GridHead.BackgroundColor = Color.FromHex("#FFEBE4");
            }else if (item.Imagem.Equals("Detail2.png")){
                GridHead.BackgroundColor = Color.FromHex("#FFF8DC");
            }else if (item.Imagem.Equals("Detail3.png")){
                GridHead.BackgroundColor = Color.FromHex("#DAF2F9");
            }
        }

    }
}