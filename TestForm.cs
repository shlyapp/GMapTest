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
    public partial class TestForm : Form
    {
        // номер вопроса
        int num = 0;
        // идентификатор места
        int id = 0;

        public TestForm(int id)
        {
            InitializeComponent();

            this.id = id;

            answerText.TextAlign = HorizontalAlignment.Center;
            
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // при загрузке формы появляется необходимый текст вопроса
            question.Text = GMapApp.DataPlace.tests[num].question;
        }

        // обработчик события надатия кнопки "Проверить"
        private void checkBtn_Click(object sender, EventArgs e)
        {
            // проверяем на правильность
            if (answerText.Text.Trim() == GMapApp.DataPlace.tests[num].answer)
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверный ответ.");
            }

            // очищаем поле ввода
            answerText.Clear();
            // инкрементируем номер вопроса
            num++;

            // проверяем на наличия след.вопроса
            if (num >= GMapApp.DataPlace.tests.Count)
            {
                MessageBox.Show("Поздравляем с прохождением теста.\nВам открылся новый маршрут!");

                if (GMapApp.DataPlace.user.unlockPlace.IndexOf(id.ToString()) == -1)
                {
                    GMapApp.DataPlace.user.addUnlockPlace(id);
                }

                Close();
            }
            else
            {
                question.Text = GMapApp.DataPlace.tests[num].question;
            }
        }
    }
}
