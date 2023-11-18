Imports K4os.Compression.LZ4.Streams
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "cs2aoop"
        uname = "root"
        pwd = "password"
        If Not con Is Nothing Then
            con.Close() ' close the connection
            'connection string signature 
            con.ConnectionString = "server=" & host & ";user id=" & uname & ";password=" & pwd & ";database=" & dbname & ""
            Try
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Public Sub SaveRecord()
        Dim fname, lname, course As String
        fname = Form1.txtfname.Text
        lname = Form1.txtlname.Text
        course = Form1.txtcourse.Text
        sqlquery = "INSERT INTO student(studFName, studLName, course) VALUES(@fname, @lname, @course)"
        'pass the query and connection to my sqlcommand
        mysqlcmd = New MySqlCommand(sqlquery, con)
        'add parameters value
        mysqlcmd.Parameters.AddWithValue("@fname", fname)
        mysqlcmd.Parameters.AddWithValue("@lname", lname)
        mysqlcmd.Parameters.AddWithValue("@course", course)
        Try
            'execute mysqlquery command
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record save successtully!")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        Finally
            TextClear()
        End Try

    End Sub
    Sub TextClear()
        Form1.txtfname.Clear()
        Form1.txtlname.Clear()
        Form1.txtcourse.Clear()
    End Sub
    Public Sub SearchData()
        Dim uid As String
        uid = Form1.txtuserid.Text

        sqlquery = "SELECT * FROM student where studID = @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@uid", uid)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                Form1.txtfirst.Text = reader("studFName").ToString()
                Form1.txtlast.Text = reader("studLName").ToString()
                Form1.txtstudcourse.Text = reader("course").ToString()
                Form1.btndlt.Enabled = True
                Form1.btnupd.Enabled = True
                Form1.txtfirst.Enabled = True
                Form1.txtlast.Enabled = True
                Form1.txtstudcourse.Enabled = True
            Else
                MsgBox("No Record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()

        End Try
    End Sub
    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM student"
        adapter = New MySqlDataAdapter(sqlquery, con)
        Try
            dtTable = New DataTable
            adapter.Fill(dtTable) 'pass the record form mysql to table
            With Form2.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub LoadCourse()
        sqlquery = "SELECT distinct course FROM student"
        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            reader = mysqlcmd.ExecuteReader
            While reader.Read
                Form2.cbocourse.Items.Add(reader("course").ToString)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub DisplayAllData(kurso As String)
        sqlquery = "SELECT * FROM student where course= @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)
        Try
            dtTable = New DataTable
            adapter.Fill(dtTable) 'pass the record form mysql to table
            With Form2.dgvdata
                .DataSource = dtTable
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub UpdateRecord(studID As String, fname As String, lname As String, course As String)
        sqlquery = "UPDATE student set studFName=@fname, studLName= @lname, course=@course where studID = @studID"
        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@studID", studID)
                cmd.ExecuteNonQuery()
                MsgBox("Update Successful", vbInformation, "Update Message")
            End Using
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()

        End Try
    End Sub
    Public Sub DeleteRecord(studid As String)
        sqlquery = "DELETE from student where studID = @studID"
        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@studID", studid)
                cmd.ExecuteNonQuery()
                MsgBox("Deletion Successful", vbInformation, "Delete Message")
            End Using
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()

        End Try
    End Sub
End Module
