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
        InfoForm infoForm;

        GMarkerGoogle[] markers = new GMarkerGoogle[6];
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMapOverlay routesOverlay = new GMapOverlay("routes");

        public MainForm()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            firstSetupGmap();
            loadMakers();

            //makeRoute(markers[5].Position, markers[4].Position);

            makeRoute();
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

            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;  // или GoogleMaps         

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(56.3490700, 53.1243900);
        }

        // загрузка всех маркеров
        private void loadMakers()
        {
            PointLatLng[] coords = new PointLatLng[6]
            {
                new PointLatLng(56.34362607288647, 53.124973176563806),
                new PointLatLng(56.34507985118993, 53.1246026136887),
                new PointLatLng(56.344925259810594, 53.125269412994385),
                new PointLatLng(56.34594547389484, 53.12523730645809),
                new PointLatLng(56.34683348667316, 53.12585809611392),
                new PointLatLng(56.35142687398434, 53.12557439423018)
            };

            String[] toolTipText = new String[6]
           {
                "Сквер имени П.А. Кривоногова,\nпамятник П.А. Кривоногову",
                "МБУ 'Киясовский районный музей\nКривоногова Петра Александровича'",
                "Бюст Героя Советского Союза В.Г. Шамшурина\nи памятник труженикам тыла и детям войны",
                "Памятник землякам, погибшим в локальных войнах",
                "Мемориал памяти землякам, павшим\nв годы Великой Отечественной войны 1941-1945 гг",
                "Бюст Героя Советского Союза В.Г. Шамшурина"
           };

            for (int i = 0; i < 6; i++)
            {
                markers[i] = new GMarkerGoogle(coords[i], GMarkerGoogleType.red);
                markers[i].ToolTipText = toolTipText[i];

                markersOverlay.Markers.Add(markers[i]);
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

       

        //private void makeRoute(PointLatLng start, PointLatLng end)
        //{
        //    MapRoute mapRoute = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, true, true, 15);

        //    GMapRoute r = new GMapRoute(mapRoute.Points, "My route");
        //    routesOverlay.Routes.Add(r);
        //    gmap.Overlays.Add(routesOverlay);
        //}

        //private void makeRoute()
        //{
        //    string r = "https://maps.googleapis.com/maps/api/directions/xml?origin={0},&destination={1}&sensor=false&language=ru&mode={2}&key=AIzaSyChRMj9oB1FKt7SYs-KY-PjmoJpUQL0Nck";

        //    string url = string.Format(r,
        //        Uri.EscapeDataString("Киясово, улица Шамшурина, 32"),
        //        Uri.EscapeDataString("Киясово, улица Шамушрина, 40"),
        //        Uri.EscapeDataString("driving"));

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    WebResponse response = request.GetResponse();

        //    Stream dataStream = response.GetResponseStream();
        //    StreamReader sreader = new StreamReader(dataStream);
        //    string responsereader = sreader.ReadToEnd();
        //    response.Close();

        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.LoadXml(responsereader);
        //    if (xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
        //    {
        //        XmlNodeList nodes = xmlDoc.SelectNodes("//leg//ster");

        //        double latStart = XmlConvert.ToDouble(xmlDoc.GetElementsByTagName("start_location")[nodes.Count].ChildNodes[0].InnerText);
        //        double lngStart = XmlConvert.ToDouble(xmlDoc.GetElementsByTagName("start_location")[nodes.Count].ChildNodes[1].InnerText);

        //        double lngEnd = XmlConvert.ToDouble(xmlDoc.GetElementsByTagName("end_location")[nodes.Count].ChildNodes[0].InnerText);
        //        double latEnd = XmlConvert.ToDouble(xmlDoc.GetElementsByTagName("end_location")[nodes.Count].ChildNodes[1].InnerText);

        //        gmap.Overlays.Add(routesOverlay);

        //    }
        //}

        private void makeRoute()
        {
            List<PointLatLng> points = new List<PointLatLng>();

            points.Add(new PointLatLng(56.34683348667316, 53.12585809611392));
            points.Add(new PointLatLng(56.35142687398434, 53.12557439423018));

            GMapRoute route = new GMapRoute(points, "road");

            route.Stroke = new Pen(Color.Red, 3);

            routesOverlay.Routes.Add(route);
            gmap.Overlays.Add(routesOverlay);

        }
    }
}
