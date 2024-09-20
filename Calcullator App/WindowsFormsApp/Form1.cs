using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string operation = Operasi.SelectedItem.ToString();

            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            lstHasil.Items.Clear();
            switch (operation)
            {
                case "Penjumlahan":
                    lstHasil.Items.Add((a + b).ToString());
                    break;
                case "Pengurangan":
                    lstHasil.Items.Add((a - b).ToString());
                    break;
                case "Perkalian":
                    lstHasil.Items.Add((a * b).ToString());
                    break;
                case "Pembagian":
                    lstHasil.Items.Add((a / b).ToString());
                    break;
            }

        }
    }
}
