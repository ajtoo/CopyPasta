using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPasta
{
    public partial class Form1 : Form
    {
        public static BindingList<string> copied = new BindingList<string>();
        private int listSize = 32;

        private const int WM_CLIPBOARDUPDATE = 0x031D;

        //pinvoke calls for add and remove clipboard listener functions
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AddClipboardFormatListener(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddClipboardFormatListener(this.Handle);
            CopyList.DataSource = copied;
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                copied.Add(Clipboard.GetText());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = CopyList.SelectedItem.ToString();

            //place in clipboard
            Clipboard.SetText(curItem);
        }
    }
}
