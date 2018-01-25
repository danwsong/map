using System;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Newtonsoft.Json.Linq;

namespace Westmount
{
    public class SearchEntry
    {
        public static SearchEntry[] SchoolData = {
            new SearchEntry {
                RoomNumber = "1053", OldRoomNumber = "88", RoomLocation = new Position(43.2262508742639, -79.8937338218093)
            },
            new SearchEntry {
                RoomNumber = "1056", OldRoomNumber = "90", RoomLocation = new Position(43.2263019330675, -79.8940094187856)
            },
            new SearchEntry {
                RoomNumber = "1057", OldRoomNumber = "92", RoomLocation = new Position(43.2263473729237, -79.8942394182086)
            },
            new SearchEntry {
                RoomNumber = "1051", OldRoomNumber = "91", RoomLocation = new Position(43.2264370310353, -79.8936335742474)
            },
            new SearchEntry {
                RoomNumber = "1049", OldRoomNumber = "93", RoomLocation = new Position(43.2264546206221, -79.8939299583435)
            },
            new SearchEntry {
                RoomNumber = "1048", OldRoomNumber = "95", RoomLocation = new Position(43.2265005489637, -79.8941871151328)
            },
            new SearchEntry {
                RoomNumber = "1059", OldRoomNumber = "94", RoomLocation = new Position(43.226407959346, -79.894428178668)
            },
            new SearchEntry {
                RoomNumber = "1060", OldRoomNumber = "96", RoomLocation = new Position(43.2264311678386, -79.8945512250066)
            },
            new SearchEntry {
                RoomNumber = "1061", OldRoomNumber = "98", RoomLocation = new Position(43.2264516890247, -79.8946622014046)
            },
            new SearchEntry {
                RoomNumber = "1062", OldRoomNumber = "100", RoomLocation = new Position(43.2264792948951, -79.8947932943702)
            },
            new SearchEntry {
                RoomNumber = "1042", OldRoomNumber = "97", RoomLocation = new Position(43.2265367052934, -79.8944979161024)
            },
            new SearchEntry {
                RoomNumber = "1040", OldRoomNumber = "99", RoomLocation = new Position(43.2265750602954, -79.8946994170547)
            },
            new SearchEntry {
                RoomNumber = "1064", OldRoomNumber = "102", RoomLocation = new Position(43.2265516075582, -79.8949498683214)
            },
            new SearchEntry {
                RoomNumber = "1065", OldRoomNumber = "104", RoomLocation = new Position(43.2266134152733, -79.8950350284576)
            },
            new SearchEntry {
                RoomNumber = "1066", OldRoomNumber = "106", RoomLocation = new Position(43.2266911023519, -79.8951436579227)
            },
            new SearchEntry {
                RoomNumber = "1067", OldRoomNumber = "108", RoomLocation = new Position(43.2267538871198, -79.8952110484242)
            },
            new SearchEntry {
                RoomNumber = "1068", OldRoomNumber = "110", RoomLocation = new Position(43.2267856459272, -79.8952727392316)
            },
            new SearchEntry {
                RoomNumber = "1069", OldRoomNumber = "112", RoomLocation = new Position(43.226823512176, -79.8953210189939)
            },
            new SearchEntry {
                RoomNumber = "1072", OldRoomNumber = "Cafeteria", RoomLocation = new Position(43.2268916713644, -79.895588234067)
            },
            new SearchEntry {
                RoomNumber = "1073", OldRoomNumber = "Auditorium", RoomLocation = new Position(43.2271389004693, -79.8958547785878)
            },
            new SearchEntry {
                RoomNumber = "1036", OldRoomNumber = "101", RoomLocation = new Position(43.2266551904128, -79.8948824778199)
            },
            new SearchEntry {
                RoomNumber = "1035", OldRoomNumber = "103", RoomLocation = new Position(43.2267174866202, -79.89496730268)
            },
            new SearchEntry {
                RoomNumber = "1034", OldRoomNumber = "105", RoomLocation = new Position(43.2267856459272, -79.8950618505478)
            },
            new SearchEntry {
                RoomNumber = "1033", OldRoomNumber = "107", RoomLocation = new Position(43.2268858082114, -79.8951996490359)
            },
            new SearchEntry {
                RoomNumber = "1028", OldRoomNumber = "109", RoomLocation = new Position(43.2270397157908, -79.8954081907868)
            },
            new SearchEntry {
                RoomNumber = "1015", OldRoomNumber = "111", RoomLocation = new Position(43.2274818925471, -79.8956526070833)
            },
            new SearchEntry {
                RoomNumber = "1009", OldRoomNumber = "Student Services", HiddenTag="Guidance", RoomLocation = new Position(43.2274535542435, -79.8960116878152)
            },
            new SearchEntry {
                RoomNumber = "1005", OldRoomNumber = "Main Office", RoomLocation = new Position(43.2273709822146, -79.8960653319955)
            },
            new SearchEntry {
                RoomNumber = "1017", OldRoomNumber = "Gym A", RoomLocation = new Position(43.2273927245644, -79.8955775052309)
            },
            new SearchEntry {
                RoomNumber = "1017", OldRoomNumber = "Gym B", RoomLocation = new Position(43.2272891429632, -79.8954286426306)
            },
            new SearchEntry {
                RoomNumber = "1019", OldRoomNumber = "Physical Literacy Playground", HiddenTag="PLP", RoomLocation = new Position(43.2274960616941, -79.8953166604042)
            },
            new SearchEntry {
                RoomNumber = "1001", OldRoomNumber = "Foyer", HiddenTag="Lobby", RoomLocation = new Position(43.2272082807889, -79.8959972709417)
            },
            new SearchEntry {
                RoomNumber = "1077", OldRoomNumber = "118", RoomLocation = new Position(43.2270553508247, -79.8960589617491)
            },
            new SearchEntry {
                RoomNumber = "1081", OldRoomNumber = "120", RoomLocation = new Position(43.2269080393302, -79.8962597921491)
            },
            new SearchEntry {
                RoomNumber = "1082", OldRoomNumber = "122", RoomLocation = new Position(43.2267976165503, -79.8964053019881)
            },
            new SearchEntry {
                RoomNumber = "1083", OldRoomNumber = "124", RoomLocation = new Position(43.2267375191126, -79.8964941501617)
            },
            new SearchEntry {
                RoomNumber = "1089", OldRoomNumber = "117", RoomLocation = new Position(43.2271474508651, -79.8961075767875)
            },
            new SearchEntry {
                RoomNumber = "1089", OldRoomNumber = "119", RoomLocation = new Position(43.2270968813641, -79.896204136312)
            },
            new SearchEntry {
                RoomNumber = "1088", OldRoomNumber = "121", RoomLocation = new Position(43.2270265237277, -79.8963020369411)
            },
            new SearchEntry {
                RoomNumber = "1087", OldRoomNumber = "123", RoomLocation = new Position(43.2269515243523, -79.8964039608836)
            },
            new SearchEntry {
                RoomNumber = "1085", OldRoomNumber = "125", RoomLocation = new Position(43.226840857353, -79.8965568467975)
            },
            new SearchEntry {
                RoomNumber = "2039", OldRoomNumber = "202", RoomLocation = new Position(43.2265533176539, -79.8949522152543)
            },
            new SearchEntry {
                RoomNumber = "2040", OldRoomNumber = "204", RoomLocation = new Position(43.2266126823758, -79.8950346931815)
            },
            new SearchEntry {
                RoomNumber = "2041", OldRoomNumber = "206", RoomLocation = new Position(43.2266874378693, -79.8951352760196)
            },
            new SearchEntry {
                RoomNumber = "2043", OldRoomNumber = "208", RoomLocation = new Position(43.2267868674195, -79.8952727392316)
            },
            new SearchEntry {
                RoomNumber = "2044", OldRoomNumber = "210", RoomLocation = new Position(43.2268628441901, -79.8953793570399)
            },
            new SearchEntry {
                RoomNumber = "2046", OldRoomNumber = "212", RoomLocation = new Position(43.2269625177519, -79.8955057561398)
            },
            new SearchEntry {
                RoomNumber = "2037", OldRoomNumber = "201", RoomLocation = new Position(43.2266571448045, -79.8948811367154)
            },
            new SearchEntry {
                RoomNumber = "2036", OldRoomNumber = "203", RoomLocation = new Position(43.2267187081138, -79.894964620471)
            },
            new SearchEntry {
                RoomNumber = "2035", OldRoomNumber = "205", RoomLocation = new Position(43.2267858902257, -79.8950558155775)
            },
            new SearchEntry {
                RoomNumber = "2033", OldRoomNumber = "207", RoomLocation = new Position(43.2268850753172, -79.8951922729611)
            },
            new SearchEntry {
                RoomNumber = "2028", OldRoomNumber = "209", RoomLocation = new Position(43.2270299438925, -79.8953934386373)
            },
            new SearchEntry {
                RoomNumber = "2027", OldRoomNumber = "211", RoomLocation = new Position(43.2270929726086, -79.8954816162586)
            },
            new SearchEntry {
                RoomNumber = "2023", OldRoomNumber = "213", RoomLocation = new Position(43.2271933786847, -79.89561740309)
            },
            new SearchEntry {
                RoomNumber = "2022", OldRoomNumber = "215", RoomLocation = new Position(43.2272730193962, -79.8957253620029)
            },
            new SearchEntry {
                RoomNumber = "2019", OldRoomNumber = "Learning Commons", HiddenTag="LC", RoomLocation = new Position(43.2274064051401, -79.8960200697184)
            },
            new SearchEntry {
                RoomNumber = "2049", OldRoomNumber = "Upper Auditorium Seating", RoomLocation = new Position(43.2271618643867, -79.8958903178573)
            },
            new SearchEntry {
                RoomNumber = "2002", OldRoomNumber = "226", RoomLocation = new Position(43.2270543736352, -79.8960599675775)
            },
            new SearchEntry {
                RoomNumber = "2007", OldRoomNumber = "228", RoomLocation = new Position(43.2269226972063, -79.8962406814098)
            },
            new SearchEntry {
                RoomNumber = "2008", OldRoomNumber = "230", RoomLocation = new Position(43.2268520950707, -79.8963385820389)
            },
            new SearchEntry {
                RoomNumber = "2009", OldRoomNumber = "232", RoomLocation = new Position(43.2267519327311, -79.8964730277658)
            },
            new SearchEntry {
                RoomNumber = "2018", OldRoomNumber = "223", RoomLocation = new Position(43.2272187855487, -79.8960371688008)
            },
            new SearchEntry {
                RoomNumber = "2016", OldRoomNumber = "225", RoomLocation = new Position(43.2271486723501, -79.8961370810866)
            },
            new SearchEntry {
                RoomNumber = "2015", OldRoomNumber = "227", RoomLocation = new Position(43.2270924840142, -79.8962131887674)
            },
            new SearchEntry {
                RoomNumber = "2014", OldRoomNumber = "229", RoomLocation = new Position(43.2270270123227, -79.8963040485978)
            },
            new SearchEntry {
                RoomNumber = "2013", OldRoomNumber = "231", RoomLocation = new Position(43.2269603190721, -79.8963952437043)
            },
            new SearchEntry {
                RoomNumber = "2012", OldRoomNumber = "233", RoomLocation = new Position(43.2268980231129, -79.8964783921838)
            },
            new SearchEntry {
                RoomNumber = "2011", OldRoomNumber = "235", RoomLocation = new Position(43.2268357270899, -79.8965628817678)
            },
        };
        public string RoomNumber { get; private set; }
        public string OldRoomNumber { get; private set; }
        public string HiddenTag { get; private set; }
        public string Teacher { get; set; }
        public Position RoomLocation { get; private set; }
    }

    public partial class WestmountPage : ContentPage
    {
        public static bool firstLevel = true;
        public static string[,] TeacherData;

        public WestmountPage()
        {
            InitializeComponent();
            InitializeMap();
        }

        void GetTeacherData()
        {
            if (TimeToPeriod() == -1)
                return;
            var request = new HttpClient().GetStringAsync("https://spreadsheets.google.com/tq?key=11Q576A8RFjEJ6XPs6NCPyJkG21xSB3ovcesO44i80oI").Result;
            request = request.Substring(request.IndexOf('(') + 1, request.Length - request.IndexOf('(') - 3);
            var table = JObject.Parse(request)["table"];
            TeacherData = new string[table["rows"].Count(), table["cols"].Count()];
            for (int i = 0; i < TeacherData.GetLength(0); i++)
                for (int j = 0; j < TeacherData.GetLength(1); j++)
                    TeacherData[i, j] = table["rows"][i]["c"][j].HasValues ? ((string)table["rows"][i]["c"][j]["v"] == null ? "" : (string)table["rows"][i]["c"][j]["v"]) : "";
            foreach (var entry in SearchEntry.SchoolData)
                entry.Teacher = null;
            for (int i = 2; TeacherData[i, 0] != ""; i++)
            {
                var teacher = TeacherData[i, 0].Split(',')[0];
                teacher = teacher[0].ToString().ToUpper() + teacher.Substring(1).ToLower();
                var room = TeacherData[i, TimeToPeriod()].Split('(').First().Trim().Split('/').First();
                for (int entry = 0; entry < SearchEntry.SchoolData.Count(); entry++)
                    if (room != "" && (SearchEntry.SchoolData[entry].RoomNumber == room || SearchEntry.SchoolData[entry].OldRoomNumber.ToUpper().StartsWith(room, StringComparison.CurrentCulture)))
                    {
                        if (SearchEntry.SchoolData[entry].Teacher == null)
                            SearchEntry.SchoolData[entry].Teacher = teacher;
                        else
                            SearchEntry.SchoolData[entry].Teacher += ", " + teacher;
                    }
            }
        }

        int TimeToPeriod()
        {
            var currentTime = DateTime.Now;
            if ((currentTime.Hour == 8 && currentTime.Minute >= 35) || (currentTime.Hour == 9 && currentTime.Minute < 55))
                return 1;
            if ((currentTime.Hour == 9 && currentTime.Minute >= 55) || (currentTime.Hour == 10) || (currentTime.Hour == 11 && currentTime.Minute < 18))
                return 2;
            if ((currentTime.Hour == 11 && currentTime.Minute >= 18) || (currentTime.Hour == 12 && currentTime.Minute < 38))
                return 3;
            if ((currentTime.Hour == 12 && currentTime.Minute >= 38) || (currentTime.Hour == 1 && currentTime.Minute < 55))
                return 4;
            if ((currentTime.Hour == 1 && currentTime.Minute >= 55) || (currentTime.Hour == 2) || (currentTime.Hour == 3 && currentTime.Minute < 15))
                return 5;
            return -1;
        }

        void InitializeMap()
        {
            Map.CameraMoving += Map_CameraMoving;
            Map.MapClicked += Map_MapClicked;
            Map.GroundOverlays.Add(new GroundOverlay
            {
                Bounds = new Bounds(new Position(43.226109, -79.896682), new Position(43.227717, -79.893367)),
                Icon = BitmapDescriptorFactory.FromBundle("Level1.png"),
                ZIndex = 2
            });
            Map.MapType = MapType.None;
            var background = new Polygon { FillColor = Color.White, StrokeWidth = 0.0f, ZIndex = 1 };
            background.Positions.Add(new Position(44, -79));
            background.Positions.Add(new Position(44, -80));
            background.Positions.Add(new Position(43, -80));
            background.Positions.Add(new Position(43, -79));
            Map.Polygons.Add(background);
            Map.UiSettings.CompassEnabled = false;
            Map.UiSettings.ZoomControlsEnabled = false;
            SearchResults.BackgroundColor = new Color(0.2, 0.2, 0.2, 0.5);
        }

        void Map_MapClicked(object sender, MapClickedEventArgs e)
        {
            if (Map.Pins.Count > 0)
                Map.Pins.RemoveAt(0);
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!BaseLayout.Children.Contains(SearchResults))
                BaseLayout.Children.Add(SearchResults, null, Constraint.Constant(Search.Height), null, Constraint.RelativeToParent(layout => layout.Height - Search.Height));
            var queryText = e.NewTextValue;
            if (queryText == "" || queryText == null)
            {
                SearchResults.FadeTo(0.0, 100);
                SearchResults.IsVisible = false;
                SearchResults.ItemsSource = new SearchEntry[] { };
                return;
            }
            if ((int)SearchResults.Opacity == 0)
                GetTeacherData();
            var filtered = SearchEntry.SchoolData.Where(c =>
            {
                if (c.OldRoomNumber != null)
                    foreach (var word in c.OldRoomNumber.Split(' '))
                        if (word.ToUpper().StartsWith(queryText.ToUpper(), StringComparison.CurrentCulture))
                            return true;
                if (c.HiddenTag != null)
                    foreach (var word in c.HiddenTag.Split(' '))
                        if (word.ToUpper().StartsWith(queryText.ToUpper(), StringComparison.CurrentCulture))
                            return true;
                if (c.Teacher != null)
                    foreach (var word in c.Teacher.Split(new string[] { ", " }, StringSplitOptions.None))
                        if (word.ToUpper().StartsWith(queryText.ToUpper(), StringComparison.CurrentCulture))
                            return true;
                if (c.RoomNumber != null && c.RoomNumber.ToUpper().StartsWith(queryText.ToUpper(), StringComparison.CurrentCulture))
                    return true;
                return false;
            }).ToList();
            filtered.Sort((x, y) => string.Compare(x.RoomNumber, y.RoomNumber, StringComparison.CurrentCulture));
            SearchResults.ItemsSource = filtered;
            SearchResults.FadeTo(1.0, 100);
            SearchResults.IsVisible = true;
        }

        void RoomSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            if (Map.Pins.Count == 0)
                Map.Pins.Add(new Pin { Position = ((SearchEntry)e.SelectedItem).RoomLocation, Label = "" });
            else
                Map.Pins[0].Position = ((SearchEntry)e.SelectedItem).RoomLocation;
            if ((firstLevel ? 1 : 2).ToString() != ((SearchEntry)e.SelectedItem).RoomNumber[0].ToString())
            {
                firstLevel = !firstLevel;
                Map.GroundOverlays[0].Icon = BitmapDescriptorFactory.FromBundle(firstLevel ? "Level1.png" : "Level2.png");
                MapLevelButton.Source = (FileImageSource)ImageSource.FromFile(firstLevel ? "Up.png" : "Down.png");
            }
            Map.AnimateCamera(CameraUpdateFactory.NewCameraPosition(new CameraPosition(((SearchEntry)e.SelectedItem).RoomLocation, 20, 45)), TimeSpan.FromSeconds(Math.Max(10 * Distance(((SearchEntry)e.SelectedItem).RoomLocation, Map.CameraPosition.Target), 0.001)));
            Search.Text = "";
            Search.Unfocus();
            SearchResults.SelectedItem = null;
        }

        public static double Distance(Position pos1, Position pos2)
        {
            var lat1 = pos1.Latitude / 180 * Math.PI;
            var lat2 = pos2.Latitude / 180 * Math.PI;
            var deltaLat = (pos2.Latitude - pos1.Latitude) / 180 * Math.PI;
            var deltaLong = (pos2.Longitude - pos1.Longitude) / 180 * Math.PI;
            var adjacent = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Sin(deltaLong / 2) * Math.Sin(deltaLong / 2);
            var distance = 6371 * 2 * Math.Atan2(Math.Sqrt(adjacent), Math.Sqrt(1 - adjacent));
            return distance;
        }

        void Map_CameraMoving(object sender, CameraMovingEventArgs e)
        {
            bool updateA = false, updateB = false;
            var zoom = e.Position.Zoom;
            if (e.Position.Zoom < 17.5)
            {
                zoom = 17.5;
                updateA = true;
            }
            var position = e.Position.Target;
            if (Distance(new Position(43.226743, -79.895084), e.Position.Target) > 0.15)
            {
                position = new Position(43.226743, -79.895084);
                updateB = true;
            }
            if (updateA)
                Map.MoveCamera(CameraUpdateFactory.NewCameraPosition(new CameraPosition(Map.CameraPosition.Target, zoom, e.Position.Bearing, e.Position.Tilt)));
            if (updateB)
                Map.AnimateCamera(CameraUpdateFactory.NewCameraPosition(new CameraPosition(position, Map.CameraPosition.Zoom, e.Position.Bearing, e.Position.Tilt)), TimeSpan.FromMilliseconds(250));
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            if (Map.Pins.Count > 0)
                Map.Pins.RemoveAt(0);
            firstLevel = !firstLevel;
            Map.GroundOverlays[0].Icon = BitmapDescriptorFactory.FromBundle(firstLevel ? "Level1.png" : "Level2.png");
            MapLevelButton.Source = (FileImageSource)ImageSource.FromFile(firstLevel ? "Up.png" : "Down.png");
        }
    }
}
