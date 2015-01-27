using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Web.PostOffice
{
    public class HtmlMailMessage : MailMessage
    {
        private Dictionary<string, Stream> _linkedResources;

        [System.Diagnostics.DebuggerStepThrough]
        public HtmlMailMessage()
            : base()
        {
            _linkedResources = new Dictionary<string, Stream>();
        }

        [System.Diagnostics.DebuggerStepThrough]
        public HtmlMailMessage(MailAddress from, MailAddress to)
        {
            _linkedResources = new Dictionary<string, Stream>();
        }

        [System.Diagnostics.DebuggerStepThrough]
        public HtmlMailMessage(string from, string to, string subject, string body)
            : base(from, to, subject, body)
        {
            _linkedResources = new Dictionary<string, Stream>();
        }

        public Dictionary<string, Stream> LinkedResources
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return _linkedResources; }
        }
    }
}
