using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fox_Radio
{
	public partial class SongNotify : Form
	{
		private Timer timer;
		private Timer autoCloseTimer;
		private int startPosX, startPosY;
		private string songName;
		private string songAuthor;
		private Image songAlbumArt;

		public SongNotify( string songName, string songAuthor, Image songAlbumArt )
		{
			InitializeComponent( );

			this.songName = songName;
			this.songAuthor = songAuthor;
			this.songAlbumArt = songAlbumArt;

			autoCloseTimer = new Timer( );
			autoCloseTimer.Enabled = true;
			autoCloseTimer.Interval = 7000;
			autoCloseTimer.Tick += autoCloseTimer_Tick;
			autoCloseTimer.Start( );
		}

		void InitAnimation( )
		{
			timer = new Timer( );
			timer.Interval = 1;
			timer.Tick += popDownAnimation_Tick;
		}

		void autoCloseTimer_Tick( object sender, EventArgs e )
		{
			InitAnimation( false );
			timer.Start( );
		}

		void InitAnimation( bool isPopUp )
		{
			if ( isPopUp )
			{
				timer = new Timer( );
				timer.Interval = 1;
				timer.Tick += popUpAnimation_Tick;
			}
			else
			{
				timer = new Timer( );
				timer.Interval = 1;
				timer.Tick += popDownAnimation_Tick;
			}
		}

		private void popUpAnimation_Tick( object sender, EventArgs e )
		{
			startPosY -= 15;

			if ( startPosY < Screen.PrimaryScreen.WorkingArea.Height - Height )
			{
				timer.Stop( );
				timer.Dispose( );
			}
			else
				this.SetDesktopLocation( startPosX, startPosY );
		}

		private void popDownAnimation_Tick( object sender, EventArgs e )
		{
			startPosY += 15;

			if ( startPosY > Screen.PrimaryScreen.WorkingArea.Height )
			{
				timer.Stop( );
				timer.Dispose( );
				this.Close( );
			}
			else
				this.SetDesktopLocation( startPosX, startPosY );
		}

		private void SongNotify_Load( object sender, EventArgs e )
		{
			this.SONG_NAME.Text = this.songName;
			this.SONG_AUTHOR.Text = this.songAuthor;
			this.SONG_ALBUM_ART.Image = this.songAlbumArt;

			startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
			startPosY = Screen.PrimaryScreen.WorkingArea.Height;
			this.SetDesktopLocation( startPosX, startPosY );

			InitAnimation( true );
			timer.Start( );
		}

		private void SONG_ALBUM_ART_Paint( object sender, PaintEventArgs e )
		{
			int w = 100, h = 100;
			// Outline drawing
			Pen lineDrawer = new Pen( Color.Silver ); // Line Color is same as Title bar
			lineDrawer.Width = 5; // Line width set to 10px

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w, 0, w, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h, w, h ); // Bottom line drawing
		}

		protected override void OnPaint( PaintEventArgs e )
		{

		}
	}
}
