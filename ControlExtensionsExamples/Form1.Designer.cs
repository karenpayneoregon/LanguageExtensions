namespace ControlExtensionsExamples
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
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.intLabel = new System.Windows.Forms.Label();
            this.panelDockBottom1 = new FormControlsLibrary.PanelDockBottom();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedRadioGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedRadioButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.descendantsGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descendantButton3 = new System.Windows.Forms.Button();
            this.descendantButton2 = new System.Windows.Forms.Button();
            this.descendantButton1 = new System.Windows.Forms.Button();
            this.panelDockBottom1.SuspendLayout();
            this.selectedRadioGroupBox.SuspendLayout();
            this.descendantsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(12, 31);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(117, 20);
            this.IntTextBox.TabIndex = 0;
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(133, 34);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(13, 13);
            this.intLabel.TabIndex = 1;
            this.intLabel.Text = "0";
            // 
            // panelDockBottom1
            // 
            this.panelDockBottom1.Controls.Add(this.exitButton);
            this.panelDockBottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDockBottom1.Location = new System.Drawing.Point(0, 270);
            this.panelDockBottom1.Name = "panelDockBottom1";
            this.panelDockBottom1.Size = new System.Drawing.Size(647, 48);
            this.panelDockBottom1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(535, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Strict string to int";
            // 
            // selectedRadioGroupBox
            // 
            this.selectedRadioGroupBox.Controls.Add(this.selectedRadioButton);
            this.selectedRadioGroupBox.Controls.Add(this.radioButton4);
            this.selectedRadioGroupBox.Controls.Add(this.radioButton3);
            this.selectedRadioGroupBox.Controls.Add(this.radioButton2);
            this.selectedRadioGroupBox.Controls.Add(this.radioButton1);
            this.selectedRadioGroupBox.Location = new System.Drawing.Point(11, 63);
            this.selectedRadioGroupBox.Name = "selectedRadioGroupBox";
            this.selectedRadioGroupBox.Size = new System.Drawing.Size(134, 117);
            this.selectedRadioGroupBox.TabIndex = 4;
            this.selectedRadioGroupBox.TabStop = false;
            this.selectedRadioGroupBox.Text = "Selected RadioButton";
            // 
            // selectedRadioButton
            // 
            this.selectedRadioButton.Location = new System.Drawing.Point(6, 88);
            this.selectedRadioButton.Name = "selectedRadioButton";
            this.selectedRadioButton.Size = new System.Drawing.Size(75, 23);
            this.selectedRadioButton.TabIndex = 4;
            this.selectedRadioButton.Text = "Selected";
            this.selectedRadioButton.UseVisualStyleBackColor = true;
            this.selectedRadioButton.Click += new System.EventHandler(this.selectedRadioButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(64, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "None";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(64, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "VB.NET";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "F#";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "C#";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // descendantsGroupBox
            // 
            this.descendantsGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this.descendantsGroupBox.Controls.Add(this.panel1);
            this.descendantsGroupBox.Controls.Add(this.descendantButton1);
            this.descendantsGroupBox.Location = new System.Drawing.Point(170, 28);
            this.descendantsGroupBox.Name = "descendantsGroupBox";
            this.descendantsGroupBox.Size = new System.Drawing.Size(472, 212);
            this.descendantsGroupBox.TabIndex = 5;
            this.descendantsGroupBox.TabStop = false;
            this.descendantsGroupBox.Text = "Descendants";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.descendantButton2);
            this.panel1.Location = new System.Drawing.Point(15, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 105);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.descendantButton3);
            this.panel2.Location = new System.Drawing.Point(175, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 80);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // descendantButton3
            // 
            this.descendantButton3.Location = new System.Drawing.Point(75, 11);
            this.descendantButton3.Name = "descendantButton3";
            this.descendantButton3.Size = new System.Drawing.Size(109, 23);
            this.descendantButton3.TabIndex = 0;
            this.descendantButton3.Text = "button1 panel2";
            this.descendantButton3.UseVisualStyleBackColor = true;
            // 
            // descendantButton2
            // 
            this.descendantButton2.Location = new System.Drawing.Point(11, 19);
            this.descendantButton2.Name = "descendantButton2";
            this.descendantButton2.Size = new System.Drawing.Size(142, 23);
            this.descendantButton2.TabIndex = 0;
            this.descendantButton2.Text = "button1 panel1";
            this.descendantButton2.UseVisualStyleBackColor = true;
            // 
            // descendantButton1
            // 
            this.descendantButton1.Location = new System.Drawing.Point(15, 33);
            this.descendantButton1.Name = "descendantButton1";
            this.descendantButton1.Size = new System.Drawing.Size(138, 23);
            this.descendantButton1.TabIndex = 0;
            this.descendantButton1.Text = "Get buttons (GroupBox)";
            this.descendantButton1.UseVisualStyleBackColor = true;
            this.descendantButton1.Click += new System.EventHandler(this.descendantButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 318);
            this.Controls.Add(this.descendantsGroupBox);
            this.Controls.Add(this.selectedRadioGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDockBottom1);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.IntTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Extensions";
            this.panelDockBottom1.ResumeLayout(false);
            this.selectedRadioGroupBox.ResumeLayout(false);
            this.selectedRadioGroupBox.PerformLayout();
            this.descendantsGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.Label intLabel;
        private FormControlsLibrary.PanelDockBottom panelDockBottom1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox selectedRadioGroupBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button selectedRadioButton;
        private System.Windows.Forms.GroupBox descendantsGroupBox;
        private System.Windows.Forms.Button descendantButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button descendantButton3;
        private System.Windows.Forms.Button descendantButton2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

