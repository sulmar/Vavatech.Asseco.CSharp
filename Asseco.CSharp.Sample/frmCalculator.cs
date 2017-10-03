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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            decimal consumption = decimal.Parse(tConsumtion.Text);
            decimal rate = decimal.Parse(tRate.Text);
            Calculator calculator = new Calculator();
            decimal result = calculator.Calculate(consumption, rate);
            tResult.Text = result.ToString("n2");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tConsumtion_TextChanged(object sender, EventArgs e)
        {
            bCalculate.Enabled = IsValid();
        }

        private bool IsValid()
        {
            bool isvalid = !string.IsNullOrEmpty(tConsumtion.Text)
                && !string.IsNullOrEmpty(tRate.Text)
                && decimal.TryParse(tConsumtion.Text, out decimal resultconsumption)
                && decimal.TryParse(tRate.Text, out decimal resultrate)
                ;

            return isvalid;
        }

        private void tRate_TextChanged(object sender, EventArgs e)
        {
            bCalculate.Enabled = IsValid();
        }
    }
}
