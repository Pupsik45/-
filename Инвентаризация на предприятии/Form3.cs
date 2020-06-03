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
    public partial class Form3 : Form
    {
        DB dB;
        Tovar tovar;
        public Form3(DB dB,Tovar tovar)
        {
            InitializeComponent();
            this.dB = dB;
            this.tovar = tovar;
            textBox1.Text = tovar.Name;
            textBox3.Text = tovar.Number.ToString();
            textBox2.Text = tovar.Kolihestvo;
            dateTimePicker1.Value = tovar.Data;
            textBox4.Text = tovar.Availability;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovar.Name = textBox1.Text;
            tovar.Number = Convert.ToInt32(textBox3.Text);
            tovar.Kolihestvo = textBox2.Text;
            tovar.Data = dateTimePicker1.Value;
            tovar.Availability = textBox4.Text;
            dB.Save();
            Close();
        }
    }
}
