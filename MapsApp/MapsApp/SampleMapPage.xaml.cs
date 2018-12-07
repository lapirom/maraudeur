using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsApp
{
    public partial class SampleMapPage : ContentPage
    {
        public SampleMapPage()
        {
            InitializeComponent();

            var map = new CustomMap
            {
                MapType = MapType.Hybrid,
            };

            var position1 = new Position(44.808269, -0.597815);
            var position2 = new Position(44.8078163, -0.599699);
            var position3 = new Position(44.8022459, -0.6007585);
            var position4 = new Position(44.8070398, -0.5981969);
            var position5 = new Position(44.8095412, -0.592582);
            var position6 = new Position(44.8070182, -0.5958829);

            var customPin1 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Parking, CREMI",
                    Address = "Si vous avez perdu votre voiture... pour vous enfuire !"
                },
                Url = "",
            };


            var customPin2 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position2,
                    Label = "Sys Admin (2ème étage)",
                    Address = "Un Blue Screen ?"
                },
                Url = ""
            };

            var customPin3 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position3,
                    Label = "Espace santé étudiants",
                    Address = "Une tendinite à l'index droit ?"
                },
                Url = ""
            };

            var customPin4 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position4,
                    Label = "Kebab le plus proche",
                    Address = "Le manger pas cher le plus proche."
                },
                Url = ""
            };

            var customPin5 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position5,
                    Label = "2ème Kebab le plus proche",
                    Address = "2 vaut mieux qu'un"
                },
                Url = ""
            };

            var customPin6 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position6,
                    Label = "Le Jardin des Fleurs",
                    Address = "Qui a dit que les informaticiens n'aimaient pas les fleurs ?!"
                },
                Url = ""
            };

            map.CustomPins = new List<CustomPin>
            {
                customPin1,
                customPin2,
                customPin3,
                customPin4,
                customPin5,
                customPin6,
            };

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Position(44.807831, -0.597515), Distance.FromMiles(0.5)));

            Content = map;
        }
    }
}
