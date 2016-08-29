using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fox_Radio
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main( )
		{
			bool bnew;

			Mutex mutex = new Mutex( true, "FoxRadio_DeveloFOX", out bnew );

			if ( bnew )
			{
				Application.EnableVisualStyles( );
				Application.SetCompatibleTextRenderingDefault( false );
				Application.Run( new Main( ) );
				mutex.ReleaseMutex( );
			}
			else
			{
				MessageBox.Show( "이미 Fox Radio 가 실행 중 입니다.", "Fox Radio", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
		}
	}
}
