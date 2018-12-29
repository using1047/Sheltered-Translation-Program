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
            this.col_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OriginalCharacters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_Value = new System.Windows.Forms.RichTextBox();
            this.lbl_Old = new System.Windows.Forms.Label();
            this.lbl_New = new System.Windows.Forms.Label();
            this.btn_GoogleTranslation = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
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
            this.cb_FileName.SelectedIndexChanged += new System.EventHandler(this.cb_FileName_SelectedIndexChanged);
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
            this.dgv_Data.Size = new System.Drawing.Size(1169, 587);
            this.dgv_Data.TabIndex = 5;
            this.dgv_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellClick);
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
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(1193, 624);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(228, 52);
            this.btn_Change.TabIndex = 7;
            this.btn_Change.Text = "값 변경(Change Value)";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1190, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1190, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Old Characters Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1190, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "New Characters Count";
            // 
            // rtb_Value
            // 
            this.rtb_Value.Location = new System.Drawing.Point(1194, 122);
            this.rtb_Value.Name = "rtb_Value";
            this.rtb_Value.Size = new System.Drawing.Size(227, 437);
            this.rtb_Value.TabIndex = 12;
            this.rtb_Value.Text = "";
            this.rtb_Value.TextChanged += new System.EventHandler(this.rtb_Value_TextChanged);
            // 
            // lbl_Old
            // 
            this.lbl_Old.AutoSize = true;
            this.lbl_Old.Location = new System.Drawing.Point(1372, 572);
            this.lbl_Old.Name = "lbl_Old";
            this.lbl_Old.Size = new System.Drawing.Size(0, 15);
            this.lbl_Old.TabIndex = 13;
            // 
            // lbl_New
            // 
            this.lbl_New.AutoSize = true;
            this.lbl_New.Location = new System.Drawing.Point(1372, 598);
            this.lbl_New.Name = "lbl_New";
            this.lbl_New.Size = new System.Drawing.Size(0, 15);
            this.lbl_New.TabIndex = 14;
            // 
            // btn_GoogleTranslation
            // 
            this.btn_GoogleTranslation.Location = new System.Drawing.Point(1326, 86);
            this.btn_GoogleTranslation.Name = "btn_GoogleTranslation";
            this.btn_GoogleTranslation.Size = new System.Drawing.Size(95, 30);
            this.btn_GoogleTranslation.TabIndex = 15;
            this.btn_GoogleTranslation.Text = "구글 번역기";
            this.btn_GoogleTranslation.UseVisualStyleBackColor = true;
            this.btn_GoogleTranslation.Click += new System.EventHandler(this.btn_GoogleTranslation_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(1238, 86);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(82, 30);
            this.btn_Undo.TabIndex = 16;
            this.btn_Undo.Text = "초기화";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // Translation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 688);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_GoogleTranslation);
            this.Controls.Add(this.lbl_New);
            this.Controls.Add(this.lbl_Old);
            this.Controls.Add(this.rtb_Value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.cb_FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.cb_Language);
            this.Name = "Translation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OriginalCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_Value;
        private System.Windows.Forms.Label lbl_Old;
        private System.Windows.Forms.Label lbl_New;
        private System.Windows.Forms.Button btn_GoogleTranslation;
        private System.Windows.Forms.Button btn_Undo;
    }
}