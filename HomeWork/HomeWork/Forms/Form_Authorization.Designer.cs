
namespace HomeWork
{
    partial class Form_Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorization));
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Pas = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.button_Authorization = new System.Windows.Forms.Button();
            this.checkBox_Pas = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_Pas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label_Welcome.Location = new System.Drawing.Point(37, 9);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(184, 25);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Добро пожаловать";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Login.Location = new System.Drawing.Point(13, 43);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(55, 20);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Логин:";
            // 
            // label_Pas
            // 
            this.label_Pas.AutoSize = true;
            this.label_Pas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Pas.Location = new System.Drawing.Point(13, 82);
            this.label_Pas.Name = "label_Pas";
            this.label_Pas.Size = new System.Drawing.Size(65, 20);
            this.label_Pas.TabIndex = 2;
            this.label_Pas.Text = "Пароль:";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(84, 43);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(153, 27);
            this.textBox_Login.TabIndex = 4;
            // 
            // button_Authorization
            // 
            this.button_Authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.button_Authorization.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Authorization.ForeColor = System.Drawing.Color.White;
            this.button_Authorization.Location = new System.Drawing.Point(55, 145);
            this.button_Authorization.Name = "button_Authorization";
            this.button_Authorization.Size = new System.Drawing.Size(153, 31);
            this.button_Authorization.TabIndex = 5;
            this.button_Authorization.Text = "Авторизироваться";
            this.button_Authorization.UseVisualStyleBackColor = false;
            this.button_Authorization.Click += new System.EventHandler(this.button_Authorization_Click);
            // 
            // checkBox_Pas
            // 
            this.checkBox_Pas.AutoSize = true;
            this.checkBox_Pas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Pas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkBox_Pas.Location = new System.Drawing.Point(57, 115);
            this.checkBox_Pas.Name = "checkBox_Pas";
            this.checkBox_Pas.Size = new System.Drawing.Size(148, 24);
            this.checkBox_Pas.TabIndex = 6;
            this.checkBox_Pas.Text = "Показать пороль";
            this.checkBox_Pas.UseVisualStyleBackColor = true;
            this.checkBox_Pas.CheckedChanged += new System.EventHandler(this.checkBox_Pas_CheckedChanged);
            // 
            // maskedTextBox_Pas
            // 
            this.maskedTextBox_Pas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_Pas.Location = new System.Drawing.Point(84, 79);
            this.maskedTextBox_Pas.Name = "maskedTextBox_Pas";
            this.maskedTextBox_Pas.PasswordChar = '*';
            this.maskedTextBox_Pas.Size = new System.Drawing.Size(153, 27);
            this.maskedTextBox_Pas.TabIndex = 7;
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 188);
            this.Controls.Add(this.maskedTextBox_Pas);
            this.Controls.Add(this.checkBox_Pas);
            this.Controls.Add(this.button_Authorization);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_Pas);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Authorization_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Pas;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Button button_Authorization;
        private System.Windows.Forms.CheckBox checkBox_Pas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Pas;
    }
}

