using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsApp
{
    public partial class CustomMapPage : ContentPage
    {
        public CustomMapPage()
        {
            InitializeComponent();

            var customMap = new CustomMap
            {
                MapType = MapType.Hybrid,
            };

            var position1 = new Position(46.0767305, 1.7561168);
            var position2 = new Position(46.2469143, 1.9691859);
            var position3 = new Position(46.2571185, 1.9708194);
            var position4 = new Position(46.7076989, 1.1459506);
            var position5 = new Position(36.891, 10.185);
            var position6 = new Position(36.892, 10.187);

            var customPin1 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Guéret",
                    Address = "La seule ville habitée ?"
                },
                Url = "",
            };


            var customPin2 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position2,
                    Label = "Roches",
                    Address = "Donc, il y a des cailloux en Creuse..."
                },
                Url = ""
            };

            var customPin3 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position3,
                    Label = "Une vache parmis d'autres",
                    Address = "Eh oui, il y a bien plus de vaches que d'habitants en Creuse."
                },
                Url = ""
            };

            var customPin4 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position4,
                    Label = "Chez Michel",
                    Address = "Il parrait qu'il a du Wifi !"
                },
                Url = ""
            };

            var customPin5 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position5,
                    Label = "Via Mobile",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.kromberg-schubert.com"
            };

            var customPin6 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position6,
                    Label = "Via Mobile",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.kromberg-schubert.com"
            };

            customMap.CustomPins = new List<CustomPin>
            {
                customPin1,
                customPin2,
                customPin3,
                customPin4,
                customPin5,
                customPin6,
            };

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Position(46.0595947, 1.7117749), Distance.FromMiles(10)));

            Content = customMap;
        }
    }
}
