namespace WindowsFormsApplication1
{
    partial class Farm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farm));
            this.hiveOneButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.hiveTwoButton = new System.Windows.Forms.Button();
            this.orchardButton = new System.Windows.Forms.Button();
            this.greenhouseButton = new System.Windows.Forms.Button();
            this.coopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hiveOneButton
            // 
            this.hiveOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiveOneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hiveOneButton.Location = new System.Drawing.Point(22, 20);
            this.hiveOneButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hiveOneButton.Name = "hiveOneButton";
            this.hiveOneButton.Size = new System.Drawing.Size(138, 39);
            this.hiveOneButton.TabIndex = 0;
            this.hiveOneButton.Text = "Hive One";
            this.hiveOneButton.UseVisualStyleBackColor = true;
            this.hiveOneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainLabel.Location = new System.Drawing.Point(31, 283);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(82, 22);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Output...";
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // hiveTwoButton
            // 
            this.hiveTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiveTwoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hiveTwoButton.Location = new System.Drawing.Point(22, 69);
            this.hiveTwoButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hiveTwoButton.Name = "hiveTwoButton";
            this.hiveTwoButton.Size = new System.Drawing.Size(138, 39);
            this.hiveTwoButton.TabIndex = 2;
            this.hiveTwoButton.Text = "Hive Two";
            this.hiveTwoButton.UseVisualStyleBackColor = true;
            this.hiveTwoButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // orchardButton
            // 
            this.orchardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orchardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orchardButton.Location = new System.Drawing.Point(22, 118);
            this.orchardButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.orchardButton.Name = "orchardButton";
            this.orchardButton.Size = new System.Drawing.Size(138, 39);
            this.orchardButton.TabIndex = 3;
            this.orchardButton.Text = "Orchard";
            this.orchardButton.UseVisualStyleBackColor = true;
            this.orchardButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // greenhouseButton
            // 
            this.greenhouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenhouseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.greenhouseButton.Location = new System.Drawing.Point(22, 168);
            this.greenhouseButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.greenhouseButton.Name = "greenhouseButton";
            this.greenhouseButton.Size = new System.Drawing.Size(138, 39);
            this.greenhouseButton.TabIndex = 4;
            this.greenhouseButton.Text = "Greenhouse";
            this.greenhouseButton.UseVisualStyleBackColor = true;
            this.greenhouseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // coopButton
            // 
            this.coopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coopButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coopButton.Location = new System.Drawing.Point(22, 217);
            this.coopButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.coopButton.Name = "coopButton";
            this.coopButton.Size = new System.Drawing.Size(138, 39);
            this.coopButton.TabIndex = 5;
            this.coopButton.Text = "Coop";
            this.coopButton.UseVisualStyleBackColor = true;
            this.coopButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Farm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1358, 547);
            this.Controls.Add(this.coopButton);
            this.Controls.Add(this.greenhouseButton);
            this.Controls.Add(this.orchardButton);
            this.Controls.Add(this.hiveTwoButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.hiveOneButton);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Farm";
            this.Text = "Farm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hiveOneButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button hiveTwoButton;
        private System.Windows.Forms.Button orchardButton;
        private System.Windows.Forms.Button greenhouseButton;
        private System.Windows.Forms.Button coopButton;
    }
}

