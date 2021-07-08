using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace GMapApp
{
    public partial class MainForm : Form
    {
        InfoForm infoForm;

        GMarkerGoogle[] markers = new GMarkerGoogle[6];
        GMapOverlay markersOverlay = new GMapOverlay("markers");

        public MainForm()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            firstSetupGmap();
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
            // без понятия почему, но switch не работает
            if (item == markers[0]) { infoForm = new InfoForm(0); infoForm.Show(); }
            if (item == markers[1]) { infoForm = new InfoForm(1); infoForm.Show(); }
            if (item == markers[2]) { infoForm = new InfoForm(2); infoForm.Show(); }
            if (item == markers[3]) { infoForm = new InfoForm(3); infoForm.Show(); }
            if (item == markers[4]) { infoForm = new InfoForm(4); infoForm.Show(); }
            if (item == markers[5]) { infoForm = new InfoForm(5); infoForm.Show(); }
        }
    }
}
