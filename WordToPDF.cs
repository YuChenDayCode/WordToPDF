using Aspose.Words;
namespace WordToPDF
{
    public partial class WordToPDF : Form
    {
        public WordToPDF()
        {
            InitializeComponent();
        }
        string pathstr = "";
        private void button1_Click(object sender, EventArgs e)
        {
            pathstr = "";
            using (FolderBrowserDialog op = new FolderBrowserDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pathstr = op.SelectedPath;
                    textBox1.Text = pathstr;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog op = new FolderBrowserDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = op.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathstr)) return;
            if (string.IsNullOrEmpty(textBox2.Text)) return;
            string[] files = Directory.GetFiles(pathstr);
            files = files.Where(t => t.Contains("doc")).ToArray();
            if (files.Count() == 0) { MessageBox.Show("无word文件，无法转换！"); return; }
            progressBar1.Maximum = files.Count();
            int i = 0;
            Task.Run(() =>
            {
                foreach (string wordFile in files)
                {
                    this.BeginInvoke(() =>
                    {
                        label2.Text = $"第 {i} 个/共 {files.Count()} 个";
                        progressBar1.Value += 1;
                    });
                    i++;

                    string pdfFileName = Path.ChangeExtension(Path.GetFileName(wordFile), ".pdf");
                    string pdfFilePath = Path.Combine(textBox2.Text, pdfFileName);
                    Document document = new Document(wordFile);
                    document.Save(pdfFilePath, SaveFormat.Pdf);
                }
            });
        }


    }
}