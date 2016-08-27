using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abacloud.ApiClient;

namespace abacloud.assistant
{
    internal static class Program
    {
        public static Client Client = null;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Client _client = null;
            var _seesionId = Properties.Settings.Default.SessionId;
            if (!string.IsNullOrEmpty(_seesionId))
                _client = Client.Create(Properties.Settings.Default.Host, new Session(_seesionId));
            else
            {
                var _loginForm = new LoginForm();
                if (_loginForm.ShowDialog() == DialogResult.OK)
                {
                    _client = _loginForm.Client;
                    Properties.Settings.Default.SessionId = _client.Session.ToString();
                    Properties.Settings.Default.Save();
                }
            }

            if (_client != null)
            {
                var _cms = new ContextMenuStrip();

                var _checkFolder = new ToolStripMenuItem("Проверить папку на наличие новых файлов");
                _checkFolder.Click += (a_sender, a_args) => { checkFolder(); };
                _cms.Items.Add(_checkFolder);

                _cms.Items.Add(new ToolStripSeparator());

                var _exitMenuItem = new ToolStripMenuItem("Выйти");
                _exitMenuItem.Click += (a_sender, a_args) => { Application.Exit(); };
                _cms.Items.Add(_exitMenuItem);

                var _ni = new NotifyIcon
                {
                    Icon = Properties.Resources.NotifyIcon,
                    ContextMenuStrip = _cms,
                };

                _ni.Visible = true;
                Client = _client;
                Application.Run();
            }
        }

        private static void checkFolder()
        {
            (new CheckFolder()).Show();
        }

        public static string ComputeHashForContent(string a_fileName)
        {
            var _stream = File.OpenRead(a_fileName);
            var _hashArr = MD5.Create().ComputeHash(_stream);
            var _hashString = string.Empty;
            foreach (var _byte in _hashArr)
            {
                _hashString += Convert.ToString(_byte, 16);
            }

            return string.Format("{0}_{1}", _hashString, _stream.Length);
        }
    }
}
