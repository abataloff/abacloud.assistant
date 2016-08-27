namespace abacloud.assistant
{
    partial class LoginForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.v_tbPassword = new System.Windows.Forms.TextBox();
            this.v_btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.v_tbHost = new System.Windows.Forms.TextBox();
            this.v_tbLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // v_tbPassword
            // 
            this.v_tbPassword.Location = new System.Drawing.Point(70, 64);
            this.v_tbPassword.Name = "v_tbPassword";
            this.v_tbPassword.PasswordChar = '*';
            this.v_tbPassword.Size = new System.Drawing.Size(156, 20);
            this.v_tbPassword.TabIndex = 3;
            // 
            // v_btnLogin
            // 
            this.v_btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.v_btnLogin.Location = new System.Drawing.Point(91, 95);
            this.v_btnLogin.Name = "v_btnLogin";
            this.v_btnLogin.Size = new System.Drawing.Size(75, 23);
            this.v_btnLogin.TabIndex = 4;
            this.v_btnLogin.Text = "Войти";
            this.v_btnLogin.UseVisualStyleBackColor = true;
            this.v_btnLogin.Click += new System.EventHandler(this.v_btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Хост:";
            // 
            // v_tbHost
            // 
            this.v_tbHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::abacloud.assistant.Properties.Settings.Default, "Host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.v_tbHost.Location = new System.Drawing.Point(70, 12);
            this.v_tbHost.Name = "v_tbHost";
            this.v_tbHost.Size = new System.Drawing.Size(156, 20);
            this.v_tbHost.TabIndex = 1;
            this.v_tbHost.Text = global::abacloud.assistant.Properties.Settings.Default.Host;
            // 
            // v_tbLogin
            // 
            this.v_tbLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::abacloud.assistant.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.v_tbLogin.Location = new System.Drawing.Point(70, 38);
            this.v_tbLogin.Name = "v_tbLogin";
            this.v_tbLogin.Size = new System.Drawing.Size(156, 20);
            this.v_tbLogin.TabIndex = 2;
            this.v_tbLogin.Text = global::abacloud.assistant.Properties.Settings.Default.UserName;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.v_btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 130);
            this.Controls.Add(this.v_tbHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v_btnLogin);
            this.Controls.Add(this.v_tbPassword);
            this.Controls.Add(this.v_tbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox v_tbLogin;
        private System.Windows.Forms.TextBox v_tbPassword;
        private System.Windows.Forms.Button v_btnLogin;
        private System.Windows.Forms.TextBox v_tbHost;
        private System.Windows.Forms.Label label3;
    }
}

