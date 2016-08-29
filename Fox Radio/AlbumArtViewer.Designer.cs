namespace Fox_Radio
{
	partial class AlbumArtViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumArtViewer));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.PANEL_TITLE = new System.Windows.Forms.Label();
			this.APP_ICON = new System.Windows.Forms.PictureBox();
			this.APP_NAME = new System.Windows.Forms.Label();
			this.SYS_close_button = new System.Windows.Forms.PictureBox();
			this.ALBUM_ART = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ALBUM_ART)).BeginInit();
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
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(427, 35);
			this.APP_TITLE_BAR.TabIndex = 21;
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
			this.PANEL_TITLE.Size = new System.Drawing.Size(59, 15);
			this.PANEL_TITLE.TabIndex = 36;
			this.PANEL_TITLE.Text = "앨범 사진";
			// 
			// APP_ICON
			// 
			this.APP_ICON.BackColor = System.Drawing.Color.White;
			this.APP_ICON.Image = global::Fox_Radio.Properties.Resources.APP_ICON_25x25;
			this.APP_ICON.Location = new System.Drawing.Point(7, 5);
			this.APP_ICON.Name = "APP_ICON";
			this.APP_ICON.Size = new System.Drawing.Size(25, 25);
			this.APP_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_ICON.TabIndex = 35;
			this.APP_ICON.TabStop = false;
			// 
			// APP_NAME
			// 
			this.APP_NAME.AutoSize = true;
			this.APP_NAME.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_NAME.Location = new System.Drawing.Point(38, 9);
			this.APP_NAME.Name = "APP_NAME";
			this.APP_NAME.Size = new System.Drawing.Size(70, 17);
			this.APP_NAME.TabIndex = 21;
			this.APP_NAME.Text = "Fox Radio";
			// 
			// SYS_close_button
			// 
			this.SYS_close_button.BackColor = System.Drawing.Color.Transparent;
			this.SYS_close_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SYS_close_button.Image = global::Fox_Radio.Properties.Resources.SYS_close_button;
			this.SYS_close_button.Location = new System.Drawing.Point(399, 7);
			this.SYS_close_button.Name = "SYS_close_button";
			this.SYS_close_button.Size = new System.Drawing.Size(20, 20);
			this.SYS_close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SYS_close_button.TabIndex = 18;
			this.SYS_close_button.TabStop = false;
			this.SYS_close_button.Click += new System.EventHandler(this.SYS_close_button_Click);
			// 
			// ALBUM_ART
			// 
			this.ALBUM_ART.Image = global::Fox_Radio.Properties.Resources.DEFAULT_ALBUM_ART;
			this.ALBUM_ART.Location = new System.Drawing.Point(7, 41);
			this.ALBUM_ART.Name = "ALBUM_ART";
			this.ALBUM_ART.Size = new System.Drawing.Size(412, 412);
			this.ALBUM_ART.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ALBUM_ART.TabIndex = 22;
			this.ALBUM_ART.TabStop = false;
			this.ALBUM_ART.Click += new System.EventHandler(this.ALBUM_ART_Click);
			// 
			// AlbumArtViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(427, 461);
			this.Controls.Add(this.ALBUM_ART);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlbumArtViewer";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Fox Radio";
			this.Load += new System.EventHandler(this.AlbumArtViewer_Load);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ALBUM_ART)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label APP_NAME;
		public System.Windows.Forms.PictureBox SYS_close_button;
		private System.Windows.Forms.PictureBox ALBUM_ART;
		public System.Windows.Forms.PictureBox APP_ICON;
		public System.Windows.Forms.Label PANEL_TITLE;
	}
}