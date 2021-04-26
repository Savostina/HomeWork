
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
            this.comboBoxFiltration = new System.Windows.Forms.ComboBox();
            this.dataGridViewDBdata = new System.Windows.Forms.DataGridView();
            this.labelmenu = new System.Windows.Forms.Label();
            this.labelFiltration = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
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
            this.label_Login.Location = new System.Drawing.Point(12, 49);
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
            this.buttonCreatingOrder.Location = new System.Drawing.Point(8, 103);
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
            this.labelViewing.Location = new System.Drawing.Point(474, 12);
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
            // comboBoxFiltration
            // 
            this.comboBoxFiltration.FormattingEnabled = true;
            this.comboBoxFiltration.Location = new System.Drawing.Point(213, 348);
            this.comboBoxFiltration.Name = "comboBoxFiltration";
            this.comboBoxFiltration.Size = new System.Drawing.Size(575, 21);
            this.comboBoxFiltration.TabIndex = 6;
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
            // labelmenu
            // 
            this.labelmenu.AutoSize = true;
            this.labelmenu.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.labelmenu.Location = new System.Drawing.Point(74, 76);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.Size = new System.Drawing.Size(64, 25);
            this.labelmenu.TabIndex = 9;
            this.labelmenu.Text = "Меню";
            // 
            // labelFiltration
            // 
            this.labelFiltration.AutoSize = true;
            this.labelFiltration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFiltration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelFiltration.Location = new System.Drawing.Point(209, 325);
            this.labelFiltration.Name = "labelFiltration";
            this.labelFiltration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFiltration.Size = new System.Drawing.Size(94, 20);
            this.labelFiltration.TabIndex = 10;
            this.labelFiltration.Text = "Фильтрация";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelName.Location = new System.Drawing.Point(172, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 12;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFiltration);
            this.Controls.Add(this.labelmenu);
            this.Controls.Add(this.dataGridViewDBdata);
            this.Controls.Add(this.comboBoxFiltration);
            this.Controls.Add(this.pictureBoxlogo);
            this.Controls.Add(this.labelViewing);
            this.Controls.Add(this.buttonCreatingOrder);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.pictureBoxavatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManager";
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
        private System.Windows.Forms.ComboBox comboBoxFiltration;
        private System.Windows.Forms.DataGridView dataGridViewDBdata;
        private System.Windows.Forms.Label labelmenu;
        private System.Windows.Forms.Label labelFiltration;
        private System.Windows.Forms.Label labelName;
    }
}