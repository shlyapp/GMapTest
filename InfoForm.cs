using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GMapApp
{
    public partial class InfoForm : Form
    {
        int id;

        public InfoForm(int id)
        {
            InitializeComponent();

            this.id = id;

            Bitmap image = new Bitmap(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + GMapApp.DataPlace.places[id].image);
            imagePlace.Image = image;
            imagePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            labelText.Text = GMapApp.DataPlace.places[id].name;
            labelText.Enabled = false;

            mainText.Text = GMapApp.DataPlace.places[id].description;
            mainText.Enabled = false;

        }

        private void routeBtn_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                MessageBox.Show("Нет маршрута.");
            }
            else
            {
                foreach (GMap.NET.WindowsForms.GMapRoute route in GMapApp.MainForm.routesOverlay.Routes) { route.IsVisible = false; }
                GMapApp.MainForm.routesOverlay.Routes[id].IsVisible = true;
                Close();
            }
            
        }
    }
}
