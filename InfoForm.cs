using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GMapApp
{
    public partial class InfoForm : Form
    {
        public InfoForm(int id)
        {
            InitializeComponent();

            Bitmap image = new Bitmap(filename: GMapApp.DataPlace.photoPaths[id]);
            imagePlace.Image = image;
            imagePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }
    }
}
