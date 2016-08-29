using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fox_Radio
{
	static class Player
	{
		public static WaveOut WAVE_OUT = null;
		public static WaveStream WAVE_STREAM = null;
		public static MemoryStream MEMORY_STREAM = null;

		public static void CreateInstance( )
		{
			WAVE_OUT = new WaveOut( );
		}

		public static void Play( )
		{

			try
			{
				WAVE_OUT.Play( );
			}
			catch ( Exception )
			{
				MessageBox.Show( "사운드 장치에 문제가 있습니다.", "Fox Radio", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		public static void Stop( )
		{
			WAVE_OUT.Stop( );

			if ( WAVE_STREAM != null )
			{
				WAVE_STREAM.Close( );
				WAVE_STREAM = null;
			}
		}

		public static void SetLocation( int pos )
		{
			WAVE_STREAM.Skip( pos );
		}

		public static void SetVolume( float volume )
		{
			try
			{
				WAVE_OUT.Volume = volume;
			}
			catch ( Exception )
			{
				MessageBox.Show( "사운드 장치에 문제가 있습니다.", "Fox Radio", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		public static void SetPlay( string fileName )
		{
			if ( WAVE_STREAM != null )
			{
				WAVE_STREAM.Dispose( );
				WAVE_STREAM = null;
			}

			AudioFileReader reader = new AudioFileReader( fileName );

			WAVE_STREAM = reader;
		
			try
			{
				WAVE_OUT.Init( reader );
			}
			catch ( NAudio.MmException )
			{
				MessageBox.Show( "사운드 장치에 문제가 있습니다.", "Fox Radio", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		public static void SetPlayStream( byte[ ] byteData )
		{
			if ( MEMORY_STREAM != null )
			{
				MEMORY_STREAM.Close( );
				MEMORY_STREAM = null;
			}

			MEMORY_STREAM = new MemoryStream( byteData );
			MEMORY_STREAM.Position = 0;

			Mp3FileReader reader = new Mp3FileReader( MEMORY_STREAM );

			WAVE_STREAM = reader;
			WAVE_OUT.Init( reader );
		}

		public static string TimeSpanToString( TimeSpan obj )
		{
			object sec = obj.Seconds;

			if ( ( int ) sec < 10 )
			{
				sec = "0" + sec;
			}

			return String.Format( "{0}:{1}", obj.Minutes, sec );
		}

		public static int TimeSpanToInteger( TimeSpan obj )
		{
			int hourToSecond = obj.Hours * 60 * 60;
			int minutesToSecond = obj.Minutes * 60;

			return hourToSecond + minutesToSecond + obj.Seconds;
		}
	}
}
