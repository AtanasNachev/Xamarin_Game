using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Guide
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<Game> Games { get; private set; }


        public MainPage()
        {
            InitializeComponent();

            Games = App.Games;

            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Game selectedItem = e.SelectedItem as Game;
            // App.Navigation.PushAsync(new MainPage());


            NavigationPage nav = new NavigationPage(new GamePage(selectedItem) { Title = "Game Information" });
            Application.Current.MainPage = nav;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Game tappedItem = e.Item as Game;
        }


        private void addNewGame(object sender, EventArgs e)
        {
            NavigationPage nav = new NavigationPage(new GameInfoPage(new Game()) { Title = "Add new Game" });
            Application.Current.MainPage = nav;
        }
    }
}
