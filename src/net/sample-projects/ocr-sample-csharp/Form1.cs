using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ocr_sample_csharp.Properties;

using asprise_ocr_api;

// Sample application of Asprise OCR C#/VB.NET SDK. Visit http://asprise.com/product/ocr for more details.
namespace ocr_sample_csharp
{
    /// <summary>
    /// Sample application of Asprise OCR C#/VB.NET SDK. Visit http://asprise.com/product/ocr for more details.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            asprise_init();
        }

        private static string GetLastImagePath()
        {
            return AspriseOCR.firstNonNull(Settings.Default["IMAGE_FILE"], "").ToString();
        }

        private static void SetLastImagePath(string path)
        {
            Settings.Default["IMAGE_FILE"] = path;
            Settings.Default.Save();
        }

        private static string GetLastLang()
        {
            return AspriseOCR.firstNonNull(Settings.Default["LAST_LANG"], "eng").ToString();
        }

        private static void SetLastLang(string lang)
        {
            Settings.Default["LAST_LANG"] = lang;
            Settings.Default.Save();
        }

        private AspriseOCR ocr;
        private String currentLang;
        private void asprise_init()
        {
            bool browsed = false;
            int count = 0;

            string dllFilePath = AspriseOCR.getOcrDllPath();
            if (dllFilePath == null)
            {
                string parentFolder = AspriseOCR.detectOcrDllInParentFolders();
                if (parentFolder != null)
                {
                    AspriseOCR.addToSystemPath(parentFolder);
                    log("Folder containing ocr dll detected: " + parentFolder);
                }
            }

            String lang = GetLastLang();
            if (lang == null || lang.Length == 0)
            {
                comboLang.SelectedIndex = 0;
                currentLang = "eng";
            }
            else
            {
                for (int i = 0; i < comboLang.Items.Count; i++)
                {
                    if (comboLang.Items[i].ToString().Equals(lang))
                    {
                        comboLang.SelectedIndex = i;
                        break;
                    }
                }
                currentLang = lang;
            }

            // Let user browse the ocr dll if it is not found in PATH.
            while (true)
            {
                dllFilePath = AspriseOCR.getOcrDllPath();
                if (dllFilePath == null)
                {
                    log("OCR dll (" + AspriseOCR.getOcrDllName() + ") is not found in PATH.");
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.RestoreDirectory = true;
                    fileDialog.Title = "Please select " + AspriseOCR.getOcrDllName();
                    fileDialog.FileName = AspriseOCR.getOcrDllName();
                    if (fileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        log("User browsed dll: " + fileDialog.FileName);
                        AspriseOCR.addToSystemPath(Path.GetDirectoryName(fileDialog.FileName));
                        browsed = true;
                    }
                    count ++;
                    if (count == 2)
                    {
                        showMessageBox("OCR DLL not found. ", "Error");
                        break;
                    }
                }
                else
                {
                    log("OCR dll found: " + dllFilePath);
                    if (browsed)
                    {
                        log("Please consider copy " + AspriseOCR.getOcrDllName() + " to directory: " +
                            Directory.GetCurrentDirectory());
                    }

                    log(AspriseOCR.GetLibraryVersion());

                    try
                    {
                        log("Starting OCR engine ...");
                        AspriseOCR.SetUp();
                        ocr = new AspriseOCR();
                        ocr.StartEngine(currentLang, AspriseOCR.SPEED_FASTEST);
                        log("OCR engine started successfully.");
                   }
                    catch (Exception e)
                    {
                        log("ERROR: Failed to start OCR engine: " + e);
                        log(e.StackTrace);
                    }
                    break;
                }
            }

            // user preference
            textImage.Text = GetLastImagePath();
        }

        public void showMessageBox(string message, string title)
        {
            if (this.InvokeRequired)
            {
                delegate_showMessageBox delegatedMethod = showMessageBox;
                Invoke(delegatedMethod, message, title);
                return;
            }

            MessageBox.Show(this, message, title, MessageBoxButtons.OK);
        }
        delegate void delegate_showMessageBox(string message, string title);

        public void log(string s, bool clear = false)
        {
            if (textbox.InvokeRequired)
            {
                delegate_log delegatedMethod = log;
                Invoke(delegatedMethod, s, clear);
                return;
            }

            if (clear)
            {
                textbox.Text = "";
            }

            if (textbox.Text.Length > 1)
            {
                textbox.Text += "\r\n";
            }
            textbox.Text += s.Replace("\n", "\r\n"); // to properly display in textbox
        }
        delegate void delegate_log(string s, bool clear = false);

        private Color _Color1 = Color.White;
        private Color _Color2 = Color.LightBlue;
        private float _ColorAngle = 60f;

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Getting the graphics object
            Graphics g = pevent.Graphics;

            // Creating the rectangle for the gradient
            Rectangle rBackground = new Rectangle(0, 0,
                                      this.Width, this.Height);

            // Creating the lineargradient
            System.Drawing.Drawing2D.LinearGradientBrush bBackground
                = new System.Drawing.Drawing2D.LinearGradientBrush(rBackground,
                                                  _Color1, _Color2, _ColorAngle);

            // Draw the gradient onto the form
            g.FillRectangle(bBackground, rBackground);

            // Disposing of the resources held by the brush
            bBackground.Dispose();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // settings
            if (!AspriseOCR.isEmpty(textImage.Text))
            {
                try
                {
                    dialog.InitialDirectory = Path.GetDirectoryName(textImage.Text.Trim());
                }
                catch (Exception exception)
                {
                }
            }
            dialog.Title = "Please select OCR input image";
            dialog.Filter = "Image Files(*.BMP;*.GIF;*.JPG;*PNG;*TIF;*TIFF)|*.BMP;*.GIF;*.JPG;*PNG;*TIF;*TIFF|All files (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textImage.Text = dialog.FileName;
            }
        }

        private Thread threadOcr;

        private String langOnUI;
        private void buttonOcr_Click(object sender, EventArgs e)
        {
            if (threadOcr != null && threadOcr.IsAlive)
            {
                showMessageBox("OCR in progress, please wait ...", "Info");
                return;
            }

            langOnUI = comboLang.Text;
            threadOcr = new Thread(this.doOcr);
            threadOcr.Start();
        }

        void doOcr()
        {
            if (textImage.Text.Trim().Length == 0)
            {
                showMessageBox("Please select an input image first.", "Error");
                return;
            }

            if (!File.Exists(textImage.Text.Trim()))
            {
                showMessageBox("Image file does not exist: " + textImage.Text, "Error");
                return;
            }

            if (! langOnUI.Equals(currentLang))
            {
                ocr.StopEngine();
                currentLang = null;

                ocr = new AspriseOCR();
                ocr.StartEngine(langOnUI, AspriseOCR.SPEED_FASTEST);
                currentLang = langOnUI;
            }

            if (ocr == null || !ocr.IsEngineRunning)
            {
                showMessageBox("OCR engine is not running", "Error");
                return;
            }

            if (!checkRecognizeText.Checked && !checkRecognizeBarcodes.Checked)
            {
                showMessageBox("Please check at least one of 'Text', 'Barcodes'", "Warn");
                return;
            }

            string recognizeType = AspriseOCR.RECOGNIZE_TYPE_ALL;
            if (!checkRecognizeText.Checked)
            {
                recognizeType = AspriseOCR.RECOGNIZE_TYPE_BARCODE;
            }
            if (!checkRecognizeBarcodes.Checked)
            {
                recognizeType = AspriseOCR.RECOGNIZE_TYPE_TEXT;
            }

            string outputFormat = AspriseOCR.OUTPUT_FORMAT_PLAINTEXT;
            if (radioOutputXml.Checked)
            {
                outputFormat = AspriseOCR.OUTPUT_FORMAT_XML;
            }
            if (radioOutputPdf.Checked)
            {
                outputFormat = AspriseOCR.OUTPUT_FORMAT_PDF;
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            string pdfOutputFile = null;
            if (outputFormat.Equals(AspriseOCR.OUTPUT_FORMAT_PDF))
            {
                pdfOutputFile = Path.Combine(Directory.GetCurrentDirectory(), DateTime.Now.ToString("O").Replace(':', '-') + ".pdf");
                dict.Add(AspriseOCR.PROP_PDF_OUTPUT_FILE, pdfOutputFile);
                dict.Add(AspriseOCR.PROP_PDF_OUTPUT_TEXT_VISIBLE, "true");
                dict.Add(AspriseOCR.PROP_PDF_OUTPUT_IMAGE_FORCE_BW, "true");
            }

            log("OCR in progress, please stand by ...", true);
            DateTime timeStart = DateTime.Now;
            // Performs the actual recognition
            string s = ocr.Recognize(textImage.Text.Trim(), -1, -1, -1, -1, -1, recognizeType, outputFormat, dict);
            DateTime timeEnd = DateTime.Now;

            // open pdf file
            if (outputFormat.Equals(AspriseOCR.OUTPUT_FORMAT_PDF))
            {
                if (s != null && s.Trim().Length > 0)
                {
                    log(s + "\nPDF file: " + pdfOutputFile, true);
                }
                else
                {
                    log("PDF file created: " + pdfOutputFile, true);
                    try
                    {
                        System.Diagnostics.Process.Start(@pdfOutputFile);
                    }
                    catch (Exception e)
                    {
                        // ignore
                    }
                }
                log("For illustration purpose, text has been rendered in color instead of transparent.");
            }
            else
            {
                log(s, true);
            }

            // user preference
            SetLastImagePath(textImage.Text);
            SetLastLang(currentLang);
        }

        private void linkMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://asprise.com/product/ocr");
        }
    }
}
