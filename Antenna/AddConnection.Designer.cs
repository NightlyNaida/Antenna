namespace Antenna
{
    partial class AddConnection
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COM_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_CountSearchedValue = new System.Windows.Forms.Label();
            this.label_CountSearched = new System.Windows.Forms.Label();
            this.button_AddConnection = new System.Windows.Forms.Button();
            this.pictureBox_Load_Animation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load_Animation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COM_Port,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.Leave += new System.EventHandler(this.DataGridView1_Leave);
            // 
            // COM_Port
            // 
            this.COM_Port.HeaderText = "COM порт";
            this.COM_Port.Name = "COM_Port";
            // 
            // ID
            // 
            this.ID.HeaderText = "Идентификатор";
            this.ID.Name = "ID";
            this.ID.Width = 300;
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(21, 178);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(119, 46);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // label_CountSearchedValue
            // 
            this.label_CountSearchedValue.AutoSize = true;
            this.label_CountSearchedValue.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CountSearchedValue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_CountSearchedValue.Location = new System.Drawing.Point(333, 197);
            this.label_CountSearchedValue.Name = "label_CountSearchedValue";
            this.label_CountSearchedValue.Size = new System.Drawing.Size(26, 27);
            this.label_CountSearchedValue.TabIndex = 6;
            this.label_CountSearchedValue.Text = "0";
            this.label_CountSearchedValue.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label_CountSearched
            // 
            this.label_CountSearched.AutoSize = true;
            this.label_CountSearched.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CountSearched.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_CountSearched.Location = new System.Drawing.Point(334, 178);
            this.label_CountSearched.Name = "label_CountSearched";
            this.label_CountSearched.Size = new System.Drawing.Size(130, 19);
            this.label_CountSearched.TabIndex = 5;
            this.label_CountSearched.Text = "Найдено антенн";
            this.label_CountSearched.Click += new System.EventHandler(this.Label4_Click);
            // 
            // button_AddConnection
            // 
            this.button_AddConnection.Enabled = false;
            this.button_AddConnection.Font = new System.Drawing.Font("Aktiv Grotesk Corp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddConnection.Location = new System.Drawing.Point(161, 178);
            this.button_AddConnection.Name = "button_AddConnection";
            this.button_AddConnection.Size = new System.Drawing.Size(119, 46);
            this.button_AddConnection.TabIndex = 7;
            this.button_AddConnection.Text = "Добавить антенну";
            this.button_AddConnection.UseVisualStyleBackColor = true;
            this.button_AddConnection.Click += new System.EventHandler(this.Button_AddConnection_Click);
            // 
            // pictureBox_Load_Animation
            // 
            this.pictureBox_Load_Animation.Image = global::Antenna.Properties.Resources._30;
            this.pictureBox_Load_Animation.Location = new System.Drawing.Point(338, 197);
            this.pictureBox_Load_Animation.Name = "pictureBox_Load_Animation";
            this.pictureBox_Load_Animation.Size = new System.Drawing.Size(126, 22);
            this.pictureBox_Load_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Load_Animation.TabIndex = 8;
            this.pictureBox_Load_Animation.TabStop = false;
            this.pictureBox_Load_Animation.Visible = false;
            // 
            // AddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.pictureBox_Load_Animation);
            this.Controls.Add(this.button_AddConnection);
            this.Controls.Add(this.label_CountSearchedValue);
            this.Controls.Add(this.label_CountSearched);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddConnection";
            this.Text = "AddConnection";
            this.Load += new System.EventHandler(this.AddConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load_Animation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_CountSearchedValue;
        private System.Windows.Forms.Label label_CountSearched;
        private System.Windows.Forms.Button button_AddConnection;
        private System.Windows.Forms.PictureBox pictureBox_Load_Animation;
    }
}