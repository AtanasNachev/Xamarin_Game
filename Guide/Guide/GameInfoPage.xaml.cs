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
        private Game _game;
        public GameInfoPage(Game game)
        {
            InitializeComponent();
            _game = game;
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
            App.Games.Remove(_game);
            NavigationPage nav = new NavigationPage(new MainPage() { Title = "Games" });
            Application.Current.MainPage = nav;
        }


        private void cancel(object sender, EventArgs e)
        {
            NavigationPage nav = new NavigationPage(new MainPage() { Title = "Games" });
            Application.Current.MainPage = nav;
        }
    }
}