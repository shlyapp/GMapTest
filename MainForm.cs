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

        public static GMapOverlay markersOverlay = new GMapOverlay("markers");
        public static GMapOverlay routesOverlay = new GMapOverlay("routes");

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
            //loadMakers();
            gmap.Overlays.Add(markersOverlay);
            gmap.Overlays.Add(routesOverlay);
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


        // загрузка всех маркеров
        private void loadMakers()
        {

            
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

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            //Place place = new Place("place", "toopltip", "description", "image", 123, 123);
            //db.Places.Add(place);

           //Route route = new Route("SquareToMuseum", "test");
            //db.Routes.Add(route);
            MessageBox.Show(GMapApp.DataPlace.routes[1].points);
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
