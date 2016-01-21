using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainsLog.Core
{
    public class LogEntry
    {
        public int Id { get; set; } // unique identifier
        public DateTime EntryDate { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public string TextPreview
        {
            get
            {
                if (Text.Length > 100)
                {
                    return Text.Substring(0, 100);
                }
                else return Text.Substring(0, Text.Length);
            }
        }
    }
}
