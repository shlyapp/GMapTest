﻿using System;
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

        int num = 0;
        int id = 0;

        public TestForm(int id)
        {
            InitializeComponent();

            this.id = id;

            answerText.TextAlign = HorizontalAlignment.Center;
            
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            question.Text = GMapApp.DataPlace.tests[num].question;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (answerText.Text == GMapApp.DataPlace.tests[num].answer)
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Неверный ответ.");
            }

            answerText.Clear();
            num++;

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
