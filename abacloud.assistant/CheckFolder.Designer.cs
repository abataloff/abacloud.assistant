namespace abacloud.assistant
{
    partial class CheckFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.v_tbPathToFolder = new System.Windows.Forms.TextBox();
            this.v_btnStart = new System.Windows.Forms.Button();
            this.v_btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.v_dgv = new System.Windows.Forms.DataGridView();
            this.v_dgvcbcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.v_dgvtbcFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_dgvtbcHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_dgvtbcExistInCloud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_btnUploadToCloud = new System.Windows.Forms.Button();
            this.v_llSelectNotExistInCloud = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.v_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // v_tbPathToFolder
            // 
            this.v_tbPathToFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_tbPathToFolder.Location = new System.Drawing.Point(94, 14);
            this.v_tbPathToFolder.Name = "v_tbPathToFolder";
            this.v_tbPathToFolder.Size = new System.Drawing.Size(482, 20);
            this.v_tbPathToFolder.TabIndex = 0;
            // 
            // v_btnStart
            // 
            this.v_btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v_btnStart.Location = new System.Drawing.Point(613, 12);
            this.v_btnStart.Name = "v_btnStart";
            this.v_btnStart.Size = new System.Drawing.Size(75, 23);
            this.v_btnStart.TabIndex = 1;
            this.v_btnStart.Text = "Начать";
            this.v_btnStart.UseVisualStyleBackColor = true;
            this.v_btnStart.Click += new System.EventHandler(this.v_btnStart_Click);
            // 
            // v_btnSelectFolder
            // 
            this.v_btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v_btnSelectFolder.Location = new System.Drawing.Point(582, 12);
            this.v_btnSelectFolder.Name = "v_btnSelectFolder";
            this.v_btnSelectFolder.Size = new System.Drawing.Size(25, 23);
            this.v_btnSelectFolder.TabIndex = 2;
            this.v_btnSelectFolder.Text = "...";
            this.v_btnSelectFolder.UseVisualStyleBackColor = true;
            this.v_btnSelectFolder.Click += new System.EventHandler(this.v_btnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь к папке:";
            // 
            // v_dgv
            // 
            this.v_dgv.AllowUserToAddRows = false;
            this.v_dgv.AllowUserToDeleteRows = false;
            this.v_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.v_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.v_dgvcbcCheck,
            this.v_dgvtbcFileName,
            this.v_dgvtbcHash,
            this.v_dgvtbcExistInCloud});
            this.v_dgv.Location = new System.Drawing.Point(15, 40);
            this.v_dgv.Name = "v_dgv";
            this.v_dgv.RowHeadersVisible = false;
            this.v_dgv.Size = new System.Drawing.Size(673, 190);
            this.v_dgv.TabIndex = 4;
            // 
            // v_dgvcbcCheck
            // 
            this.v_dgvcbcCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.v_dgvcbcCheck.FillWeight = 25F;
            this.v_dgvcbcCheck.Frozen = true;
            this.v_dgvcbcCheck.HeaderText = "";
            this.v_dgvcbcCheck.Name = "v_dgvcbcCheck";
            this.v_dgvcbcCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.v_dgvcbcCheck.Width = 25;
            // 
            // v_dgvtbcFileName
            // 
            this.v_dgvtbcFileName.FillWeight = 128.1977F;
            this.v_dgvtbcFileName.HeaderText = "Имя файла";
            this.v_dgvtbcFileName.Name = "v_dgvtbcFileName";
            // 
            // v_dgvtbcHash
            // 
            this.v_dgvtbcHash.FillWeight = 128.1977F;
            this.v_dgvtbcHash.HeaderText = "Хеш";
            this.v_dgvtbcHash.Name = "v_dgvtbcHash";
            // 
            // v_dgvtbcExistInCloud
            // 
            this.v_dgvtbcExistInCloud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.v_dgvtbcExistInCloud.FillWeight = 43.60465F;
            this.v_dgvtbcExistInCloud.HeaderText = "В облаке";
            this.v_dgvtbcExistInCloud.Name = "v_dgvtbcExistInCloud";
            this.v_dgvtbcExistInCloud.ReadOnly = true;
            this.v_dgvtbcExistInCloud.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.v_dgvtbcExistInCloud.Width = 78;
            // 
            // v_btnUploadToCloud
            // 
            this.v_btnUploadToCloud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.v_btnUploadToCloud.Location = new System.Drawing.Point(190, 236);
            this.v_btnUploadToCloud.Name = "v_btnUploadToCloud";
            this.v_btnUploadToCloud.Size = new System.Drawing.Size(141, 23);
            this.v_btnUploadToCloud.TabIndex = 5;
            this.v_btnUploadToCloud.Text = "Загрузить в облако";
            this.v_btnUploadToCloud.UseVisualStyleBackColor = true;
            this.v_btnUploadToCloud.Click += new System.EventHandler(this.v_btnUploadToCloud_Click);
            // 
            // v_llSelectNotExistInCloud
            // 
            this.v_llSelectNotExistInCloud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.v_llSelectNotExistInCloud.AutoSize = true;
            this.v_llSelectNotExistInCloud.Location = new System.Drawing.Point(494, 241);
            this.v_llSelectNotExistInCloud.Name = "v_llSelectNotExistInCloud";
            this.v_llSelectNotExistInCloud.Size = new System.Drawing.Size(194, 13);
            this.v_llSelectNotExistInCloud.TabIndex = 6;
            this.v_llSelectNotExistInCloud.TabStop = true;
            this.v_llSelectNotExistInCloud.Text = "Выбрать не существующие в облаке";
            this.v_llSelectNotExistInCloud.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.v_llSelectNotExistInCloud_LinkClicked);
            // 
            // CheckFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 271);
            this.Controls.Add(this.v_llSelectNotExistInCloud);
            this.Controls.Add(this.v_btnUploadToCloud);
            this.Controls.Add(this.v_dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_btnSelectFolder);
            this.Controls.Add(this.v_btnStart);
            this.Controls.Add(this.v_tbPathToFolder);
            this.Name = "CheckFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckFolder";
            ((System.ComponentModel.ISupportInitialize)(this.v_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox v_tbPathToFolder;
        private System.Windows.Forms.Button v_btnStart;
        private System.Windows.Forms.Button v_btnSelectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView v_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn v_dgvcbcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_dgvtbcFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_dgvtbcHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_dgvtbcExistInCloud;
        private System.Windows.Forms.Button v_btnUploadToCloud;
        private System.Windows.Forms.LinkLabel v_llSelectNotExistInCloud;
    }
}