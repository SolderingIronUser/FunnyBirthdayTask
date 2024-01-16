using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbClients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ScrollBar.Value = LayoutPanel.VerticalScroll.Value;
            ScrollBar.Maximum = LayoutPanel.VerticalScroll.Maximum;
            ScrollBar.Minimum = LayoutPanel.VerticalScroll.Minimum;

            LayoutPanel.ControlAdded += LayoutPanel_ControlAdded;
            LayoutPanel.ControlRemoved += LayoutPanel_ControlRemoved;
        }

        private void LayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ScrollBar.Minimum = LayoutPanel.VerticalScroll.Minimum;
        }

        private void LayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ScrollBar.Maximum = LayoutPanel.VerticalScroll.Maximum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            LayoutPanel.Controls.Clear();
        }


        private void WindowClients (string nameClient, string phoneClient, string mailClient, string descriptionClient) {



            GroupBox contain = new GroupBox();
            contain.Size = new Size(1094, 296);
            contain.Text = "";
            contain.BackColor = Color.Linen;
            

            PictureBox photo = new PictureBox();
            photo.Location = new Point (6, 15);
            photo.Size = new Size(160, 160);
            photo.BackColor = Color.Cyan;

            Label name = new Label();
            name.Location = new Point(189, 16);
            name.Text = nameClient;
            name.Font = new Font("Tahoma", 15, FontStyle.Bold);
            name.MaximumSize = new Size(1000, 25);
            name.AutoSize = true;


            Label mail = new Label();
            mail.Location = new Point(189, 41);
            mail.Text = mailClient;
            mail.Font = new Font("Tahoma", 15, FontStyle.Bold);
            mail.MaximumSize = new Size(1000, 25);
            mail.AutoSize = true;

            Label phone = new Label();
            phone.Location = new Point(189, 66);
            phone.Text = phoneClient;
            phone.Font = new Font("Tahoma", 15, FontStyle.Bold);
            phone.MaximumSize = new Size(1000, 25);
            phone.AutoSize = true;


            Label description = new Label();
            description.Location = new Point(189, 117);
            description.Text = descriptionClient;
            description.Font = new Font("Tahoma", 12);
            description.MaximumSize = new Size(1000, 400);
            description.AutoSize = true;

            SiticoneButton editBtn = new SiticoneButton();
            editBtn.Location = new Point(6, 181);
            editBtn.Size = new Size(160, 45);
            editBtn.Text = "Редактировать профиль";

            SiticoneButton deleteBtn = new SiticoneButton();
            deleteBtn.Location = new Point(6, 232);
            deleteBtn.Size = new Size(160, 45);
            deleteBtn.Text = "Удалить";






            contain.Controls.Add(photo);
            contain.Controls.Add(name);
            contain.Controls.Add(mail);
            contain.Controls.Add(phone);
            contain.Controls.Add(description);
            contain.Controls.Add(editBtn);
            contain.Controls.Add(deleteBtn);

            LayoutPanel.Controls.Add(contain);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = "Мы любим животных и стараемся поддерживать тех из них, кому не посчастливилось иметь ласковых хозяев " +
                "и тёплый кров. Один из проверенных способов это сделать — помочь благотворительному фонду «Луч Добра». " +
                "Благодаря их труду ежегодно сотни питомцев находят свой новый дом. cМы любим животных и стараемся поддерживать " +
                "тех из них, кому не посчастливилось иметь ласковых хозяев и тёплый кров.Один из проверенных способов это сделать" +
                " — помочь благотворительному фонду «Луч Добра». Благодаря их труду ежегодно сотни питомцев находят свой новый дом";

            WindowClients("Vanessa Lucky","Телефон: 7 999 999 99 99","Почта: mail@mail.ru",text);
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            LayoutPanel.VerticalScroll.Value = ScrollBar.Value;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PhotoImage_Click(object sender, EventArgs e)
        {

        }
    }
}
