using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace ToDoListv2.View
{
    public partial class MyObjectListView : ObjectListView
    {
        protected override void WndProc( ref Message m )
        {
            switch ( m.Msg )
            {
                case WM_NCCALCSIZE: 
                    int style = (int)GetWindowLong( this.Handle, GWL_STYLE );
                    if ( (style & WS_VSCROLL) == WS_VSCROLL )
                        SetWindowLong( this.Handle, GWL_STYLE, style & ~WS_VSCROLL );
                    if ( (style & WS_HSCROLL) == WS_HSCROLL )
                        SetWindowLong( this.Handle, GWL_STYLE, style & ~WS_HSCROLL );
                    base.WndProc( ref m );
                    break;
                case WM_MOUSEWHEEL:
                    short delta = (short)((int)(long)m.WParam >> 16);
                    SendMessage( this.Handle, WM_VSCROLL, (IntPtr)(delta < 0 ? SB_LINEUP : SB_LINEDOWN), IntPtr.Zero );
                    base.WndProc( ref m );
                    break;
                default:
                    base.WndProc( ref m );
                    break;
            }
        }

        const int GWL_STYLE = -16;
        const int WM_VSCROLL = 0x115;
        const int WM_NCCALCSIZE = 0x83;
        const int WM_MOUSEWHEEL = 0x20a;
        const int WS_VSCROLL = 0x00200000;
        const int WS_HSCROLL = 0x00100000;
        const int SB_LINEDOWN = 0;
        const int SB_LINEUP = 1;

        public static int GetWindowLong( IntPtr hWnd, int nIndex )
        {
            if ( IntPtr.Size == 4 )
                return (int)GetWindowLong32( hWnd, nIndex );
            else
                return (int)(long)GetWindowLongPtr64( hWnd, nIndex );
        }

        public static int SetWindowLong( IntPtr hWnd, int nIndex, int dwNewLong )
        {
            if ( IntPtr.Size == 4 )
                return (int)SetWindowLongPtr32( hWnd, nIndex, dwNewLong );
            else
                return (int)(long)SetWindowLongPtr64( hWnd, nIndex, dwNewLong );
        }

        [DllImport( "user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto )]
        public static extern IntPtr GetWindowLong32( IntPtr hWnd, int nIndex );

        [DllImport( "user32.dll", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto )]
        public static extern IntPtr GetWindowLongPtr64( IntPtr hWnd, int nIndex );

        [DllImport( "user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto )]
        public static extern IntPtr SetWindowLongPtr32( IntPtr hWnd, int nIndex, int dwNewLong );

        [DllImport( "user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto )]
        public static extern IntPtr SetWindowLongPtr64( IntPtr hWnd, int nIndex, int dwNewLong );

        [DllImport( "user32.dll" )]
        private static extern IntPtr SendMessage( IntPtr hWnd, int msg, IntPtr wp, IntPtr lp );

        public MyObjectListView()
        {
            InitializeComponent();
        }
    }
}