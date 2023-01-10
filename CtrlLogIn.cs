using WFA230110_2.Properties;

namespace WFA230110_2
{
    public partial class CtrlLogIn : UserControl
    {
        public event EventHandler<LogInEventArgs> LogInEvent;

        public CtrlLogIn()
        {
            InitializeComponent();
            btnLogIn.Click += OnBtnLogInClick;
        }

        private void OnBtnLogInClick(object? sender, EventArgs e)
        {
            if (tbUsername.Text == Resources.username
                && tbPassword.Text == Resources.password)
            {
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
