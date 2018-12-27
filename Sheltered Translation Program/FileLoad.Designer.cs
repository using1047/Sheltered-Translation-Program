namespace Sheltered_Translation_Program
{
    partial class FileLoad
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_translation = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_translation
            // 
            this.btn_translation.Enabled = false;
            this.btn_translation.Location = new System.Drawing.Point(12, 56);
            this.btn_translation.Name = "btn_translation";
            this.btn_translation.Size = new System.Drawing.Size(594, 27);
            this.btn_translation.TabIndex = 0;
            this.btn_translation.Text = "번역하기(Translation)";
            this.btn_translation.UseVisualStyleBackColor = true;
            this.btn_translation.Click += new System.EventHandler(this.btn_translation_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(364, 21);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(242, 25);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "파일 위치 지정하기(Open Files)";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 25);
            this.textBox1.TabIndex = 2;
            // 
            // FileLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 93);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_translation);
            this.Name = "FileLoad";
            this.Text = "File Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_translation;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox textBox1;
    }
}

