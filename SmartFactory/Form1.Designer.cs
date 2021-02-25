namespace SmartFactory
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.bt_addP = new MetroFramework.Controls.MetroTile();
            this.bt_conP = new MetroFramework.Controls.MetroTile();
            this.bt_addinFo = new MetroFramework.Controls.MetroTile();
            this.bt_Pro = new MetroFramework.Controls.MetroTile();
            this.bt_pConsult = new MetroFramework.Controls.MetroTile();
            this.bt_addPart = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(97, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "GORONG FACTORY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_addP
            // 
            this.bt_addP.ActiveControl = null;
            this.bt_addP.Location = new System.Drawing.Point(54, 174);
            this.bt_addP.Name = "bt_addP";
            this.bt_addP.Size = new System.Drawing.Size(328, 241);
            this.bt_addP.TabIndex = 14;
            this.bt_addP.Text = "제품 추가";
            this.bt_addP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_addP.TileImage = global::SmartFactory.Properties.Resources.product;
            this.bt_addP.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_addP.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bt_addP.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bt_addP.UseSelectable = true;
            this.bt_addP.UseTileImage = true;
            this.bt_addP.Click += new System.EventHandler(this.bt_addP_Click);
            // 
            // bt_conP
            // 
            this.bt_conP.ActiveControl = null;
            this.bt_conP.Location = new System.Drawing.Point(388, 174);
            this.bt_conP.Name = "bt_conP";
            this.bt_conP.Size = new System.Drawing.Size(206, 118);
            this.bt_conP.TabIndex = 15;
            this.bt_conP.Text = "제품 관리";
            this.bt_conP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_conP.TileImage = global::SmartFactory.Properties.Resources.product_management_32px;
            this.bt_conP.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_conP.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bt_conP.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bt_conP.UseSelectable = true;
            this.bt_conP.UseTileImage = true;
            this.bt_conP.Click += new System.EventHandler(this.bt_conP_Click);
            // 
            // bt_addinFo
            // 
            this.bt_addinFo.ActiveControl = null;
            this.bt_addinFo.Location = new System.Drawing.Point(388, 298);
            this.bt_addinFo.Name = "bt_addinFo";
            this.bt_addinFo.Size = new System.Drawing.Size(206, 117);
            this.bt_addinFo.TabIndex = 16;
            this.bt_addinFo.Text = "제품별 부품추가";
            this.bt_addinFo.TileImage = global::SmartFactory.Properties.Resources.test;
            this.bt_addinFo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_addinFo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bt_addinFo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bt_addinFo.UseSelectable = true;
            this.bt_addinFo.UseTileImage = true;
            this.bt_addinFo.Click += new System.EventHandler(this.bt_addinFo_Click);
            // 
            // bt_Pro
            // 
            this.bt_Pro.ActiveControl = null;
            this.bt_Pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_Pro.Location = new System.Drawing.Point(54, 421);
            this.bt_Pro.Name = "bt_Pro";
            this.bt_Pro.Size = new System.Drawing.Size(540, 114);
            this.bt_Pro.TabIndex = 17;
            this.bt_Pro.Text = "공정현황";
            this.bt_Pro.TileImage = global::SmartFactory.Properties.Resources.workflow_100px;
            this.bt_Pro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Pro.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bt_Pro.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bt_Pro.UseCustomBackColor = true;
            this.bt_Pro.UseSelectable = true;
            this.bt_Pro.UseStyleColors = true;
            this.bt_Pro.UseTileImage = true;
            this.bt_Pro.Click += new System.EventHandler(this.bt_Pro_Click);
            // 
            // bt_pConsult
            // 
            this.bt_pConsult.ActiveControl = null;
            this.bt_pConsult.Location = new System.Drawing.Point(600, 174);
            this.bt_pConsult.Name = "bt_pConsult";
            this.bt_pConsult.Size = new System.Drawing.Size(299, 117);
            this.bt_pConsult.TabIndex = 18;
            this.bt_pConsult.Text = "부품관리";
            this.bt_pConsult.TileImage = global::SmartFactory.Properties.Resources.ci;
            this.bt_pConsult.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_pConsult.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bt_pConsult.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bt_pConsult.UseSelectable = true;
            this.bt_pConsult.UseTileImage = true;
            this.bt_pConsult.Click += new System.EventHandler(this.bt_pConsult_Click);
            // 
            // bt_addPart
            // 
            this.bt_addPart.ActiveControl = null;
            this.bt_addPart.Location = new System.Drawing.Point(600, 298);
            this.bt_addPart.Name = "bt_addPart";
            this.bt_addPart.Size = new System.Drawing.Size(299, 237);
            this.bt_addPart.TabIndex = 19;
            this.bt_addPart.Text = "부품 추가";
            this.bt_addPart.TileImage = global::SmartFactory.Properties.Resources.gear_fix;
            this.bt_addPart.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_addPart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bt_addPart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bt_addPart.UseSelectable = true;
            this.bt_addPart.UseTileImage = true;
            this.bt_addPart.Click += new System.EventHandler(this.bt_addPart_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel1.Location = new System.Drawing.Point(54, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "생산";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(498, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "부품";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(430, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "V 1.0.0.0";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SmartFactory.Properties.Resources.bulbbw;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomRight;
            this.BackMaxSize = 3000;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(954, 551);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bt_addPart);
            this.Controls.Add(this.bt_pConsult);
            this.Controls.Add(this.bt_Pro);
            this.Controls.Add(this.bt_addinFo);
            this.Controls.Add(this.bt_conP);
            this.Controls.Add(this.bt_addP);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightSlateGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile bt_addP;
        private MetroFramework.Controls.MetroTile bt_conP;
        private MetroFramework.Controls.MetroTile bt_addinFo;
        private MetroFramework.Controls.MetroTile bt_Pro;
        private MetroFramework.Controls.MetroTile bt_pConsult;
        private MetroFramework.Controls.MetroTile bt_addPart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

