namespace Vazquez_Mortgage
{
    partial class Form1
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtprincipal = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboInterest = new System.Windows.Forms.ComboBox();
            this.rdo15year = new System.Windows.Forms.RadioButton();
            this.rdo30year = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(83, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(111, 25);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal:";
            // 
            // txtprincipal
            // 
            this.txtprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprincipal.Location = new System.Drawing.Point(200, 9);
            this.txtprincipal.Name = "txtprincipal";
            this.txtprincipal.Size = new System.Drawing.Size(132, 31);
            this.txtprincipal.TabIndex = 1;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(83, 59);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(160, 25);
            this.lblTerm.TabIndex = 2;
            this.lblTerm.Text = "Term in Years";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interest";
            // 
            // cboInterest
            // 
            this.cboInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInterest.FormattingEnabled = true;
            this.cboInterest.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterest.Location = new System.Drawing.Point(200, 235);
            this.cboInterest.Name = "cboInterest";
            this.cboInterest.Size = new System.Drawing.Size(66, 33);
            this.cboInterest.TabIndex = 5;
            // 
            // rdo15year
            // 
            this.rdo15year.AutoSize = true;
            this.rdo15year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo15year.Location = new System.Drawing.Point(91, 101);
            this.rdo15year.Name = "rdo15year";
            this.rdo15year.Size = new System.Drawing.Size(113, 29);
            this.rdo15year.TabIndex = 2;
            this.rdo15year.TabStop = true;
            this.rdo15year.Text = "15 Year";
            this.rdo15year.UseVisualStyleBackColor = true;
            // 
            // rdo30year
            // 
            this.rdo30year.AutoSize = true;
            this.rdo30year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo30year.Location = new System.Drawing.Point(91, 145);
            this.rdo30year.Name = "rdo30year";
            this.rdo30year.Size = new System.Drawing.Size(113, 29);
            this.rdo30year.TabIndex = 3;
            this.rdo30year.TabStop = true;
            this.rdo30year.Text = "30 Year";
            this.rdo30year.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOther.Location = new System.Drawing.Point(91, 189);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(109, 29);
            this.rdoOther.TabIndex = 4;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other...";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(77, 288);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(205, 44);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Payment";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(190, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(77, 351);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 420);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdo30year);
            this.Controls.Add(this.rdo15year);
            this.Controls.Add(this.cboInterest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.txtprincipal);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "Form1";
            this.Text = "Ethan Vazquez : Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtprincipal;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboInterest;
        private System.Windows.Forms.RadioButton rdo15year;
        private System.Windows.Forms.RadioButton rdo30year;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
    }
}

