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
            this.components = new System.ComponentModel.Container();
            this.hiveOneButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.hiveTwoButton = new System.Windows.Forms.Button();
            this.orchardButton = new System.Windows.Forms.Button();
            this.greenhouseButton = new System.Windows.Forms.Button();
            this.coopButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort5 = new System.IO.Ports.SerialPort(this.components);
            this.commandCenter = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lightsDimmer = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.lightsDimmer)).BeginInit();
            this.SuspendLayout();
            // 
            // hiveOneButton
            // 
            this.hiveOneButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hiveOneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hiveOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hiveOneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hiveOneButton.FlatAppearance.BorderSize = 0;
            this.hiveOneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hiveOneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.hiveOneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.hiveOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiveOneButton.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiveOneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hiveOneButton.Location = new System.Drawing.Point(22, 20);
            this.hiveOneButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hiveOneButton.Name = "hiveOneButton";
            this.hiveOneButton.Size = new System.Drawing.Size(198, 39);
            this.hiveOneButton.TabIndex = 0;
            this.hiveOneButton.Text = "Hive One";
            this.hiveOneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hiveOneButton.UseVisualStyleBackColor = false;
            this.hiveOneButton.Click += new System.EventHandler(this.hiveOne_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainLabel.Location = new System.Drawing.Point(28, 261);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(383, 50);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Output...";
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // hiveTwoButton
            // 
            this.hiveTwoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hiveTwoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hiveTwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hiveTwoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hiveTwoButton.FlatAppearance.BorderSize = 0;
            this.hiveTwoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hiveTwoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.hiveTwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.hiveTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiveTwoButton.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiveTwoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hiveTwoButton.Location = new System.Drawing.Point(22, 69);
            this.hiveTwoButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hiveTwoButton.Name = "hiveTwoButton";
            this.hiveTwoButton.Size = new System.Drawing.Size(198, 39);
            this.hiveTwoButton.TabIndex = 2;
            this.hiveTwoButton.Text = "Hive Two";
            this.hiveTwoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hiveTwoButton.UseVisualStyleBackColor = false;
            this.hiveTwoButton.Click += new System.EventHandler(this.hiveTwo_Click);
            // 
            // orchardButton
            // 
            this.orchardButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orchardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orchardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orchardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.orchardButton.FlatAppearance.BorderSize = 0;
            this.orchardButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.orchardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.orchardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.orchardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orchardButton.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orchardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orchardButton.Location = new System.Drawing.Point(22, 118);
            this.orchardButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.orchardButton.Name = "orchardButton";
            this.orchardButton.Size = new System.Drawing.Size(198, 39);
            this.orchardButton.TabIndex = 3;
            this.orchardButton.Text = "Orchard";
            this.orchardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orchardButton.UseVisualStyleBackColor = false;
            this.orchardButton.Click += new System.EventHandler(this.orchardButton_Click);
            // 
            // greenhouseButton
            // 
            this.greenhouseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.greenhouseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenhouseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenhouseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.greenhouseButton.FlatAppearance.BorderSize = 0;
            this.greenhouseButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.greenhouseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.greenhouseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.greenhouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenhouseButton.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenhouseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.greenhouseButton.Location = new System.Drawing.Point(22, 168);
            this.greenhouseButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.greenhouseButton.Name = "greenhouseButton";
            this.greenhouseButton.Size = new System.Drawing.Size(198, 39);
            this.greenhouseButton.TabIndex = 4;
            this.greenhouseButton.Text = "Greenhouse";
            this.greenhouseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenhouseButton.UseVisualStyleBackColor = false;
            this.greenhouseButton.Click += new System.EventHandler(this.greenhouseButton_Click);
            // 
            // coopButton
            // 
            this.coopButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.coopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.coopButton.FlatAppearance.BorderSize = 0;
            this.coopButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.coopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.coopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.coopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coopButton.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coopButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coopButton.Location = new System.Drawing.Point(22, 217);
            this.coopButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.coopButton.Name = "coopButton";
            this.coopButton.Size = new System.Drawing.Size(198, 39);
            this.coopButton.TabIndex = 5;
            this.coopButton.Text = "Coop";
            this.coopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coopButton.UseVisualStyleBackColor = false;
            this.coopButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Snow;
            this.monthCalendar1.Location = new System.Drawing.Point(420, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // commandCenter
            // 
            this.commandCenter.BackColor = System.Drawing.Color.Snow;
            this.commandCenter.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCenter.FormattingEnabled = true;
            this.commandCenter.Items.AddRange(new object[] {
            "Fan",
            "Vents",
            "Watering System",
            "Heater",
            "Lights"});
            this.commandCenter.Location = new System.Drawing.Point(420, 261);
            this.commandCenter.Name = "commandCenter";
            this.commandCenter.Size = new System.Drawing.Size(227, 172);
            this.commandCenter.TabIndex = 7;
            this.commandCenter.ThreeDCheckBoxes = true;
            this.commandCenter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.commandCenter_ItemCheck);
            this.commandCenter.SelectedIndexChanged += new System.EventHandler(this.commandCenter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(420, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 79);
            this.label1.TabIndex = 8;
            this.label1.Text = "Greenhouse Command Center";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lightsDimmer
            // 
            this.lightsDimmer.Location = new System.Drawing.Point(509, 378);
            this.lightsDimmer.Name = "lightsDimmer";
            this.lightsDimmer.Size = new System.Drawing.Size(127, 45);
            this.lightsDimmer.TabIndex = 9;
            this.lightsDimmer.ValueChanged += new System.EventHandler(this.lightsDimmer_ValueChanged);
            // 
            // Farm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 547);
            this.Controls.Add(this.lightsDimmer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandCenter);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.coopButton);
            this.Controls.Add(this.greenhouseButton);
            this.Controls.Add(this.orchardButton);
            this.Controls.Add(this.hiveTwoButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.hiveOneButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Farm";
            this.Text = "Farm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lightsDimmer)).EndInit();
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort5;
        private System.Windows.Forms.CheckedListBox commandCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar lightsDimmer;
    }
}

