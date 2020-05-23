using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.ComponentModel;

namespace Guide
{
    public partial class App : Application
    {
        public static IList<Game> Games { get; private set; }


        public App()
        {
            InitializeComponent();
            InitialGameList();
            MainPage = new MainPage();
        }

        protected void InitialGameList()
        {
            Games = new List<Game>();
            Games.Add(new Game { Name = "Rome Total War", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/73/Romebox.jpg", Anotaion = "Once the Roman Empire is under your command, don't lay down your sword just yet - the Barbarians are coming. With two award-winning titles from the esteemed Total War series, you'll have twice as many obstacles and opportunities to control and conquer the greatest empire ever known to man. The Collection Edition includes: Rome: Total War Guide one of three noble Roman families on a century spanning quest to seize control of the Roman Empire." });
            Games.Add(new Game { Name = "Galactic Civilizations" , ImageUrl= "https://upload.wikimedia.org/wikipedia/en/2/2b/GalacticCivilizationsBox.jpg", Anotaion = "The games within the Galactic Civilization game group are turn-based strategy games in a sci-fi setting, where the player has to rule the universe. To archive this goal, the player colonizes, conquers or persuade planets to join his side. Each planet can produce structures, space ships, income and research points. With the research points the player discovers new technologies." });
            Games.Add(new Game { Name = "Tom Clancy: Division", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/03/The_Division_box.jpg", Anotaion = "Tom Clancy's The Division is an online-only action role-playing video game developed by Massive Entertainment and published in 2016 by Ubisoft, for Microsoft Windows, PlayStation 4 and Xbox One. It is set in a near future New York City in the aftermath of a viral pandemic; the player, a Special Agent of the Strategic Homeland Division, is tasked with helping the group rebuild its operations in Manhattan, investigate the nature of the outbreak, and combat criminal activity in its wake. The Division is structured with elements of role-playing games, as well as cooperative and player versus player online multiplayer." });
            Games.Add(new Game { Name = "Counter Strike", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/43/Counter-Strike_Source_%28box_art%29.jpg", Anotaion = "Counter-Strike (CS) is a series of multiplayer first-person shooter video games in which teams of terrorists battle to perpetrate an act of terror (bombing, hostage-taking, assassination) while counter-terrorists try to prevent it (bomb defusal, hostage rescue). " });
            Games.Add(new Game { Name = "Empire Earth", ImageUrl = "https://cdn4.amcn.in/a/gaimer.alle.bg/assets/e7f1fafc34ca-w417-c999999999-v7411718a24/il0uh0iycl.jpg", Anotaion = "Empire Earth is a series of real-time strategy video games developed by Stainless Steel Studios and Mad Doc Software, and published by Sierra Entertainment, Activision, and Vivendi. The games in the series are historical RTS games that are similar to Age of Empires." });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
