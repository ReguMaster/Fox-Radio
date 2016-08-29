using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Id3v2;

namespace Fox_Radio
{
	public class FileBytesAbstraction : TagLib.File.IFileAbstraction
	{
		public FileBytesAbstraction( string name, byte[ ] bytes )
		{
			Name = name;

			var stream = new MemoryStream( bytes );
			ReadStream = stream;
			WriteStream = stream;
		}

		public void CloseStream( Stream stream )
		{
			stream.Dispose( );
		}

		public string Name { get; private set; }

		public Stream ReadStream { get; private set; }

		public Stream WriteStream { get; private set; }
	}

	public class ServerConnector
	{
		private TcpClient TCP_CLIENT;
		private Socket SOCKET;
		private Main MainForm;
		private SongNotify SongNotifyForm;

		public string SERVER_IP
		{
			set; get;
		}

		public int SERVER_PORT
		{
			set; get;
		}

		public ServerConnector( Main baseForm )
		{
			this.MainForm = baseForm;
		}

		public void Connect( bool isReconnectMode )
		{
			try
			{
				MainForm.APP_MUSIC_PANEL.Visible = false;
				MainForm.APP_LOADING_LABEL.Visible = true;
				MainForm.APP_LOADING_ICON.Visible = true;
				MainForm.APP_LOADING_ICON.Image = global::Fox_Radio.Properties.Resources.CONNECT_ICON;
				MainForm.APP_LOADING_LABEL.Text = "Fox Radio 서버에" + ( isReconnectMode ? " 다시" : "" ) + " 연결 하는 중 ...";
				MainForm.nextServerLoadingLabel.Visible = false;

				System.Threading.Thread.Sleep( 1000 );

				TCP_CLIENT = new TcpClient( );
				TCP_CLIENT.Connect( SERVER_IP, SERVER_PORT );

				SOCKET = TCP_CLIENT.Client;

				MainForm.SERVER_CONNECTED_TEXT.Text = "연결됨";

				MainForm.OnServerConnected( );

				if ( isReconnectMode )
				{
					if ( MainForm.reconnectTimer != null )
					{
						MainForm.reconnectTimer.Enabled = false;
						MainForm.reconnectTimer.Stop( );
						MainForm.reconnectTimer.Close( );
						MainForm.reconnectTimer = null;
					}
				}
			}
			catch ( SocketException )
			{
				if ( isReconnectMode )
				{
					MainForm.reconnectTimeOriginalInt += 5;
					MainForm.reconnectTimeTickInt = MainForm.reconnectTimeOriginalInt;

					MainForm.nextServerLoadingLabel.Text = MainForm.reconnectTimeTickInt + " 초 후 재접속 합니다 ..";

					if ( MainForm.reconnectTimer != null )
						MainForm.reconnectTimer.Interval = MainForm.reconnectTimeOriginalInt * 1000;

					if ( MainForm.reconnectNumberCountTimer != null )
					{
						MainForm.reconnectNumberCountTimer.Enabled = true;
						MainForm.reconnectNumberCountTimer.Start( );
					}
				}

				MainForm.OnServerConnectError( !isReconnectMode );
			}
		}

		public void Request( string songName, string songAuthor, string songDesc )
		{
			byte[ ] songNameBuffer = Encoding.UTF8.GetBytes( songName );
			byte[ ] songAuthorBuffer = Encoding.UTF8.GetBytes( songAuthor );
			byte[ ] songDescBuffer = Encoding.UTF8.GetBytes( songDesc );

			SOCKET.Send( BitConverter.GetBytes( songNameBuffer.Length ), 0, 4, 0 ); // 음악 이름 길이 전송
			SOCKET.Send( songNameBuffer, 0, songNameBuffer.Length, 0 ); // 음악 이름 전송


			SOCKET.Send( BitConverter.GetBytes( songAuthorBuffer.Length ), 0, 4, 0 ); // 음악 가수 길이 전송
			SOCKET.Send( songAuthorBuffer, 0, songAuthorBuffer.Length, 0 ); // 음악 가수 전송


			SOCKET.Send( BitConverter.GetBytes( songDescBuffer.Length ), 0, 4, 0 ); // 음악 설명 길이 전송
			SOCKET.Send( songDescBuffer, 0, songDescBuffer.Length, 0 ); // 음악 설명 전송
		}

		private void NotifyBox( string songName, string songAuthor, System.Drawing.Image songAlbumArt )
		{
			SongNotifyForm = new SongNotify( songName, songAuthor, songAlbumArt );
			SongNotifyForm.ShowDialog( );
		}

		public void NotifyListener( )
		{

		}

		public void Listener( )
		{
			string APP_DIRECTORY = Application.StartupPath;

			try
			{
				while ( true )
				{
					System.Threading.Thread.Sleep( 100 );

					MemoryStream ms = new MemoryStream( );

					byte[ ] songSizeBuffer = new byte[ 4 ];
					byte[ ] songInfoSizeBuffer = new byte[ 4 ];
					int songSize;
					int songInfoSize;

					SOCKET.Receive( songSizeBuffer, 0, songSizeBuffer.Length, 0 ); // SONG SIZE

					songSize = BitConverter.ToInt32( songSizeBuffer, 0 );

					SOCKET.Receive( songInfoSizeBuffer, 0, songInfoSizeBuffer.Length, 0 ); // SONG INFO SIZE

					songInfoSize = BitConverter.ToInt32( songInfoSizeBuffer, 0 );

					byte[ ] songInfoBuffer = new byte[ songInfoSize ];

					SOCKET.Receive( songInfoBuffer, 0, songInfoBuffer.Length, 0 ); // SONG INFO

					string songInfo = Encoding.UTF8.GetString( songInfoBuffer );
					int songMaxSize = songSize;

					MainForm.SONG_TITLE_LABEL.Text = "버퍼링 중 ...";
					MainForm.SONG_AUTHOR_LABEL.Text = "";
					MainForm.SONG_TIME.Text = "";

					while ( songSize > 0 )
					{
						byte[ ] buffer = new byte[ 31024 ];
						int read = SOCKET.Receive( buffer, 0, buffer.Length, 0 ); // SONG

						songSize -= read;

						ms.Write( buffer, 0, read );
					}

					ms.Seek( 0, SeekOrigin.Begin );
					byte[ ] byteBuffer = new byte[ ms.Length ];
					ms.Read( byteBuffer, 0, byteBuffer.Length );
					ms.Close( );

					Player.Stop( );

					string[ ] songInformation = songInfo.Split( '@' );
					int songLocation = int.Parse( songInformation[ 2 ] );

					float vol = ( ( float ) MainForm.VOLUME_BAR.Value / 100 );

					Player.SetPlayStream( byteBuffer );
					Player.SetLocation( songLocation );

					MainForm.SongTick = songLocation;
					MainForm.SongMaxTick = Player.TimeSpanToInteger( Player.WAVE_STREAM.TotalTime );

					Player.SetVolume( vol );
					Player.Play( );

					using ( TagLib.File file = TagLib.File.Create( new FileBytesAbstraction( APP_DIRECTORY + "\\buffer\\buffer.mp3", byteBuffer ) ) )
					{

						float calc = ( float ) Player.WAVE_STREAM.CurrentTime.TotalSeconds / ( float ) Player.WAVE_STREAM.TotalTime.TotalSeconds;

						MainForm.SONG_TRACKBAR.Size = new Size( ( int ) ( 285 * calc ), 5 );
						MainForm.SONG_TIME.Text = Player.TimeSpanToString( Player.WAVE_STREAM.CurrentTime ) + " / " + Player.TimeSpanToString( Player.WAVE_STREAM.TotalTime );

						MainForm.SONG_TITLE_LABEL.Font = MainForm.AutoFontSize( MainForm.SONG_TITLE_LABEL, songInformation[ 0 ] );
						MainForm.SONG_TITLE_LABEL.Text = songInformation[ 0 ];

						MainForm.SONG_AUTHOR_LABEL.Text = songInformation[ 1 ];
						MainForm.SongTickTimer.Enabled = true;
						MainForm.SongTickTimer.Start( );

						MainForm.SONG_LYRICS.Text = "";


						if ( file.Tag.Pictures.Length >= 1 )
						{
							byte[ ] bin = file.Tag.Pictures[ 0 ].Data.Data;
							MainForm.SONG_ALBUM_ART.Image = System.Drawing.Image.FromStream( new MemoryStream( bin ) ).GetThumbnailImage( 200, 200, null, IntPtr.Zero );
							MainForm.SONG_ALBUM_ART.Cursor = Cursors.Hand;
							MainForm.fullAlbumArt = System.Drawing.Image.FromStream( new MemoryStream( bin ) ).GetThumbnailImage( 412, 412, null, IntPtr.Zero );
							MainForm.haveAlbumArt = true;
						}
						else
						{
							MainForm.SONG_ALBUM_ART.Image = global::Fox_Radio.Properties.Resources.DEFAULT_ALBUM_ART;
							MainForm.SONG_ALBUM_ART.Cursor = Cursors.Default;
							MainForm.fullAlbumArt = null;
							MainForm.haveAlbumArt = false;
						}

						Lyrics.GetLyrics( byteBuffer, true );


						Thread thread = new Thread( ( ) => NotifyBox( songInformation[ 0 ], songInformation[ 1 ], MainForm.SONG_ALBUM_ART.Image ) );
						thread.IsBackground = true;
						thread.Start( );


					}
				}
			}
			catch ( SocketException )
			{
				Player.Stop( );

				MainForm.SERVER_CONNECTED_TEXT.Text = "연결 끊김";

				if ( MainForm.ServerConnectThread != null )
				{
					MainForm.ServerConnectThread.Abort( );
					MainForm.ServerConnectThread = null;
				}

				MainForm.ServerConnectThread = new Thread( ( ) => Connect( false ) );
				MainForm.ServerConnectThread.IsBackground = true;
				MainForm.ServerConnectThread.Start( );

				MainForm.ServerListenerThread = new Thread( new ThreadStart( Listener ) );
				MainForm.ServerListenerThread.IsBackground = true;

				MainForm.reconnectTimeOriginalInt = 10;
				MainForm.reconnectTimeTickInt = MainForm.reconnectTimeOriginalInt;

				MainForm.nextServerLoadingLabel.Text = MainForm.reconnectTimeTickInt + " 초 후 재접속 합니다 ..";

				if ( MainForm.reconnectTimer != null )
				{
					MainForm.reconnectTimer.Interval = MainForm.reconnectTimeOriginalInt * 1000;
					MainForm.reconnectTimer.Enabled = true;
					MainForm.reconnectTimer.Start( );
				}

				if ( MainForm.reconnectNumberCountTimer != null )
				{
					MainForm.reconnectNumberCountTimer.Enabled = true;
					MainForm.reconnectNumberCountTimer.Start( );
				}
			}
		}
	}
}
