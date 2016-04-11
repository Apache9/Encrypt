namespace Encrypt
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.dstTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.encButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srcTextBox
            // 
            this.srcTextBox.Location = new System.Drawing.Point(12, 12);
            this.srcTextBox.Multiline = true;
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(480, 320);
            this.srcTextBox.TabIndex = 0;
            // 
            // dstTextBox
            // 
            this.dstTextBox.Location = new System.Drawing.Point(12, 430);
            this.dstTextBox.Multiline = true;
            this.dstTextBox.Name = "dstTextBox";
            this.dstTextBox.Size = new System.Drawing.Size(480, 320);
            this.dstTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(81, 373);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(123, 21);
            this.passwordTextBox.TabIndex = 2;
            // 
            // encButton
            // 
            this.encButton.Location = new System.Drawing.Point(223, 367);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(120, 30);
            this.encButton.TabIndex = 3;
            this.encButton.Text = "加密";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(370, 367);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(120, 30);
            this.decButton.TabIndex = 4;
            this.decButton.Text = "解密";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(37, 377);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(41, 12);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "密码：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 762);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.encButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.dstTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Name = "MainForm";
            this.Text = "加密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox dstTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Label passwordLabel;
    }
}

