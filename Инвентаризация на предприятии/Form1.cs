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
    public partial class Form1 : Form
    {
        DB dB;
        public Form1(DB dB)
        {
            InitializeComponent();
            timer1.Start();
            this.dB = dB;
        }

       

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(dB).Show();
        }

        void show()
        {
            listView1.Items.Clear();
            foreach (Tovar tovar in dB.tovars)
            {
                ListViewItem row = new ListViewItem(tovar.Number.ToString());
                row.SubItems.Add(tovar.Name);
                row.SubItems.Add(tovar.Kolihestvo);
                row.SubItems.Add(tovar.Data.ToShortDateString());
                row.SubItems.Add(tovar.Availability);
                row.Tag = tovar;
                listView1.Items.Add(row);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                return;
           
            show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Tovar tovar = (Tovar)listView1.SelectedItems[0].Tag;
            Form3 form2 = new Form3(dB,tovar);
            form2.ShowDialog();
            show();
            dB.Save();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Tovar tovar = (Tovar)listView1.SelectedItems[0].Tag;
            dB.tovars.Remove(tovar);
            show();
            dB.Save();
        }

        private void удалитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Tovar> tovars = new List<Tovar>();
            dB.tovars = tovars;
            show();
            dB.Save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }


}
