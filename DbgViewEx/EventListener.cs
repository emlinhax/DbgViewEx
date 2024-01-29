using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using Microsoft.Diagnostics.Tracing.Session;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DbgViewEx
{
    public class EventData
    {
        public string EventIndex;
        public string EventName;
        public string ProcessID;
        public string Summary;
    }

    public static class EventListener
	{
        public static TraceEventSession session = null;

        public static void EventCallback(TraceEvent e)
        {
            EventData eventData = new EventData();
            eventData.EventIndex = e.EventIndex.ToString();
            eventData.EventName = e.EventName;
            eventData.ProcessID = e.ProcessID.ToString();
            eventData.Summary = JsonConvert.SerializeObject(e);

            Main.main.AddEvent(eventData);
        }

        public static void Initialize()
		{
            session = new TraceEventSession(KernelTraceEventParser.KernelSessionName);
            session.EnableKernelProvider(KernelTraceEventParser.Keywords.Process | KernelTraceEventParser.Keywords.ImageLoad | KernelTraceEventParser.Keywords.Registry | KernelTraceEventParser.Keywords.Driver);

            var parser = session.Source.Kernel;
            parser.All += e =>
            {
                EventData eventData = new EventData();
                eventData.EventIndex = e.EventIndex.ToString();
                eventData.EventName = e.EventName;
                eventData.ProcessID = e.ProcessID.ToString();
                eventData.Summary = JsonConvert.SerializeObject(e);

                Main.main.AddEvent(eventData);
            };
        }

        public static void Start()
        {
            Initialize();
            Task.Run(() => session.Source.Process());
        }

        public static void Stop()
        {
            session.Stop();
            session.Dispose();
            session = null;
        }

        public static void ProcessNewData()
		{
			Main.main.RefreshETWLog();
        }
	}
}