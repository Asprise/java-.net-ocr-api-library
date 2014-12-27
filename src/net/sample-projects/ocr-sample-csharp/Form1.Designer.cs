namespace ocr_sample_csharp
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOcr = new System.Windows.Forms.Button();
            this.checkRecognizeBarcodes = new System.Windows.Forms.CheckBox();
            this.checkRecognizeText = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioOutputXml = new System.Windows.Forms.RadioButton();
            this.radioOutputPdf = new System.Windows.Forms.RadioButton();
            this.radioOutputText = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkMoreInfo = new System.Windows.Forms.LinkLabel();
            this.textbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(805, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thank You For Evaluating Asprise OCR SDK for C#";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instruction: select an image and press the OCR button to start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboLang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonOcr);
            this.groupBox1.Controls.Add(this.checkRecognizeBarcodes);
            this.groupBox1.Controls.Add(this.checkRecognizeText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioOutputXml);
            this.groupBox1.Controls.Add(this.radioOutputPdf);
            this.groupBox1.Controls.Add(this.radioOutputText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.textImage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OCR";
            // 
            // buttonOcr
            // 
            this.buttonOcr.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOcr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOcr.Location = new System.Drawing.Point(651, 54);
            this.buttonOcr.Name = "buttonOcr";
            this.buttonOcr.Size = new System.Drawing.Size(132, 27);
            this.buttonOcr.TabIndex = 8;
            this.buttonOcr.Text = "OCR";
            this.buttonOcr.UseVisualStyleBackColor = false;
            this.buttonOcr.Click += new System.EventHandler(this.buttonOcr_Click);
            // 
            // checkRecognizeBarcodes
            // 
            this.checkRecognizeBarcodes.AutoSize = true;
            this.checkRecognizeBarcodes.Checked = true;
            this.checkRecognizeBarcodes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRecognizeBarcodes.Location = new System.Drawing.Point(406, 62);
            this.checkRecognizeBarcodes.Name = "checkRecognizeBarcodes";
            this.checkRecognizeBarcodes.Size = new System.Drawing.Size(71, 17);
            this.checkRecognizeBarcodes.TabIndex = 7;
            this.checkRecognizeBarcodes.Text = "Barcodes";
            this.checkRecognizeBarcodes.UseVisualStyleBackColor = true;
            // 
            // checkRecognizeText
            // 
            this.checkRecognizeText.AutoSize = true;
            this.checkRecognizeText.Checked = true;
            this.checkRecognizeText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRecognizeText.Location = new System.Drawing.Point(353, 62);
            this.checkRecognizeText.Name = "checkRecognizeText";
            this.checkRecognizeText.Size = new System.Drawing.Size(47, 17);
            this.checkRecognizeText.TabIndex = 6;
            this.checkRecognizeText.Text = "Text";
            this.checkRecognizeText.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recognize:";
            // 
            // radioOutputXml
            // 
            this.radioOutputXml.AutoSize = true;
            this.radioOutputXml.Location = new System.Drawing.Point(161, 62);
            this.radioOutputXml.Name = "radioOutputXml";
            this.radioOutputXml.Size = new System.Drawing.Size(47, 17);
            this.radioOutputXml.TabIndex = 4;
            this.radioOutputXml.Text = "XML";
            this.radioOutputXml.UseVisualStyleBackColor = true;
            // 
            // radioOutputPdf
            // 
            this.radioOutputPdf.AutoSize = true;
            this.radioOutputPdf.Location = new System.Drawing.Point(213, 62);
            this.radioOutputPdf.Name = "radioOutputPdf";
            this.radioOutputPdf.Size = new System.Drawing.Size(46, 17);
            this.radioOutputPdf.TabIndex = 3;
            this.radioOutputPdf.Text = "PDF";
            this.radioOutputPdf.UseVisualStyleBackColor = true;
            // 
            // radioOutputText
            // 
            this.radioOutputText.AutoSize = true;
            this.radioOutputText.Checked = true;
            this.radioOutputText.Location = new System.Drawing.Point(87, 62);
            this.radioOutputText.Name = "radioOutputText";
            this.radioOutputText.Size = new System.Drawing.Size(68, 17);
            this.radioOutputText.TabIndex = 2;
            this.radioOutputText.TabStop = true;
            this.radioOutputText.Text = "Plain text";
            this.radioOutputText.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output Format:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(708, 24);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse ...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(87, 27);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(615, 20);
            this.textImage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Image:";
            // 
            // linkMoreInfo
            // 
            this.linkMoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.linkMoreInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkMoreInfo.Location = new System.Drawing.Point(0, 400);
            this.linkMoreInfo.Name = "linkMoreInfo";
            this.linkMoreInfo.Size = new System.Drawing.Size(805, 20);
            this.linkMoreInfo.TabIndex = 3;
            this.linkMoreInfo.TabStop = true;
            this.linkMoreInfo.Text = "For more information, please click here to visit http://asprise.com/product/ocr";
            this.linkMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMoreInfo_LinkClicked);
            // 
            // textbox
            // 
            this.textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox.Location = new System.Drawing.Point(8, 106);
            this.textbox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox.Size = new System.Drawing.Size(789, 209);
            this.textbox.TabIndex = 4;
            this.textbox.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textbox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 314);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Language:";
            // 
            // comboLang
            // 
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Items.AddRange(new object[] {
            "eng",
            "spa",
            "por",
            "deu",
            "fra"});
            this.comboLang.Location = new System.Drawing.Point(562, 59);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(83, 21);
            this.comboLang.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.linkMoreInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Asprise OCR Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioOutputXml;
        private System.Windows.Forms.RadioButton radioOutputPdf;
        private System.Windows.Forms.RadioButton radioOutputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOcr;
        private System.Windows.Forms.CheckBox checkRecognizeBarcodes;
        private System.Windows.Forms.CheckBox checkRecognizeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkMoreInfo;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.Label label5;
    }
}