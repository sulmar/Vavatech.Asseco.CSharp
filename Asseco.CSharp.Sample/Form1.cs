using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asseco.CSharp.Sample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tFirstName.Text) && !string.IsNullOrEmpty(tLastName.Text))
            {
                tStatus.Text = "Dane zostały zapisane.";

            }
            else tStatus.Text = "Brak danych";




        }

        private void bCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalculator = new FrmCalculator();
            frmCalculator.ShowDialog();
        }
    }
}
