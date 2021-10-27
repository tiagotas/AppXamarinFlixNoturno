using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlixNoturno.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapitanMarvel : ContentPage
    {
        public CapitanMarvel()
        {
            InitializeComponent();

            poster.Source = ImageSource.FromResource("AppXamarinFlixNoturno.Posters.capitamarvel.jpg");

            sinopse.Text = @"Capitã Marvel, parte do exército de elite dos Kree, uma raça alienígena, 
encontra-se no meio de uma batalha entre seu povo e os Skrulls. Ao tentar 
impedir uma invasão de larga escala na Terra, em 1995, ela tem memórias 
recorrentes de uma outra vida, como Carol Danvers, agente da Força Aérea 
norte-americana. Com a ajuda de Nick Fury, Capitã Marvel precisa descobrir 
os segredos de seu passado e pôr um fim ao conflito intergalático com os Skrulls.";

        }
    }
}