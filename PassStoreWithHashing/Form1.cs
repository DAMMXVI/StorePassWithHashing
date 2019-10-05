using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace PassStoreWithHashing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Define variables
        string ID, pass, hashed_password, salt;
        StringBuilder Sb = new StringBuilder();
        char[] split = { ':' };
        string[] splitted;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ID = txtID.Text;
            pass = txtPass.Text;
            hashed_password = hash_password(pass);
            MessageBox.Show(hashed_password);
            btnLogin.Enabled = false;
        }

        private void btnPassControl_Click(object sender, EventArgs e)
        {
            pass = txtPassControl.Text;
            if (check_password(hashed_password, pass))
                MessageBox.Show("Congratulations Correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Opps Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public string hash_password(string password)
        {

            using (var hash = SHA256.Create())
            {
                salt = Guid.NewGuid().ToString();
                Encoding enc = Encoding.UTF8;

                byte[] result = hash.ComputeHash(enc.GetBytes(password + salt));
                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
                Sb.Append(":" + salt);
            }
            return Sb.ToString();
        }
        public bool check_password(string hashed_password, string user_password)
        {
            splitted = hashed_password.Split(split);
            pass = splitted[0];
            salt = splitted[1];
            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;

                byte[] result = hash.ComputeHash(enc.GetBytes(user_password + salt));
                Sb.Clear();
                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
                user_password = Sb.ToString();
            }
            return pass == user_password;

        }
    }
}
