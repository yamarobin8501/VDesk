using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;
using WindowsDesktop.Interop;
using WindowsInput;
using WindowsInput.Native;
using Microsoft.Win32;

//using WindowsDesktop.Internal;


namespace VirtualDesktopForm
{
    struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    //[StructLayout(LayoutKind.Sequential)]
    struct APPBARDATA
    {
        public int cbSize;
        public IntPtr hWnd;
        public int uCallbackMessage;
        public int uEdge;
        public RECT rc;
        public IntPtr lParam;
    }

    enum ABMsg : int
    {
        ABM_NEW = 0,
        ABM_REMOVE = 1,
        ABM_QUERYPOS = 2,
        ABM_SETPOS = 3,
        ABM_GETSTATE = 4,
        ABM_GETTASKBARPOS = 5,
        ABM_ACTIVATE = 6,
        ABM_GETAUTOHIDEBAR = 7,
        ABM_SETAUTOHIDEBAR = 8,
        ABM_WINDOWPOSCHANGED = 9,
        ABM_SETSTATE = 10
    }

    enum ABNotify : int
    {
        ABN_STATECHANGE = 0,
        ABN_POSCHANGED,
        ABN_FULLSCREENAPP,
        ABN_WINDOWARRANGE
    }

    enum ABEdge : int
    {
        ABE_LEFT = 0,
        ABE_TOP,
        ABE_RIGHT,
        ABE_BOTTOM
    }
    public partial class Form1 : Form
    {
        private bool fPinState = false;
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "AppBar";
            timeLeft = 90;
            textBox1.Text = timeLeft.ToString();
            //this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btnDock_Click(sender, e);
            var handle = this.Handle;
            this.Height = 23;
            if (fPinState)
            {
                VirtualDesktop.UnpinWindow(handle);
                fPinState = false;
            }
            else
            {
                VirtualDesktop.PinWindow(handle);
                fPinState = true;
            }
        }

        private void btnLeftDesktop_Click(object sender, EventArgs e)
        {
            if (fPinState)
                VirtualDesktop.UnpinWindow(this.Handle);

            WindowsDesktop.VirtualDesktop current = this.GetCurrentDesktop();
            if (current != null) {
                WindowsDesktop.VirtualDesktop vd = current.GetLeft();
                if (vd != null) {
                    vd.Switch();
                }
            } else {

            }
            if (fPinState)
                VirtualDesktop.PinWindow(this.Handle);

        }

        private void btnRightDesktop_Click(object sender, EventArgs e)
        {

            if (fPinState)
                VirtualDesktop.UnpinWindow(this.Handle);
            WindowsDesktop.VirtualDesktop current = this.GetCurrentDesktop();
            if (current != null)
            {
                WindowsDesktop.VirtualDesktop vd = current.GetRight();
                if (vd != null) {
                    vd.Switch();
                }
            } else {
                
            }
            if(fPinState)
                VirtualDesktop.PinWindow(this.Handle);            
        }

        private bool fBarRegistered = false;
        [DllImport("kernel32.dll")]
        public static extern void ExitProcess(uint dwExitCode);
        [DllImport("SHELL32", CallingConvention = CallingConvention.StdCall)]
        static extern uint SHAppBarMessage(int dwMessage, ref APPBARDATA pData);
        [DllImport("USER32")]
        static extern int GetSystemMetrics(int Index);
        [DllImport("User32.dll", ExactSpelling = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool MoveWindow
            (IntPtr hWnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int RegisterWindowMessage(string msg);
        private int uCallBack;
 
        private void RegisterBar()
        {
            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;
            if (!fBarRegistered)
            {
                uCallBack = RegisterWindowMessage("AppBarMessage");
                abd.uCallbackMessage = uCallBack;
                uint ret = SHAppBarMessage((int)ABMsg.ABM_NEW, ref abd);
                fBarRegistered = true;
                ABSetPos();
            }
            else
            {
                SHAppBarMessage((int)ABMsg.ABM_REMOVE, ref abd);
                fBarRegistered = false;
            }
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == uCallBack)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)ABNotify.ABN_POSCHANGED:
                        ABSetPos();
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void ABSetPos()
        {
            APPBARDATA abd = new APPBARDATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = this.Handle;
            abd.uEdge = (int)ABEdge.ABE_TOP;

            if (abd.uEdge == (int)ABEdge.ABE_LEFT || abd.uEdge == (int)ABEdge.ABE_RIGHT)
            {
                abd.rc.top = 0;
                abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height;
                if (abd.uEdge == (int)ABEdge.ABE_LEFT)
                {
                    abd.rc.left = 0;
                    abd.rc.right = Size.Width;
                }
                else
                {
                    abd.rc.right = SystemInformation.PrimaryMonitorSize.Width;
                    abd.rc.left = abd.rc.right - Size.Width;
                }

            }
            else
            {
                abd.rc.left = 0;
                abd.rc.right = SystemInformation.PrimaryMonitorSize.Width;
                if (abd.uEdge == (int)ABEdge.ABE_TOP)
                {
                    abd.rc.top = 0;
                    abd.rc.bottom = Size.Height;
                }
                else
                {
                    abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height;
                    abd.rc.top = abd.rc.bottom - Size.Height;
                }
            }

            // Query the system for an approved size and position. 
            SHAppBarMessage((int)ABMsg.ABM_QUERYPOS, ref abd);

            // Adjust the rectangle, depending on the edge to which the 
            // appbar is anchored. 
            switch (abd.uEdge)
            {
                case (int)ABEdge.ABE_LEFT:
                    abd.rc.right = abd.rc.left + Size.Width;
                    break;
                case (int)ABEdge.ABE_RIGHT:
                    abd.rc.left = abd.rc.right - Size.Width;
                    break;
                case (int)ABEdge.ABE_TOP:
                    abd.rc.bottom = abd.rc.top + Size.Height;
                    break;
                case (int)ABEdge.ABE_BOTTOM:
                    abd.rc.top = abd.rc.bottom - Size.Height;
                    break;
            }

            // Pass the final bounding rectangle to the system. 
            SHAppBarMessage((int)ABMsg.ABM_SETPOS, ref abd);

            // Move and size the appbar so that it conforms to the 
            // bounding rectangle passed to the system. 
            MoveWindow(abd.hWnd, abd.rc.left, abd.rc.top,
                abd.rc.right - abd.rc.left, abd.rc.bottom - abd.rc.top, true);
        }
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RegisterBar();
        }
        private int m_nTop, m_nLeft, m_nRight, m_nBottom;

        private void btnDesktop_1_Click(object sender, EventArgs e)
        {
            VirtualDesktop[] vdList = VirtualDesktop.GetDesktops();
            if (vdList.Length >= 1)
            {
                VirtualDesktop vdCurrent = vdList[0];
                vdCurrent.Switch();
            }
        }

        private void btnDesktop_2_Click(object sender, EventArgs e)
        {
            VirtualDesktop[] vdList = VirtualDesktop.GetDesktops();
            if (vdList.Length > 1)
            {
                VirtualDesktop vdCurrent = vdList[1];
                vdCurrent.Switch();
            }
        }
        private void btnDesktop_3_Click(object sender, EventArgs e)
        {
            VirtualDesktop[] vdList = VirtualDesktop.GetDesktops();
            if (vdList.Length > 2)
            {
                VirtualDesktop vdCurrent = vdList[2];
                vdCurrent.Switch();
            }
        }

        private void MsgBox(string msgTexto, string msgTitulo)
        {
            MessageBox.Show(msgTexto, msgTitulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            //fBarRegistered = true;
            //RegisterBar();
            //System.Threading.Thread.Sleep(100);
            //MsgBox("Buenos Dias!", "3DtoAll");
            ExitProcess(0);
            //Application.Exit();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!fBarRegistered)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastPoint.X;
                    this.Top += e.Y - lastPoint.Y;
                }
            }

        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            //MsgBox(sender.ToString(), e.Button.ToString());
            if (e.Button == MouseButtons.Middle)
            {
                TabManager();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"F:\__CLIENTS\Rob 2017\");
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pictureViewer myForm = new pictureViewer();
                myForm.Show();
                this.Show();
                //this.Close();
                //Process.Start(@"F:\__CLIENTS\Rob 2017\1200x630bb.jpg");
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }

        private void TabManager()
        {
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.TAB);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MsgBox(sender.ToString(),e.ToString());
            TabManager();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RegistryKey MyReg = Registry.CurrentUser.CreateSubKey
            //                     ("Control Panel\\Desktop\\WindowMetrics");
            //MyReg.SetValue("MinAnimate", 1);
            //MyReg.Close();
            MsgBox("test", "Test!");


    }
        private float timeLeft;
        private float timeLeftDividido;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            //timeLeftDividido = timeLeft / 60;
            textBox1.Text = timeLeft.ToString();
        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            timeLeft = 90;
            textBox1.Text = "90";
        }

        private void btnDesktop_4_Click(object sender, EventArgs e)
        {
            VirtualDesktop[] vdList = VirtualDesktop.GetDesktops();
            if (vdList.Length > 3)
            {
                VirtualDesktop vdCurrent = vdList[3];
                vdCurrent.Switch();
            }
        }
        private void btnDesktop_5_Click(object sender, EventArgs e)
        {
            VirtualDesktop[] vdList = VirtualDesktop.GetDesktops();
            if (vdList.Length > 4)
            {
                VirtualDesktop vdCurrent = vdList[4];
                vdCurrent.Switch();
            }
        }

        private void btnDock_Click(object sender, EventArgs e)
        {
            if (!fBarRegistered) {

                btnDock.Text = "UnDock";
                m_nLeft = this.Left;
                m_nTop = this.Top;
                m_nRight = this.Right;
                m_nBottom = this.Bottom;
            } else {
                btnDock.Text = "Dock";
                MoveWindow(this.Handle, m_nLeft, m_nTop, m_nRight - m_nLeft, m_nBottom - m_nTop, true);
            }
            RegisterBar();

        }
    }
}

