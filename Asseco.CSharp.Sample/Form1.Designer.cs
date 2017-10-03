namespace Asseco.CSharp.Sample
{
    partial class FrmMain
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
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tAge = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.dBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dEndDate = new System.Windows.Forms.DateTimePicker();
            this.tStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(77, 15);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(100, 20);
            this.tFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko:";
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(77, 39);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(100, 20);
            this.tLastName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wiek";
            // 
            // tAge
            // 
            this.tAge.Location = new System.Drawing.Point(77, 65);
            this.tAge.Name = "tAge";
            this.tAge.Size = new System.Drawing.Size(100, 20);
            this.tAge.TabIndex = 0;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(197, 226);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 3;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(116, 226);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(13, 159);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(40, 13);
            this.lStatus.TabIndex = 5;
            this.lStatus.Text = "Status:";
            // 
            // dBeginDate
            // 
            this.dBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dBeginDate.Location = new System.Drawing.Point(77, 91);
            this.dBeginDate.Name = "dBeginDate";
            this.dBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dBeginDate.TabIndex = 7;
            // 
            // dEndDate
            // 
            this.dEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dEndDate.Location = new System.Drawing.Point(77, 117);
            this.dEndDate.Name = "dEndDate";
            this.dEndDate.Size = new System.Drawing.Size(200, 20);
            this.dEndDate.TabIndex = 7;
            // 
            // tStatus
            // 
            this.tStatus.ForeColor = System.Drawing.Color.Red;
            this.tStatus.Location = new System.Drawing.Point(77, 152);
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(100, 20);
            this.tStatus.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data do";
            // 
            // bCalculator
            // 
            this.bCalculator.Location = new System.Drawing.Point(15, 226);
            this.bCalculator.Name = "bCalculator";
            this.bCalculator.Size = new System.Drawing.Size(75, 23);
            this.bCalculator.TabIndex = 9;
            this.bCalculator.Text = "Kalkulator";
            this.bCalculator.UseVisualStyleBackColor = true;
            this.bCalculator.Click += new System.EventHandler(this.bCalculator_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bCalculator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dEndDate);
            this.Controls.Add(this.dBeginDate);
            this.Controls.Add(this.tStatus);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tAge);
            this.Controls.Add(this.tLastName);
            this.Controls.Add(this.tFirstName);
            this.Name = "FrmMain";
            this.Text = "Formularz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tAge;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.DateTimePicker dBeginDate;
        private System.Windows.Forms.DateTimePicker dEndDate;
        private System.Windows.Forms.TextBox tStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCalculator;
    }
}

