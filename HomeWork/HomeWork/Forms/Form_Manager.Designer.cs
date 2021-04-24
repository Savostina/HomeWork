
namespace HomeWork.Forms
{
    partial class Form_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Manager));
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.label_Manager = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.button_CreatingOrder = new System.Windows.Forms.Button();
            this.label_Viewing = new System.Windows.Forms.Label();
            this.button_Sortname = new System.Windows.Forms.Button();
            this.button_Sortnumber = new System.Windows.Forms.Button();
            this.textBox_DataoutputfromBD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(200, 199);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 0;
            this.pictureBox_avatar.TabStop = false;
            // 
            // label_Manager
            // 
            this.label_Manager.AutoSize = true;
            this.label_Manager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Manager.Location = new System.Drawing.Point(12, 214);
            this.label_Manager.Name = "label_Manager";
            this.label_Manager.Size = new System.Drawing.Size(83, 20);
            this.label_Manager.TabIndex = 1;
            this.label_Manager.Text = "Менеджер";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Login.Location = new System.Drawing.Point(12, 236);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(23, 20);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "@";
            // 
            // button_CreatingOrder
            // 
            this.button_CreatingOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.button_CreatingOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreatingOrder.ForeColor = System.Drawing.Color.White;
            this.button_CreatingOrder.Location = new System.Drawing.Point(16, 260);
            this.button_CreatingOrder.Name = "button_CreatingOrder";
            this.button_CreatingOrder.Size = new System.Drawing.Size(196, 30);
            this.button_CreatingOrder.TabIndex = 3;
            this.button_CreatingOrder.Text = "Оформление заказа";
            this.button_CreatingOrder.UseVisualStyleBackColor = false;
            this.button_CreatingOrder.Click += new System.EventHandler(this.button_CreatingOrder_Click);
            // 
            // label_Viewing
            // 
            this.label_Viewing.AutoSize = true;
            this.label_Viewing.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Viewing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_Viewing.Location = new System.Drawing.Point(345, 12);
            this.label_Viewing.Name = "label_Viewing";
            this.label_Viewing.Size = new System.Drawing.Size(314, 25);
            this.label_Viewing.TabIndex = 4;
            this.label_Viewing.Text = "Просмотр существующих заказов";
            // 
            // button_Sortname
            // 
            this.button_Sortname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.button_Sortname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sortname.ForeColor = System.Drawing.Color.White;
            this.button_Sortname.Location = new System.Drawing.Point(515, 40);
            this.button_Sortname.Name = "button_Sortname";
            this.button_Sortname.Size = new System.Drawing.Size(196, 30);
            this.button_Sortname.TabIndex = 5;
            this.button_Sortname.Text = "Сортировка по названию";
            this.button_Sortname.UseVisualStyleBackColor = false;
            // 
            // button_Sortnumber
            // 
            this.button_Sortnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.button_Sortnumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sortnumber.ForeColor = System.Drawing.Color.White;
            this.button_Sortnumber.Location = new System.Drawing.Point(313, 40);
            this.button_Sortnumber.Name = "button_Sortnumber";
            this.button_Sortnumber.Size = new System.Drawing.Size(196, 30);
            this.button_Sortnumber.TabIndex = 6;
            this.button_Sortnumber.Text = "Сортировка по номеру";
            this.button_Sortnumber.UseVisualStyleBackColor = false;
            // 
            // textBox_DataoutputfromBD
            // 
            this.textBox_DataoutputfromBD.Location = new System.Drawing.Point(223, 77);
            this.textBox_DataoutputfromBD.Multiline = true;
            this.textBox_DataoutputfromBD.Name = "textBox_DataoutputfromBD";
            this.textBox_DataoutputfromBD.Size = new System.Drawing.Size(565, 213);
            this.textBox_DataoutputfromBD.TabIndex = 7;
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.textBox_DataoutputfromBD);
            this.Controls.Add(this.button_Sortnumber);
            this.Controls.Add(this.button_Sortname);
            this.Controls.Add(this.label_Viewing);
            this.Controls.Add(this.button_CreatingOrder);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Manager);
            this.Controls.Add(this.pictureBox_avatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Manager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.Label label_Manager;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Button button_CreatingOrder;
        private System.Windows.Forms.Label label_Viewing;
        private System.Windows.Forms.Button button_Sortname;
        private System.Windows.Forms.Button button_Sortnumber;
        private System.Windows.Forms.TextBox textBox_DataoutputfromBD;
    }
}