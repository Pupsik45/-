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
    public partial class Form2 : Form
    {
        DB dB;
        public Form2(DB dB)
        {
            InitializeComponent();
            this.dB = dB;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tovar tovar = new Tovar();
            tovar.Name = textBox1.Text;
            tovar.Number = Convert.ToInt32(textBox3.Text);
            tovar.Kolihestvo = textBox2.Text;
            tovar.Data = dateTimePicker1.Value;
            tovar.Availability = textBox4.Text;
            dB.tovars.Add(tovar);
            dB.Save();
            Close();
        }

    }
}
