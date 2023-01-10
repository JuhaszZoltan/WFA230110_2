using WFA230110_2.Properties;

namespace WFA230110_2
{
    public partial class CtrlLogIn : UserControl
    {
        public FrmMain FrmMainRef { get; }

        public event EventHandler<LogInEventArgs> LogInEvent;

        public CtrlLogIn(FrmMain frmMain)
        {
            InitializeComponent();
            btnLogIn.Click += OnBtnLogInClick;
            FrmMainRef = frmMain;
        }

        private void OnBtnLogInClick(object? sender, EventArgs e)
        {
            if (tbUsername.Text == Resources.username
                && tbPassword.Text == Resources.password)
            {
                //FrmMainRef.pnlMain.Controls.Remove(this);
                //FrmMainRef.pnlMain.Controls.Add(
                //    FrmMainRef.CtrlApplicationMain);
                LogInEvent?.Invoke(this, new LogInEventArgs() { IsSuccessed = true, Username = $"{tbUsername.Text}" });
            }
            else
            {
                LogInEvent?.Invoke(this, new LogInEventArgs() { IsSuccessed = false });
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
            }

        }


    }
}
