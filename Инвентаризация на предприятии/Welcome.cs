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
    public partial class Welcome : Form
    {
        DB dB;
        User user;
         Timer t = new Timer();
        public Welcome(DB dB, User user)
        {
            InitializeComponent();
            string v;
            v = "Добро пожаловать, ";
            this.dB = dB;
            this.user = user;
            label1.Text = v + user.Users;

           
            t.Interval = 5000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            Hide();
            t.Stop();
            new Form1(dB).Show();
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
