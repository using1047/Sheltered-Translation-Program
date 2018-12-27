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
    public partial class FileLoad : Form
    {
        const int MAXFILE = 8;
        public string FolderPath = "";

        public FileLoad()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Language 폴더 선택\nSelect Language Folder";
                fbd.ShowDialog();

                string path = fbd.SelectedPath;

                if (CheckedFiles(path) == true)
                {
                    btn_translation.Enabled = true;
                    txt_Path.Text = path;
                }
                else MessageBox.Show("파일이 부족합니다.");
            }
        }

        private void btn_translation_Click(object sender, EventArgs e)
        {
            FolderPath = txt_Path.Text;
            this.Close();
        }

        private bool CheckedFiles(string Path)
        {
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] fi = new FileInfo[di.GetFiles().Count()];
            
            for (int i = 0; i < MAXFILE; i++)
            {
                fi = di.GetFiles(FileName(i));
                if (fi.Count() == 0) return false;
            }
            return true;
        }

        enum FileNames
        {
            Localization = 0,
            Pool_FamilyNames,
            Pool_FemaleNames,
            Pool_MaleNames,
            Pool_PetNames,
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
                case 1: Name = FileNames.Pool_FamilyNames.ToString(); break;
                case 2: Name = FileNames.Pool_FemaleNames.ToString(); break;
                case 3: Name = FileNames.Pool_MaleNames.ToString(); break;
                case 4: Name = FileNames.Pool_PetNames.ToString(); break;
                case 5: Name = FileNames.PS4Lang.ToString(); break;
                case 6: Name = FileNames.TempLocalization.ToString(); break;
                case 7: Name = FileNames.XboneLang.ToString(); break;
            }
            return Name + ".txt";
        }
    }
}
