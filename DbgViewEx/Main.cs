using Microsoft.Diagnostics.Tracing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbgViewEx
{
    public partial class Main : Form
    {
        public static Main main;
        public List<EventData> PendingEventsToBeAdded = new List<EventData>();   

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            EventListener.Initialize();

            SizeLastColumn(ETW_List);
        }

        public void AddEvent(EventData e)
        {
            PendingEventsToBeAdded.Add(e);            
        }

        public ListViewItem MakeListViewItemFromData(string eventIndex, string eventName, string processId, string summary)
        {
            ListViewItem eventListItem = new ListViewItem(eventIndex);
            eventListItem.SubItems.Add(eventName);
            eventListItem.SubItems.Add(processId);
            eventListItem.SubItems.Add(summary);
            return eventListItem;
        }

        public bool PerformConditionCheck(EFilterAction action, EFilterCondition condition, string source, string comparer)
        {
            if (source == null || comparer == null || action == EFilterAction.NONE || condition == EFilterCondition.NONE) 
                return true; // always include if filter incomplete

            bool takeit = true;
            if(condition == EFilterCondition.EQUALS)
            {
                takeit = (source == comparer);
            }
            if(condition == EFilterCondition.CONTAINS)
            {
                takeit = (source.Contains(comparer));
            }

            return action == EFilterAction.EXCLUDE ? !takeit : takeit;
        }

        public void RefreshETWLog()
        {
            Queue<ListViewItem> items = new Queue<ListViewItem>(); ;
            foreach(EventData e in PendingEventsToBeAdded.ToArray())
            {
                if (Settings.filter.Subject != EFilterSubject.NONE)
                {
                    switch (Settings.filter.Subject)
                    {
                        case EFilterSubject.EVENT_NAME:
                            if (!PerformConditionCheck(Settings.filter.Action, Settings.filter.Condition, e.EventName, Settings.filter.Value))
                                continue;
                            break;
                        case EFilterSubject.PROCESS_ID:
                            if (!PerformConditionCheck(Settings.filter.Action, Settings.filter.Condition, e.ProcessID, Settings.filter.Value))
                                continue;
                            break;
                        case EFilterSubject.SUMMARY:
                            if (!PerformConditionCheck(Settings.filter.Action, Settings.filter.Condition, e.Summary, Settings.filter.Value))
                                continue;
                            break;
                        default:
                            break;
                    }
                }

                ListViewItem item = MakeListViewItemFromData(e.EventIndex, e.EventName, e.ProcessID, e.Summary);
                items.Enqueue(item);
            }

            ETW_List.Items.AddRange(items.ToArray());
            PendingEventsToBeAdded.Clear();
        }

        private void ETW_ProcessTimer_Tick(object sender, EventArgs e)
        {
            ETW_ProcessTimer.Interval = TOOLBAR_Settings_Refresh_0_5.Checked ? 500 : (TOOLBAR_Settings_Refresh_1.Checked ? 1000 : (TOOLBAR_Settings_Refresh_5.Checked ? 5000 : 1000));
            EventListener.ProcessNewData();
        }

        private void TOOLBAR_Settings_Refresh_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var currentItem = sender as ToolStripMenuItem;
            if (currentItem != null)
            {
                ((ToolStripMenuItem)currentItem).DropDownItems
                    .OfType<ToolStripMenuItem>().ToList()
                    .ForEach(item =>
                    {
                        item.Checked = false;
                    });
            }
        }

        public List<string> GetSubjects()
        {
            List<string> subjects = new List<string>();
            foreach(ColumnHeader item in ETW_List.Columns)
            {
                subjects.Add(item.Text);
            }

            return subjects;
        }

        private void ETW_RIB_Filter_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            filterForm.Show();
        }

        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            SizeLastColumn(ETW_List);
        }

        private void ETW_RIB_Start_Click(object sender, EventArgs e)
        {
            ETW_List.Items.Clear();
            ETW_ProcessTimer.Start();
            EventListener.Start();
        }

        private void ETW_RIB_Stop_Click(object sender, EventArgs e)
        {
            ETW_ProcessTimer.Stop();
            EventListener.Stop();
        }
    }
}
