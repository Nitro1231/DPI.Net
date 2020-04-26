using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPI {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Supporting Languages
            langBox.Items.Add("VB.Net");
            langBox.Items.Add("C#");

            //Options: Dpi, Font (Defolat), Inherit, None
            dpiBox.Items.Add("Font");
            dpiBox.Items.Add("Dpi");
            dpiBox.Items.Add("Inherit");
            dpiBox.Items.Add("None");
        }

        private void Main_Load(object sender, EventArgs e) {

        }

        private void apply_Click(object sender, EventArgs e) {

        }
    }
}
