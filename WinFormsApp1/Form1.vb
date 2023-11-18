Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtfirst.Enabled = False
        txtlast.Enabled = False
        txtstudcourse.Enabled = False
        btnupd.Enabled = False
        btndlt.Enabled = False

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        SaveRecord()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        SearchData()
    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Form2.show()
        Me.Hide()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            UpdateRecord(txtuserid.Text, txtfirst.Text, txtlast.Text, txtstudcourse.Text)
            MsgBox("Update Successful")
        Else
            MsgBox("Update Cancelled")
        End If

    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            DeleteRecord(txtuserid.Text)
            MsgBox("Delete Record")
        Else
            MsgBox("Delete Cancelled")
        End If
    End Sub
End Class
