Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Private Function savedata(sql As String)
        Dim mysqlcon As MySqlConnection = New MySqlConnection("server= localhost;Port=3306; database=librarymngt; username= root; password=sms")
        Dim mysqlcmd As MySqlCommand
        Dim mysqlresult As Boolean
        Try
            mysqlcon.Open()
            mysqlcmd = New MySqlCommand
            With mysqlcmd
                .Connection = mysqlcon
                .CommandText = sql
                mysqlresult = .ExecuteNonQuery
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return mysqlresult
    End Function
    Private Sub Browsedocument()
        Me.Cursor = Cursors.WaitCursor

        Dim ofd As New OpenFileDialog
        Dim con As OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Try
            With ofd
                .Filter = "Excel File(*.xlsx)|*.xlsx|All files(*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import data from excel file"
            End With
            If ofd.ShowDialog() = DialogResult.OK Then
                txtlocation.Text = ofd.FileName

                con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + txtlocation.Text + ";Extended Properties=Excel 12.0;")
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM [Sheet1$]"

                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                dgv1.DataSource = dt
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub uploaddocument()
        Me.Cursor = Cursors.WaitCursor
        ProgressBar1.BringToFront()

        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + txtlocation.Text + ";Extended Properties=Excel 12.0;")
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim result As Boolean
        Dim sql As String
        '

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM [Sheet1$]"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)


            For Each r As DataRow In dt.Rows

                sql = "INSERT INTO studentinfo(admno,name,sex)values('" & r(0).ToString & "','" & r(1).ToString.Replace("'", "''") & "','" & r(2).ToString & "')"
                result = savedata(sql)

                '   sql = "Insert into parentinfo (admno)values('" & r(0).ToString & "')"
                ' result = savedata(sql)

                ' sql = "INSERT INTO classallocation(admno,class,stream,year)values('" & r(0).ToString & "','" & tclass.Text & "','" & tstream.Text & "','" & tyear.Text & "')"
                ' result = savedata(sql)

                If result Then
                    Timer1.Start()
                End If
            Next
        Catch ex As Exception
        Finally
            con.Close()
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Browsedocument()
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        uploaddocument()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Successfully imported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ProgressBar1.Value = 0
        Else

            ProgressBar1.Value += 1
        End If
    End Sub
End Class
