namespace DataExtensionsExamples
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDockBottom1 = new FormControlsLibrary.PanelDockBottom();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEndsWith = new System.Windows.Forms.RadioButton();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.rdoContains = new System.Windows.Forms.RadioButton();
            this.rdoStartsWith = new System.Windows.Forms.RadioButton();
            this.filterButton = new System.Windows.Forms.Button();
            this.currentPrimaryKeyButton = new System.Windows.Forms.Button();
            this.lastPrimaryKeyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDockBottom1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 285);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelDockBottom1
            // 
            this.panelDockBottom1.Controls.Add(this.lastPrimaryKeyButton);
            this.panelDockBottom1.Controls.Add(this.groupBox1);
            this.panelDockBottom1.Controls.Add(this.currentPrimaryKeyButton);
            this.panelDockBottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDockBottom1.Location = new System.Drawing.Point(0, 285);
            this.panelDockBottom1.Name = "panelDockBottom1";
            this.panelDockBottom1.Size = new System.Drawing.Size(913, 134);
            this.panelDockBottom1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoEndsWith);
            this.groupBox1.Controls.Add(this.filterTextBox);
            this.groupBox1.Controls.Add(this.rdoContains);
            this.groupBox1.Controls.Add(this.rdoStartsWith);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Location = new System.Drawing.Point(180, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter company name";
            // 
            // rdoEndsWith
            // 
            this.rdoEndsWith.AutoSize = true;
            this.rdoEndsWith.Location = new System.Drawing.Point(471, 18);
            this.rdoEndsWith.Name = "rdoEndsWith";
            this.rdoEndsWith.Size = new System.Drawing.Size(71, 17);
            this.rdoEndsWith.TabIndex = 5;
            this.rdoEndsWith.Text = "Ends with";
            this.rdoEndsWith.UseVisualStyleBackColor = true;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(138, 18);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(139, 20);
            this.filterTextBox.TabIndex = 4;
            // 
            // rdoContains
            // 
            this.rdoContains.AutoSize = true;
            this.rdoContains.Location = new System.Drawing.Point(399, 18);
            this.rdoContains.Name = "rdoContains";
            this.rdoContains.Size = new System.Drawing.Size(66, 17);
            this.rdoContains.TabIndex = 3;
            this.rdoContains.Text = "Contains";
            this.rdoContains.UseVisualStyleBackColor = true;
            // 
            // rdoStartsWith
            // 
            this.rdoStartsWith.AutoSize = true;
            this.rdoStartsWith.Checked = true;
            this.rdoStartsWith.Location = new System.Drawing.Point(295, 18);
            this.rdoStartsWith.Name = "rdoStartsWith";
            this.rdoStartsWith.Size = new System.Drawing.Size(74, 17);
            this.rdoStartsWith.TabIndex = 2;
            this.rdoStartsWith.TabStop = true;
            this.rdoStartsWith.Text = "Starts with";
            this.rdoStartsWith.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(6, 19);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(118, 23);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // currentPrimaryKeyButton
            // 
            this.currentPrimaryKeyButton.Location = new System.Drawing.Point(12, 29);
            this.currentPrimaryKeyButton.Name = "currentPrimaryKeyButton";
            this.currentPrimaryKeyButton.Size = new System.Drawing.Size(118, 23);
            this.currentPrimaryKeyButton.TabIndex = 0;
            this.currentPrimaryKeyButton.Text = "Current Primary Key";
            this.currentPrimaryKeyButton.UseVisualStyleBackColor = true;
            this.currentPrimaryKeyButton.Click += new System.EventHandler(this.currentPrimaryKeyButton_Click);
            // 
            // lastPrimaryKeyButton
            // 
            this.lastPrimaryKeyButton.Location = new System.Drawing.Point(12, 58);
            this.lastPrimaryKeyButton.Name = "lastPrimaryKeyButton";
            this.lastPrimaryKeyButton.Size = new System.Drawing.Size(118, 23);
            this.lastPrimaryKeyButton.TabIndex = 3;
            this.lastPrimaryKeyButton.Text = "Last Primary Key";
            this.lastPrimaryKeyButton.UseVisualStyleBackColor = true;
            this.lastPrimaryKeyButton.Click += new System.EventHandler(this.lastPrimaryKeyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelDockBottom1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDockBottom1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormControlsLibrary.PanelDockBottom panelDockBottom1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button currentPrimaryKeyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.RadioButton rdoContains;
        private System.Windows.Forms.RadioButton rdoStartsWith;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.RadioButton rdoEndsWith;
        private System.Windows.Forms.Button lastPrimaryKeyButton;
    }
}

