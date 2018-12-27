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
        const int MAXFILE = 8;
        string path = "";
        FileLoad fileLoad = new FileLoad();
        FileInfo[] files;

        public Translation()
        {
            InitializeComponent();
            fileLoad.Show();

            fileLoad.FormClosed += FileLoad_FormClosed;
            cb_Language.SelectedIndexChanged += Cb_Language_SelectedIndexChanged;
        }

        private void FileLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            path = fileLoad.FolderPath;
            if (path == "") this.Close();
            else
            {
                SetFile();
                files = new FileInfo[MAXFILE];
                for(int i = 0; i < MAXFILE; i++)
                {
                    files[i] = new FileInfo(path + "\\" + FileName(i));
                }
                SetLanguage();
            }
        }

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
        }

        private void SetFile()
        {
            for (int i = 0; i < MAXFILE; i++)
            {
                cb_FileName.Items.Add(FileName(i));
            }
            cb_FileName.SelectedIndex = 0;
        }

        private void Cb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            while(dgv_Data.Rows.Count > 1)
            {
                dgv_Data.Rows.RemoveAt(0);
            }
            StreamReader sr = new StreamReader(files[cb_FileName.SelectedIndex].FullName);
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split('\t');
                if (str[0] == "") { }
                else
                {
                    string[] row = { str[0], str[cb_Language.SelectedIndex + 1], str[cb_Language.SelectedIndex + 1].Length.ToString() };
                    dgv_Data.Rows.Add(row);
                }
            }
            dgv_Data.Refresh();
            sr.Close();
        }

        enum LanguageNames
        {

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
