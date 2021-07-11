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

            // идентификатор номера места
            this.id = id; 
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // подгружаем изображение (формат {текущее местоположение + папка Image})
            Bitmap image = new Bitmap(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + GMapApp.DataPlace.places[id].image);
            imagePlace.Image = image;
            imagePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            // название 
            labelText.Text = GMapApp.DataPlace.places[id].name;
            labelText.Enabled = false;

            // описание
            mainText.Text = GMapApp.DataPlace.places[id].description;
            mainText.Enabled = false;
        }

        private void routeBtn_Click(object sender, EventArgs e)
        {
            // проверяем, открыт ли данные маршрут пользователю
            if (GMapApp.DataPlace.user.unlockPlace.IndexOf(id.ToString()) != -1)
            {
                // если да, то пытаемся его построить, иначе данного маршрута вообще не сущаествует
                try
                {
                    // скрываем все маршруты
                    foreach (GMap.NET.WindowsForms.GMapRoute route in GMapApp.MainForm.routesOverlay.Routes) { route.IsVisible = false; }
                    // выводим только нужный
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

        // обрабочик события нажатия кнопки "Перейти к тесту"
        private void testBtn_Click(object sender, EventArgs e)
        {
            // скрываем текущую форму с информацией
            Hide();
            // показываем форму с тестом
            testForm = new TestForm(id);
            testForm.ShowDialog();
            // закрываем после прохождения теста
            Close();
        }

    }
}
