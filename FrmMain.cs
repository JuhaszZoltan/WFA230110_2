namespace WFA230110_2
{
    public partial class FrmMain : Form
    {
        public CtrlLogIn CtrlLogIn { get; set; }
        public CtrlApplicationMain CtrlApplicationMain { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            CtrlLogIn = new(this);

            CtrlLogIn.Location = new()
            {
                X = (pnlMain.Width - CtrlLogIn.Width) / 2,
                Y = (pnlMain.Height - CtrlLogIn.Height) / 2,
            };

            pnlMain.Controls.Add(CtrlLogIn);

            CtrlLogIn.LogInEvent += OnCtrlLogInLogInEvent;
        }

        private void OnCtrlLogInLogInEvent(object? sender, LogInEventArgs e)
        {
            if (e.IsSuccessed)
            {
                pnlMain.Controls.Remove(CtrlLogIn);

                CtrlApplicationMain = new(e.Username);
                CtrlApplicationMain.Location = new()
                {
                    X = (pnlMain.Width - CtrlApplicationMain.Width) / 2,
                    Y = (pnlMain.Height - CtrlApplicationMain.Height) / 2,
                };
                pnlMain.Controls.Add(CtrlApplicationMain);
            }
            else
            {
                _ = MessageBox.Show(
                        caption: "HIBA!",
                        text: "hibás bejelentkezési adatokat adtál meg!\nPróbáld meg újra!",
                        icon: MessageBoxIcon.Error,
                        buttons: MessageBoxButtons.OK);
            }
        }
    }
}