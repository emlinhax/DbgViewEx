using Microsoft.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbgViewEx
{
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            EventListener.Initialize();
        }

        public void AddEvent(TraceEvent e)
        {
            ListViewItem eventListItem = new ListViewItem(e.EventIndex.ToString());
            //eventListItem.SubItems.Add();
            eventListItem.SubItems.Add(e.EventName);
            eventListItem.SubItems.Add(e.ProcessID.ToString());



            ETW_List.Items.Add(eventListItem);
        }
    }
}
