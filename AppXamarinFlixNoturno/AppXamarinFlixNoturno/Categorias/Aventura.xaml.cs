using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlixNoturno.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            logotipo.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Img.xamarin.png");

            btnCapitaMarvel.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.capitamarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.panteranegra.jpg");
            btnShazan.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.shazam.jpg");
            btnAladdin.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.alladin.jpg");
            btnDumbo.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.dumbo.jpg");
            btnVef.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.vef.jpg");
        }

        private void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitanMarvel());

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}