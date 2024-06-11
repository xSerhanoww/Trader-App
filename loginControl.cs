
using System.Data;
using TraderBeta_02.Data;
using static TraderBeta_02.Form1;
using static TraderBeta_02.AccountForm;

namespace TraderBeta_02
{
    public partial class LoginControl : UserControl
    {
        private static string Username {  get; set; }

        public LoginControl()
        {
            InitializeComponent();
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.Instance.panel3.Enabled = true;
            Form1.Instance.panel1.Enabled = true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (var db = new StocksDbContext()) 
            {
               var user = db.Users.Where(x => x.Username == username_txtbox.Text).FirstOrDefault();
                if (user != null && user.Password == password_txtbox.Text)
                {
                    isLoggedIn = true;
                    LoggedUserId = user.ID;
                    Username = user.Name;
                    Balance = user.Balance;
                    StaticBalance = 100000;
                    exit_Click(sender, e);
                    CheckLogin();

                }
                else incorrectPass_lbl.Visible = true;
               
            
            }
        }
        public static void CheckLogin()
        {

            if (isLoggedIn == true)
            {
                Instance.welcome_lbl.Visible = true;
                Instance.welcome_lbl.Text = $"Welcome, {Username} !";
                Instance.login_btn.Visible = false;
                Instance.logout_btn.Visible = true;

            }
            else
            {
                Instance.welcome_lbl.Visible = false;
                Instance.login_btn.Visible = true;
                Instance.logout_btn.Visible = false;


            }
               




        }
    }
}
