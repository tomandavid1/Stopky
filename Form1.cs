using System.Drawing.Text;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stopky
{
	public partial class StopkyWindow : Form
	{
		private DateTime? startTime;
		private DateTime? stopTime;
		private TimeSpan? difference = null;

		private bool startButton = false;
		private bool stopButton = true;

		static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		const UInt32 SWP_NOSIZE = 0x0001;
		const UInt32 SWP_NOMOVE = 0x0002;
		const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
		public StopkyWindow()
		{
			SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
			InitializeComponent();
			//this.BackColor = Color.LimeGreen;
			//this.TransparencyKey = Color.LimeGreen;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		private void Start_Click(object sender, EventArgs e)
		{
			if (!startButton)
			{

				if (stopTime != null)
				{
					if (difference == null)
					{
						difference = (DateTime.Now - stopTime);
					}
					else
					{
						difference = (DateTime.Now - stopTime) + difference;
					}

				}
				if (startTime == null)
				{
					startTime = DateTime.Now;
				}
				formTimer.Start();
				startButton = true;
				stopButton = false;
			}
		}

		private void Stop_Click(object sender, EventArgs e)
		{
			if (!stopButton)
			{
				formTimer.Stop();
				stopTime = DateTime.Now;
				stopButton = true;
				startButton = false;
			}

		}

		private void Reset_Click(object sender, EventArgs e)
		{
			formTimer.Stop();
			startTime = null;
			stopTime = null;
			difference = null;
			startButton = false;
			stopButton = true;
			watchLabel.Text = "00:00.00";
		}

		private void formTimer_Tick_1(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			TimeSpan? span = now - startTime;
			if (difference != null)
			{
				span = span - difference;
			}
			watchLabel.Text = span?.ToString(@"mm\:ss\.ff");
		}

		private void Stopky_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.None;

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}