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
using System.Text.RegularExpressions;
using System.Collections;

namespace PhotoGroup
{
    public partial class FormMain : Form
    {
        const string IMAGE_PATTERN = @".*\.(gif|jpg|jpeg|tiff|png|bmp)$";

        FolderBrowserDialog sourceBrowser;
        FolderBrowserDialog destinationBrowser;
        FlowLayoutPanel cbHolder;
        Label sourceLabel;
        Label destinationLabel;
        PictureBox imagePreview;
        Button next;
        Button previous;
        Form configsForm;
        Image defaultImage;

        Regex imageFormatRegex;
        ArrayList sourceFiles;
        int fileIndex;

        public FormMain()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            cbHolder = (FlowLayoutPanel)this.Controls.Find("fp_options", true).FirstOrDefault();
            sourceBrowser = new FolderBrowserDialog();
            sourceBrowser.Description = "Selecione a pasta com as fotos por organizar";
            destinationBrowser = new FolderBrowserDialog();
            destinationBrowser.Description = "Selecione onde colocar as pastas com as fotos organizadas";
            sourceFiles = new ArrayList();
            imageFormatRegex = new Regex(IMAGE_PATTERN, RegexOptions.IgnoreCase);
            sourceLabel = (Label)this.Controls.Find("lb_source", true).FirstOrDefault();
            destinationLabel = (Label)this.Controls.Find("lb_destination", true).FirstOrDefault();
            imagePreview = (PictureBox)this.Controls.Find("pb_preview", true).FirstOrDefault();
            next = (Button)this.Controls.Find("btn_next", true).FirstOrDefault();
            previous = (Button)this.Controls.Find("btn_previous", true).FirstOrDefault();
            defaultImage = imagePreview.Image;
            configsForm = new FormConfig();

            loadPreferences();
        }

        private void loadPreferences()
        {
            cbHolder.Controls.Clear();

            foreach (string val in Properties.Settings.Default.Categories)
            {
                CheckBox cb = new CheckBox();
                cb.Text = val;
                cb.Name = "cb_option";
                cb.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                cbHolder.Controls.Add(cb);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            CheckBox[] options = cbHolder.Controls.Find("cb_option", true).Cast<CheckBox>().Where(option => option.Checked).ToArray();

            foreach(CheckBox c in options)
            {
                string file = sourceFiles[fileIndex] as string;
                string destination = Path.Combine(destinationBrowser.SelectedPath, c.Text);

                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }

                File.Copy(file, Path.Combine(destination, Path.GetFileName(file)), true);

                c.Checked = false;
            }

            nextFile();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (fileIndex > 0)
            {
                fileIndex -= 2;
                nextFile();
            }
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            DialogResult result = sourceBrowser.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    if (loadFiles() && nextFile())
                    {
                        sourceLabel.Text = sourceBrowser.SelectedPath;
                        if (!destinationBrowser.SelectedPath.Equals(""))
                        {
                            enableNavigation();
                        }
                    } else
                    {
                        sourceBrowser.SelectedPath = "";
                        disableNavigation();
                        resetImagePreview();
                    }
                    break;
                default:
                    sourceBrowser.SelectedPath = "";
                    disableNavigation();
                    resetImagePreview();
                    break;
            }

            sourceLabel.Text = sourceBrowser.SelectedPath;
        }

        private void resetImagePreview()
        {
            imagePreview.ImageLocation = "";
            imagePreview.Image = defaultImage;
            imagePreview.Refresh();
        }

        private void enableNavigation()
        {
            next.Enabled = true;
            previous.Enabled = true;
        }

        private void disableNavigation()
        {
            next.Enabled = false;
            previous.Enabled = false;
        }

        private void btn_destination_Click(object sender, EventArgs e)
        {
            DialogResult result = destinationBrowser.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    if (!sourceBrowser.SelectedPath.Equals(""))
                    {
                        enableNavigation();
                    }
                    break;
                default:
                    destinationBrowser.SelectedPath = "";
                    disableNavigation();
                    break;
            }

            destinationLabel.Text = destinationBrowser.SelectedPath;
        }

        private bool loadFiles()
        {
            sourceFiles.Clear();
            string[] files;
            try
            {
                files = Directory.GetFiles(sourceBrowser.SelectedPath, "*", SearchOption.AllDirectories);
            }
            catch
            {
                MessageBox.Show(this, "Não é possível escolher esta pasta.");
                return false;
            }

            foreach(string file in files)
            {
                if (imageFormatRegex.IsMatch(file))
                {
                    sourceFiles.Add(file);
                }
            }

            Console.WriteLine(sourceFiles.Count + " images found.");

            fileIndex = -1;
            return true;
        }

        private bool nextFile()
        {
            if (fileIndex + 1 >= sourceFiles.Count)
            {
                Console.WriteLine("No more images.");
                MessageBox.Show(this, "Esta pasta não contém imagens.");
                return false;
            }

            imagePreview.ImageLocation = (string)sourceFiles[++fileIndex];
            Console.WriteLine("Loading image " + (string)sourceFiles[fileIndex]);

            imagePreview.Refresh();
            return true;
        }

        private void btn_select_all_Click(object sender, EventArgs e)
        {
            CheckBox[] options = cbHolder.Controls.Find("cb_option", true).Cast<CheckBox>().ToArray();

            foreach (CheckBox c in options)
            {
                c.Checked = true;
            }
        }

        private void btn_deselect_all_Click(object sender, EventArgs e)
        {
            CheckBox[] options = cbHolder.Controls.Find("cb_option", true).Cast<CheckBox>().ToArray();

            foreach (CheckBox c in options)
            {
                c.Checked = false;
            }
        }

        private void btn_configs_Click(object sender, EventArgs e)
        {
            configsForm.ShowDialog(this);
            loadPreferences();
        }
    }
}
