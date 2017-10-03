namespace Asseco.CSharp.Sample
{
    partial class FrmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tConsumtion = new System.Windows.Forms.TextBox();
            this.lConsumption = new System.Windows.Forms.Label();
            this.lRate = new System.Windows.Forms.Label();
            this.tRate = new System.Windows.Forms.TextBox();
            this.tResult = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tConsumtion
            // 
            this.tConsumtion.Location = new System.Drawing.Point(112, 12);
            this.tConsumtion.MaxLength = 6;
            this.tConsumtion.Name = "tConsumtion";
            this.tConsumtion.Size = new System.Drawing.Size(100, 20);
            this.tConsumtion.TabIndex = 0;
            this.tConsumtion.TextChanged += new System.EventHandler(this.tConsumtion_TextChanged);
            // 
            // lConsumption
            // 
            this.lConsumption.AutoSize = true;
            this.lConsumption.Location = new System.Drawing.Point(28, 15);
            this.lConsumption.Name = "lConsumption";
            this.lConsumption.Size = new System.Drawing.Size(78, 13);
            this.lConsumption.TabIndex = 1;
            this.lConsumption.Text = "Zużycie energii";
            // 
            // lRate
            // 
            this.lRate.AutoSize = true;
            this.lRate.Location = new System.Drawing.Point(28, 41);
            this.lRate.Name = "lRate";
            this.lRate.Size = new System.Drawing.Size(43, 13);
            this.lRate.TabIndex = 1;
            this.lRate.Text = "Stawka";
            // 
            // tRate
            // 
            this.tRate.Location = new System.Drawing.Point(112, 38);
            this.tRate.MaxLength = 6;
            this.tRate.Name = "tRate";
            this.tRate.Size = new System.Drawing.Size(100, 20);
            this.tRate.TabIndex = 0;
            this.tRate.TextChanged += new System.EventHandler(this.tRate_TextChanged);
            // 
            // tResult
            // 
            this.tResult.Location = new System.Drawing.Point(112, 99);
            this.tResult.Name = "tResult";
            this.tResult.Size = new System.Drawing.Size(100, 20);
            this.tResult.TabIndex = 0;
            this.tResult.TextChanged += new System.EventHandler(this.tResult_TextChanged);
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(197, 226);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(75, 23);
            this.bCalculate.TabIndex = 2;
            this.bCalculate.Text = "Oblicz";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(28, 102);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(33, 13);
            this.lResult.TabIndex = 1;
            this.lResult.Text = "Koszt";
            this.lResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lRate);
            this.Controls.Add(this.lConsumption);
            this.Controls.Add(this.tResult);
            this.Controls.Add(this.tRate);
            this.Controls.Add(this.tConsumtion);
            this.Name = "FrmCalculator";
            this.Text = "frmCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tConsumtion;
        private System.Windows.Forms.Label lConsumption;
        private System.Windows.Forms.Label lRate;
        private System.Windows.Forms.TextBox tRate;
        private System.Windows.Forms.TextBox tResult;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label lResult;
    }
}