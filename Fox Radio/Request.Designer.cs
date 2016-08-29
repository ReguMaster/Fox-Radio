namespace Fox_Radio
{
	partial class Request
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
			this.SONG_REQUEST_BUTTON = new System.Windows.Forms.Button();
			this.SONG_AUTHOR_TEXTBOX = new System.Windows.Forms.TextBox();
			this.SONG_AUTHOR = new System.Windows.Forms.Label();
			this.SONG_NAME_TEXTBOX = new System.Windows.Forms.TextBox();
			this.SONG_NAME = new System.Windows.Forms.Label();
			this.SONG_DESC = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_ICON = new System.Windows.Forms.PictureBox();
			this.PANEL_TITLE = new System.Windows.Forms.Label();
			this.APP_NAME = new System.Windows.Forms.Label();
			this.SYS_close_button = new System.Windows.Forms.PictureBox();
			this.SONG_DESC_TEXTBOX = new System.Windows.Forms.TextBox();
			this.WARNING_DESC = new System.Windows.Forms.Label();
			this.WARNING_ICON = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WARNING_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// SONG_REQUEST_BUTTON
			// 
			this.SONG_REQUEST_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SONG_REQUEST_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_REQUEST_BUTTON.ForeColor = System.Drawing.Color.Black;
			this.SONG_REQUEST_BUTTON.Location = new System.Drawing.Point(332, 210);
			this.SONG_REQUEST_BUTTON.Name = "SONG_REQUEST_BUTTON";
			this.SONG_REQUEST_BUTTON.Size = new System.Drawing.Size(101, 29);
			this.SONG_REQUEST_BUTTON.TabIndex = 50;
			this.SONG_REQUEST_BUTTON.Text = "음악 요청";
			this.SONG_REQUEST_BUTTON.UseVisualStyleBackColor = true;
			this.SONG_REQUEST_BUTTON.Click += new System.EventHandler(this.SONG_REQUEST_BUTTON_Click);
			// 
			// SONG_AUTHOR_TEXTBOX
			// 
			this.SONG_AUTHOR_TEXTBOX.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_AUTHOR_TEXTBOX.Location = new System.Drawing.Point(12, 118);
			this.SONG_AUTHOR_TEXTBOX.MaxLength = 30;
			this.SONG_AUTHOR_TEXTBOX.Name = "SONG_AUTHOR_TEXTBOX";
			this.SONG_AUTHOR_TEXTBOX.Size = new System.Drawing.Size(421, 23);
			this.SONG_AUTHOR_TEXTBOX.TabIndex = 46;
			// 
			// SONG_AUTHOR
			// 
			this.SONG_AUTHOR.AutoSize = true;
			this.SONG_AUTHOR.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
			this.SONG_AUTHOR.Location = new System.Drawing.Point(9, 100);
			this.SONG_AUTHOR.Name = "SONG_AUTHOR";
			this.SONG_AUTHOR.Size = new System.Drawing.Size(59, 15);
			this.SONG_AUTHOR.TabIndex = 45;
			this.SONG_AUTHOR.Text = "음악 가수";
			// 
			// SONG_NAME_TEXTBOX
			// 
			this.SONG_NAME_TEXTBOX.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_NAME_TEXTBOX.Location = new System.Drawing.Point(12, 65);
			this.SONG_NAME_TEXTBOX.MaxLength = 50;
			this.SONG_NAME_TEXTBOX.Name = "SONG_NAME_TEXTBOX";
			this.SONG_NAME_TEXTBOX.Size = new System.Drawing.Size(421, 23);
			this.SONG_NAME_TEXTBOX.TabIndex = 44;
			// 
			// SONG_NAME
			// 
			this.SONG_NAME.AutoSize = true;
			this.SONG_NAME.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_NAME.Location = new System.Drawing.Point(9, 43);
			this.SONG_NAME.Name = "SONG_NAME";
			this.SONG_NAME.Size = new System.Drawing.Size(59, 15);
			this.SONG_NAME.TabIndex = 43;
			this.SONG_NAME.Text = "음악 이름";
			// 
			// SONG_DESC
			// 
			this.SONG_DESC.AutoSize = true;
			this.SONG_DESC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
			this.SONG_DESC.Location = new System.Drawing.Point(9, 152);
			this.SONG_DESC.Name = "SONG_DESC";
			this.SONG_DESC.Size = new System.Drawing.Size(31, 15);
			this.SONG_DESC.TabIndex = 47;
			this.SONG_DESC.Text = "설명";
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.APP_ICON);
			this.APP_TITLE_BAR.Controls.Add(this.PANEL_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.APP_NAME);
			this.APP_TITLE_BAR.Controls.Add(this.SYS_close_button);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(445, 35);
			this.APP_TITLE_BAR.TabIndex = 53;
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			this.APP_TITLE_BAR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseUp);
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
			// 
			// PANEL_TITLE
			// 
			this.PANEL_TITLE.AutoSize = true;
			this.PANEL_TITLE.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PANEL_TITLE.Location = new System.Drawing.Point(112, 10);
			this.PANEL_TITLE.Name = "PANEL_TITLE";
			this.PANEL_TITLE.Size = new System.Drawing.Size(59, 15);
			this.PANEL_TITLE.TabIndex = 28;
			this.PANEL_TITLE.Text = "음악 요청";
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
			// SONG_DESC_TEXTBOX
			// 
			this.SONG_DESC_TEXTBOX.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SONG_DESC_TEXTBOX.Location = new System.Drawing.Point(12, 173);
			this.SONG_DESC_TEXTBOX.MaxLength = 30;
			this.SONG_DESC_TEXTBOX.Name = "SONG_DESC_TEXTBOX";
			this.SONG_DESC_TEXTBOX.Size = new System.Drawing.Size(421, 23);
			this.SONG_DESC_TEXTBOX.TabIndex = 48;
			// 
			// WARNING_DESC
			// 
			this.WARNING_DESC.AutoSize = true;
			this.WARNING_DESC.Cursor = System.Windows.Forms.Cursors.Default;
			this.WARNING_DESC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARNING_DESC.Location = new System.Drawing.Point(38, 220);
			this.WARNING_DESC.Name = "WARNING_DESC";
			this.WARNING_DESC.Size = new System.Drawing.Size(230, 15);
			this.WARNING_DESC.TabIndex = 56;
			this.WARNING_DESC.Text = "모든 요청 사항을 올바르게 입력하십시오.";
			// 
			// WARNING_ICON
			// 
			this.WARNING_ICON.BackColor = System.Drawing.Color.White;
			this.WARNING_ICON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WARNING_ICON.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.WARNING_ICON.Image = global::Fox_Radio.Properties.Resources.SYS_info_button;
			this.WARNING_ICON.Location = new System.Drawing.Point(12, 217);
			this.WARNING_ICON.Name = "WARNING_ICON";
			this.WARNING_ICON.Size = new System.Drawing.Size(20, 20);
			this.WARNING_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.WARNING_ICON.TabIndex = 57;
			this.WARNING_ICON.TabStop = false;
			// 
			// Request
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(445, 251);
			this.Controls.Add(this.WARNING_ICON);
			this.Controls.Add(this.WARNING_DESC);
			this.Controls.Add(this.SONG_DESC_TEXTBOX);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.SONG_DESC);
			this.Controls.Add(this.SONG_REQUEST_BUTTON);
			this.Controls.Add(this.SONG_AUTHOR_TEXTBOX);
			this.Controls.Add(this.SONG_AUTHOR);
			this.Controls.Add(this.SONG_NAME_TEXTBOX);
			this.Controls.Add(this.SONG_NAME);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Request";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Fox Radio";
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SYS_close_button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WARNING_ICON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button SONG_REQUEST_BUTTON;
		private System.Windows.Forms.TextBox SONG_AUTHOR_TEXTBOX;
		public System.Windows.Forms.Label SONG_AUTHOR;
		private System.Windows.Forms.TextBox SONG_NAME_TEXTBOX;
		public System.Windows.Forms.Label SONG_NAME;
		public System.Windows.Forms.Label SONG_DESC;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		public System.Windows.Forms.PictureBox APP_ICON;
		public System.Windows.Forms.Label PANEL_TITLE;
		private System.Windows.Forms.Label APP_NAME;
		public System.Windows.Forms.PictureBox SYS_close_button;
		private System.Windows.Forms.TextBox SONG_DESC_TEXTBOX;
		public System.Windows.Forms.Label WARNING_DESC;
		public System.Windows.Forms.PictureBox WARNING_ICON;
	}
}