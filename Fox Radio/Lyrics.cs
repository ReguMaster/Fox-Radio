using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fox_Radio
{
	static class Lyrics
	{
		// https://github.com/shimika/Simplayer5/blob/master/Lyrics.cs
		//private string soapForm = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><SOAP-ENV:Envelope xmlns:SOAP-ENV=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:SOAP-ENC=\"http://www.w3.org/2003/05/soap-encoding\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:ns2=\"ALSongWebServer/Service1Soap\" xmlns:ns1=\"ALSongWebServer\" xmlns:ns3=\"ALSongWebServer/Service1Soap12\"><SOAP-ENV:Body><ns1:GetLyric7><ns1:encData>510090e92db352abad44687c57e07504f1cff1e770d4c31a8607404a26c0ae33cbd95b31c52c54c794b0f2d535b2641f7170bcabf279ba900e50098d946f58496e52541ca01c4e16a7ffaef9d13182fae4baf68ea478b7f2a22a92103d822e6c49c9d187b3911ff325d4dab923da8dc50f3824715083d062a43e28f85eb2f2c0</ns1:encData><ns1:stQuery><ns1:strChecksum>#strChecksum#</ns1:strChecksum><ns1:strVersion>3.19</ns1:strVersion><ns1:strMACAddress>e858217d415f52e84df2d807d2045c5a78f008c9bed684f350f2c78b6fceeacb</ns1:strMACAddress><ns1:strIPAddress>192.168.1.1</ns1:strIPAddress></ns1:stQuery></ns1:GetLyric7></SOAP-ENV:Body></SOAP-ENV:Envelope>";
		private static string soapForm = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><SOAP-ENV:Envelope xmlns:SOAP-ENV=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:SOAP-ENC=\"http://www.w3.org/2003/05/soap-encoding\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:ns2=\"ALSongWebServer/Service1Soap\" xmlns:ns1=\"ALSongWebServer\" xmlns:ns3=\"ALSongWebServer/Service1Soap12\"><SOAP-ENV:Body><ns1:GetLyric5><ns1:stQuery><ns1:strChecksum>#strChecksum#</ns1:strChecksum><ns1:strVersion>2.0 beta2</ns1:strVersion><ns1:strMACAddress></ns1:strMACAddress><ns1:strIPAddress>255.255.255.0</ns1:strIPAddress></ns1:stQuery></ns1:GetLyric5></SOAP-ENV:Body></SOAP-ENV:Envelope>";
		private static string[ ] lyrList;
		public static string[ ] LyricLists { get { return lyrList; } }
		public static List<string> LyricListsCon = new List<string>( );
		public static List<int> timeLine = new List<int>( );

		public static bool GetLyrics( byte[ ] byteData, bool init )
		{
			LyricListsCon.Clear( );
			timeLine.Clear( );

			bool ok = parseXML( byteData );

			if ( !ok || lyrList == null )
			{
				return false;
			}

			if ( init )
				Init( );

			return true;
		}

		private static bool parseXML( byte[ ] byteData )
		{
			string md5 = GetSongMD5( byteData );

			if ( md5 == "" ) { return false; }

			XmlDocument doc = webRequest( md5 );

			if ( doc.HasChildNodes )
			{
				foreach ( XmlNode node in doc.ChildNodes[ 1 ].ChildNodes[ 0 ].ChildNodes[ 0 ].ChildNodes[ 0 ].ChildNodes )
				{
					if ( node.Name == "strLyric" )
					{
						lyrList = new string[ 1 ];
						string str = node.InnerText.Replace( "<br>", Environment.NewLine );
						lyrList[ 0 ] = str;
						break;
					}
				}
			}

			return true;
		}

		private static XmlDocument webRequest( string md5 )
		{
			XmlDocument xml = new XmlDocument( );
			HttpWebRequest request = null;
			string str = soapForm.Replace( "#strChecksum#", md5 );

			try
			{
				request = ( HttpWebRequest ) WebRequest.Create( "http://lyrics.alsong.co.kr/alsongwebservice/service1.asmx" );
				request.ContentType = "application/soap+xml; charset=utf-8";
				request.Method = "POST";
				request.UserAgent = "gSOAP/2.7";

				using ( StreamWriter sw = new StreamWriter( request.GetRequestStream( ) ) )
				{
					sw.WriteLine( str );
				}

				Stream response = request.GetResponse( ).GetResponseStream( );
				xml.Load( response );
			}
			catch ( Exception ) { }

			return xml;
		}

		public static string GetSongMD5( byte[ ] byteData )
		{
			try
			{
				MemoryStream stream = new MemoryStream( byteData );

				if ( stream == null ) { return ""; }

				int p = 0;
				stream.Position = 0L;
				byte[ ] buffer = new byte[ 27 ];
				stream.Read( buffer, 0, 27 );

				if ( buffer.Length < 27 || stream.Position > 50000L ) { return ""; }

				long position = stream.Position;

				string tag = Encoding.ASCII.GetString( buffer, 0, 3 );

				if ( tag == "ID3" )
				{
					stream.Position -= 17L;
					byte[ ] tagSize = new byte[ 4 ];
					Array.Copy( buffer, 6, tagSize, 0, 4 );
					movePosition( searchPosition( stream, ref p, tagSize ) );
				}
				else
				{
					stream.Position = 0L;
					movePosition( stream );
				}

				byte[ ] pureBytes = new byte[ 163840 ];
				stream.Read( pureBytes, 0, 163840 );
				stream.Close( );

				return getMD5FromByteArray( pureBytes );
			}
			catch
			{
				return "";
			}
		}

		private static Stream searchPosition( Stream stream, ref int position, byte[ ] tagSize )
		{
			bool flag = false;
			for ( int i = 0; i < 500000; i++ )
			{
				position = 10 + ( ( int ) tagSize[ 0 ] << 21 | ( int ) tagSize[ 1 ] << 14 | ( int ) tagSize[ 2 ] << 7 | ( int ) tagSize[ 3 ] );

				if ( stream.CanSeek )
				{
					stream.Position = ( long ) position;
					flag = true;
					break;
				}
			}

			if ( !flag )
			{
				stream.Position = 0L;
			}
			return stream;
		}

		private static Stream movePosition( Stream stream )
		{
			for ( int i = 0; i < 50000; i++ )
			{
				if ( stream.ReadByte( ) == ( int ) byte.MaxValue && stream.ReadByte( ) >> 5 == 7 )
				{
					stream.Position += -2L;
					break;
				}
			}

			return stream;
		}

		private static string getMD5FromByteArray( byte[ ] byteArray )
		{
			MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider( );
			cryptoServiceProvider.ComputeHash( byteArray );

			byte[ ] hash = cryptoServiceProvider.Hash;
			StringBuilder stringBuilder = new StringBuilder( );

			foreach ( byte num in hash )
			{
				stringBuilder.Append( string.Format( "{0:X2}", ( object ) num ) );
			}
			return stringBuilder.ToString( );
		}

		// my code lol;

		public static void Init( )
		{
			foreach ( string lyrics in LyricLists )
			{
				string[ ] convTemp = lyrics.Split( '\n' );

				foreach ( string ly2 in convTemp )
				{
					if ( ly2 == "" ) continue;

					string temp = ly2.Substring( 1, ly2.IndexOf( ']' ) - 1 );

					if ( temp == "00:00.00" ) continue;

					int index = temp.IndexOf( ':' ); // :
					int index2 = temp.IndexOf( '.' ); // .

					string min = temp.Substring( 0, 2 );
					string second = temp.Substring( index + 1, 2 );

					TimeSpan ts = new TimeSpan( 0, int.Parse( min ), int.Parse( second ) );

					LyricListsCon.Add( ly2.Substring( ly2.LastIndexOf( ']' ) + 1 ) );
					timeLine.Add( ( int ) ts.TotalSeconds );
				}
			}
		}

		public static int GetLyricsByCurrentTime( int currSec )
		{
			int maxTimeLine = timeLine.Count;
			int i = 0;

			try
			{
				foreach ( int sec in timeLine )
				{
					if ( currSec >= sec && currSec < timeLine[ i + 1 ] )
					{
						return i;
					}

					i++;
				}
			}
			catch ( Exception ) { }

			return i;
		}
	}
}
