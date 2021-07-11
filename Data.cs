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
    // класс для работы с данными из базы данных
    public class DataPlace
    {
        // список мест
        public static List<Place> places =  new List<Place>();
        // список маршрутов
        public static List<Route> routes = new List<Route>();
        // список тестов
        public static List<Test> tests = new List<Test>();
        // пользователь
        public static User user;

        // для взаимодействия с БД
        private static AppContext db;

        public static void loadData()
        {
            db = new AppContext();

            // загружаем полнотсью таблицу
            places = db.Places.ToList();
            routes = db.Routes.ToList();
            tests = db.Tests.ToList();

            // у нас только один юзер
            user = db.Users.ToArray()[0];

            // создаем маркеры на карте исходя из координат мест
            for (int i = 0; i < places.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(places[i].lat, places[i].lng), GMarkerGoogleType.red);
                marker.ToolTipText = places[i].tooltip;
                GMapApp.MainForm.markersOverlay.Markers.Add(marker);
            }

            // разделители для парсере из строки в списко точек
            char[] spliters = { '\n', ';' };

            for (int i = 0; i < routes.Count(); i++)
            {
                // парсим в массив координат
                string[] pointsAsStr = routes[i].points.Split(spliters[0]);

                List<PointLatLng> points = new List<PointLatLng>();

                for (int j = 0; j < pointsAsStr.Length; j++)
                {
                    // получаем координаты каждой точки
                    string[] point = pointsAsStr[j].Split(spliters[1]);

                    //добавляем в лист точек
                    points.Add(new PointLatLng(Convert.ToDouble(point[0]), Convert.ToDouble(point[1])));
                }

                // создаем маршрут из добавленных точек
                GMapRoute route = new GMapRoute(points, "route");
                route.Stroke = new System.Drawing.Pen(System.Drawing.Color.Green, 4);
                //изначально все маршруты не видимые
                route.IsVisible = false;
                GMapApp.MainForm.routesOverlay.Routes.Add(route);

            }
        }

        // сохраняем изменения в базе данных
        public static void saveData()
        {
            db.SaveChanges();
        }
    }
}
