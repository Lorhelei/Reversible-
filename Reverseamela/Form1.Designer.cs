namespace Reverseamela
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDoTheThing = new System.Windows.Forms.Button();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.webBrowser7 = new System.Windows.Forms.WebBrowser();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.webBrowser6 = new System.Windows.Forms.WebBrowser();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpSauceBox = new System.Windows.Forms.GroupBox();
            this.cbWhatAnime = new System.Windows.Forms.CheckBox();
            this.cbSauceNao = new System.Windows.Forms.CheckBox();
            this.cbiqdb = new System.Windows.Forms.CheckBox();
            this.cbYandex = new System.Windows.Forms.CheckBox();
            this.cbe621 = new System.Windows.Forms.CheckBox();
            this.cbTinEye = new System.Windows.Forms.CheckBox();
            this.cbGoogle = new System.Windows.Forms.CheckBox();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbDragit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.wbSelected = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.gpSauceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // btnDoTheThing
            // 
            this.btnDoTheThing.Location = new System.Drawing.Point(479, 374);
            this.btnDoTheThing.Name = "btnDoTheThing";
            this.btnDoTheThing.Size = new System.Drawing.Size(277, 32);
            this.btnDoTheThing.TabIndex = 3;
            this.btnDoTheThing.Text = "Upload";
            this.btnDoTheThing.UseVisualStyleBackColor = true;
            this.btnDoTheThing.Click += new System.EventHandler(this.button2_Click);
            this.btnDoTheThing.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(42, 14);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(431, 20);
            this.tbxDireccion.TabIndex = 4;
            this.tbxDireccion.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 160;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(461, 599);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(762, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 629);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.ForeColor = System.Drawing.Color.Lime;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Images Google";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(653, 597);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webBrowser2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(659, 603);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TinEye";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.AllowWebBrowserDrop = false;
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(659, 603);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webBrowser3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(659, 603);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Yandex";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.AllowWebBrowserDrop = false;
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScriptErrorsSuppressed = true;
            this.webBrowser3.Size = new System.Drawing.Size(659, 603);
            this.webBrowser3.TabIndex = 0;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "iqdb e621";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser4
            // 
            this.webBrowser4.AllowWebBrowserDrop = false;
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(3, 3);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.ScriptErrorsSuppressed = true;
            this.webBrowser4.Size = new System.Drawing.Size(653, 597);
            this.webBrowser4.TabIndex = 0;
            this.webBrowser4.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "iqdb";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser5
            // 
            this.webBrowser5.AllowWebBrowserDrop = false;
            this.webBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser5.Location = new System.Drawing.Point(3, 3);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.ScriptErrorsSuppressed = true;
            this.webBrowser5.Size = new System.Drawing.Size(653, 597);
            this.webBrowser5.TabIndex = 0;
            this.webBrowser5.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.webBrowser7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(659, 603);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "SauceNAO";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // webBrowser7
            // 
            this.webBrowser7.AllowWebBrowserDrop = false;
            this.webBrowser7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser7.Location = new System.Drawing.Point(3, 3);
            this.webBrowser7.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser7.Name = "webBrowser7";
            this.webBrowser7.Size = new System.Drawing.Size(653, 597);
            this.webBrowser7.TabIndex = 0;
            this.webBrowser7.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.webBrowser6);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(659, 603);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "What Anime Is?";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // webBrowser6
            // 
            this.webBrowser6.AllowWebBrowserDrop = false;
            this.webBrowser6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser6.Location = new System.Drawing.Point(3, 3);
            this.webBrowser6.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser6.Name = "webBrowser6";
            this.webBrowser6.ScriptErrorsSuppressed = true;
            this.webBrowser6.Size = new System.Drawing.Size(653, 597);
            this.webBrowser6.TabIndex = 0;
            this.webBrowser6.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Myriad Hebrew", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(479, 616);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(276, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Hello!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selected";
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(479, 346);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(276, 20);
            this.tbxUrl.TabIndex = 11;
            this.tbxUrl.TextChanged += new System.EventHandler(this.tbxUrl_TextChanged);
            this.tbxUrl.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Url:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // gpSauceBox
            // 
            this.gpSauceBox.Controls.Add(this.cbWhatAnime);
            this.gpSauceBox.Controls.Add(this.cbSauceNao);
            this.gpSauceBox.Controls.Add(this.cbiqdb);
            this.gpSauceBox.Controls.Add(this.cbYandex);
            this.gpSauceBox.Controls.Add(this.cbe621);
            this.gpSauceBox.Controls.Add(this.cbTinEye);
            this.gpSauceBox.Controls.Add(this.cbGoogle);
            this.gpSauceBox.Location = new System.Drawing.Point(479, 413);
            this.gpSauceBox.Name = "gpSauceBox";
            this.gpSauceBox.Size = new System.Drawing.Size(277, 131);
            this.gpSauceBox.TabIndex = 12;
            this.gpSauceBox.TabStop = false;
            this.gpSauceBox.Text = "Sources";
            this.gpSauceBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // cbWhatAnime
            // 
            this.cbWhatAnime.AutoSize = true;
            this.cbWhatAnime.Checked = true;
            this.cbWhatAnime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWhatAnime.Location = new System.Drawing.Point(15, 100);
            this.cbWhatAnime.Name = "cbWhatAnime";
            this.cbWhatAnime.Size = new System.Drawing.Size(101, 17);
            this.cbWhatAnime.TabIndex = 0;
            this.cbWhatAnime.Text = "What Anime Is?";
            this.cbWhatAnime.UseVisualStyleBackColor = true;
            // 
            // cbSauceNao
            // 
            this.cbSauceNao.AutoSize = true;
            this.cbSauceNao.Checked = true;
            this.cbSauceNao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSauceNao.Location = new System.Drawing.Point(161, 77);
            this.cbSauceNao.Name = "cbSauceNao";
            this.cbSauceNao.Size = new System.Drawing.Size(80, 17);
            this.cbSauceNao.TabIndex = 0;
            this.cbSauceNao.Text = "SauceNAO";
            this.cbSauceNao.UseVisualStyleBackColor = true;
            // 
            // cbiqdb
            // 
            this.cbiqdb.AutoSize = true;
            this.cbiqdb.Checked = true;
            this.cbiqdb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbiqdb.Location = new System.Drawing.Point(15, 77);
            this.cbiqdb.Name = "cbiqdb";
            this.cbiqdb.Size = new System.Drawing.Size(46, 17);
            this.cbiqdb.TabIndex = 0;
            this.cbiqdb.Text = "iqdb";
            this.cbiqdb.UseVisualStyleBackColor = true;
            // 
            // cbYandex
            // 
            this.cbYandex.AutoSize = true;
            this.cbYandex.Checked = true;
            this.cbYandex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbYandex.Location = new System.Drawing.Point(15, 54);
            this.cbYandex.Name = "cbYandex";
            this.cbYandex.Size = new System.Drawing.Size(62, 17);
            this.cbYandex.TabIndex = 0;
            this.cbYandex.Text = "Yandex";
            this.cbYandex.UseVisualStyleBackColor = true;
            // 
            // cbe621
            // 
            this.cbe621.AutoSize = true;
            this.cbe621.Checked = true;
            this.cbe621.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbe621.Location = new System.Drawing.Point(161, 54);
            this.cbe621.Name = "cbe621";
            this.cbe621.Size = new System.Drawing.Size(50, 17);
            this.cbe621.TabIndex = 0;
            this.cbe621.Text = "e621";
            this.cbe621.UseVisualStyleBackColor = true;
            // 
            // cbTinEye
            // 
            this.cbTinEye.AutoSize = true;
            this.cbTinEye.Checked = true;
            this.cbTinEye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTinEye.Location = new System.Drawing.Point(161, 31);
            this.cbTinEye.Name = "cbTinEye";
            this.cbTinEye.Size = new System.Drawing.Size(59, 17);
            this.cbTinEye.TabIndex = 0;
            this.cbTinEye.Text = "TinEye";
            this.cbTinEye.UseVisualStyleBackColor = true;
            // 
            // cbGoogle
            // 
            this.cbGoogle.AutoSize = true;
            this.cbGoogle.Checked = true;
            this.cbGoogle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGoogle.Location = new System.Drawing.Point(15, 31);
            this.cbGoogle.Name = "cbGoogle";
            this.cbGoogle.Size = new System.Drawing.Size(97, 17);
            this.cbGoogle.TabIndex = 0;
            this.cbGoogle.Text = "Images Google";
            this.cbGoogle.UseVisualStyleBackColor = true;
            this.cbGoogle.CheckedChanged += new System.EventHandler(this.cbGoogle_CheckedChanged);
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(479, 550);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(276, 35);
            this.btnOpenBrowser.TabIndex = 1;
            this.btnOpenBrowser.Text = "Open in Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            this.btnOpenBrowser.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLoading.Image = global::Reverseamela.Properties.Resources.giphy;
            this.pbLoading.Location = new System.Drawing.Point(1446, 295);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(284, 290);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 14;
            this.pbLoading.TabStop = false;
            // 
            // pbDragit
            // 
            this.pbDragit.BackgroundImage = global::Reverseamela.Properties.Resources.Draggit;
            this.pbDragit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDragit.Location = new System.Drawing.Point(1459, 210);
            this.pbDragit.Name = "pbDragit";
            this.pbDragit.Size = new System.Drawing.Size(100, 50);
            this.pbDragit.TabIndex = 13;
            this.pbDragit.TabStop = false;
            this.pbDragit.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbDragit_DragDrop);
            this.pbDragit.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbDragit_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(479, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // wbSelected
            // 
            this.wbSelected.AllowWebBrowserDrop = false;
            this.wbSelected.Location = new System.Drawing.Point(1498, 43);
            this.wbSelected.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSelected.Name = "wbSelected";
            this.wbSelected.ScrollBarsEnabled = false;
            this.wbSelected.Size = new System.Drawing.Size(143, 119);
            this.wbSelected.TabIndex = 16;
            this.wbSelected.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbSelected_DocumentCompleted);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 646);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbDragit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.gpSauceBox);
            this.Controls.Add(this.btnDoTheThing);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wbSelected);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Reversible!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.gpSauceBox.ResumeLayout(false);
            this.gpSauceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDoTheThing;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.WebBrowser webBrowser7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpSauceBox;
        private System.Windows.Forms.CheckBox cbWhatAnime;
        private System.Windows.Forms.CheckBox cbSauceNao;
        private System.Windows.Forms.CheckBox cbiqdb;
        private System.Windows.Forms.CheckBox cbYandex;
        private System.Windows.Forms.CheckBox cbe621;
        private System.Windows.Forms.CheckBox cbTinEye;
        private System.Windows.Forms.CheckBox cbGoogle;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.WebBrowser webBrowser6;
        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.PictureBox pbDragit;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.WebBrowser wbSelected;
    }
}

