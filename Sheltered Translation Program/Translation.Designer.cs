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
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.rtxt_Value = new System.Windows.Forms.RichTextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.col_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OriginalCharacters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Language
            // 
            this.cb_Language.FormattingEnabled = true;
            this.cb_Language.Location = new System.Drawing.Point(163, 21);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.Size = new System.Drawing.Size(213, 23);
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
            this.cb_FileName.Size = new System.Drawing.Size(213, 23);
            this.cb_FileName.TabIndex = 4;
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ItemName,
            this.col_Value,
            this.col_OriginalCharacters});
            this.dgv_Data.Location = new System.Drawing.Point(15, 89);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowTemplate.Height = 27;
            this.dgv_Data.Size = new System.Drawing.Size(1169, 386);
            this.dgv_Data.TabIndex = 5;
            // 
            // rtxt_Value
            // 
            this.rtxt_Value.Location = new System.Drawing.Point(12, 481);
            this.rtxt_Value.Name = "rtxt_Value";
            this.rtxt_Value.Size = new System.Drawing.Size(1172, 96);
            this.rtxt_Value.TabIndex = 6;
            this.rtxt_Value.Text = "";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(12, 583);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(1172, 42);
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
            this.col_OriginalCharacters.Width = 160;
            // 
            // Translation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 637);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.rtxt_Value);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.cb_FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.cb_Language);
            this.Name = "Translation";
            this.Text = "Translation";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Language;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FileName;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.RichTextBox rtxt_Value;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OriginalCharacters;
    }
}