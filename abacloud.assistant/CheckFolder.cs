using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abacloud.assistant
{
    public partial class CheckFolder : Form
    {
        public CheckFolder()
        {
            InitializeComponent();
#if DEBUG
            v_tbPathToFolder.Text = Path.Combine(Application.StartupPath, "Test");
#endif
        }

        private void v_btnSelectFolder_Click(object a_sender, EventArgs a_e)
        {
            var _fbd = new FolderBrowserDialog();
            if (_fbd.ShowDialog() == DialogResult.OK)
            {
                v_tbPathToFolder.Text = _fbd.SelectedPath;
            }
        }

        private void v_btnStart_Click(object a_sender, EventArgs a_e)
        {
            checkFolder(v_tbPathToFolder.Text);
        }

        void checkFolder(string a_pathToFolder)
        {
            foreach (var _fileName in Directory.GetFiles(a_pathToFolder))
            {
                var _hash = Program.ComputeHashForContent(_fileName);
                v_dgv.Rows.Add(false, _fileName, _hash, Program.Client.ExistContent(_hash));
            }

            foreach (var _directoryName in Directory.GetDirectories(a_pathToFolder))
                checkFolder(_directoryName);
        }

        private void v_btnUploadToCloud_Click(object a_sender, EventArgs a_e)
        {
            foreach (DataGridViewRow _row in v_dgv.Rows)
            {
                if ((bool) _row.Cells[0].Value)
                {
                    var _fileName = _row.Cells[1].Value.ToString();
                    Program.Client.SendFile(_fileName);
                }
            }
            MessageBox.Show("Готово");
        }

        private void v_llSelectNotExistInCloud_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow _row in v_dgv.Rows)
            {
                if (!bool.Parse(_row.Cells[3].Value.ToString()))
                    _row.Cells[0].Value = true;
            }
        }
    }
}
