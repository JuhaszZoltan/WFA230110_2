using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA230110_2
{
    public class LogInEventArgs : EventArgs
    {
        public bool IsSuccessed { get; set; }
        public string Username { get; set; }
    }
}
