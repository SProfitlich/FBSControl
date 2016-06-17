<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFBS
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Opt270 = New System.Windows.Forms.RadioButton()
        Me.Opt180 = New System.Windows.Forms.RadioButton()
        Me.Opt90 = New System.Windows.Forms.RadioButton()
        Me.Opt0 = New System.Windows.Forms.RadioButton()
        Me.chkGespiegelt = New System.Windows.Forms.CheckBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.FBSControl = New FBS_Element.FBSControl()
        Me.SuspendLayout()
        '
        'Opt270
        '
        Me.Opt270.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Opt270.AutoSize = True
        Me.Opt270.Location = New System.Drawing.Point(361, 144)
        Me.Opt270.Name = "Opt270"
        Me.Opt270.Size = New System.Drawing.Size(53, 21)
        Me.Opt270.TabIndex = 10
        Me.Opt270.Text = "270"
        Me.Opt270.UseVisualStyleBackColor = True
        '
        'Opt180
        '
        Me.Opt180.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Opt180.AutoSize = True
        Me.Opt180.Location = New System.Drawing.Point(360, 117)
        Me.Opt180.Name = "Opt180"
        Me.Opt180.Size = New System.Drawing.Size(53, 21)
        Me.Opt180.TabIndex = 9
        Me.Opt180.Text = "180"
        Me.Opt180.UseVisualStyleBackColor = True
        '
        'Opt90
        '
        Me.Opt90.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Opt90.AutoSize = True
        Me.Opt90.Location = New System.Drawing.Point(360, 90)
        Me.Opt90.Name = "Opt90"
        Me.Opt90.Size = New System.Drawing.Size(45, 21)
        Me.Opt90.TabIndex = 8
        Me.Opt90.Text = "90"
        Me.Opt90.UseVisualStyleBackColor = True
        '
        'Opt0
        '
        Me.Opt0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Opt0.AutoSize = True
        Me.Opt0.Checked = True
        Me.Opt0.Location = New System.Drawing.Point(360, 63)
        Me.Opt0.Name = "Opt0"
        Me.Opt0.Size = New System.Drawing.Size(37, 21)
        Me.Opt0.TabIndex = 7
        Me.Opt0.TabStop = True
        Me.Opt0.Text = "0"
        Me.Opt0.UseVisualStyleBackColor = True
        '
        'chkGespiegelt
        '
        Me.chkGespiegelt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkGespiegelt.AutoSize = True
        Me.chkGespiegelt.Location = New System.Drawing.Point(361, 12)
        Me.chkGespiegelt.Name = "chkGespiegelt"
        Me.chkGespiegelt.Size = New System.Drawing.Size(98, 21)
        Me.chkGespiegelt.TabIndex = 6
        Me.chkGespiegelt.Text = "Gespiegelt"
        Me.chkGespiegelt.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(361, 181)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(54, 22)
        Me.txtSize.TabIndex = 11
        Me.txtSize.Text = "1.0"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(358, 224)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(67, 17)
        Me.lblFileName.TabIndex = 12
        Me.lblFileName.Text = "FileName"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(361, 244)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(156, 22)
        Me.txtFileName.TabIndex = 13
        Me.txtFileName.Text = "d:\SWLogo_90.bmp"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(361, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(442, 272)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 15
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'FBSControl
        '
        Me.FBSControl.Location = New System.Drawing.Point(12, 10)
        Me.FBSControl.Name = "FBSControl"
        Me.FBSControl.Size = New System.Drawing.Size(311, 285)
        Me.FBSControl.TabIndex = 0
        '
        'FrmFBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 313)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Opt270)
        Me.Controls.Add(Me.Opt180)
        Me.Controls.Add(Me.Opt90)
        Me.Controls.Add(Me.Opt0)
        Me.Controls.Add(Me.chkGespiegelt)
        Me.Controls.Add(Me.FBSControl)
        Me.Name = "FrmFBS"
        Me.Text = "FBS mit OCX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FBSControl As FBS_Element.FBSControl
    Friend WithEvents Opt270 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt180 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt90 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt0 As System.Windows.Forms.RadioButton
    Friend WithEvents chkGespiegelt As System.Windows.Forms.CheckBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button

End Class
