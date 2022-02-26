using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class InputForm : Form
    {
        public static Form thisForm;

        private OutputForm output = new OutputForm();

        public InputForm()
        {
            InitializeComponent();
            thisForm = this;
        }

        private void input_Load(object sender, EventArgs e)
        {
            //txtvkill.Text = Convert.ToString(0.28); // b
            //txtftlp.Text = Convert.ToString(0.30); // d
        }

        private void bntcomp_Click(object sender, EventArgs e)
        {
            double t_end, x_init, a, y_init, g, b, d;
            bool failed = false;
            failed |= !double.TryParse(txttime.Text, out t_end);
            failed |= !double.TryParse(txtpplv.Text, out x_init);
            failed |= !double.TryParse(txtftlv.Text, out a);
            failed |= !double.TryParse(txtpplp.Text, out y_init);
            failed |= !double.TryParse(txtdclp.Text, out g);
            failed |= !double.TryParse(txtvkill.Text, out b);
            failed |= !double.TryParse(txtftlp.Text, out d);

            if (failed || t_end < 0 || x_init < 0 || a < 0 || y_init < 0 || g < 0 || b < 0 || d < 0)
            {
                MessageBox.Show("Неверные данные", "Ошибка!");
                return;
            }

            Lotka.Inst.t_end = t_end;
            Lotka.Inst.x_init = x_init;
            Lotka.Inst.a      = a;
            Lotka.Inst.y_init = y_init;
            Lotka.Inst.g      = g;
            Lotka.Inst.b      = b;
            Lotka.Inst.d      = d;
            Lotka.Inst.graph = checkBox3.Checked ? GraphSelect.Circle : GraphSelect.Lotka;

            output.Show();
            output.load();
            Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void input_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
