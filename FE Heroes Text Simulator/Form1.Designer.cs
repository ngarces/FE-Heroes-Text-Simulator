namespace FE_Heroes_Text_Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox_Name = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Line1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Line2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Line3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ImportUnit = new System.Windows.Forms.Button();
            this.button_ImportBG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_BG = new System.Windows.Forms.ComboBox();
            this.numericUpDown_UnitX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_UnitY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_BGY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_BGX = new System.Windows.Forms.NumericUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_ClearUnit = new System.Windows.Forms.Button();
            this.checkBox_ResizeUnit = new System.Windows.Forms.CheckBox();
            this.checkBox_ResizeBG = new System.Windows.Forms.CheckBox();
            this.comboBox_BG2 = new System.Windows.Forms.ComboBox();
            this.checkBox_Darken = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UnitX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UnitY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BGY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BGX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.MaximumSize = new System.Drawing.Size(720, 1280);
            this.pictureBox.MinimumSize = new System.Drawing.Size(720, 1280);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(720, 1280);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // richTextBox_Name
            // 
            this.richTextBox_Name.Location = new System.Drawing.Point(738, 93);
            this.richTextBox_Name.Name = "richTextBox_Name";
            this.richTextBox_Name.Size = new System.Drawing.Size(100, 20);
            this.richTextBox_Name.TabIndex = 2;
            this.richTextBox_Name.Text = "Name";
            this.richTextBox_Name.TextChanged += new System.EventHandler(this.richTextBox_Name_TextChanged);
            // 
            // richTextBox_Line1
            // 
            this.richTextBox_Line1.Location = new System.Drawing.Point(778, 119);
            this.richTextBox_Line1.Name = "richTextBox_Line1";
            this.richTextBox_Line1.Size = new System.Drawing.Size(256, 20);
            this.richTextBox_Line1.TabIndex = 3;
            this.richTextBox_Line1.Text = "";
            this.richTextBox_Line1.TextChanged += new System.EventHandler(this.richTextBox_Line1_TextChanged);
            // 
            // richTextBox_Line2
            // 
            this.richTextBox_Line2.Location = new System.Drawing.Point(778, 145);
            this.richTextBox_Line2.Name = "richTextBox_Line2";
            this.richTextBox_Line2.Size = new System.Drawing.Size(256, 20);
            this.richTextBox_Line2.TabIndex = 4;
            this.richTextBox_Line2.Text = "";
            this.richTextBox_Line2.TextChanged += new System.EventHandler(this.richTextBox_Line2_TextChanged);
            // 
            // richTextBox_Line3
            // 
            this.richTextBox_Line3.Location = new System.Drawing.Point(778, 171);
            this.richTextBox_Line3.Name = "richTextBox_Line3";
            this.richTextBox_Line3.Size = new System.Drawing.Size(256, 20);
            this.richTextBox_Line3.TabIndex = 5;
            this.richTextBox_Line3.Text = "";
            this.richTextBox_Line3.TextChanged += new System.EventHandler(this.richTextBox_Line3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Line 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line 3";
            // 
            // button_ImportUnit
            // 
            this.button_ImportUnit.Location = new System.Drawing.Point(738, 12);
            this.button_ImportUnit.Name = "button_ImportUnit";
            this.button_ImportUnit.Size = new System.Drawing.Size(108, 23);
            this.button_ImportUnit.TabIndex = 10;
            this.button_ImportUnit.Text = "Import Unit Image";
            this.button_ImportUnit.UseVisualStyleBackColor = true;
            this.button_ImportUnit.Click += new System.EventHandler(this.button_ImportUnit_Click);
            // 
            // button_ImportBG
            // 
            this.button_ImportBG.Location = new System.Drawing.Point(926, 222);
            this.button_ImportBG.Name = "button_ImportBG";
            this.button_ImportBG.Size = new System.Drawing.Size(108, 23);
            this.button_ImportBG.TabIndex = 11;
            this.button_ImportBG.Text = "Import Background";
            this.button_ImportBG.UseVisualStyleBackColor = true;
            this.button_ImportBG.Click += new System.EventHandler(this.button_ImportBG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Background";
            // 
            // comboBox_BG
            // 
            this.comboBox_BG.FormattingEnabled = true;
            this.comboBox_BG.Location = new System.Drawing.Point(739, 222);
            this.comboBox_BG.Name = "comboBox_BG";
            this.comboBox_BG.Size = new System.Drawing.Size(181, 21);
            this.comboBox_BG.TabIndex = 13;
            this.comboBox_BG.SelectedIndexChanged += new System.EventHandler(this.comboBox_BG_SelectedIndexChanged);
            // 
            // numericUpDown_UnitX
            // 
            this.numericUpDown_UnitX.Location = new System.Drawing.Point(756, 54);
            this.numericUpDown_UnitX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_UnitX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_UnitX.Name = "numericUpDown_UnitX";
            this.numericUpDown_UnitX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_UnitX.TabIndex = 14;
            this.numericUpDown_UnitX.ValueChanged += new System.EventHandler(this.numericUpDown_UnitX_ValueChanged);
            // 
            // numericUpDown_UnitY
            // 
            this.numericUpDown_UnitY.Location = new System.Drawing.Point(839, 54);
            this.numericUpDown_UnitY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_UnitY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_UnitY.Name = "numericUpDown_UnitY";
            this.numericUpDown_UnitY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_UnitY.TabIndex = 15;
            this.numericUpDown_UnitY.ValueChanged += new System.EventHandler(this.numericUpDown_UnitY_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(819, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(819, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(736, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "X";
            // 
            // numericUpDown_BGY
            // 
            this.numericUpDown_BGY.Location = new System.Drawing.Point(839, 312);
            this.numericUpDown_BGY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_BGY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_BGY.Name = "numericUpDown_BGY";
            this.numericUpDown_BGY.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_BGY.TabIndex = 23;
            this.numericUpDown_BGY.ValueChanged += new System.EventHandler(this.numericUpDown_BGY_ValueChanged);
            // 
            // numericUpDown_BGX
            // 
            this.numericUpDown_BGX.Location = new System.Drawing.Point(756, 312);
            this.numericUpDown_BGX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_BGX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_BGX.Name = "numericUpDown_BGX";
            this.numericUpDown_BGX.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_BGX.TabIndex = 22;
            this.numericUpDown_BGX.ValueChanged += new System.EventHandler(this.numericUpDown_BGX_ValueChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(737, 350);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 26;
            this.button_Save.Text = "Save Image";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_ClearUnit
            // 
            this.button_ClearUnit.Location = new System.Drawing.Point(852, 12);
            this.button_ClearUnit.Name = "button_ClearUnit";
            this.button_ClearUnit.Size = new System.Drawing.Size(108, 23);
            this.button_ClearUnit.TabIndex = 27;
            this.button_ClearUnit.Text = "Clear Unit Image";
            this.button_ClearUnit.UseVisualStyleBackColor = true;
            this.button_ClearUnit.Click += new System.EventHandler(this.button_ClearUnit_Click);
            // 
            // checkBox_ResizeUnit
            // 
            this.checkBox_ResizeUnit.AutoSize = true;
            this.checkBox_ResizeUnit.Checked = true;
            this.checkBox_ResizeUnit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ResizeUnit.Location = new System.Drawing.Point(902, 56);
            this.checkBox_ResizeUnit.Name = "checkBox_ResizeUnit";
            this.checkBox_ResizeUnit.Size = new System.Drawing.Size(58, 17);
            this.checkBox_ResizeUnit.TabIndex = 29;
            this.checkBox_ResizeUnit.Text = "Resize";
            this.checkBox_ResizeUnit.UseVisualStyleBackColor = true;
            this.checkBox_ResizeUnit.CheckedChanged += new System.EventHandler(this.checkBox_ResizeUnit_CheckedChanged);
            // 
            // checkBox_ResizeBG
            // 
            this.checkBox_ResizeBG.AutoSize = true;
            this.checkBox_ResizeBG.Checked = true;
            this.checkBox_ResizeBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ResizeBG.Location = new System.Drawing.Point(902, 315);
            this.checkBox_ResizeBG.Name = "checkBox_ResizeBG";
            this.checkBox_ResizeBG.Size = new System.Drawing.Size(58, 17);
            this.checkBox_ResizeBG.TabIndex = 30;
            this.checkBox_ResizeBG.Text = "Resize";
            this.checkBox_ResizeBG.UseVisualStyleBackColor = true;
            this.checkBox_ResizeBG.CheckedChanged += new System.EventHandler(this.checkBox_ResizeBG_CheckedChanged);
            // 
            // comboBox_BG2
            // 
            this.comboBox_BG2.FormattingEnabled = true;
            this.comboBox_BG2.Location = new System.Drawing.Point(739, 272);
            this.comboBox_BG2.Name = "comboBox_BG2";
            this.comboBox_BG2.Size = new System.Drawing.Size(181, 21);
            this.comboBox_BG2.TabIndex = 31;
            this.comboBox_BG2.SelectedIndexChanged += new System.EventHandler(this.comboBox_BG2_SelectedIndexChanged);
            // 
            // checkBox_Darken
            // 
            this.checkBox_Darken.AutoSize = true;
            this.checkBox_Darken.Location = new System.Drawing.Point(739, 249);
            this.checkBox_Darken.Name = "checkBox_Darken";
            this.checkBox_Darken.Size = new System.Drawing.Size(61, 17);
            this.checkBox_Darken.TabIndex = 32;
            this.checkBox_Darken.Text = "Darken";
            this.checkBox_Darken.UseVisualStyleBackColor = true;
            this.checkBox_Darken.CheckedChanged += new System.EventHandler(this.checkBox_Darken_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 749);
            this.Controls.Add(this.checkBox_Darken);
            this.Controls.Add(this.comboBox_BG2);
            this.Controls.Add(this.checkBox_ResizeBG);
            this.Controls.Add(this.checkBox_ResizeUnit);
            this.Controls.Add(this.button_ClearUnit);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown_BGY);
            this.Controls.Add(this.numericUpDown_BGX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_UnitY);
            this.Controls.Add(this.numericUpDown_UnitX);
            this.Controls.Add(this.comboBox_BG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ImportBG);
            this.Controls.Add(this.button_ImportUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_Line3);
            this.Controls.Add(this.richTextBox_Line2);
            this.Controls.Add(this.richTextBox_Line1);
            this.Controls.Add(this.richTextBox_Name);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FE Heroes Text Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UnitX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UnitY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BGY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BGX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox richTextBox_Name;
        private System.Windows.Forms.RichTextBox richTextBox_Line1;
        private System.Windows.Forms.RichTextBox richTextBox_Line2;
        private System.Windows.Forms.RichTextBox richTextBox_Line3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ImportUnit;
        private System.Windows.Forms.Button button_ImportBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BG;
        private System.Windows.Forms.NumericUpDown numericUpDown_UnitX;
        private System.Windows.Forms.NumericUpDown numericUpDown_UnitY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_BGY;
        private System.Windows.Forms.NumericUpDown numericUpDown_BGX;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_ClearUnit;
        private System.Windows.Forms.CheckBox checkBox_ResizeUnit;
        private System.Windows.Forms.CheckBox checkBox_ResizeBG;
        private System.Windows.Forms.ComboBox comboBox_BG2;
        private System.Windows.Forms.CheckBox checkBox_Darken;
    }
}

