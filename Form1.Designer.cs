namespace Cake_Factory_New
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
            this.lstCakes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveRound = new System.Windows.Forms.Button();
            this.btnSaveSquare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRound = new System.Windows.Forms.DateTimePicker();
            this.nudSizeRound = new System.Windows.Forms.NumericUpDown();
            this.chbChocoIceRound = new System.Windows.Forms.CheckBox();
            this.chbFruitOption = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCostRound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSquare = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSizeSquare = new System.Windows.Forms.NumericUpDown();
            this.chbChocoIcingSquare = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCostSquare = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCakeWriting = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCakes
            // 
            this.lstCakes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCakes.FormattingEnabled = true;
            this.lstCakes.ItemHeight = 15;
            this.lstCakes.Location = new System.Drawing.Point(46, 447);
            this.lstCakes.Name = "lstCakes";
            this.lstCakes.Size = new System.Drawing.Size(328, 154);
            this.lstCakes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(42, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date                    Type                     Size";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(46, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 354);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCostRound);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.chbFruitOption);
            this.tabPage1.Controls.Add(this.chbChocoIceRound);
            this.tabPage1.Controls.Add(this.nudSizeRound);
            this.tabPage1.Controls.Add(this.dtpRound);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSaveRound);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Round";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCakeWriting);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblCostSquare);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.chbChocoIcingSquare);
            this.tabPage2.Controls.Add(this.nudSizeSquare);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtpSquare);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSaveSquare);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(320, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Square";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveRound
            // 
            this.btnSaveRound.Location = new System.Drawing.Point(209, 29);
            this.btnSaveRound.Name = "btnSaveRound";
            this.btnSaveRound.Size = new System.Drawing.Size(77, 37);
            this.btnSaveRound.TabIndex = 0;
            this.btnSaveRound.Text = "SAVE";
            this.btnSaveRound.UseVisualStyleBackColor = true;
            this.btnSaveRound.Click += new System.EventHandler(this.btnSaveRound_Click);
            // 
            // btnSaveSquare
            // 
            this.btnSaveSquare.Location = new System.Drawing.Point(215, 24);
            this.btnSaveSquare.Name = "btnSaveSquare";
            this.btnSaveSquare.Size = new System.Drawing.Size(77, 37);
            this.btnSaveSquare.TabIndex = 1;
            this.btnSaveSquare.Text = "SAVE";
            this.btnSaveSquare.UseVisualStyleBackColor = true;
            this.btnSaveSquare.Click += new System.EventHandler(this.btnSaveSquare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Needed By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diameter:";
            // 
            // dtpRound
            // 
            this.dtpRound.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRound.Location = new System.Drawing.Point(26, 62);
            this.dtpRound.Name = "dtpRound";
            this.dtpRound.Size = new System.Drawing.Size(111, 26);
            this.dtpRound.TabIndex = 3;
            // 
            // nudSizeRound
            // 
            this.nudSizeRound.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSizeRound.Location = new System.Drawing.Point(26, 138);
            this.nudSizeRound.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudSizeRound.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSizeRound.Name = "nudSizeRound";
            this.nudSizeRound.ReadOnly = true;
            this.nudSizeRound.Size = new System.Drawing.Size(61, 26);
            this.nudSizeRound.TabIndex = 4;
            this.nudSizeRound.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSizeRound.ValueChanged += new System.EventHandler(this.nudSizeRound_ValueChanged);
            // 
            // chbChocoIceRound
            // 
            this.chbChocoIceRound.AutoSize = true;
            this.chbChocoIceRound.Location = new System.Drawing.Point(26, 185);
            this.chbChocoIceRound.Name = "chbChocoIceRound";
            this.chbChocoIceRound.Size = new System.Drawing.Size(153, 24);
            this.chbChocoIceRound.TabIndex = 5;
            this.chbChocoIceRound.Text = "Chocolate Icing";
            this.chbChocoIceRound.UseVisualStyleBackColor = true;
            this.chbChocoIceRound.CheckedChanged += new System.EventHandler(this.chbChocoIceRound_CheckedChanged);
            // 
            // chbFruitOption
            // 
            this.chbFruitOption.AutoSize = true;
            this.chbFruitOption.Location = new System.Drawing.Point(26, 229);
            this.chbFruitOption.Name = "chbFruitOption";
            this.chbFruitOption.Size = new System.Drawing.Size(123, 24);
            this.chbFruitOption.TabIndex = 6;
            this.chbFruitOption.Text = "Fruit Option";
            this.chbFruitOption.UseVisualStyleBackColor = true;
            this.chbFruitOption.CheckedChanged += new System.EventHandler(this.chbFruitOption_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost:";
            // 
            // lblCostRound
            // 
            this.lblCostRound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostRound.Location = new System.Drawing.Point(92, 271);
            this.lblCostRound.Name = "lblCostRound";
            this.lblCostRound.Size = new System.Drawing.Size(97, 33);
            this.lblCostRound.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Needed By:";
            // 
            // dtpSquare
            // 
            this.dtpSquare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSquare.Location = new System.Drawing.Point(25, 58);
            this.dtpSquare.Name = "dtpSquare";
            this.dtpSquare.Size = new System.Drawing.Size(111, 26);
            this.dtpSquare.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Size:";
            // 
            // nudSizeSquare
            // 
            this.nudSizeSquare.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSizeSquare.Location = new System.Drawing.Point(25, 136);
            this.nudSizeSquare.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudSizeSquare.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSizeSquare.Name = "nudSizeSquare";
            this.nudSizeSquare.ReadOnly = true;
            this.nudSizeSquare.Size = new System.Drawing.Size(61, 26);
            this.nudSizeSquare.TabIndex = 6;
            this.nudSizeSquare.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSizeSquare.ValueChanged += new System.EventHandler(this.nudSizeSquare_ValueChanged);
            // 
            // chbChocoIcingSquare
            // 
            this.chbChocoIcingSquare.AutoSize = true;
            this.chbChocoIcingSquare.Location = new System.Drawing.Point(25, 179);
            this.chbChocoIcingSquare.Name = "chbChocoIcingSquare";
            this.chbChocoIcingSquare.Size = new System.Drawing.Size(153, 24);
            this.chbChocoIcingSquare.TabIndex = 7;
            this.chbChocoIcingSquare.Text = "Chocolate Icing";
            this.chbChocoIcingSquare.UseVisualStyleBackColor = true;
            this.chbChocoIcingSquare.CheckedChanged += new System.EventHandler(this.chbChocoIcingSquare_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cost:";
            // 
            // lblCostSquare
            // 
            this.lblCostSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostSquare.Location = new System.Drawing.Point(107, 278);
            this.lblCostSquare.Name = "lblCostSquare";
            this.lblCostSquare.Size = new System.Drawing.Size(89, 30);
            this.lblCostSquare.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "CakeWriting:";
            // 
            // txtCakeWriting
            // 
            this.txtCakeWriting.Location = new System.Drawing.Point(29, 233);
            this.txtCakeWriting.Name = "txtCakeWriting";
            this.txtCakeWriting.Size = new System.Drawing.Size(167, 26);
            this.txtCakeWriting.TabIndex = 11;
            this.txtCakeWriting.Text = "Congratulations";
            this.txtCakeWriting.TextChanged += new System.EventHandler(this.txtCakeWriting_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(418, 637);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCakes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Cake Factory";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCakes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveRound;
        private System.Windows.Forms.Button btnSaveSquare;
        private System.Windows.Forms.Label lblCostRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbFruitOption;
        private System.Windows.Forms.CheckBox chbChocoIceRound;
        private System.Windows.Forms.NumericUpDown nudSizeRound;
        private System.Windows.Forms.DateTimePicker dtpRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCakeWriting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCostSquare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbChocoIcingSquare;
        private System.Windows.Forms.NumericUpDown nudSizeSquare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSquare;
        private System.Windows.Forms.Label label5;
    }
}

