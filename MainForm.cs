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

        // слои с маркерами и маршрутом
        public static GMapOverlay markersOverlay = new GMapOverlay("markers");
        public static GMapOverlay routesOverlay = new GMapOverlay("routes");

        public MainForm()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            firstSetupGmap();
            
            // загружаем данные из БД
            GMapApp.DataPlace.loadData();

            gmap.Overlays.Add(markersOverlay);
            gmap.Overlays.Add(routesOverlay);

            // приветственный текст
            welcomText.Text = "Здравствуйте! Команда проекта приветствует Вас в нашем приложении. Если Вы готовы узнать больше об истории Киясовского района и его жителях, выберите маршрут и способ передвижения. С наилучшими пожеланиями, ученики 11 класса МБОУ «Киясовская СОШ» Екатерина Шутова, Даниил Костенков, Виктория Бузанова, Виктория Замилова.";

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

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Hide();

            #region Проверка на совпадение
            if (item == markersOverlay.Markers[0]) { infoForm = new InfoForm(0); infoForm.ShowDialog(); }
            if (item == markersOverlay.Markers[1]) { infoForm = new InfoForm(1); infoForm.ShowDialog(); }
            if (item == markersOverlay.Markers[2]) { infoForm = new InfoForm(2); infoForm.ShowDialog(); }
            if (item == markersOverlay.Markers[3]) { infoForm = new InfoForm(3); infoForm.ShowDialog(); }
            if (item == markersOverlay.Markers[4]) { infoForm = new InfoForm(4); infoForm.ShowDialog(); }
            if (item == markersOverlay.Markers[5]) { infoForm = new InfoForm(5); infoForm.ShowDialog(); }
            #endregion

            Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GMapApp.DataPlace.saveData();
        }
    }
}
