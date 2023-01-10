using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230110_2
{
    public partial class CtrlApplicationMain : UserControl
    {
        public CtrlApplicationMain(string username)
        {
            InitializeComponent();
            lblHello.Text = $"Hello, {username}!";
        }
    }
}
