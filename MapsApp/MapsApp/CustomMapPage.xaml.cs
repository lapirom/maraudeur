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

            var position1 = new Position(46.16959900000001, 1.8714519999999766);
            var position2 = new Position(46.28254500000001, 2.000344000000041);
            var position3 = new Position(46.2571185, 1.9708194);
            var position4 = new Position(46.7076989, 1.1459506);
            var position5 = new Position(46.2319694, 1.9766053);
            var position6 = new Position(46.0592497, 2.2834104);
            var position7 = new Position(46.0423787, 1.719308);
            var position8 = new Position(45.8450756, 2.2174647);
            var position9 = new Position(46.3370774, 2.1912582);
            var position10 = new Position(46.006615, 1.9169698);
            var position11 = new Position(45.813619, 1.7736720000000332);

            

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
                    Label = "Rien",
                    Address = ""
                },
                Url = ""
            };

            var customPin6 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position6,
                    Label = "Le vide",
                    Address = ""
                },
                Url = ""
            };

            var customPin7 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position7,
                    Label = "Nada",
                    Address = ""
                },
                Url = ""
            };

            var customPin8 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position8,
                    Label = "Niente",
                    Address = ""
                },
                Url = ""
            };

            var customPin9 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position9,
                    Label = "Que pouic",
                    Address = ""
                },
                Url = ""
            };

            var customPin10 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position10,
                    Label = "Le néant",
                    Address = ""
                },
                Url = ""
            };

            var customPin11 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position11,
                    Label = "Peyrat-le-Château",
                    Address = "Là, c'est plus la Creuse"
                },
                Url = ""
            };

            customMap.CustomPins = new List<CustomPin>
            {
                customPin1,
                customPin2,
                customPin3,
                customPin4,
                customPin5,
                customPin6,
                customPin7,
                customPin8,
                customPin9,
                customPin10,
                customPin11,
            };

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Position(46.0595947, 1.7117749), Distance.FromMiles(40)));

            Content = customMap;
        }
    }
}
