namespace Antenna
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label_for_login_textBox = new System.Windows.Forms.Label();
            this.label_for_password_textBox = new System.Windows.Forms.Label();
            this.button_LetsConnection = new System.Windows.Forms.Button();
            this.label_LetsChangeConnectionOptions = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.password_textBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_LoadingAnimation = new System.Windows.Forms.PictureBox();
            this.label_TryConnection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(97, 32);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(200, 20);
            this.login_textBox.TabIndex = 0;
            // 
            // label_for_login_textBox
            // 
            this.label_for_login_textBox.AutoSize = true;
            this.label_for_login_textBox.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12.25F);
            this.label_for_login_textBox.Location = new System.Drawing.Point(93, 9);
            this.label_for_login_textBox.Name = "label_for_login_textBox";
            this.label_for_login_textBox.Size = new System.Drawing.Size(56, 20);
            this.label_for_login_textBox.TabIndex = 1;
            this.label_for_login_textBox.Text = "Логин";
            // 
            // label_for_password_textBox
            // 
            this.label_for_password_textBox.AutoSize = true;
            this.label_for_password_textBox.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12.25F);
            this.label_for_password_textBox.Location = new System.Drawing.Point(93, 74);
            this.label_for_password_textBox.Name = "label_for_password_textBox";
            this.label_for_password_textBox.Size = new System.Drawing.Size(67, 20);
            this.label_for_password_textBox.TabIndex = 3;
            this.label_for_password_textBox.Text = "Пароль";
            // 
            // button_LetsConnection
            // 
            this.button_LetsConnection.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 11.25F);
            this.button_LetsConnection.Location = new System.Drawing.Point(97, 175);
            this.button_LetsConnection.Name = "button_LetsConnection";
            this.button_LetsConnection.Size = new System.Drawing.Size(117, 31);
            this.button_LetsConnection.TabIndex = 4;
            this.button_LetsConnection.Text = "Подключение";
            this.button_LetsConnection.UseVisualStyleBackColor = true;
            this.button_LetsConnection.Click += new System.EventHandler(this.Button_LetsConnection_click);
            // 
            // label_LetsChangeConnectionOptions
            // 
            this.label_LetsChangeConnectionOptions.AutoSize = true;
            this.label_LetsChangeConnectionOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_LetsChangeConnectionOptions.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LetsChangeConnectionOptions.Location = new System.Drawing.Point(93, 222);
            this.label_LetsChangeConnectionOptions.Name = "label_LetsChangeConnectionOptions";
            this.label_LetsChangeConnectionOptions.Size = new System.Drawing.Size(203, 19);
            this.label_LetsChangeConnectionOptions.TabIndex = 6;
            this.label_LetsChangeConnectionOptions.Text = "Смена параметров подключения";
            this.label_LetsChangeConnectionOptions.UseCompatibleTextRendering = true;
            this.label_LetsChangeConnectionOptions.Click += new System.EventHandler(this.Label_LetsChangeConnectionOptions_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(389, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";

            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 8.25F);
            this.password_textBox.Location = new System.Drawing.Point(97, 97);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(200, 20);
            this.password_textBox.TabIndex = 8;
            this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_textBox_KeyDown);
            // 
            // pictureBox_LoadingAnimation
            // 
            this.pictureBox_LoadingAnimation.Image = global::Antenna.Properties.Resources._30;
            this.pictureBox_LoadingAnimation.Location = new System.Drawing.Point(97, 123);
            this.pictureBox_LoadingAnimation.Name = "pictureBox_LoadingAnimation";
            this.pictureBox_LoadingAnimation.Size = new System.Drawing.Size(190, 27);
            this.pictureBox_LoadingAnimation.TabIndex = 9;
            this.pictureBox_LoadingAnimation.TabStop = false;
            this.pictureBox_LoadingAnimation.Visible = false;
            // 
            // label_TryConnection
            // 
            this.label_TryConnection.AutoSize = true;
            this.label_TryConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_TryConnection.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TryConnection.Location = new System.Drawing.Point(97, 153);
            this.label_TryConnection.Name = "label_TryConnection";
            this.label_TryConnection.Size = new System.Drawing.Size(98, 19);
            this.label_TryConnection.TabIndex = 10;
            this.label_TryConnection.Text = "Подключаюсь...";
            this.label_TryConnection.UseCompatibleTextRendering = true;
            this.label_TryConnection.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(389, 275);
            this.Controls.Add(this.label_TryConnection);
            this.Controls.Add(this.pictureBox_LoadingAnimation);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_LetsChangeConnectionOptions);
            this.Controls.Add(this.button_LetsConnection);
            this.Controls.Add(this.label_for_password_textBox);
            this.Controls.Add(this.label_for_login_textBox);
            this.Controls.Add(this.login_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label label_for_login_textBox;
        private System.Windows.Forms.Label label_for_password_textBox;
        private System.Windows.Forms.Button button_LetsConnection;
        private System.Windows.Forms.Label label_LetsChangeConnectionOptions;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MaskedTextBox password_textBox;
        private System.Windows.Forms.PictureBox pictureBox_LoadingAnimation;
        private System.Windows.Forms.Label label_TryConnection;
    }
}

