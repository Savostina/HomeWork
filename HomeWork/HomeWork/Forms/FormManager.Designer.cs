
namespace HomeWork.Forms
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.pictureBoxavatar = new System.Windows.Forms.PictureBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.buttonCreatingOrder = new System.Windows.Forms.Button();
            this.labelViewing = new System.Windows.Forms.Label();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.comboBoxfname = new System.Windows.Forms.ComboBox();
            this.comboBoxfnumber = new System.Windows.Forms.ComboBox();
            this.dataGridViewDBdata = new System.Windows.Forms.DataGridView();
            this.labelmenu = new System.Windows.Forms.Label();
            this.labelfname = new System.Windows.Forms.Label();
            this.labelfnumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxavatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBdata)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxavatar
            // 
            this.pictureBoxavatar.Location = new System.Drawing.Point(49, 12);
            this.pictureBoxavatar.Name = "pictureBoxavatar";
            this.pictureBoxavatar.Size = new System.Drawing.Size(31, 30);
            this.pictureBoxavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxavatar.TabIndex = 0;
            this.pictureBoxavatar.TabStop = false;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelManager.Location = new System.Drawing.Point(83, 17);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(83, 20);
            this.labelManager.TabIndex = 1;
            this.labelManager.Text = "Менеджер";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Login.Location = new System.Drawing.Point(161, 18);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(23, 20);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "@";
            // 
            // buttonCreatingOrder
            // 
            this.buttonCreatingOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.buttonCreatingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatingOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreatingOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCreatingOrder.Location = new System.Drawing.Point(11, 79);
            this.buttonCreatingOrder.Name = "buttonCreatingOrder";
            this.buttonCreatingOrder.Size = new System.Drawing.Size(196, 30);
            this.buttonCreatingOrder.TabIndex = 3;
            this.buttonCreatingOrder.Text = "Оформление заказа";
            this.buttonCreatingOrder.UseVisualStyleBackColor = false;
            this.buttonCreatingOrder.Click += new System.EventHandler(this.buttonCreatingOrder_Click);
            // 
            // labelViewing
            // 
            this.labelViewing.AutoSize = true;
            this.labelViewing.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.labelViewing.Location = new System.Drawing.Point(339, 17);
            this.labelViewing.Name = "labelViewing";
            this.labelViewing.Size = new System.Drawing.Size(314, 25);
            this.labelViewing.TabIndex = 4;
            this.labelViewing.Text = "Просмотр существующих заказов";
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Image = global::HomeWork.Properties.Resources.social_media_logo_google_plus_icon_icons_com_56623;
            this.pictureBoxlogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(31, 30);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 5;
            this.pictureBoxlogo.TabStop = false;
            // 
            // comboBoxfname
            // 
            this.comboBoxfname.FormattingEnabled = true;
            this.comboBoxfname.Location = new System.Drawing.Point(213, 348);
            this.comboBoxfname.Name = "comboBoxfname";
            this.comboBoxfname.Size = new System.Drawing.Size(257, 21);
            this.comboBoxfname.TabIndex = 6;
            // 
            // comboBoxfnumber
            // 
            this.comboBoxfnumber.FormattingEnabled = true;
            this.comboBoxfnumber.Location = new System.Drawing.Point(531, 347);
            this.comboBoxfnumber.Name = "comboBoxfnumber";
            this.comboBoxfnumber.Size = new System.Drawing.Size(257, 21);
            this.comboBoxfnumber.TabIndex = 7;
            // 
            // dataGridViewDBdata
            // 
            this.dataGridViewDBdata.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDBdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBdata.GridColor = System.Drawing.Color.White;
            this.dataGridViewDBdata.Location = new System.Drawing.Point(213, 49);
            this.dataGridViewDBdata.Name = "dataGridViewDBdata";
            this.dataGridViewDBdata.Size = new System.Drawing.Size(575, 268);
            this.dataGridViewDBdata.TabIndex = 8;
            // 
            // labelmenu
            // 
            this.labelmenu.AutoSize = true;
            this.labelmenu.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.labelmenu.Location = new System.Drawing.Point(77, 52);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.Size = new System.Drawing.Size(64, 25);
            this.labelmenu.TabIndex = 9;
            this.labelmenu.Text = "Меню";
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelfname.Location = new System.Drawing.Point(209, 325);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(166, 20);
            this.labelfname.TabIndex = 10;
            this.labelfname.Text = "Фильтрация по имени";
            // 
            // labelfnumber
            // 
            this.labelfnumber.AutoSize = true;
            this.labelfnumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelfnumber.Location = new System.Drawing.Point(527, 325);
            this.labelfnumber.Name = "labelfnumber";
            this.labelfnumber.Size = new System.Drawing.Size(173, 20);
            this.labelfnumber.TabIndex = 11;
            this.labelfnumber.Text = "Фильтрация по номеру";
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.labelfnumber);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.labelmenu);
            this.Controls.Add(this.dataGridViewDBdata);
            this.Controls.Add(this.comboBoxfnumber);
            this.Controls.Add(this.comboBoxfname);
            this.Controls.Add(this.pictureBoxlogo);
            this.Controls.Add(this.labelViewing);
            this.Controls.Add(this.buttonCreatingOrder);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.pictureBoxavatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxavatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxavatar;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Button buttonCreatingOrder;
        private System.Windows.Forms.Label labelViewing;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.ComboBox comboBoxfname;
        private System.Windows.Forms.ComboBox comboBoxfnumber;
        private System.Windows.Forms.DataGridView dataGridViewDBdata;
        private System.Windows.Forms.Label labelmenu;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label labelfnumber;
    }
}