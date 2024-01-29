using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbgViewEx
{
    public enum EFilterSubject
    {
        NONE,
        EVENT_NAME,
        PROCESS_ID
    }

    public enum EFilterCondition
    {
        NONE,
        EQUALS,
        CONTAINS
    }

    public enum EFilterAction
    {
        NONE,
        INCLUDE,
        EXCLUDE
    }

    public class Filter
    {
        public EFilterSubject Subject;
        public EFilterCondition Condition;
        public string Value;
        public EFilterAction Action;
    }
    public static class Settings
    {
        public static Filter filter = new Filter();
    }
}
