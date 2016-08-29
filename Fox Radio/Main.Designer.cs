namespace Fox_Radio
{
	partial class Main
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.PANEL_TITLE = new System.Windows.Forms.Label();
			this.APP_NAME = new System.Windows.Forms.Label();
			this.SONG_TITLE_LABEL = new System.Windows.Forms.Label();
			this.SONG_AUTHOR_LABEL = new System.Windows.Forms.Label();
			this.APP_MUSIC_PANEL = new System.Windows.Forms.Panel();
			this.SONG_REQUEST_BUTTON = new System.Windows.Forms.Button();
			this.SONG_LYRICS = new System.Windows.Forms.Label();
			this.VOLUME_BAR = new System.Windows.Forms.TrackBar();
			this.SERVER_CONNECTED_TEXT = new System.Windows.Forms.Label();
			this.SONG_TIME = new System.Windows.Forms.Label();
			this.SONG_TRACKBAR_MAX = new System.Windows.Forms.Panel();
			this.SONG_TRACKBAR = new System.Windows.Forms.Panel();
			this.APP_LOADING_LABEL = new System.Windows.Forms.Label();
			this.nextServerLoadingLabel = new System.Windows.Forms.Label();
			this.APP_NOTIFY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
			this.APP_NOTIFY_ICON_MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.APP_NOTIFY_ICON_MENU_OPTION_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.APP_NOTIFY_ICON_MENU_OPTION_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.APP_NOTIFY_ICON_MENU_OPTION_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.APP_ICON = new System.Windows.Forms.PictureBox();
			this.SYS_min_button = new System.Windows.Forms.PictureBox();
			this.SYS_close_button = new System.Windows.Forms.PictureBox();
			this.SONG_ALBUM_ART = new System.Windows.Forms.PictureBox();
			this.VOLUME_ICON = new System.Windows.Forms.PictureBox();
			this.SERVER_CONNECTED_ICON = new System.Windows.Forms.PictureBox();
			this.APP_LOADING_ICON = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			this.APP_MUSIC_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VOLUME_BAR)).BeginInit();
			this.SONG_TRACKBAR_MAX.SuspendLayout();
			this.APP_NOTIFY_ICON_MENU.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_min_button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SONG_ALBUM_ART)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VOLUME_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SERVER_CONNECTED_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOADING_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.APP_ICON);
			this.APP_TITLE_BAR.Controls.Add(this.PANEL_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.APP_NAME);
			this.APP_TITLE_BAR.Controls.Add(this.SYS_min_button);
			this.APP_TITLE_BAR.Controls.Add(this.SYS_close_button);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(445, 35);
			this.APP_TITLE_BAR.TabIndex = 20;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			this.APP_TITLE_BAR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseUp);
			// 
			// PANEL_TITLE
			// 
			this.PANEL_TITLE.AutoSize = true;
			this.PANEL_TITLE.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PANEL_TITLE.Location = new System.Drawing.Point(112, 10);
			this.PANEL_TITLE.Name = "PANEL_TITLE";
			this.PANEL_TITLE.Size = new System.Drawing.Size(60, 15);
			this.PANEL_TITLE.TabIndex = 28;
			this.PANEL_TITLE.Text = "연결 중 ...";
			// 
			// APP_NAME
			// 
			this.APP_NAME.AutoSize = true;
			this.APP_NAME.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_NAME.Location = new System.Drawing.Point(36, 9);
			this.APP_NAME.Name = "APP_NAME";
			this.APP_NAME.Size = new System.Drawing.Size(70, 17);
			this.APP_NAME.TabIndex = 21;
			this.APP_NAME.Text = "Fox Radio";
			// 
			// SONG_TITLE_LABEL
			// 
			this.SONG_TITLE_LABEL.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_TITLE_LABEL.Location = new System.Drawing.Point(139, 3);
			this.SONG_TITLE_LABEL.Name = "SONG_TITLE_LABEL";
			this.SONG_TITLE_LABEL.Size = new System.Drawing.Size(294, 25);
			this.SONG_TITLE_LABEL.TabIndex = 22;
			this.SONG_TITLE_LABEL.Text = "노래 제목";
			this.SONG_TITLE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SONG_AUTHOR_LABEL
			// 
			this.SONG_AUTHOR_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.SONG_AUTHOR_LABEL.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_AUTHOR_LABEL.Location = new System.Drawing.Point(141, 31);
			this.SONG_AUTHOR_LABEL.Name = "SONG_AUTHOR_LABEL";
			this.SONG_AUTHOR_LABEL.Size = new System.Drawing.Size(290, 17);
			this.SONG_AUTHOR_LABEL.TabIndex = 23;
			this.SONG_AUTHOR_LABEL.Text = "노래 가수";
			this.SONG_AUTHOR_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// APP_MUSIC_PANEL
			// 
			this.APP_MUSIC_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_REQUEST_BUTTON);
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_ALBUM_ART);
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_LYRICS);
			this.APP_MUSIC_PANEL.Controls.Add(this.VOLUME_ICON);
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_TITLE_LABEL);
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_AUTHOR_LABEL);
			this.APP_MUSIC_PANEL.Controls.Add(this.VOLUME_BAR);
			this.APP_MUSIC_PANEL.Controls.Add(this.SERVER_CONNECTED_ICON);
			this.APP_MUSIC_PANEL.Controls.Add(this.SERVER_CONNECTED_TEXT);
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_TIME);
			this.APP_MUSIC_PANEL.Controls.Add(this.SONG_TRACKBAR_MAX);
			this.APP_MUSIC_PANEL.Location = new System.Drawing.Point(5, 33);
			this.APP_MUSIC_PANEL.Name = "APP_MUSIC_PANEL";
			this.APP_MUSIC_PANEL.Size = new System.Drawing.Size(436, 239);
			this.APP_MUSIC_PANEL.TabIndex = 24;
			// 
			// SONG_REQUEST_BUTTON
			// 
			this.SONG_REQUEST_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SONG_REQUEST_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_REQUEST_BUTTON.ForeColor = System.Drawing.Color.Black;
			this.SONG_REQUEST_BUTTON.Location = new System.Drawing.Point(3, 139);
			this.SONG_REQUEST_BUTTON.Name = "SONG_REQUEST_BUTTON";
			this.SONG_REQUEST_BUTTON.Size = new System.Drawing.Size(130, 26);
			this.SONG_REQUEST_BUTTON.TabIndex = 51;
			this.SONG_REQUEST_BUTTON.Text = "음악 요청";
			this.SONG_REQUEST_BUTTON.UseVisualStyleBackColor = true;
			this.SONG_REQUEST_BUTTON.Click += new System.EventHandler(this.SONG_REQUEST_BUTTON_Click);
			// 
			// SONG_LYRICS
			// 
			this.SONG_LYRICS.BackColor = System.Drawing.Color.Transparent;
			this.SONG_LYRICS.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_LYRICS.Location = new System.Drawing.Point(141, 144);
			this.SONG_LYRICS.Name = "SONG_LYRICS";
			this.SONG_LYRICS.Size = new System.Drawing.Size(290, 58);
			this.SONG_LYRICS.TabIndex = 35;
			// 
			// VOLUME_BAR
			// 
			this.VOLUME_BAR.BackColor = System.Drawing.Color.White;
			this.VOLUME_BAR.Location = new System.Drawing.Point(34, 213);
			this.VOLUME_BAR.Maximum = 100;
			this.VOLUME_BAR.Name = "VOLUME_BAR";
			this.VOLUME_BAR.Size = new System.Drawing.Size(114, 45);
			this.VOLUME_BAR.TabIndex = 29;
			this.VOLUME_BAR.TabStop = false;
			this.VOLUME_BAR.TickStyle = System.Windows.Forms.TickStyle.None;
			this.VOLUME_BAR.Value = 50;
			this.VOLUME_BAR.Scroll += new System.EventHandler(this.VOLUME_BAR_Scroll);
			// 
			// SERVER_CONNECTED_TEXT
			// 
			this.SERVER_CONNECTED_TEXT.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SERVER_CONNECTED_TEXT.Location = new System.Drawing.Point(277, 215);
			this.SERVER_CONNECTED_TEXT.Name = "SERVER_CONNECTED_TEXT";
			this.SERVER_CONNECTED_TEXT.Size = new System.Drawing.Size(126, 15);
			this.SERVER_CONNECTED_TEXT.TabIndex = 26;
			this.SERVER_CONNECTED_TEXT.Text = "연결됨";
			this.SERVER_CONNECTED_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SONG_TIME
			// 
			this.SONG_TIME.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_TIME.Location = new System.Drawing.Point(351, 107);
			this.SONG_TIME.Name = "SONG_TIME";
			this.SONG_TIME.Size = new System.Drawing.Size(79, 17);
			this.SONG_TIME.TabIndex = 24;
			this.SONG_TIME.Text = "0:00 / 0:00";
			this.SONG_TIME.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// SONG_TRACKBAR_MAX
			// 
			this.SONG_TRACKBAR_MAX.BackColor = System.Drawing.Color.WhiteSmoke;
			this.SONG_TRACKBAR_MAX.Controls.Add(this.SONG_TRACKBAR);
			this.SONG_TRACKBAR_MAX.Location = new System.Drawing.Point(144, 129);
			this.SONG_TRACKBAR_MAX.Name = "SONG_TRACKBAR_MAX";
			this.SONG_TRACKBAR_MAX.Size = new System.Drawing.Size(280, 5);
			this.SONG_TRACKBAR_MAX.TabIndex = 37;
			// 
			// SONG_TRACKBAR
			// 
			this.SONG_TRACKBAR.BackColor = System.Drawing.Color.DimGray;
			this.SONG_TRACKBAR.Location = new System.Drawing.Point(0, 0);
			this.SONG_TRACKBAR.Name = "SONG_TRACKBAR";
			this.SONG_TRACKBAR.Size = new System.Drawing.Size(0, 5);
			this.SONG_TRACKBAR.TabIndex = 36;
			// 
			// APP_LOADING_LABEL
			// 
			this.APP_LOADING_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.APP_LOADING_LABEL.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_LOADING_LABEL.Location = new System.Drawing.Point(5, 165);
			this.APP_LOADING_LABEL.Name = "APP_LOADING_LABEL";
			this.APP_LOADING_LABEL.Size = new System.Drawing.Size(433, 17);
			this.APP_LOADING_LABEL.TabIndex = 25;
			this.APP_LOADING_LABEL.Text = "Fox Radio 서버에 연결 하는 중 ...";
			this.APP_LOADING_LABEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// nextServerLoadingLabel
			// 
			this.nextServerLoadingLabel.BackColor = System.Drawing.Color.Transparent;
			this.nextServerLoadingLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.nextServerLoadingLabel.Location = new System.Drawing.Point(4, 187);
			this.nextServerLoadingLabel.Name = "nextServerLoadingLabel";
			this.nextServerLoadingLabel.Size = new System.Drawing.Size(434, 18);
			this.nextServerLoadingLabel.TabIndex = 29;
			this.nextServerLoadingLabel.Text = "10 초 후 재접속 합니다 ..";
			this.nextServerLoadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// APP_NOTIFY_ICON
			// 
			this.APP_NOTIFY_ICON.ContextMenuStrip = this.APP_NOTIFY_ICON_MENU;
			this.APP_NOTIFY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("APP_NOTIFY_ICON.Icon")));
			this.APP_NOTIFY_ICON.Text = "Fox Radio";
			this.APP_NOTIFY_ICON.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.APP_NOTIFY_ICON_MouseDoubleClick);
			// 
			// APP_NOTIFY_ICON_MENU
			// 
			this.APP_NOTIFY_ICON_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.APP_NOTIFY_ICON_MENU_OPTION_1,
            this.APP_NOTIFY_ICON_MENU_OPTION_2,
            this.APP_NOTIFY_ICON_MENU_OPTION_3});
			this.APP_NOTIFY_ICON_MENU.Name = "APP_NOTIFY_ICON_MENU";
			this.APP_NOTIFY_ICON_MENU.Size = new System.Drawing.Size(156, 70);
			// 
			// APP_NOTIFY_ICON_MENU_OPTION_1
			// 
			this.APP_NOTIFY_ICON_MENU_OPTION_1.BackColor = System.Drawing.Color.White;
			this.APP_NOTIFY_ICON_MENU_OPTION_1.Name = "APP_NOTIFY_ICON_MENU_OPTION_1";
			this.APP_NOTIFY_ICON_MENU_OPTION_1.Size = new System.Drawing.Size(155, 22);
			this.APP_NOTIFY_ICON_MENU_OPTION_1.Text = "Fox Radio 열기";
			this.APP_NOTIFY_ICON_MENU_OPTION_1.Click += new System.EventHandler(this.APP_NOTIFY_ICON_MENU_OPTION_1_Click);
			// 
			// APP_NOTIFY_ICON_MENU_OPTION_2
			// 
			this.APP_NOTIFY_ICON_MENU_OPTION_2.BackColor = System.Drawing.Color.White;
			this.APP_NOTIFY_ICON_MENU_OPTION_2.Name = "APP_NOTIFY_ICON_MENU_OPTION_2";
			this.APP_NOTIFY_ICON_MENU_OPTION_2.Size = new System.Drawing.Size(155, 22);
			this.APP_NOTIFY_ICON_MENU_OPTION_2.Text = "Fox Radio 정보";
			this.APP_NOTIFY_ICON_MENU_OPTION_2.Click += new System.EventHandler(this.APP_NOTIFY_ICON_MENU_OPTION_2_Click);
			// 
			// APP_NOTIFY_ICON_MENU_OPTION_3
			// 
			this.APP_NOTIFY_ICON_MENU_OPTION_3.BackColor = System.Drawing.Color.White;
			this.APP_NOTIFY_ICON_MENU_OPTION_3.Name = "APP_NOTIFY_ICON_MENU_OPTION_3";
			this.APP_NOTIFY_ICON_MENU_OPTION_3.Size = new System.Drawing.Size(155, 22);
			this.APP_NOTIFY_ICON_MENU_OPTION_3.Text = "Fox Radio 종료";
			this.APP_NOTIFY_ICON_MENU_OPTION_3.Click += new System.EventHandler(this.APP_NOTIFY_ICON_MENU_OPTION_3_Click);
			// 
			// APP_ICON
			// 
			this.APP_ICON.BackColor = System.Drawing.Color.White;
			this.APP_ICON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.APP_ICON.Image = global::Fox_Radio.Properties.Resources.APP_ICON_25x25;
			this.APP_ICON.Location = new System.Drawing.Point(5, 5);
			this.APP_ICON.Name = "APP_ICON";
			this.APP_ICON.Size = new System.Drawing.Size(25, 25);
			this.APP_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_ICON.TabIndex = 34;
			this.APP_ICON.TabStop = false;
			this.APP_ICON.Click += new System.EventHandler(this.APP_ICON_Click);
			// 
			// SYS_min_button
			// 
			this.SYS_min_button.BackColor = System.Drawing.Color.Transparent;
			this.SYS_min_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SYS_min_button.Image = global::Fox_Radio.Properties.Resources.SYS_min_button;
			this.SYS_min_button.Location = new System.Drawing.Point(388, 7);
			this.SYS_min_button.Name = "SYS_min_button";
			this.SYS_min_button.Size = new System.Drawing.Size(20, 20);
			this.SYS_min_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SYS_min_button.TabIndex = 19;
			this.SYS_min_button.TabStop = false;
			this.SYS_min_button.Click += new System.EventHandler(this.SYS_min_button_Click);
			// 
			// SYS_close_button
			// 
			this.SYS_close_button.BackColor = System.Drawing.Color.Transparent;
			this.SYS_close_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SYS_close_button.Image = global::Fox_Radio.Properties.Resources.SYS_close_button;
			this.SYS_close_button.Location = new System.Drawing.Point(417, 7);
			this.SYS_close_button.Name = "SYS_close_button";
			this.SYS_close_button.Size = new System.Drawing.Size(20, 20);
			this.SYS_close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SYS_close_button.TabIndex = 18;
			this.SYS_close_button.TabStop = false;
			this.SYS_close_button.Click += new System.EventHandler(this.SYS_close_button_Click);
			// 
			// SONG_ALBUM_ART
			// 
			this.SONG_ALBUM_ART.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SONG_ALBUM_ART.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SONG_ALBUM_ART.Image = global::Fox_Radio.Properties.Resources.DEFAULT_ALBUM_ART;
			this.SONG_ALBUM_ART.Location = new System.Drawing.Point(3, 4);
			this.SONG_ALBUM_ART.Name = "SONG_ALBUM_ART";
			this.SONG_ALBUM_ART.Size = new System.Drawing.Size(130, 130);
			this.SONG_ALBUM_ART.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SONG_ALBUM_ART.TabIndex = 21;
			this.SONG_ALBUM_ART.TabStop = false;
			this.SONG_ALBUM_ART.Click += new System.EventHandler(this.SONG_ALBUM_ART_Click);
			this.SONG_ALBUM_ART.Paint += new System.Windows.Forms.PaintEventHandler(this.SONG_ALBUM_ART_Paint);
			// 
			// VOLUME_ICON
			// 
			this.VOLUME_ICON.Image = global::Fox_Radio.Properties.Resources.VOLUME_ICON;
			this.VOLUME_ICON.Location = new System.Drawing.Point(3, 210);
			this.VOLUME_ICON.Name = "VOLUME_ICON";
			this.VOLUME_ICON.Size = new System.Drawing.Size(25, 25);
			this.VOLUME_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VOLUME_ICON.TabIndex = 31;
			this.VOLUME_ICON.TabStop = false;
			// 
			// SERVER_CONNECTED_ICON
			// 
			this.SERVER_CONNECTED_ICON.Image = global::Fox_Radio.Properties.Resources.SERVER_CONNECT_ICON_small;
			this.SERVER_CONNECTED_ICON.Location = new System.Drawing.Point(408, 210);
			this.SERVER_CONNECTED_ICON.Name = "SERVER_CONNECTED_ICON";
			this.SERVER_CONNECTED_ICON.Size = new System.Drawing.Size(25, 25);
			this.SERVER_CONNECTED_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SERVER_CONNECTED_ICON.TabIndex = 27;
			this.SERVER_CONNECTED_ICON.TabStop = false;
			// 
			// APP_LOADING_ICON
			// 
			this.APP_LOADING_ICON.BackColor = System.Drawing.Color.Transparent;
			this.APP_LOADING_ICON.Image = global::Fox_Radio.Properties.Resources.CONNECT_ICON;
			this.APP_LOADING_ICON.Location = new System.Drawing.Point(194, 107);
			this.APP_LOADING_ICON.Name = "APP_LOADING_ICON";
			this.APP_LOADING_ICON.Size = new System.Drawing.Size(50, 50);
			this.APP_LOADING_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.APP_LOADING_ICON.TabIndex = 28;
			this.APP_LOADING_ICON.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(445, 273);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.APP_MUSIC_PANEL);
			this.Controls.Add(this.nextServerLoadingLabel);
			this.Controls.Add(this.APP_LOADING_ICON);
			this.Controls.Add(this.APP_LOADING_LABEL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Fox Radio";
			this.Load += new System.EventHandler(this.Main_Load);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			this.APP_MUSIC_PANEL.ResumeLayout(false);
			this.APP_MUSIC_PANEL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VOLUME_BAR)).EndInit();
			this.SONG_TRACKBAR_MAX.ResumeLayout(false);
			this.APP_NOTIFY_ICON_MENU.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_min_button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SONG_ALBUM_ART)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VOLUME_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SERVER_CONNECTED_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOADING_ICON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public System.Windows.Forms.PictureBox SYS_min_button;
		public System.Windows.Forms.PictureBox SYS_close_button;
		private System.Windows.Forms.Panel APP_TITLE_BAR;

		#endregion

		private System.Windows.Forms.Label APP_NAME;
		public System.Windows.Forms.PictureBox SONG_ALBUM_ART;
		public System.Windows.Forms.Label SONG_TITLE_LABEL;
		public System.Windows.Forms.Label SONG_AUTHOR_LABEL;
		public System.Windows.Forms.Panel APP_MUSIC_PANEL;
		public System.Windows.Forms.Label APP_LOADING_LABEL;
		public System.Windows.Forms.Label SONG_TIME;
		public System.Windows.Forms.Label SERVER_CONNECTED_TEXT;
		public System.Windows.Forms.PictureBox SERVER_CONNECTED_ICON;
		public System.Windows.Forms.PictureBox APP_LOADING_ICON;
		public System.Windows.Forms.Label PANEL_TITLE;
		public System.Windows.Forms.TrackBar VOLUME_BAR;
		public System.Windows.Forms.PictureBox VOLUME_ICON;
		public System.Windows.Forms.Label nextServerLoadingLabel;
		public System.Windows.Forms.PictureBox APP_ICON;
		private System.Windows.Forms.NotifyIcon APP_NOTIFY_ICON;
		private System.Windows.Forms.ContextMenuStrip APP_NOTIFY_ICON_MENU;
		private System.Windows.Forms.ToolStripMenuItem APP_NOTIFY_ICON_MENU_OPTION_1;
		private System.Windows.Forms.ToolStripMenuItem APP_NOTIFY_ICON_MENU_OPTION_2;
		private System.Windows.Forms.ToolStripMenuItem APP_NOTIFY_ICON_MENU_OPTION_3;
		public System.Windows.Forms.Label SONG_LYRICS;
		public System.Windows.Forms.Panel SONG_TRACKBAR;
		private System.Windows.Forms.Panel SONG_TRACKBAR_MAX;
		public System.Windows.Forms.Button SONG_REQUEST_BUTTON;
	}
}

