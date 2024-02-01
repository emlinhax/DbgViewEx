using Newtonsoft.Json.Linq;
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
    public partial class EventDetails : Form
    {
        public EventDetails()
        {
            InitializeComponent();
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {

        }

        public void ProcessDetails(EventData eventData)
        {
            ED_RawJson.Text = JObject.Parse(eventData.Summary).ToString();
            //ED_Stacktrace.Text = eventData.StackTrace;
        }
    }
}
