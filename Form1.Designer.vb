<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblTitle = New Label()
        picPayroll = New PictureBox()
        lblHeading = New Label()
        lblInstruct = New Label()
        txtCal = New RichTextBox()
        btnTaxes = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblFica = New Label()
        lblFederal = New Label()
        lblState = New Label()
        lblTitle2 = New Label()
        lblResults = New Label()
        ficaResults = New Label()
        federalResults = New Label()
        stateResults = New Label()
        CType(picPayroll, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(473, 60)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(290, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Payroll Calculator "
        ' 
        ' picPayroll
        ' 
        picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), Image)
        picPayroll.Location = New Point(0, -1)
        picPayroll.Name = "picPayroll"
        picPayroll.Size = New Size(425, 296)
        picPayroll.SizeMode = PictureBoxSizeMode.StretchImage
        picPayroll.TabIndex = 1
        picPayroll.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(515, 136)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(179, 62)
        lblHeading.TabIndex = 2
        lblHeading.Text = "Paycheck" & vbCrLf & "Calculation "
        lblHeading.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblInstruct
        ' 
        lblInstruct.AutoSize = True
        lblInstruct.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruct.Location = New Point(205, 327)
        lblInstruct.Name = "lblInstruct"
        lblInstruct.Size = New Size(171, 21)
        lblInstruct.TabIndex = 3
        lblInstruct.Text = "Enter Gross Pay:"
        ' 
        ' txtCal
        ' 
        txtCal.Location = New Point(437, 316)
        txtCal.Name = "txtCal"
        txtCal.Size = New Size(145, 32)
        txtCal.TabIndex = 4
        txtCal.Text = ""
        ' 
        ' btnTaxes
        ' 
        btnTaxes.BackColor = SystemColors.Highlight
        btnTaxes.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTaxes.ForeColor = Color.White
        btnTaxes.Location = New Point(69, 371)
        btnTaxes.Name = "btnTaxes"
        btnTaxes.Size = New Size(128, 42)
        btnTaxes.TabIndex = 5
        btnTaxes.Text = "Compute Taxes "
        btnTaxes.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Highlight
        btnClear.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(324, 370)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 42)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Highlight
        btnExit.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(566, 370)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 42)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblFica
        ' 
        lblFica.AutoSize = True
        lblFica.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFica.Location = New Point(84, 436)
        lblFica.Name = "lblFica"
        lblFica.Size = New Size(57, 19)
        lblFica.TabIndex = 8
        lblFica.Text = "FICA:"
        ' 
        ' lblFederal
        ' 
        lblFederal.AutoSize = True
        lblFederal.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFederal.Location = New Point(307, 436)
        lblFederal.Name = "lblFederal"
        lblFederal.Size = New Size(109, 19)
        lblFederal.TabIndex = 9
        lblFederal.Text = "Federal Tax:"
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblState.Location = New Point(566, 436)
        lblState.Name = "lblState"
        lblState.Size = New Size(89, 19)
        lblState.TabIndex = 10
        lblState.Text = "State Tax:"
        ' 
        ' lblTitle2
        ' 
        lblTitle2.AutoSize = True
        lblTitle2.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle2.Location = New Point(171, 502)
        lblTitle2.Name = "lblTitle2"
        lblTitle2.Size = New Size(224, 21)
        lblTitle2.TabIndex = 11
        lblTitle2.Text = "Net Paycheck Income:"
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResults.Location = New Point(458, 502)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(54, 21)
        lblResults.TabIndex = 12
        lblResults.Text = "$000"
        ' 
        ' ficaResults
        ' 
        ficaResults.AutoSize = True
        ficaResults.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ficaResults.Location = New Point(147, 436)
        ficaResults.Name = "ficaResults"
        ficaResults.Size = New Size(39, 19)
        ficaResults.TabIndex = 13
        ficaResults.Text = "000"
        ' 
        ' federalResults
        ' 
        federalResults.AutoSize = True
        federalResults.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        federalResults.Location = New Point(422, 436)
        federalResults.Name = "federalResults"
        federalResults.Size = New Size(39, 19)
        federalResults.TabIndex = 14
        federalResults.Text = "000"
        ' 
        ' stateResults
        ' 
        stateResults.AutoSize = True
        stateResults.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stateResults.Location = New Point(661, 436)
        stateResults.Name = "stateResults"
        stateResults.Size = New Size(39, 19)
        stateResults.TabIndex = 15
        stateResults.Text = "000"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 555)
        Controls.Add(stateResults)
        Controls.Add(federalResults)
        Controls.Add(ficaResults)
        Controls.Add(lblResults)
        Controls.Add(lblTitle2)
        Controls.Add(lblState)
        Controls.Add(lblFederal)
        Controls.Add(lblFica)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnTaxes)
        Controls.Add(txtCal)
        Controls.Add(lblInstruct)
        Controls.Add(lblHeading)
        Controls.Add(picPayroll)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Payroll Every Two Weeks"
        CType(picPayroll, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstruct As Label
    Friend WithEvents txtCal As RichTextBox
    Friend WithEvents btnTaxes As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents ficaResults As Label
    Friend WithEvents federalResults As Label
    Friend WithEvents stateResults As Label

End Class
