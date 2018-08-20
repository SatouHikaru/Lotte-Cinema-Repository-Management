using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucPassword : UserControl
    {
        public Account account = new Account();
        AccountBLL accountBLL = new AccountBLL();

        public ucPassword()
        {
            InitializeComponent();
        }

        private static ucPassword instance;
        public static ucPassword Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucPassword();
                return instance;
            }
        }

        private void splBtnChange_Click(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtEdtOldPassword, "");
            if (txtEdtOldPassword.Text == "")
                errorProvider.SetError(txtEdtOldPassword, "Bạn chưa nhập mật khẩu cũ");

            errorProvider.SetError(txtEdtNewPassword1, "");
            if (txtEdtNewPassword1.Text == "")
                errorProvider.SetError(txtEdtNewPassword1, "Bạn chưa nhập mật khẩu mới");

            errorProvider.SetError(txtEdtNewPassword2, "");
            if (txtEdtNewPassword2.Text == "")
                errorProvider.SetError(txtEdtNewPassword2, "Bạn chưa nhập lại mật khẩu mới");

            if (txtEdtNewPassword1.Text == txtEdtNewPassword2.Text &&
                txtEdtNewPassword1.Text != "")
            {
                DataTable dt = new DataTable();
                account.Password = txtEdtNewPassword1.Text;
                dt = accountBLL.ResetPassword(account);
                Clear();
                XtraMessageBox.Show("Đã thay đổi mật khẩu", "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Clear()
        {
            txtEdtOldPassword.Text = "";
            txtEdtNewPassword1.Text = "";
            txtEdtNewPassword2.Text = "";
        }

        private void splBtnClear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }
    }
}