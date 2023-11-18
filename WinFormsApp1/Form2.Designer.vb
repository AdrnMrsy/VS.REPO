<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        cbocourse = New ComboBox()
        btndisplay = New Button()
        dgvdata = New DataGridView()
        btnhome = New Button()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbocourse
        ' 
        cbocourse.FormattingEnabled = True
        cbocourse.Location = New Point(174, 59)
        cbocourse.Margin = New Padding(4)
        cbocourse.Name = "cbocourse"
        cbocourse.Size = New Size(235, 28)
        cbocourse.TabIndex = 0
        ' 
        ' btndisplay
        ' 
        btndisplay.Location = New Point(538, 56)
        btndisplay.Margin = New Padding(4)
        btndisplay.Name = "btndisplay"
        btndisplay.Size = New Size(107, 31)
        btndisplay.TabIndex = 1
        btndisplay.Text = "Display"
        btndisplay.UseVisualStyleBackColor = True
        ' 
        ' dgvdata
        ' 
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(118, 130)
        dgvdata.Margin = New Padding(4)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(579, 323)
        dgvdata.TabIndex = 2
        ' 
        ' btnhome
        ' 
        btnhome.Location = New Point(538, 506)
        btnhome.Margin = New Padding(4)
        btnhome.Name = "btnhome"
        btnhome.Size = New Size(107, 31)
        btnhome.TabIndex = 3
        btnhome.Text = "Home"
        btnhome.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(818, 563)
        ControlBox = False
        Controls.Add(btnhome)
        Controls.Add(dgvdata)
        Controls.Add(btndisplay)
        Controls.Add(cbocourse)
        Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form2"
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents btndisplay As Button
    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents btnhome As Button
End Class
