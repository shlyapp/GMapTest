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
    public partial class Form1 : Form
    {

        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(56.3442, 53.124), GMarkerGoogleType.red);

        public Form1()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            // Первоначальная настройки при загрузке gMapControl

            gmap.Bearing = 0;
            gmap.CanDragMap = true;
            gmap.DragButton = MouseButtons.Right;

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

            // Работа с маркерами

            GMapOverlay markersOverlay = new GMapOverlay("markers");

            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);

            marker.ToolTipText = "Музей Кривоногова";

            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
        }

        private void gmap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                checkingMarkerClick(e);
            }
        }

        private Boolean checkingMarkerClick(MouseEventArgs e)
        {
            // допустимая погрешность (область вокруг маркера)
            double clickError = 0.0005;

            // уставливаем координаты границ области
            double leftBorder = Math.Round(marker.Position.Lat, 4) - clickError;
            double rightBorder = Math.Round(marker.Position.Lat, 4) + clickError;
            double upperBorder = Math.Round(marker.Position.Lng, 4) - clickError;
            double lowerBorder = Math.Round(marker.Position.Lng, 4) + clickError;

            // координаты мышки
            double x = Math.Round(gmap.FromLocalToLatLng(e.X, e.Y).Lat, 4);
            double y = Math.Round(gmap.FromLocalToLatLng(e.X, e.Y).Lng, 4);

            if ((leftBorder <= x && x <= rightBorder) && (upperBorder <= y && y <= lowerBorder))
            {
                MessageBox.Show("Попал!");
                return true;
            }

            return false;
        }
    }
}
