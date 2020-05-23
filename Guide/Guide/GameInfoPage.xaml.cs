using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameInfoPage : ContentPage
    {
        public GameInfoPage(Game game)
        {
            InitializeComponent();
            gameName.Text = game.Name;
            gameImageUrl.Text = game.ImageUrl;
            gameAnotation.Text = game.Anotaion;
        }


        private void saveGameInfo(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Name = gameName.Text;
            game.ImageUrl = gameImageUrl.Text;
            game.Anotaion = gameAnotation.Text;
            App.Games.Add(game);
            Navigation.PushAsync(new MainPage());
        }
    }
}