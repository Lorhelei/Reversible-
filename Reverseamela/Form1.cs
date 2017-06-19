using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reverseamela.Properties;

namespace Reverseamela
{
    public partial class Form1 : Form
    {

        private static StringBuilder cmdOutput = null;
        Process cmdProcess;
        StreamWriter cmdStreamWriter;
        private bool read;
        private string zelda;
        private List<string> imgList = new List<string>();
        private string originalpath;
        private int contador;
        private int direccionindex;
        private string direccion;
        private string filename;


        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetImagesInList();
            SetImagesInGrid();            
        }

        private void ConstructGrid()
        {
            DataGridViewImageColumn col1 = new DataGridViewImageColumn();
            DataGridViewImageColumn col2 = new DataGridViewImageColumn();
            DataGridViewImageColumn col3 = new DataGridViewImageColumn();

            col1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            col2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            col3.ImageLayout = DataGridViewImageCellLayout.Zoom;

            col1.Width = 160;
            col2.Width = 160;
            col3.Width = 160;

            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col2);
            dataGridView1.Columns.Add(col3);
            
        }

        private void SetImagesInGrid()
        {
            dataGridView1.Rows.Clear();


            while (contador < imgList.Count-1)
            {
                Image img1 = Image.FromFile(imgList[contador]);
                if (contador < imgList.Count - 1)
                {
                    contador++;
                }
                else
                {
                    img1 = null;
                }


                Image img2 = Image.FromFile(imgList[contador]);
                if (contador < imgList.Count - 1)
                {
                    contador++;
                }
                else
                {
                    img2 = null;
                }

                Image img3 = Image.FromFile(imgList[contador]);
                if (contador < imgList.Count - 1)
                {
                    contador++;
                }
                else
                {
                    img3 = null;
                }
                Object[] row = new object[] { img1, img2, img3 };
                dataGridView1.Rows.Add(row);
            }

            contador = 0;
        }

        private void SetImagesInList()
        {
            try
            {
                imgList = new List<string>();
                originalpath = @tbxDireccion.Text;
                var directorio = new DirectoryInfo(originalpath);

                foreach (var file in directorio.GetFiles("*.jpg"))
                {
                    imgList.Add(file.DirectoryName + @"\" + file.Name);
                }

                foreach (var file in directorio.GetFiles("*.png"))
                {
                    imgList.Add(file.DirectoryName + @"\" + file.Name);
                }

                foreach (var file in directorio.GetFiles("*.jpeg"))
                {
                    imgList.Add(file.DirectoryName + @"\" + file.Name);
                }
            }
            catch (Exception e)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(0,0);
            ConstructGrid();
            cmdOutput = new StringBuilder("");
            cmdProcess = new Process();

            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.RedirectStandardOutput = true;

            cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            cmdProcess.StartInfo.RedirectStandardInput = true;

            cmdProcess.Start();
            cmdStreamWriter = cmdProcess.StandardInput;
            cmdProcess.BeginOutputReadLine();
        }

        private void StartCMD()
        {
            cmdOutput = new StringBuilder("");
            cmdProcess = new Process();

            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.RedirectStandardOutput = true;

            cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            cmdProcess.StartInfo.RedirectStandardInput = true;

            cmdProcess.Start();
            cmdStreamWriter = cmdProcess.StandardInput;
            cmdProcess.BeginOutputReadLine();
        }

        private static void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                cmdOutput.Append(Environment.NewLine + outLine.Data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UploadImage();
            ReverseSearch();         
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            direccionindex = dataGridView1.SelectedCells[0].ColumnIndex + dataGridView1.SelectedCells[0].RowIndex*4;
            direccion = imgList[direccionindex];
            pictureBox1.ImageLocation = imgList[direccionindex];
        }

        private void UploadImage()
        {
            if (tbxUrl.Text == "")
            {
                StartCMD();
                cmdStreamWriter.WriteLine(@"cd C:\Python\Scripts");
                cmdStreamWriter.WriteLine("uguu -r " + '\u0022' + direccion + '\u0022');
                cmdStreamWriter.WriteLine("exit");
                lblStatus.Text = "Uploading...";
                cmdProcess.WaitForExit();
                lblStatus.Text = "Loading...";
                GetUrlUguu();
            }
            else
            {
                zelda = tbxUrl.Text;
            }

        }

        private void GetUrlUguu()
        {
            string cadena = cmdOutput.ToString();
            bool noSecure = true;
            zelda = "";

            foreach (var VARIABLE in cmdOutput.ToString())
            {
                if (VARIABLE.ToString() == "'")
                {
                    if (read)
                    {
                        read = false;
                    }
                    else
                    {
                        read = true;
                    }
                }
                else
                {
                    if (read)
                    {
                        if (noSecure && VARIABLE.ToString() == "s")
                        {
                            noSecure = false;
                        }
                        else
                        {
                            zelda = zelda + VARIABLE.ToString();
                        }

                    }
                }
            }

            if (zelda == "")
            {
                lblStatus.Text = "Unable to upload file";
            }
        }

        private void ReverseSearch()
        {
            if (cbGoogle.Checked)
            {
                Uri url1 = new Uri("http://www.google.com/searchbyimage?site=search&sa=X&image_url=" + zelda);
                webBrowser1.Url = url1;
            }

            if (cbTinEye.Checked)
            {
                Uri url2 = new Uri("http://tineye.com/search?extension_ver=bookmark_1.0&url=" + zelda);
                webBrowser2.Url = url2;
            }

            if (cbYandex.Checked)
            {
                Uri url3 = new Uri("http://yandex.com/images/search?text=" + zelda);
                webBrowser3.Url = url3;
            }

            if (cbe621.Checked)
            {
                Uri url4 = new Uri("http://iqdb.harry.lu/?url=" + zelda);
                webBrowser4.Url = url4;
            }

            if (cbiqdb.Checked)
            {
                Uri url5 = new Uri("http://iqdb.org/?url=" + zelda);
                webBrowser5.Url = url5;
            }

            if (cbSauceNao.Checked)
            {
                Uri url6 = new Uri("http://saucenao.com/search.php?db=999&url=" + zelda);
                webBrowser7.Url = url6;
            }

            if (cbTinEye.Checked)
            {
                Uri url7 = new Uri("https://whatanime.ga/?url=" + zelda);
                webBrowser6.Url = url7;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.Size = new Size(0, 0);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            Dragthis.Url = new Uri(Directory.GetCurrentDirectory() + "\\Resources\\Draggit.jpg");
            panel1.Size = ClientSize;

        }

        private void Dragthis_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Uri local = new Uri(Directory.GetCurrentDirectory() + "\\Resources\\Draggit.jpg");
            if (Dragthis.Url != local)
            {
                var url = Dragthis.Url;
                string dir = Dragthis.Url.ToString();
                direccion = url.ToString().Substring(8, dir.Length - 8);
                pictureBox1.ImageLocation = direccion;
                Dragthis.Url = local;
                panel1.Size = new Size(0, 0);
            }
        }

        private void tbxUrl_TextChanged(object sender, EventArgs e)
        {
            if (tbxUrl.Text == "")
            {
                btnDoTheThing.Text = "Upload";
            }
            else
            {
                btnDoTheThing.Text = "Send Link";
            }
        }

        private void webBrowser6_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lblStatus.Text = "Done!";
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    System.Diagnostics.Process.Start(webBrowser1.Url.AbsoluteUri);
                    break;
                case 1:
                    System.Diagnostics.Process.Start(webBrowser2.Url.AbsoluteUri);
                    break;
                case 2:
                    System.Diagnostics.Process.Start(webBrowser3.Url.AbsoluteUri);
                    break;
                case 3:
                    System.Diagnostics.Process.Start(webBrowser4.Url.AbsoluteUri);
                    break;
                case 4:
                    System.Diagnostics.Process.Start(webBrowser5.Url.AbsoluteUri);
                    break;
                case 5:
                    System.Diagnostics.Process.Start(webBrowser7.Url.AbsoluteUri);
                    break;
                case 6:
                    System.Diagnostics.Process.Start(webBrowser6.Url.AbsoluteUri);
                    break;
            }
        }
    }
}
