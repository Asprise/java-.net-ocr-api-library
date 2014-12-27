<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.buttonOcr = New System.Windows.Forms.Button()
        Me.checkRecognizeBarcodes = New System.Windows.Forms.CheckBox()
        Me.checkRecognizeText = New System.Windows.Forms.CheckBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.radioOutputXml = New System.Windows.Forms.RadioButton()
        Me.radioOutputPdf = New System.Windows.Forms.RadioButton()
        Me.radioOutputText = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.buttonBrowse = New System.Windows.Forms.Button()
        Me.textImage = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textbox = New System.Windows.Forms.TextBox()
        Me.linkMoreInfo = New System.Windows.Forms.LinkLabel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.comboLang = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.textbox, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 86)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(846, 367)
        Me.tableLayoutPanel1.TabIndex = 9
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.comboLang)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.buttonOcr)
        Me.groupBox1.Controls.Add(Me.checkRecognizeBarcodes)
        Me.groupBox1.Controls.Add(Me.checkRecognizeText)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.radioOutputXml)
        Me.groupBox1.Controls.Add(Me.radioOutputPdf)
        Me.groupBox1.Controls.Add(Me.radioOutputText)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.buttonBrowse)
        Me.groupBox1.Controls.Add(Me.textImage)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(8, 6)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(830, 88)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "OCR"
        '
        'buttonOcr
        '
        Me.buttonOcr.BackColor = System.Drawing.Color.RoyalBlue
        Me.buttonOcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonOcr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonOcr.Location = New System.Drawing.Point(675, 58)
        Me.buttonOcr.Name = "buttonOcr"
        Me.buttonOcr.Size = New System.Drawing.Size(149, 23)
        Me.buttonOcr.TabIndex = 8
        Me.buttonOcr.Text = "OCR"
        Me.buttonOcr.UseVisualStyleBackColor = False
        '
        'checkRecognizeBarcodes
        '
        Me.checkRecognizeBarcodes.AutoSize = True
        Me.checkRecognizeBarcodes.Checked = True
        Me.checkRecognizeBarcodes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkRecognizeBarcodes.Location = New System.Drawing.Point(432, 61)
        Me.checkRecognizeBarcodes.Name = "checkRecognizeBarcodes"
        Me.checkRecognizeBarcodes.Size = New System.Drawing.Size(71, 17)
        Me.checkRecognizeBarcodes.TabIndex = 7
        Me.checkRecognizeBarcodes.Text = "Barcodes"
        Me.checkRecognizeBarcodes.UseVisualStyleBackColor = True
        '
        'checkRecognizeText
        '
        Me.checkRecognizeText.AutoSize = True
        Me.checkRecognizeText.Checked = True
        Me.checkRecognizeText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkRecognizeText.Location = New System.Drawing.Point(379, 61)
        Me.checkRecognizeText.Name = "checkRecognizeText"
        Me.checkRecognizeText.Size = New System.Drawing.Size(47, 17)
        Me.checkRecognizeText.TabIndex = 6
        Me.checkRecognizeText.Text = "Text"
        Me.checkRecognizeText.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(312, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Recognize:"
        '
        'radioOutputXml
        '
        Me.radioOutputXml.AutoSize = True
        Me.radioOutputXml.Location = New System.Drawing.Point(161, 62)
        Me.radioOutputXml.Name = "radioOutputXml"
        Me.radioOutputXml.Size = New System.Drawing.Size(47, 17)
        Me.radioOutputXml.TabIndex = 4
        Me.radioOutputXml.Text = "XML"
        Me.radioOutputXml.UseVisualStyleBackColor = True
        '
        'radioOutputPdf
        '
        Me.radioOutputPdf.AutoSize = True
        Me.radioOutputPdf.Location = New System.Drawing.Point(213, 62)
        Me.radioOutputPdf.Name = "radioOutputPdf"
        Me.radioOutputPdf.Size = New System.Drawing.Size(46, 17)
        Me.radioOutputPdf.TabIndex = 3
        Me.radioOutputPdf.Text = "PDF"
        Me.radioOutputPdf.UseVisualStyleBackColor = True
        '
        'radioOutputText
        '
        Me.radioOutputText.AutoSize = True
        Me.radioOutputText.Checked = True
        Me.radioOutputText.Location = New System.Drawing.Point(87, 62)
        Me.radioOutputText.Name = "radioOutputText"
        Me.radioOutputText.Size = New System.Drawing.Size(68, 17)
        Me.radioOutputText.TabIndex = 2
        Me.radioOutputText.TabStop = True
        Me.radioOutputText.Text = "Plain text"
        Me.radioOutputText.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 62)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Output Format:"
        '
        'buttonBrowse
        '
        Me.buttonBrowse.Location = New System.Drawing.Point(626, 25)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse.TabIndex = 2
        Me.buttonBrowse.Text = "Browse ..."
        Me.buttonBrowse.UseVisualStyleBackColor = True
        '
        'textImage
        '
        Me.textImage.Location = New System.Drawing.Point(87, 27)
        Me.textImage.Name = "textImage"
        Me.textImage.Size = New System.Drawing.Size(533, 20)
        Me.textImage.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(42, 30)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Image:"
        '
        'textbox
        '
        Me.textbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textbox.Location = New System.Drawing.Point(8, 106)
        Me.textbox.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.textbox.Multiline = True
        Me.textbox.Name = "textbox"
        Me.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textbox.Size = New System.Drawing.Size(830, 255)
        Me.textbox.TabIndex = 4
        Me.textbox.WordWrap = False
        '
        'linkMoreInfo
        '
        Me.linkMoreInfo.BackColor = System.Drawing.Color.Transparent
        Me.linkMoreInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.linkMoreInfo.Location = New System.Drawing.Point(0, 453)
        Me.linkMoreInfo.Name = "linkMoreInfo"
        Me.linkMoreInfo.Size = New System.Drawing.Size(846, 20)
        Me.linkMoreInfo.TabIndex = 8
        Me.linkMoreInfo.TabStop = True
        Me.linkMoreInfo.Text = "For more information, please click here to visit http://asprise.com/product/ocr"
        Me.linkMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.label1.Location = New System.Drawing.Point(0, 50)
        Me.label1.Margin = New System.Windows.Forms.Padding(0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(846, 36)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Instruction: select an image and press the OCR button to start"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelTitle
        '
        Me.labelTitle.BackColor = System.Drawing.Color.White
        Me.labelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.OrangeRed
        Me.labelTitle.Location = New System.Drawing.Point(0, 0)
        Me.labelTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(846, 50)
        Me.labelTitle.TabIndex = 6
        Me.labelTitle.Text = "Thank You For Evaluating Asprise OCR SDK for VB.NET"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comboLang
        '
        Me.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLang.FormattingEnabled = True
        Me.comboLang.Items.AddRange(New Object() {"eng", "spa", "por", "deu", "fra"})
        Me.comboLang.Location = New System.Drawing.Point(573, 58)
        Me.comboLang.Name = "comboLang"
        Me.comboLang.Size = New System.Drawing.Size(83, 21)
        Me.comboLang.TabIndex = 12
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(518, 61)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(58, 13)
        Me.label5.TabIndex = 11
        Me.label5.Text = "Language:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 473)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.linkMoreInfo)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.labelTitle)
        Me.Name = "Form1"
        Me.Text = "Asprise OCR"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents buttonOcr As System.Windows.Forms.Button
    Private WithEvents checkRecognizeBarcodes As System.Windows.Forms.CheckBox
    Private WithEvents checkRecognizeText As System.Windows.Forms.CheckBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents radioOutputXml As System.Windows.Forms.RadioButton
    Private WithEvents radioOutputPdf As System.Windows.Forms.RadioButton
    Private WithEvents radioOutputText As System.Windows.Forms.RadioButton
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents buttonBrowse As System.Windows.Forms.Button
    Private WithEvents textImage As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textbox As System.Windows.Forms.TextBox
    Private WithEvents linkMoreInfo As System.Windows.Forms.LinkLabel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents labelTitle As System.Windows.Forms.Label
    Private WithEvents comboLang As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label

End Class
