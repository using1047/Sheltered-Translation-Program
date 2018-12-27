namespace Sheltered_Translation_Program
{
    partial class Translation
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
            this.cb_Language = new System.Windows.Forms.ComboBox();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_FileName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.col_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OriginalCharacters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Language
            // 
            this.cb_Language.FormattingEnabled = true;
            this.cb_Language.Location = new System.Drawing.Point(163, 21);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.Size = new System.Drawing.Size(170, 23);
            this.cb_Language.TabIndex = 1;
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Language.Location = new System.Drawing.Point(15, 24);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(126, 17);
            this.lbl_Language.TabIndex = 2;
            this.lbl_Language.Text = "언어(Language)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "파일명(File Name)";
            // 
            // cb_FileName
            // 
            this.cb_FileName.FormattingEnabled = true;
            this.cb_FileName.Location = new System.Drawing.Point(163, 50);
            this.cb_FileName.Name = "cb_FileName";
            this.cb_FileName.Size = new System.Drawing.Size(170, 23);
            this.cb_FileName.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ItemName,
            this.col_Value,
            this.col_OriginalCharacters});
            this.dataGridView1.Location = new System.Drawing.Point(15, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(829, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(829, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(15, 356);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(829, 42);
            this.btn_Change.TabIndex = 7;
            this.btn_Change.Text = "수정 확인";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // col_ItemName
            // 
            this.col_ItemName.HeaderText = "Item Name";
            this.col_ItemName.Name = "col_ItemName";
            this.col_ItemName.Width = 200;
            // 
            // col_Value
            // 
            this.col_Value.HeaderText = "Value";
            this.col_Value.Name = "col_Value";
            this.col_Value.Width = 500;
            // 
            // col_OriginalCharacters
            // 
            this.col_OriginalCharacters.HeaderText = "Original Characters";
            this.col_OriginalCharacters.Name = "col_OriginalCharacters";
            this.col_OriginalCharacters.Width = 85;
            // 
            // Translation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 409);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.cb_Language);
            this.Name = "Translation";
            this.Text = "Translation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Language;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FileName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OriginalCharacters;
    }
}