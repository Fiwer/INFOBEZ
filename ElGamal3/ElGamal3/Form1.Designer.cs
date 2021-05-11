namespace ElGamal3
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
            this.txtBCrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBPublicKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBSecretKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBIn = new System.Windows.Forms.TextBox();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Random = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBCrypt
            // 
            this.txtBCrypt.Location = new System.Drawing.Point(240, 40);
            this.txtBCrypt.Multiline = true;
            this.txtBCrypt.Name = "txtBCrypt";
            this.txtBCrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBCrypt.Size = new System.Drawing.Size(188, 69);
            this.txtBCrypt.TabIndex = 0;
            this.txtBCrypt.TextChanged += new System.EventHandler(this.txtBCrypt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Зашифрованное сообщение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Открытый ключ (p,g,y)";
            // 
            // txtBPublicKey
            // 
            this.txtBPublicKey.Location = new System.Drawing.Point(36, 136);
            this.txtBPublicKey.Name = "txtBPublicKey";
            this.txtBPublicKey.Size = new System.Drawing.Size(209, 20);
            this.txtBPublicKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Закрытый ключ";
            // 
            // txtBSecretKey
            // 
            this.txtBSecretKey.Location = new System.Drawing.Point(36, 176);
            this.txtBSecretKey.Name = "txtBSecretKey";
            this.txtBSecretKey.Size = new System.Drawing.Size(101, 20);
            this.txtBSecretKey.TabIndex = 5;
            this.txtBSecretKey.Text = "8";
            this.txtBSecretKey.TextChanged += new System.EventHandler(this.txtBSecretKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дешифрованное сообщение";
            // 
            // txtBDecrypt
            // 
            this.txtBDecrypt.Location = new System.Drawing.Point(36, 89);
            this.txtBDecrypt.Name = "txtBDecrypt";
            this.txtBDecrypt.Size = new System.Drawing.Size(151, 20);
            this.txtBDecrypt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сообщение";
            // 
            // txtBIn
            // 
            this.txtBIn.Location = new System.Drawing.Point(36, 40);
            this.txtBIn.Name = "txtBIn";
            this.txtBIn.Size = new System.Drawing.Size(151, 20);
            this.txtBIn.TabIndex = 9;
            this.txtBIn.TextChanged += new System.EventHandler(this.txtBIn_TextChanged);
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(328, 134);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 20);
            this.textBox_p.TabIndex = 11;
            this.textBox_p.Text = "503";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(328, 176);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 20);
            this.textBox_q.TabIndex = 12;
            this.textBox_q.Text = "107";
            this.textBox_q.TextChanged += new System.EventHandler(this.textBox_q_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(291, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "p =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(291, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "g =";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(295, 215);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(133, 23);
            this.button_Random.TabIndex = 15;
            this.button_Random.Text = "Random";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(154, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 30);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 259);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBSecretKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBPublicKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBCrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBCrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBPublicKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBSecretKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBIn;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.ListBox listBox1;
    }
}

