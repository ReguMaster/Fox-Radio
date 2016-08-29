namespace Fox_Radio
{
	partial class Info
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.PANEL_TITLE = new System.Windows.Forms.Label();
			this.APP_ICON = new System.Windows.Forms.PictureBox();
			this.APP_NAME = new System.Windows.Forms.Label();
			this.SYS_close_button = new System.Windows.Forms.PictureBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameKORLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.iconPicture = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.PANEL_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.APP_ICON);
			this.APP_TITLE_BAR.Controls.Add(this.APP_NAME);
			this.APP_TITLE_BAR.Controls.Add(this.SYS_close_button);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(438, 35);
			this.APP_TITLE_BAR.TabIndex = 22;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			this.APP_TITLE_BAR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseUp);
			// 
			// PANEL_TITLE
			// 
			this.PANEL_TITLE.AutoSize = true;
			this.PANEL_TITLE.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PANEL_TITLE.Location = new System.Drawing.Point(114, 10);
			this.PANEL_TITLE.Name = "PANEL_TITLE";
			this.PANEL_TITLE.Size = new System.Drawing.Size(83, 15);
			this.PANEL_TITLE.TabIndex = 41;
			this.PANEL_TITLE.Text = "프로그램 정보";
			// 
			// APP_ICON
			// 
			this.APP_ICON.BackColor = System.Drawing.Color.White;
			this.APP_ICON.Image = global::Fox_Radio.Properties.Resources.APP_ICON_25x25;
			this.APP_ICON.Location = new System.Drawing.Point(6, 5);
			this.APP_ICON.Name = "APP_ICON";
			this.APP_ICON.Size = new System.Drawing.Size(25, 25);
			this.APP_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_ICON.TabIndex = 36;
			this.APP_ICON.TabStop = false;
			// 
			// APP_NAME
			// 
			this.APP_NAME.AutoSize = true;
			this.APP_NAME.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_NAME.Location = new System.Drawing.Point(38, 9);
			this.APP_NAME.Name = "APP_NAME";
			this.APP_NAME.Size = new System.Drawing.Size(70, 17);
			this.APP_NAME.TabIndex = 35;
			this.APP_NAME.Text = "Fox Radio";
			// 
			// SYS_close_button
			// 
			this.SYS_close_button.BackColor = System.Drawing.Color.Transparent;
			this.SYS_close_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SYS_close_button.Image = global::Fox_Radio.Properties.Resources.SYS_close_button;
			this.SYS_close_button.Location = new System.Drawing.Point(411, 7);
			this.SYS_close_button.Name = "SYS_close_button";
			this.SYS_close_button.Size = new System.Drawing.Size(20, 20);
			this.SYS_close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SYS_close_button.TabIndex = 18;
			this.SYS_close_button.TabStop = false;
			this.SYS_close_button.Click += new System.EventHandler(this.SYS_close_button_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.nameLabel.Location = new System.Drawing.Point(112, 42);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(102, 25);
			this.nameLabel.TabIndex = 36;
			this.nameLabel.Text = "Fox Radio";
			// 
			// nameKORLabel
			// 
			this.nameKORLabel.AutoSize = true;
			this.nameKORLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.nameKORLabel.Location = new System.Drawing.Point(114, 69);
			this.nameKORLabel.Name = "nameKORLabel";
			this.nameKORLabel.Size = new System.Drawing.Size(78, 17);
			this.nameKORLabel.TabIndex = 38;
			this.nameKORLabel.Text = "폭스 라디오";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.versionLabel.Location = new System.Drawing.Point(375, 141);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(56, 17);
			this.versionLabel.TabIndex = 39;
			this.versionLabel.Text = "버전 1.0";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.copyrightLabel.Location = new System.Drawing.Point(3, 147);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(201, 13);
			this.copyrightLabel.TabIndex = 40;
			this.copyrightLabel.Text = "Copyright © DeveloFOX Studio 2016";
			// 
			// iconPicture
			// 
			this.iconPicture.BackColor = System.Drawing.Color.Transparent;
			this.iconPicture.Image = global::Fox_Radio.Properties.Resources.APP_ICON;
			this.iconPicture.Location = new System.Drawing.Point(6, 42);
			this.iconPicture.Name = "iconPicture";
			this.iconPicture.Size = new System.Drawing.Size(100, 100);
			this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconPicture.TabIndex = 37;
			this.iconPicture.TabStop = false;
			// 
			// Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(438, 165);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.nameKORLabel);
			this.Controls.Add(this.iconPicture);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Info";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Fox Radio";
			this.Load += new System.EventHandler(this.Info_Load);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.PictureBox SYS_close_button;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		public System.Windows.Forms.PictureBox APP_ICON;
		private System.Windows.Forms.Label APP_NAME;
		private System.Windows.Forms.Label nameLabel;
		public System.Windows.Forms.PictureBox iconPicture;
		private System.Windows.Forms.Label nameKORLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label copyrightLabel;
		public System.Windows.Forms.Label PANEL_TITLE;
	}
}