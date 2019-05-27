namespace Antenna
{
    partial class ChangeConnectionParameters
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
            this.label_IPServer = new System.Windows.Forms.Label();
            this.label_DBMS_Port = new System.Windows.Forms.Label();
            this.textBox_DBMS_Port = new System.Windows.Forms.TextBox();
            this.label_NameBD = new System.Windows.Forms.Label();
            this.textBox_NameBD = new System.Windows.Forms.TextBox();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_IPServer = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label_IPServer
            // 
            this.label_IPServer.AutoSize = true;
            this.label_IPServer.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12.25F);
            this.label_IPServer.Location = new System.Drawing.Point(12, 9);
            this.label_IPServer.Name = "label_IPServer";
            this.label_IPServer.Size = new System.Drawing.Size(130, 20);
            this.label_IPServer.TabIndex = 3;
            this.label_IPServer.Text = "Адрес сервера";
            // 
            // label_DBMS_Port
            // 
            this.label_DBMS_Port.AutoSize = true;
            this.label_DBMS_Port.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12.25F);
            this.label_DBMS_Port.Location = new System.Drawing.Point(12, 68);
            this.label_DBMS_Port.Name = "label_DBMS_Port";
            this.label_DBMS_Port.Size = new System.Drawing.Size(96, 20);
            this.label_DBMS_Port.TabIndex = 5;
            this.label_DBMS_Port.Text = "Порт СУБД";
            // 
            // textBox_DBMS_Port
            // 
            this.textBox_DBMS_Port.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DBMS_Port.Location = new System.Drawing.Point(16, 91);
            this.textBox_DBMS_Port.Name = "textBox_DBMS_Port";
            this.textBox_DBMS_Port.Size = new System.Drawing.Size(200, 20);
            this.textBox_DBMS_Port.TabIndex = 4;
            // 
            // label_NameBD
            // 
            this.label_NameBD.AutoSize = true;
            this.label_NameBD.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12.25F);
            this.label_NameBD.Location = new System.Drawing.Point(12, 133);
            this.label_NameBD.Name = "label_NameBD";
            this.label_NameBD.Size = new System.Drawing.Size(109, 20);
            this.label_NameBD.TabIndex = 7;
            this.label_NameBD.Text = "Название БД";
            // 
            // textBox_NameBD
            // 
            this.textBox_NameBD.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NameBD.Location = new System.Drawing.Point(16, 156);
            this.textBox_NameBD.Name = "textBox_NameBD";
            this.textBox_NameBD.Size = new System.Drawing.Size(200, 20);
            this.textBox_NameBD.TabIndex = 6;
            // 
            // button_Change
            // 
            this.button_Change.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 11.25F);
            this.button_Change.Location = new System.Drawing.Point(16, 217);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(200, 31);
            this.button_Change.TabIndex = 8;
            this.button_Change.Text = "Изменить параметры";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 11.25F);
            this.button_Cancel.Location = new System.Drawing.Point(16, 254);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(200, 31);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // textBox_IPServer
            // 
            this.textBox_IPServer.Location = new System.Drawing.Point(16, 32);
            this.textBox_IPServer.Name = "textBox_IPServer";
            this.textBox_IPServer.Size = new System.Drawing.Size(200, 20);
            this.textBox_IPServer.TabIndex = 10;
            this.textBox_IPServer.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.textBox_IPServer.ValidatingType = typeof(System.DateTime);
            // 
            // ChangeConnectionParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 306);
            this.Controls.Add(this.textBox_IPServer);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label_NameBD);
            this.Controls.Add(this.textBox_NameBD);
            this.Controls.Add(this.label_DBMS_Port);
            this.Controls.Add(this.textBox_DBMS_Port);
            this.Controls.Add(this.label_IPServer);
            this.Name = "ChangeConnectionParameters";
            this.Text = "Изменение параметров подключения";
            this.Load += new System.EventHandler(this.ChangeConnectionParameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IPServer;
        private System.Windows.Forms.Label label_DBMS_Port;
        private System.Windows.Forms.TextBox textBox_DBMS_Port;
        private System.Windows.Forms.Label label_NameBD;
        private System.Windows.Forms.TextBox textBox_NameBD;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.MaskedTextBox textBox_IPServer;
    }
}