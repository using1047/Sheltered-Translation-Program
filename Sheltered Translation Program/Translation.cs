using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sheltered_Translation_Program
{
    public partial class Translation : Form
    {
        // Need Files Count
        const int MAXFILE = 8;
        // Asset path
        string path = "";
        // File Load Form
        FileLoad fileLoad = new FileLoad();
        // Need Files
        FileInfo[] files;

        bool CompleteSet = false;

        public Translation()
        {
            InitializeComponent();
            fileLoad.Show();

            // Event
            fileLoad.FormClosed += FileLoad_FormClosed;
            cb_Language.SelectedIndexChanged += Cb_Language_SelectedIndexChanged;
        }

        // File Check Logic & Setting
        private void FileLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            path = fileLoad.FolderPath;
            if (path == "") this.Close();
            else
            {
                SetFile();
                files = new FileInfo[MAXFILE];
                for (int i = 0; i < MAXFILE; i++)
                {
                    files[i] = new FileInfo(path + "\\" + FileName(i));
                }
                SetLanguage();
                CompleteSet = true;
            }
        }

        // Set Surported Game Language List
        private void SetLanguage()
        {
            string file = cb_FileName.SelectedItem.ToString();
            StreamReader sr = new StreamReader(files[cb_FileName.SelectedIndex].FullName);
            string[] str = sr.ReadLine().Split('\t');
            for (int i = 1; i < str.Count(); i++)
            {
                cb_Language.Items.Add(str[i]);
            }
            cb_Language.SelectedIndex = 0;
            sr.Close();
        }

        // Set Asset Folder in File List
        private void SetFile()
        {
            for (int i = 0; i < MAXFILE; i++)
            {
                cb_FileName.Items.Add(FileName(i));
            }
            cb_FileName.SelectedIndex = 0;
        }

        // Change Language
        private void Cb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dgv_Data.Rows.Count > 1)
            {
                dgv_Data.Rows.RemoveAt(0);
            }
            StreamReader sr = new StreamReader(files[cb_FileName.SelectedIndex].FullName);
            int checkline = 1;
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split('\t');
                if (str[0] == "") { }
                else
                {
                    string[] row = { checkline.ToString(), str[0], str[cb_Language.SelectedIndex + 1], str[cb_Language.SelectedIndex + 1].Length.ToString() };
                    dgv_Data.Rows.Add(row);
                    checkline++;
                }
            }
            dgv_Data.Refresh();
            sr.Close();
        }

        private void cb_FileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompleteSet == true)
            {
                while (dgv_Data.Rows.Count > 1)
                {
                    dgv_Data.Rows.RemoveAt(0);
                }
                StreamReader sr = new StreamReader(files[cb_FileName.SelectedIndex].FullName);
                int checkline = 1;
                while (!sr.EndOfStream)
                {

                    string[] str = sr.ReadLine().Split('\t');
                    if (str[0] == "") { }
                    else
                    {
                        string[] row = { str[0], str[cb_Language.SelectedIndex + 1], str[cb_Language.SelectedIndex + 1].Length.ToString() };
                        dgv_Data.Rows.Add(row);
                        checkline++;
                    }
                }
                dgv_Data.Refresh();
                sr.Close();
            }
        }

        // Right - Top //
        // Save File, Undo, Google Translate //
        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path + "\\" + FileName(cb_FileName.SelectedIndex));
            List<string> Columns = new List<string>();

            int p = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split('\t');

                if (arr.Count() != 10)
                {
                    MessageBox.Show("파일의 레이아웃에 문제가 있습니다.\n비어있는 값이 포함되어 있습니다.");
                    this.Close();
                }

                if (arr[0] == "" || arr[0] == "\t") arr[cb_Language.SelectedIndex] = "";
                else
                {
                    // 언어 자료 삽입
                    if (dgv_Data.Rows[p].Cells[2].Value == null) arr[cb_Language.SelectedIndex + 1] = " ";
                    else arr[cb_Language.SelectedIndex + 1] = dgv_Data.Rows[p].Cells[2].Value.ToString();
                    p++;
                }

                for (int i = 0; i < 10; i++)
                {
                    if (arr[i] == "") arr[i] = " ";
                }

                Columns.AddRange(arr);
            }
            sr.Close();
            sr.Dispose();

            StreamWriter sw = new StreamWriter(path + "\\" + FileName(cb_FileName.SelectedIndex), false, Encoding.UTF8);

            for (int line = 0; line < Columns.Count; line++)
            {
                if (Columns[line] == "") sw.Write("\t"); // 비어 있으면 Tab
                else sw.Write(Columns[line]);               // 아니라면 아이템 넣음

                if ((line + 1) >= 10 && (line + 1) % 10 == 0) sw.Write("\r\n"); // 단어 10개 마다 줄바꿈
                else sw.Write("\t");
            }
            sw.Close();
            MessageBox.Show("저장완료");
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            rtb_Value.Text = dgv_Data.CurrentCell.Value.ToString();
        }

        private void btn_GoogleTranslation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.google.com/?um=1&ie=UTF-8&hl=ko&client=tw-ob#view=home&op=translate&sl=zh-CN&tl=ko&text=" + rtb_Value.Text);
        }

        // Right - Mid //
        // DataGridView Event, Value Characters Count View //
        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string value = dgv_Data.CurrentCell.Value.ToString();
                rtb_Value.Text = value;
                lbl_Old.Text = value.Length.ToString();
            }
        }

        private void rtb_Value_TextChanged(object sender, EventArgs e)
        {
            lbl_New.Text = rtb_Value.Text.Length.ToString();
        }

        // Right - Bot //
        // Change DataGridView Value //
        private void btn_Change_Click(object sender, EventArgs e)
        {
            dgv_Data.CurrentCell.Value = rtb_Value.Text;
            dgv_Data.Refresh();
        }

        // Enum Data //
        // Need Files Name, Files -> EnumToString //
        enum FileNames
        {
            Localization = 0,
            Pool_FamilyNames,  // Will Remove
            Pool_FemaleNames, // Will Remove
            Pool_MaleNames,    // Will Remove
            Pool_PetNames,       // Will Remove
            PS4Lang,
            TempLocalization,
            XboneLang = 7
        }

        private string FileName(int number)
        {
            string Name = null;
            switch (number)
            {
                case 0: Name = FileNames.Localization.ToString(); break;
                case 1: Name = FileNames.Pool_FamilyNames.ToString(); break;    // Will Remove
                case 2: Name = FileNames.Pool_FemaleNames.ToString(); break;  // Will Remove
                case 3: Name = FileNames.Pool_MaleNames.ToString(); break;     // Will Remove
                case 4: Name = FileNames.Pool_PetNames.ToString(); break;       // Will Remove
                case 5: Name = FileNames.PS4Lang.ToString(); break;
                case 6: Name = FileNames.TempLocalization.ToString(); break;
                case 7: Name = FileNames.XboneLang.ToString(); break;
            }
            return Name + ".txt";
        }
    }
}
