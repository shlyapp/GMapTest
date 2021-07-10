using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace GMapApp
{
    public class DataPlace
    {
        public static List<Place> places =  new List<Place>();
        public static List<Route> routes = new List<Route>();
        public static List<Test> tests = new List<Test>();

        public static void loadData()
        {
            AppContext db = new AppContext();

            places = db.Places.ToList();
            routes = db.Routes.ToList();
            tests = db.Tests.ToList();

            for (int i = 0; i < places.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(places[i].lat, places[i].lng), GMarkerGoogleType.red);
                marker.ToolTipText = places[i].tooltip;
                GMapApp.MainForm.markersOverlay.Markers.Add(marker);
            }

            char[] spliters = { '\n', ';' };

            for (int i = 0; i < routes.Count(); i++)
            {

                string[] pointsAsStr = routes[i].points.Split(spliters[0]);

                List<PointLatLng> points = new List<PointLatLng>();

                for (int j = 0; j < pointsAsStr.Length; j++)
                {
                    string[] point = pointsAsStr[j].Split(spliters[1]);

                    points.Add(new PointLatLng(Convert.ToDouble(point[0]), Convert.ToDouble(point[1])));
                }

                GMapRoute route = new GMapRoute(points, "route");
                route.IsVisible = false;
                GMapApp.MainForm.routesOverlay.Routes.Add(route);

            }
        }
    }
}
