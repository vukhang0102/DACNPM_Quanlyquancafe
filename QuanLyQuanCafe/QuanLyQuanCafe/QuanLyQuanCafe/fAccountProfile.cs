using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }

        // hàm cập nhật thông tin tài khoản
        void UpdateAccountInfo()
        {
            int hoa = 0, thuong = 0, dacbiet = 0, so = 0;
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            if (newpass.Length <8)
            {
                lbWarningNewPass.Text = "Nhập mật khẩu tối thiểu 8 ký tự bao gồm số, chữ cái và chứa kí tự đặc biệt";
            }
            else
            {
                for (int i = 0; i < newpass.Length; i++)
                {
                    if (newpass[i] >= 'A' && newpass[i]<= 'Z') hoa++;
                    if (newpass[i] >= 'a' && newpass[i]<= 'z') thuong++;
                    if (newpass[i] >= '0' && newpass[i]<= '9') so++;
                    if (newpass[i] >= '!' && newpass[i]<= '/') dacbiet++;
                    if (newpass[i] >= ':' && newpass[i]<= '@') dacbiet++;
                    if (newpass[i] >= '[' && newpass[i]<= '`') dacbiet++;
                    if (newpass[i] >= '{' && newpass[i]<= '~') dacbiet++;
                }
                if (hoa != 0 && thuong != 0 && dacbiet != 0 && so != 0)
                {
                    string reenterPass = txbReEnterPass.Text;
                    string userName = txbUserName.Text;
                    if (!newpass.Equals(reenterPass))
                    {
                        lbWarningRepeat.Text = "Không trùng khớp với mật khẩu ở trên.";
                        //MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!", "Lưu ý");
                    }
                    else
                    {
                        if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            if (updateAccount != null)
                                updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                        }
                        else
                        {
                            lbCheckPassword.Text = "Mật khẩu không chính xác.";
                            //MessageBox.Show("Vui lòng điền đúng mật khấu");
                        }
                    }
                }
                else
                {
                    lbWarningNewPass.Text = "Nhập mật khẩu tối thiểu 8 ký tự bao gồm số, chữ cái và chứa kí tự đặc biệt.";

                }
            }
              
            
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btnExti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lbCheckPassword.Text = "";
            lbWarningNewPass.Text = "";
            lbWarningRepeat.Text = "";
            UpdateAccountInfo();
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void txbNewPass_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
