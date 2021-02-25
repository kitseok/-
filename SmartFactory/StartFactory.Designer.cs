namespace SmartFactory
{
    partial class StartFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartFactory));
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(104, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "GORONG FACTORY";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(465, 345);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 37);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "공정 시작";
            this.btnStart.UseSelectable = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(590, 345);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 37);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "중단";
            this.btnStop.UseSelectable = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 206);
            this.textBox1.TabIndex = 7;
            // 
            // progressBar
            // 
            this.progressBar.animated = false;
            this.progressBar.animationIterval = 5;
            this.progressBar.animationSpeed = 300;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressBar.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBar.LabelVisible = true;
            this.progressBar.LineProgressThickness = 8;
            this.progressBar.LineThickness = 5;
            this.progressBar.Location = new System.Drawing.Point(79, 138);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progressBar.Size = new System.Drawing.Size(201, 201);
            this.progressBar.TabIndex = 22;
            this.progressBar.Value = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(330, 354);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "작업건수 :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(415, 354);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 19);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "0";
            this.lblStatus.UseCustomBackColor = true;
            this.lblStatus.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(565, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // StartFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartFactory.Properties.Resources.bulbbw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::SmartFactory.Properties.Resources.bulbbw;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomRight;
            this.BackMaxSize = 3000;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "StartFactory";
            this.Load += new System.EventHandler(this.StartFactory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroButton btnStop;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}