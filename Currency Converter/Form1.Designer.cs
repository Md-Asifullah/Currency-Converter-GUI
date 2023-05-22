namespace Currency_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toDD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toDisplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // fromDD
            // 
            this.fromDD.CausesValidation = false;
            this.fromDD.FormattingEnabled = true;
            this.fromDD.Items.AddRange(new object[] {
            "United States Dollar",
            "Malaysian Ringgit",
            "Bangladeshi Taka"});
            this.fromDD.Location = new System.Drawing.Point(93, 85);
            this.fromDD.Name = "fromDD";
            this.fromDD.Size = new System.Drawing.Size(264, 28);
            this.fromDD.TabIndex = 2;
            this.fromDD.Text = "Select Currency";
            this.fromDD.SelectedIndexChanged += new System.EventHandler(this.fromDD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // toDD
            // 
            this.toDD.FormattingEnabled = true;
            this.toDD.Items.AddRange(new object[] {
            "United States Dollar",
            "Malaysian Ringgit",
            "Bangladeshi Taka"});
            this.toDD.Location = new System.Drawing.Point(92, 138);
            this.toDD.Name = "toDD";
            this.toDD.Size = new System.Drawing.Size(265, 28);
            this.toDD.TabIndex = 4;
            this.toDD.Text = "Select Currency";
            this.toDD.SelectedIndexChanged += new System.EventHandler(this.toDD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Converting";
            // 
            // fromDisplay
            // 
            this.fromDisplay.AutoSize = true;
            this.fromDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromDisplay.Location = new System.Drawing.Point(138, 196);
            this.fromDisplay.Name = "fromDisplay";
            this.fromDisplay.Size = new System.Drawing.Size(16, 20);
            this.fromDisplay.TabIndex = 6;
            this.fromDisplay.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "To";
            // 
            // toDisplay
            // 
            this.toDisplay.AutoSize = true;
            this.toDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toDisplay.Location = new System.Drawing.Point(244, 196);
            this.toDisplay.Name = "toDisplay";
            this.toDisplay.Size = new System.Drawing.Size(16, 20);
            this.toDisplay.TabIndex = 8;
            this.toDisplay.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter Amount";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input.Location = new System.Drawing.Point(39, 276);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(217, 43);
            this.input.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(39, 342);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 31);
            this.output.TabIndex = 12;
            this.output.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 399);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fromDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox toDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fromDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label toDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label output;
    }
}
