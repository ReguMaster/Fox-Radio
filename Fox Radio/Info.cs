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
	public partial class Info : Form
	{
		private bool drag = false;
		private Point startPoint = new Point( 0, 0 );

		public Info( )
		{
			InitializeComponent( );
		}

		private void Info_Load( object sender, EventArgs e )
		{
			System.Reflection.Assembly assemObject = System.Reflection.Assembly.GetExecutingAssembly( );
			Version version = assemObject.GetName( ).Version;

			this.versionLabel.Text = "버전 " + version.Major + "." + version.Minor;
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{

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
	}
}
