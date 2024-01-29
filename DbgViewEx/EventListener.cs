using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Session;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DbgViewEx
{
	public static class EventListener
	{
		public static void Initialize()
		{
			using (var session = new TraceEventSession(KernelTraceEventParser.KernelSessionName))
			{
				session.EnableKernelProvider(KernelTraceEventParser.Keywords.Process | KernelTraceEventParser.Keywords.ImageLoad);
				var parser = session.Source.Kernel;

				parser.ImageLoad += e => {
					Main.main.AddEvent(e);
				};

				Task.Run(() => session.Source.Process());
				//Thread.Sleep(TimeSpan.FromSeconds(5));
			}
		}
	}
}