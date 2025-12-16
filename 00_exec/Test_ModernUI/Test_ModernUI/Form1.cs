using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Test_ModernUI
{
    public partial class frmMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public frmMain()
        {
            Console.WriteLine("Called frmMain ");
            InitializeComponent();
            Console.WriteLine("After InitializeComponent");
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavi.Height = btnDashboard.Height;
            pnlNavi.Left = btnDashboard.Left;
            pnlNavi.Top = btnDashboard.Top;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Console.WriteLine("Close frmMain ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Called Form1_Load");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnDashboard.Height;
            pnlNavi.Left = btnDashboard.Left;
            pnlNavi.Top = btnDashboard.Top;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnAnalytics.Height;
            pnlNavi.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnCalendar.Height;
            pnlNavi.Top = btnCalendar.Top;
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnContactUs.Height;
            pnlNavi.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnSettings.Height;
            pnlNavi.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
