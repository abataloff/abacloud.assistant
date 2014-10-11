using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abacloud.assistant
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //generateRandomFile("random.out");
            var _sender = new Sender();
            //_sender.SendFile*("c:\\temp\\#02 Allen.mkv");
            //_sender.SendFile("c:\\temp\\Code_orig.rar");
            //_sender.SendFile("random.out");
            _sender.SendDirectory(@"c:\Users\abatalov\Code\AbaBackup\");

            //Application.Run(new MainWindow());
        }

        private static void generateRandomFile(string a_fileName)
        {
            var _file = File.Create(a_fileName);
            var _rnd = new Random();
            for (var _i = 0; _i < 1*1024*1024; _i++)
            {
                _file.WriteByte((byte) _rnd.Next(byte.MaxValue));
            }
            _file.Close();
        }
    }
}
