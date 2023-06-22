namespace dxfWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Copy and click";
            if (Clipboard.GetText().Length >0)
            {
                label1.Text = Clipboard.GetText();
            }
            label2.Text = "Click select folder";
        }

        private void copy_Folder(string sourse, string dest)
        {
      
            Directory.CreateDirectory(dest);
            foreach (string file in Directory.GetFiles(sourse))
            {
                File.Copy(file, $"{dest}\\{Path.GetFileName(file)}", false);
            }
            foreach (string dir in Directory.GetDirectories(sourse))
            {
                copy_Folder(dir, $"{dest}\\{Path.GetFileName(dir)}");
            }
        }
        
        private void change_Folder(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            string sourse = $"{label2.Text}\\{butt.Text}\\{butt.Text} 0";
            string dest = $"{label2.Text}\\{butt.Text}\\{label1.Text}";
            start_process(sourse, dest);
        }
        private void button_Enter(object sender, EventArgs e)
        {
            string sourse = $"{label2.Text}\\{textBox1.Text}\\{textBox1.Text} 0";
            string dest = $"{label2.Text}\\{textBox1.Text}\\{label1.Text}";
            start_process(sourse, dest);
        }

        private void start_process(string sourse, string dest)
        {
            if (!File.Exists(sourse))
            {
                MessageBox.Show(
                "Файл не был найден, проверьте путь",
                "Path Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error 
                );
                return;
            }
            copy_Folder(sourse, dest);
            DirectoryInfo sourse_Dir = new DirectoryInfo(sourse);
            foreach (FileInfo file in sourse_Dir.GetFiles("*.dxf"))
            {
                file.Delete();
            }
            markDXFBase.Convert(new string[] { dest });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().Length > 0)
            {
                label1.Text = Clipboard.GetText();
            }
            else
            {
                label1.Text = "Copy and click";
            }
        }

        private void set_Folder(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            label2.Text = dialog.SelectedPath.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}   