using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abacloud.ApiClient;

namespace abacloud.assistant
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Client Client
        {
            get;
            private set;
        }

        private void v_btnLogin_Click(object a_sender, EventArgs a_e)
        {
            var _client = Client.Create(v_tbHost.Text, v_tbLogin.Text, v_tbPassword.Text);
            if (_client == null)
                MessageBox.Show(@"Не получилось авторизоваться");
            else
            {
                Client = _client;
                DialogResult = DialogResult.OK;
            }
        }

        private void LoginForm_FormClosed(object a_sender, FormClosedEventArgs a_e)
        {
            Properties.Settings.Default.Save();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
