using System;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Fox_Radio
{
	public partial class Main : Form
	{
		private bool drag = false;
		private Point startPoint = new Point( 0, 0 );
		private Point volumeBarStartPoint = new Point( 0, 0 );

		public ServerConnector SERVER_CONNECTOR;
		public Thread ServerConnectThread;
		public Thread ServerListenerThread;

		public System.Timers.Timer SongTickTimer;
		public int SongTick;
		public int SongMaxTick;
		public bool haveAlbumArt;
		public Image fullAlbumArt;

		public int reconnectTimeOriginalInt;
		public int reconnectTimeTickInt;
		public System.Timers.Timer reconnectTimer = null;
		public System.Timers.Timer reconnectNumberCountTimer = null;
		public System.Timers.Timer requestCoolTimeTimer = null;

		public Main( )
		{
			CheckForIllegalCrossThreadCalls = false;

			InitializeComponent( );

			SERVER_CONNECTOR = new ServerConnector( this );
			SERVER_CONNECTOR.SERVER_IP = "182.212.36.48";
			SERVER_CONNECTOR.SERVER_PORT = 12340;

			SongTickTimer = new System.Timers.Timer( );
			SongTickTimer.Enabled = false;
			SongTickTimer.Interval = 1000;
			SongTickTimer.Elapsed += new ElapsedEventHandler( SongTickTimer_Elapsed );
		}

		private void SongTickTimer_Elapsed( object sender, ElapsedEventArgs e )
		{
			if ( Player.WAVE_STREAM == null ) return;

			if ( SongTick < SongMaxTick )
			{
				SongTick++;

				float calc = ( float ) SongTick / ( float ) SongMaxTick;

				this.SONG_TRACKBAR.Size = new Size( ( int ) ( 321 * calc ), 5 );
				this.SONG_TIME.Text = Player.TimeSpanToString( Player.WAVE_STREAM.CurrentTime ) + " / " + Player.TimeSpanToString( Player.WAVE_STREAM.TotalTime );

				try
				{
					this.SONG_LYRICS.Text = Lyrics.LyricListsCon[ Lyrics.GetLyricsByCurrentTime( ( int ) Player.WAVE_STREAM.CurrentTime.TotalSeconds ) ].Trim( );
				}
				catch ( Exception ) { }
			}
			else
			{
				SongTickTimer.Enabled = false;
				SongTickTimer.Stop( );
			}
		}

		public void OnMusicRequest( )
		{
			this.SONG_REQUEST_BUTTON.Enabled = false;

			if ( requestCoolTimeTimer != null )
			{
				requestCoolTimeTimer.Close( );
				requestCoolTimeTimer = null;
			}

			requestCoolTimeTimer = new System.Timers.Timer( );
			requestCoolTimeTimer.Enabled = true;
			requestCoolTimeTimer.Interval = 60 * 1000;
			requestCoolTimeTimer.Elapsed += new ElapsedEventHandler( requestCoolTimeTimer_Elapsed );
		}

		private void requestCoolTimeTimer_Elapsed( object sender, ElapsedEventArgs e )
		{
			this.SONG_REQUEST_BUTTON.Enabled = true;

			if ( requestCoolTimeTimer != null )
			{
				requestCoolTimeTimer.Close( );
				requestCoolTimeTimer = null;
			}
		}

		public Font AutoFontSize( Label label, string text )
		{
			Font ft;
			Graphics gp;
			SizeF sz;
			Single Faktor, FaktorX, FaktorY;
			gp = label.CreateGraphics( );
			sz = gp.MeasureString( text, label.Font );
			gp.Dispose( );

			FaktorX = ( label.Width ) / sz.Width;
			FaktorY = ( label.Height ) / sz.Height;
			if ( FaktorX > FaktorY )
				Faktor = FaktorY;
			else
				Faktor = FaktorX;
			ft = label.Font;

			return new Font( ft.Name, ft.SizeInPoints * ( Faktor ) - 1, System.Drawing.FontStyle.Bold );
		}

		private void Main_Load( object sender, EventArgs e )
		{
			this.Activate( );

			System.IO.Directory.CreateDirectory( "buffer" );
			Player.CreateInstance( );

			this.PANEL_TITLE.Text = "연결 중 ...";

			ServerConnectThread = new Thread( ( ) => SERVER_CONNECTOR.Connect( false ) );
			ServerConnectThread.IsBackground = true;
			ServerConnectThread.Start( );

			ServerListenerThread = new Thread( new ThreadStart( SERVER_CONNECTOR.Listener ) );
			ServerListenerThread.IsBackground = true;

			this.APP_MUSIC_PANEL.Visible = false;

			this.VOLUME_BAR.Value = Properties.Settings.Default.volume;
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			Pen lineDrawer = new Pen( Color.Black ); // Line Color is same as Title bar
			lineDrawer.Width = 1; // Line width set to 10px

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // Top line drawing
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // Left line drawing
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // Right line drawing
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			// Outline drawing
			//Pen lineDrawer = new Pen( Color.Orange ); // Line Color is same as Title bar
			//lineDrawer.Width = 3; // Line width set to 10px

			//e.Graphics.DrawLine( lineDrawer, 0, e.ClipRectangle.Height, e.ClipRectangle.Width, e.ClipRectangle.Height ); // Bottom line drawing
		}

		private void SONG_ALBUM_ART_Paint( object sender, PaintEventArgs e )
		{
			// Outline drawing
			//Pen lineDrawer = new Pen( Color.White ); // Line Color is same as Title bar
			//lineDrawer.Width = 5; // Line width set to 10px

			//e.Graphics.DrawLine( lineDrawer, 0, 0, e.ClipRectangle.Width, 0 ); // Top line drawing
			//e.Graphics.DrawLine( lineDrawer, 0, 0, 0, e.ClipRectangle.Height ); // Left line drawing
			//e.Graphics.DrawLine( lineDrawer, e.ClipRectangle.Width, 0, e.ClipRectangle.Width, e.ClipRectangle.Height ); // Right line drawing
			//e.Graphics.DrawLine( lineDrawer, 0, e.ClipRectangle.Height, e.ClipRectangle.Width, e.ClipRectangle.Height ); // Bottom line drawing
		}
		
		private void SONG_CURRENT_LENGTH_Paint( object sender, PaintEventArgs e )
		{

		}

		private void BeginReconnectToServer( )
		{
			this.reconnectTimeOriginalInt = 10;
			this.reconnectTimeTickInt = this.reconnectTimeOriginalInt;

			if ( this.reconnectTimer != null )
			{
				this.reconnectTimer.Close( );
				this.reconnectTimer = null;
			}

			if ( this.reconnectNumberCountTimer != null )
			{
				this.reconnectNumberCountTimer.Close( );
				this.reconnectNumberCountTimer = null;
			}

			this.reconnectTimer = new System.Timers.Timer( );
			this.reconnectTimer.Enabled = true;
			this.reconnectTimer.Interval = this.reconnectTimeOriginalInt * 1000;
			this.reconnectTimer.Elapsed += new System.Timers.ElapsedEventHandler( this.reconnectTimer_Tick );
			this.reconnectTimer.Start( );

			this.reconnectNumberCountTimer = new System.Timers.Timer( );
			this.reconnectNumberCountTimer.Enabled = true;
			this.reconnectNumberCountTimer.Interval = 1000;
			this.reconnectNumberCountTimer.Elapsed += new System.Timers.ElapsedEventHandler( this.reconnectNumberCountTimer_Tick );
			this.reconnectNumberCountTimer.Start( );
		}

		private void reconnectTimer_Tick( object sender, ElapsedEventArgs e )
		{
			// 다시 접속 시작;
			this.reconnectNumberCountTimer.Enabled = false;
			this.reconnectNumberCountTimer.Stop( );

			if ( ServerConnectThread != null )
			{
				ServerConnectThread.Abort( );
				ServerConnectThread = null;
			}

			ServerConnectThread = new Thread( ( ) => SERVER_CONNECTOR.Connect( true ) );
			ServerConnectThread.IsBackground = true;
			ServerConnectThread.Start( );
		}

		private void reconnectNumberCountTimer_Tick( object sender, ElapsedEventArgs e )
		{
			// 재접속 카운트 셈;
			if ( this.reconnectTimeTickInt > 0 )
				this.reconnectTimeTickInt--;

			this.nextServerLoadingLabel.Text = this.reconnectTimeTickInt + " 초 후 재접속 합니다 ..";
		}

		public void OnServerConnected( )
		{
			this.nextServerLoadingLabel.Visible = false;
			this.APP_MUSIC_PANEL.Visible = true;

			this.APP_LOADING_LABEL.Visible = false;
			this.APP_LOADING_ICON.Visible = false;

			this.PANEL_TITLE.Text = "현재 재생중";
			this.ServerListenerThread.Start( );
		}

		public void OnServerConnectError( bool reConnect )
		{
			this.nextServerLoadingLabel.Visible = true;

			this.APP_MUSIC_PANEL.Visible = false;

			this.APP_LOADING_LABEL.Visible = true;
			this.APP_LOADING_ICON.Visible = true;
			this.APP_LOADING_ICON.Image = global::Fox_Radio.Properties.Resources.CONNECT_ERROR_ICON;
			this.APP_LOADING_LABEL.Text = "Fox Radio 서버에 연결할 수 없습니다 :(";
			this.PANEL_TITLE.Text = "연결 중 ...";

			if ( reConnect )
				this.BeginReconnectToServer( );
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( this.drag )
			{
				Point p1 = new Point( e.X, e.Y );
				Point p2 = this.PointToScreen( p1 );
				Point p3 = new Point( p2.X - this.startPoint.X, p2.Y - this.startPoint.Y );

				this.Location = p3;
			}
		}

		private void APP_TITLE_BAR_MouseUp( object sender, MouseEventArgs e )
		{
			this.drag = false;
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			this.startPoint = e.Location;
			this.drag = true;
		}

		private void SYS_min_button_Click( object sender, EventArgs e )
		{
			this.APP_NOTIFY_ICON.Visible = true;
			this.APP_NOTIFY_ICON.ShowBalloonTip( 5, "Fox Radio", "Fox Radio 가 백그라운드에서 실행 중 입니다.", ToolTipIcon.Info );

			this.Visible = false;
			this.ShowInTaskbar = false;
			this.WindowState = FormWindowState.Minimized;
		}

		private void SYS_close_button_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void VOLUME_BAR_Scroll( object sender, EventArgs e )
		{
			float vol = ( ( float ) VOLUME_BAR.Value / 100 );

			Player.SetVolume( vol );

			Properties.Settings.Default.volume = VOLUME_BAR.Value;
			Properties.Settings.Default.Save( );
		}

		private void SONG_ALBUM_ART_Click( object sender, EventArgs e )
		{
			if ( haveAlbumArt )
			{
				AlbumArtViewer Form = new AlbumArtViewer( this.fullAlbumArt );
				Form.ShowDialog( );
			}
		}

		private void APP_NOTIFY_ICON_MouseDoubleClick( object sender, MouseEventArgs e )
		{
			APP_NOTIFY_ICON_MENU_OPTION_1_Click( null, null );
		}

		private void APP_NOTIFY_ICON_MENU_OPTION_1_Click( object sender, EventArgs e )
		{
			this.Show( );
			this.Activate( );
			this.Focus( );

			this.ShowInTaskbar = true;
			this.Visible = true;
			this.WindowState = FormWindowState.Normal;
			this.APP_NOTIFY_ICON.Visible = false;
		}

		private void APP_NOTIFY_ICON_MENU_OPTION_2_Click( object sender, EventArgs e )
		{
			Info Form = new Info( );
			Form.ShowDialog( );
		}

		private void APP_NOTIFY_ICON_MENU_OPTION_3_Click( object sender, EventArgs e )
		{
			Application.Exit( );
		}

		private void APP_ICON_Click( object sender, EventArgs e )
		{
			Info Form = new Info( );
			Form.ShowDialog( );
		}

		private void SONG_REQUEST_BUTTON_Click( object sender, EventArgs e )
		{
			Request Form = new Request( this );
			Form.ShowDialog( );
		}
	}
}
