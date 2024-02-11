namespace Med_Tech
{
    partial class Avtarizacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtarizacia));
            this.Skrit_parol = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassvordTextBox = new System.Windows.Forms.TextBox();
            this.Avtorizacia1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Skrit_parol
            // 
            this.Skrit_parol.AutoSize = true;
            this.Skrit_parol.Location = new System.Drawing.Point(226, 99);
            this.Skrit_parol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skrit_parol.Name = "Skrit_parol";
            this.Skrit_parol.Size = new System.Drawing.Size(13, 13);
            this.Skrit_parol.TabIndex = 19;
            this.Skrit_parol.Text = "0";
            this.Skrit_parol.Click += new System.EventHandler(this.Skrit_parol_Click);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(24, 159);
            this.Registration.Margin = new System.Windows.Forms.Padding(2);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(213, 25);
            this.Registration.TabIndex = 18;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Авторизация";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.White;
            this.LoginTextBox.Location = new System.Drawing.Point(63, 73);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(176, 20);
            this.LoginTextBox.TabIndex = 14;
            // 
            // PassvordTextBox
            // 
            this.PassvordTextBox.BackColor = System.Drawing.Color.White;
            this.PassvordTextBox.Location = new System.Drawing.Point(63, 96);
            this.PassvordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassvordTextBox.Name = "PassvordTextBox";
            this.PassvordTextBox.Size = new System.Drawing.Size(159, 20);
            this.PassvordTextBox.TabIndex = 13;
            this.PassvordTextBox.UseSystemPasswordChar = true;
            // 
            // Avtorizacia1
            // 
            this.Avtorizacia1.BackColor = System.Drawing.Color.White;
            this.Avtorizacia1.Location = new System.Drawing.Point(24, 129);
            this.Avtorizacia1.Margin = new System.Windows.Forms.Padding(2);
            this.Avtorizacia1.Name = "Avtorizacia1";
            this.Avtorizacia1.Size = new System.Drawing.Size(213, 25);
            this.Avtorizacia1.TabIndex = 12;
            this.Avtorizacia1.Text = "Авторизация";
            this.Avtorizacia1.UseVisualStyleBackColor = false;
            this.Avtorizacia1.Click += new System.EventHandler(this.Avtorizacia1_Click);
            // 
            // Avtarizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 214);
            this.Controls.Add(this.Skrit_parol);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PassvordTextBox);
            this.Controls.Add(this.Avtorizacia1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtarizacia";
            this.Text = "Avtarizacia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Skrit_parol;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassvordTextBox;
        private System.Windows.Forms.Button Avtorizacia1;
    }
}