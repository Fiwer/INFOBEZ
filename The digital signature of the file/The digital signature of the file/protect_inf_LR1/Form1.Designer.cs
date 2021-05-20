namespace protect_inf_LR1
{
    partial class Form1
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
            this.signButton = new System.Windows.Forms.Button();
            this.checkSignButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.sourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.signFilePathTextBox = new System.Windows.Forms.TextBox();
            this.signFileButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signButton.Location = new System.Drawing.Point(454, 288);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(176, 41);
            this.signButton.TabIndex = 1;
            this.signButton.Text = "Подписать";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // checkSignButton
            // 
            this.checkSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkSignButton.Location = new System.Drawing.Point(454, 342);
            this.checkSignButton.Name = "checkSignButton";
            this.checkSignButton.Size = new System.Drawing.Size(176, 41);
            this.checkSignButton.TabIndex = 2;
            this.checkSignButton.Text = "Проверить подлинность подписи";
            this.checkSignButton.UseVisualStyleBackColor = true;
            this.checkSignButton.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "p =";
            // 
            // textBox_p
            // 
            this.textBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_p.Location = new System.Drawing.Point(60, 140);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(370, 26);
            this.textBox_p.TabIndex = 4;
            this.textBox_p.Text = "101";
            this.textBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "q =";
            // 
            // textBox_q
            // 
            this.textBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_q.Location = new System.Drawing.Point(60, 170);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(370, 26);
            this.textBox_q.TabIndex = 6;
            this.textBox_q.Text = "103";
            this.textBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Простые числа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "d =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "n =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(23, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Секретный ключ";
            // 
            // textBox_d
            // 
            this.textBox_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_d.Location = new System.Drawing.Point(60, 253);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(370, 26);
            this.textBox_d.TabIndex = 11;
            this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_n.Location = new System.Drawing.Point(60, 285);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(370, 26);
            this.textBox_n.TabIndex = 12;
            this.textBox_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sourceFilePathTextBox
            // 
            this.sourceFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sourceFilePathTextBox.Location = new System.Drawing.Point(60, 22);
            this.sourceFilePathTextBox.Name = "sourceFilePathTextBox";
            this.sourceFilePathTextBox.Size = new System.Drawing.Size(370, 24);
            this.sourceFilePathTextBox.TabIndex = 13;
            // 
            // signFilePathTextBox
            // 
            this.signFilePathTextBox.Enabled = false;
            this.signFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signFilePathTextBox.Location = new System.Drawing.Point(60, 80);
            this.signFilePathTextBox.Name = "signFilePathTextBox";
            this.signFilePathTextBox.Size = new System.Drawing.Size(370, 24);
            this.signFilePathTextBox.TabIndex = 14;
            // 
            // signFileButton
            // 
            this.signFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signFileButton.Location = new System.Drawing.Point(454, 74);
            this.signFileButton.Name = "signFileButton";
            this.signFileButton.Size = new System.Drawing.Size(176, 30);
            this.signFileButton.TabIndex = 16;
            this.signFileButton.Text = "Файл с подписью";
            this.signFileButton.UseVisualStyleBackColor = true;
            this.signFileButton.Click += new System.EventHandler(this.signFileButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Введите текст";
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(454, 140);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(167, 36);
            this.Random.TabIndex = 18;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(454, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 43);
            this.listBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 395);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signFileButton);
            this.Controls.Add(this.signFilePathTextBox);
            this.Controls.Add(this.sourceFilePathTextBox);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSignButton);
            this.Controls.Add(this.signButton);
            this.Name = "Form1";
            this.Text = "vscode.ru - электронная подпись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button checkSignButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox sourceFilePathTextBox;
        private System.Windows.Forms.TextBox signFilePathTextBox;
        private System.Windows.Forms.Button signFileButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.ListBox listBox1;
    }
}

