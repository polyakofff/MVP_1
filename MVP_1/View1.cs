using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_1 {
    public partial class View1 : Form, IView {
        public View1() {
            InitializeComponent();
        }

        public double InputDegrees {
            get {
                return textBox1.Text == string.Empty ? 0 : double.Parse(textBox1.Text);
            }
        }

        public event EventHandler<EventArgs> OnSetFahrenheit;
        public event EventHandler<EventArgs> OnSetCelsius;

        public void PrintCelsius(double value) {
            label1.Text = value.ToString("F3");
        }

        public void PrintFahrenheit(double value) {
            label2.Text = value.ToString("F3");
        }

        private void View1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            OnSetCelsius?.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e) {
            OnSetFahrenheit?.Invoke(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
