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
    public partial class GamePage : ContentPage
    {
        private Game _game;
        public GamePage(Game game)
        {
            InitializeComponent();
            _game = game;
            GameNameLabel.Text = game.Name;
            GameImageUrl.Source = game.ImageUrl;
            GameAnotation.Text = game.Anotaion;
        }

        private void RemoveGame(object sender, EventArgs e)
        {
            App.Games.Remove(_game);
            Navigation.PushAsync(new MainPage());
        }


        private void updateGameInfo(object sender, EventArgs e)
        {
            App.Games.Remove(_game);
            Navigation.PushAsync(new GameInfoPage(_game));
        }
    }
}