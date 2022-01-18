using LojaNatal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LojaNatal.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        public Home()
        {
            InitializeComponent();
            
            BindingContext = new ViewModel.InicioViewModel();
        }
        private void GoDetalhe(object sender,EventArgs args)
        {
            Grid lblDetalhe = (Grid)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Item vaga = tapGest.CommandParameter as Item;
            //Navigation.PushAsync(new Paginas.Detalhes(vaga));

            App.Current.MainPage = new Paginas.Detalhes(vaga);

        }
    }
}