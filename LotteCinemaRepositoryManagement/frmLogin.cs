using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;


namespace LotteCinemaRepositoryManagement
{
    public partial class frmLogin : XtraForm
    {
        DataTable dt = new DataTable();
        Account account = new Account();
        AccountBLL accountBLL = new AccountBLL();
        string username;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void splBtnLogin_Click(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtEdtUsername, "");
            if (txtEdtUsername.Text == "")
                errorProvider.SetError(txtEdtUsername, "Bạn chưa nhập tên đăng nhập");

            errorProvider.SetError(txtEdtPassword, "");
            if (txtEdtPassword.Text == "")
                errorProvider.SetError(txtEdtPassword, "Bạn chưa nhập mật khẩu");

            if (txtEdtUsername.Text != "" && txtEdtPassword.Text != "")
            {
                account.Username = txtEdtUsername.Text;
                account.Password = txtEdtPassword.Text;
                dt = accountBLL.Login(account);
                if (dt.Rows.Count > 0)
                {
                    account.Name = dt.Rows[0]["Name"].ToString();
                    account.Role = dt.Rows[0]["Role"].ToString();
                    txtEdtPassword.Text = "";
                    Hide();
                    frmMain m = new frmMain(account.Username, account.Name, account.Role);
                    m.ShowDialog();
                    Show();
                }
                else
                {
                    txtEdtPassword.Text = "";
                    if (txtEdtUsername.Text != "hikaru")
                        username = txtEdtUsername.Text;
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng", "Thông báo!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void hyperlnkLblCtrlForgotPassword_Click(object sender, System.EventArgs e)
        {
            account.Username = username;
            try
            {
                dt = accountBLL.GetByUsername(account);
                if (dt.Rows.Count > 0)
                {
                    accountBLL.SendMessage(account);
                    XtraMessageBox.Show("Đã gửi thông báo quên mật khẩu cho quản trị viên", "Thông báo!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
            finally
            {
                account.Username = null;
                username = null;
            }
        }

        private void splBtnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}