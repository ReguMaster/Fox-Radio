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
	public partial class Request : Form
	{
		private bool drag = false;
		private Point startPoint = new Point( 0, 0 );
		private Main MainForm;
		//private ServerConnector connector;

		public Request( Main MainForm )
		{
			InitializeComponent( );

			this.MainForm = MainForm;
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

		private void SYS_close_button_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void SONG_REQUEST_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.SONG_NAME_TEXTBOX.Text != "" && this.SONG_DESC_TEXTBOX.Text != "" && this.SONG_AUTHOR_TEXTBOX.Text != "" )
			{
				DialogResult result = MessageBox.Show( this, "음악을 요청하시겠습니까? 취소할 수 없습니다.", "Fox Radio", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

				if ( result == DialogResult.Yes )
				{
					this.Close( );
					MainForm.SERVER_CONNECTOR.Request( this.SONG_NAME_TEXTBOX.Text, this.SONG_AUTHOR_TEXTBOX.Text, this.SONG_DESC_TEXTBOX.Text );

					MainForm.OnMusicRequest( );
					MessageBox.Show( this, "음악이 요청되었습니다.", "Fox Radio", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
			else
			{
				MessageBox.Show( this, "모든 정보를 올바르게 입력하십시오.", "Fox Radio", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}
	}
}
