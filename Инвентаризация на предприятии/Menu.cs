using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Инвентаризация_на_предприятии
{
    public partial class Menu : Form
    {
        DB dB = new DB();
        User user;
        
        public Menu(User user)
        {
            this.user = user;
            InitializeComponent();

            textBox1.Text = "Введите имя";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Введите фамилию";
            textBox2.ForeColor = Color.Gray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя")
                textBox1.Text = "";
            textBox1.ForeColor = Color.Black;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Введите имя";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите фамилию")
                textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "Введите фамилию";
            textBox2.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            user.Users = textBox1.Text;
            new Welcome(dB,user).Show();
            dB.Save();
            this.Hide();
        }

    }
}
