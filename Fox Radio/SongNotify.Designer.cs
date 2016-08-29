namespace Fox_Radio
{
	partial class SongNotify
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
			this.APP_TITLE = new System.Windows.Forms.Label();
			this.SONG_NAME = new System.Windows.Forms.Label();
			this.SONG_AUTHOR = new System.Windows.Forms.Label();
			this.APP_DESC = new System.Windows.Forms.Label();
			this.SONG_ALBUM_ART = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.SONG_ALBUM_ART)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_TITLE.Location = new System.Drawing.Point(13, 9);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(89, 20);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "현재 재생중";
			// 
			// SONG_NAME
			// 
			this.SONG_NAME.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_NAME.Location = new System.Drawing.Point(6, 148);
			this.SONG_NAME.Name = "SONG_NAME";
			this.SONG_NAME.Size = new System.Drawing.Size(215, 20);
			this.SONG_NAME.TabIndex = 1;
			this.SONG_NAME.Text = "음악 제목";
			this.SONG_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SONG_AUTHOR
			// 
			this.SONG_AUTHOR.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_AUTHOR.Location = new System.Drawing.Point(6, 170);
			this.SONG_AUTHOR.Name = "SONG_AUTHOR";
			this.SONG_AUTHOR.Size = new System.Drawing.Size(215, 19);
			this.SONG_AUTHOR.TabIndex = 2;
			this.SONG_AUTHOR.Text = "음악 가수";
			this.SONG_AUTHOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// APP_DESC
			// 
			this.APP_DESC.AutoSize = true;
			this.APP_DESC.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_DESC.Location = new System.Drawing.Point(157, 13);
			this.APP_DESC.Name = "APP_DESC";
			this.APP_DESC.Size = new System.Drawing.Size(58, 13);
			this.APP_DESC.TabIndex = 4;
			this.APP_DESC.Text = "Fox Radio";
			this.APP_DESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SONG_ALBUM_ART
			// 
			this.SONG_ALBUM_ART.Image = global::Fox_Radio.Properties.Resources.DEFAULT_ALBUM_ART;
			this.SONG_ALBUM_ART.Location = new System.Drawing.Point(63, 41);
			this.SONG_ALBUM_ART.Name = "SONG_ALBUM_ART";
			this.SONG_ALBUM_ART.Size = new System.Drawing.Size(100, 100);
			this.SONG_ALBUM_ART.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SONG_ALBUM_ART.TabIndex = 3;
			this.SONG_ALBUM_ART.TabStop = false;
			this.SONG_ALBUM_ART.Paint += new System.Windows.Forms.PaintEventHandler(this.SONG_ALBUM_ART_Paint);
			// 
			// SongNotify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(227, 207);
			this.Controls.Add(this.APP_DESC);
			this.Controls.Add(this.SONG_ALBUM_ART);
			this.Controls.Add(this.SONG_AUTHOR);
			this.Controls.Add(this.SONG_NAME);
			this.Controls.Add(this.APP_TITLE);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SongNotify";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "현재 스트리밍 중";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.SongNotify_Load);
			((System.ComponentModel.ISupportInitialize)(this.SONG_ALBUM_ART)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.Label SONG_NAME;
		private System.Windows.Forms.Label SONG_AUTHOR;
		private System.Windows.Forms.PictureBox SONG_ALBUM_ART;
		private System.Windows.Forms.Label APP_DESC;
	}
}