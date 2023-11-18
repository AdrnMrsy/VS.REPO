Public Class Form2
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        If cbocourse.SelectedIndex = 0 Then
            DisplayAllData("bsit")
        ElseIf cbocourse.SelectedIndex = 1 Then
            DisplayAllData("bscs")
        ElseIf cbocourse.SelectedIndex = 2 Then
            DisplayAllData("coa")
        ElseIf cbocourse.SelectedIndex = 3 Then
            DisplayAllData("cba")
        Else
            MsgBox("no record found")

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase() 'connection
        LoadCourse()
        LoadAllData() 'load all the data from the db
        With dgvdata
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.Azure
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        End With
    End Sub
End Class