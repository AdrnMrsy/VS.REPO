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
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtcourse = New TextBox()
        txtlname = New TextBox()
        txtfname = New TextBox()
        btninsert = New Button()
        GroupBox2 = New GroupBox()
        btndlt = New Button()
        Label7 = New Label()
        btnupd = New Button()
        txtuserid = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtstudcourse = New TextBox()
        txtlast = New TextBox()
        txtfirst = New TextBox()
        btnsearch = New Button()
        btndisplay = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtcourse)
        GroupBox1.Controls.Add(txtlname)
        GroupBox1.Controls.Add(txtfname)
        GroupBox1.Controls.Add(btninsert)
        GroupBox1.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(51, 57)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(473, 437)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Record"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(136, 247)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 6
        Label3.Text = "Course:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(120, 167)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 5
        Label2.Text = "LastName:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(120, 99)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 4
        Label1.Text = "FirstName:"
        ' 
        ' txtcourse
        ' 
        txtcourse.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcourse.Location = New Point(256, 243)
        txtcourse.Margin = New Padding(4)
        txtcourse.Name = "txtcourse"
        txtcourse.Size = New Size(141, 27)
        txtcourse.TabIndex = 3
        ' 
        ' txtlname
        ' 
        txtlname.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtlname.Location = New Point(256, 163)
        txtlname.Margin = New Padding(4)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(141, 27)
        txtlname.TabIndex = 2
        ' 
        ' txtfname
        ' 
        txtfname.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfname.Location = New Point(256, 95)
        txtfname.Margin = New Padding(4)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(141, 27)
        txtfname.TabIndex = 1
        ' 
        ' btninsert
        ' 
        btninsert.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btninsert.Location = New Point(157, 352)
        btninsert.Margin = New Padding(4)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(173, 39)
        btninsert.TabIndex = 0
        btninsert.Text = "Insert Record"
        btninsert.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btndlt)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(btnupd)
        GroupBox2.Controls.Add(txtuserid)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtstudcourse)
        GroupBox2.Controls.Add(txtlast)
        GroupBox2.Controls.Add(txtfirst)
        GroupBox2.Controls.Add(btnsearch)
        GroupBox2.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(643, 72)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(473, 437)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Save Record"
        ' 
        ' btndlt
        ' 
        btndlt.Location = New Point(297, 387)
        btndlt.Name = "btndlt"
        btndlt.Size = New Size(75, 35)
        btndlt.TabIndex = 10
        btndlt.Text = "Delete"
        btndlt.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(109, 39)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 8
        Label7.Text = "Student ID:"
        ' 
        ' btnupd
        ' 
        btnupd.Location = New Point(109, 387)
        btnupd.Name = "btnupd"
        btnupd.Size = New Size(75, 35)
        btnupd.TabIndex = 9
        btnupd.Text = "Update "
        btnupd.UseVisualStyleBackColor = True
        ' 
        ' txtuserid
        ' 
        txtuserid.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtuserid.Location = New Point(256, 35)
        txtuserid.Margin = New Padding(4)
        txtuserid.Name = "txtuserid"
        txtuserid.Size = New Size(141, 27)
        txtuserid.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(136, 247)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 6
        Label4.Text = "Course:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(120, 167)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 5
        Label5.Text = "LastName:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(120, 99)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 20)
        Label6.TabIndex = 4
        Label6.Text = "FirstName:"
        ' 
        ' txtstudcourse
        ' 
        txtstudcourse.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtstudcourse.Location = New Point(256, 243)
        txtstudcourse.Margin = New Padding(4)
        txtstudcourse.Name = "txtstudcourse"
        txtstudcourse.Size = New Size(141, 27)
        txtstudcourse.TabIndex = 3
        ' 
        ' txtlast
        ' 
        txtlast.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtlast.Location = New Point(256, 163)
        txtlast.Margin = New Padding(4)
        txtlast.Name = "txtlast"
        txtlast.Size = New Size(141, 27)
        txtlast.TabIndex = 2
        ' 
        ' txtfirst
        ' 
        txtfirst.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfirst.Location = New Point(256, 95)
        txtfirst.Margin = New Padding(4)
        txtfirst.Name = "txtfirst"
        txtfirst.Size = New Size(141, 27)
        txtfirst.TabIndex = 1
        ' 
        ' btnsearch
        ' 
        btnsearch.Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnsearch.Location = New Point(157, 320)
        btnsearch.Margin = New Padding(4)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(173, 39)
        btnsearch.TabIndex = 0
        btnsearch.Text = "Search Record"
        btnsearch.UseVisualStyleBackColor = True
        ' 
        ' btndisplay
        ' 
        btndisplay.Location = New Point(508, 542)
        btndisplay.Margin = New Padding(4)
        btndisplay.Name = "btndisplay"
        btndisplay.Size = New Size(131, 57)
        btndisplay.TabIndex = 8
        btndisplay.Text = "Display by course"
        btndisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 636)
        Controls.Add(btndisplay)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Dutch801 XBd BT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents btninsert As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstudcourse As TextBox
    Friend WithEvents txtlast As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents btndisplay As Button
    Friend WithEvents btnupd As Button
    Friend WithEvents btndlt As Button
End Class
