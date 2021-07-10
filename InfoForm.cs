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
        TestForm testForm;

        public InfoForm(int id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

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

            if (GMapApp.DataPlace.user.unlockPlace.IndexOf(id.ToString()) != -1)
            {
                try
                {
                    foreach (GMap.NET.WindowsForms.GMapRoute route in GMapApp.MainForm.routesOverlay.Routes) { route.IsVisible = false; }
                    GMapApp.MainForm.routesOverlay.Routes[id].IsVisible = true;
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Нет маршрута.");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Данный маршрут еще не открыт.\nВам стоит изучить предыдущие места.");
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Hide();
            testForm = new TestForm(id);
            testForm.ShowDialog();
            Close();
        }

    }
}
