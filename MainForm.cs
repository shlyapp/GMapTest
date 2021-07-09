using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

using System.Xml;
using System.Net;

namespace GMapApp
{
    public partial class MainForm : Form
    {

        AppContext db;

        InfoForm infoForm;

        GMarkerGoogle[] markers = new GMarkerGoogle[6];
        List<PointLatLng> points = new List<PointLatLng>();

        GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMapOverlay routesOverlay = new GMapOverlay("routes");

        public MainForm()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            firstSetupGmap();
 

            GMapApp.DataPlace.loadData();
            //loadRoutes();
            loadMakers();
        }

        // настройка gmap при первом запуске
        private void firstSetupGmap()
        {
            gmap.Bearing = 0;
            gmap.CanDragMap = true;
            gmap.DragButton = MouseButtons.Left;

            gmap.GrayScaleMode = true;

            gmap.MarkersEnabled = true;
            gmap.MaxZoom = 17;
            gmap.MinZoom = 5;
            gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;

            gmap.NegativeMode = false;
            gmap.PolygonsEnabled = true;
            gmap.RoutesEnabled = true;
            gmap.ShowTileGridLines = false;
            gmap.ShowCenter = false;
            gmap.Zoom = 15;

            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.YandexHybridMap;  // или GoogleMaps         

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(56.3490700, 53.1243900);
        }

        private void loadRoutes()
        {
            string[] lines = System.IO.File.ReadAllLines("3.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] point = lines[i].Split(new char[] { ';' });
                points.Add(new PointLatLng(Convert.ToDouble(point[0]), Convert.ToDouble(point[1])));
            }

            routesOverlay.Routes.Add(makeRoute());
            gmap.Overlays.Add(routesOverlay);

        }

        // загрузка всех маркеров
        private void loadMakers()
        {

            for (int i = 0; i < GMapApp.DataPlace.markers.Count; i++)
            {
                markersOverlay.Markers.Add(GMapApp.DataPlace.markers[i]);
            }

            gmap.Overlays.Add(markersOverlay);
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Hide();
            // без понятия почему, но switch не работает
            if (item == markers[0]) { infoForm = new InfoForm(0); infoForm.ShowDialog(); }
            if (item == markers[1]) { infoForm = new InfoForm(1); infoForm.ShowDialog(); }
            if (item == markers[2]) { infoForm = new InfoForm(2); infoForm.ShowDialog(); }
            if (item == markers[3]) { infoForm = new InfoForm(3); infoForm.ShowDialog(); }
            if (item == markers[4]) { infoForm = new InfoForm(4); infoForm.ShowDialog(); }
            if (item == markers[5]) { infoForm = new InfoForm(5); infoForm.ShowDialog(); }
            Show();
        }

        private GMapRoute makeRoute()
        {
            GMapRoute route = new GMapRoute(points, "route");

            route.Stroke = new Pen(Color.Green, 4);

            routesOverlay.Routes.Add(route);
            gmap.Overlays.Add(routesOverlay);

            return route;

        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            //Place place = new Place("place", "toopltip", "description", "image", 123, 123);
            //db.Places.Add(place);

           //Route route = new Route("SquareToMuseum", "test");
            //db.Routes.Add(route);
            MessageBox.Show(GMapApp.DataPlace.routes[0].name);

            if (e.Button == MouseButtons.Right)
            {
                points.Add(gmap.FromLocalToLatLng(e.X, e.Y));
                makeRoute();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter str = new StreamWriter("5.txt");

            for (int i = 0; i < points.Count(); i++)
            {
                string coord = points[i].Lat.ToString() + ";" + points[i].Lng.ToString();
                str.WriteLine(coord);
            }

            //db.SaveChanges();
            str.Close();
        }

    }
}
