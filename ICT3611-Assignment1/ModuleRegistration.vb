Imports System.IO
Imports System.Windows.Forms.ListView
Imports System.Data.SqlClient

Public Class frmModuleRegistration

    Public Const file As String = "D:/DB_ICT3611_Assg1_Modules.txt"

    Private Sub btnStudentRegistration_Click(sender As Object, e As EventArgs) Handles btnStudentRegistration.Click
        frmStudentRegistration.Visible = True
        frmModuleActivation.Visible = False
        frmStudentEnrolment.Visible = False
        Me.Visible = False
    End Sub

    Private Sub btnModuleRegistration_Click(sender As Object, e As EventArgs) Handles btnModuleRegistration.Click
        frmStudentRegistration.Visible = False
        frmModuleActivation.Visible = False
        frmStudentEnrolment.Visible = False
        Me.Visible = True
    End Sub

    Private Sub btnModuleActivation_Click(sender As Object, e As EventArgs) Handles btnModuleActivation.Click
        frmStudentRegistration.Visible = False
        frmModuleActivation.Visible = True
        frmStudentEnrolment.Visible = False
        Me.Visible = False
    End Sub

    Private Sub btnStudentEnrolment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrolment.Click
        frmStudentRegistration.Visible = False
        frmModuleActivation.Visible = False
        frmStudentEnrolment.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmModuleRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       
        Dim conStr As String = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"
        Dim con As New SqlClient.SqlConnection(conStr)
        Try
            con.Open()
            Dim lstViewText(3) As String
            Dim sqlStr As String = "SELECT * FROM modules"
            Dim comm As New SqlCommand(sqlStr, con)
            Dim rd As SqlDataReader = comm.ExecuteReader

            Do While rd.HasRows

                Do While rd.Read()
                    For num As Integer = 0 To (lstViewText.Length - 2)
                        lstViewText(num) = rd.GetString(num)
                    Next

                    lstView.Items.Add(New ListViewItem(lstViewText))
                Loop

                rd.NextResult()
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        'If (My.Computer.FileSystem.FileExists(file)) Then

        'Dim reader As New StreamReader(file, False)

        'Try
        'Dim lstViewText(3) As String

        'Dim line As String
        'Dim pos As Integer

        'Do
        'line = reader.ReadLine()
        'If line Is Nothing Then Exit Do

        'pos = 0
        'For Each item In line.Split(";")
        'lstViewText(pos) = item
        'pos += 1
        'Next
        'lstView.Items.Add(New ListViewItem(lstViewText))
        'Loop

        'Catch ex As IOException
        'MsgBox(ex.ToString)
        'Finally
        'reader.Close()
        'End Try

        'End If

    End Sub

    Private Sub btnCreateModule_Click(sender As Object, e As EventArgs) Handles btnCreateModule.Click

        'Dim writer As StreamWriter
        'writer = New StreamWriter(file, True)
        Dim lstViewText(3) As String
        lstViewText(0) = txtModelCode.Text
        lstViewText(1) = txtModelTitle.Text
        lstViewText(2) = txtActicationSemester.Text

        Dim moduleExists As Boolean

        moduleExists = False

        For Each item In lstView.Items
            If (lstViewText(0) = item.SubItems(0).Text) Then
                moduleExists = True
            End If
        Next item


        If Not (moduleExists) Then
            Dim con As New SqlConnection
            Dim inscmd As New SqlCommand
            con.ConnectionString = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"

            Try
                con.Open()
                inscmd.Connection = con
                inscmd.CommandText = ("INSERT INTO modules(CODE,TITLE,ACTIVE_SEMESTER) VALUES('" + txtModelCode.Text + "', '" + txtModelTitle.Text + "', '" + txtActicationSemester.Text + "')")
                inscmd.ExecuteNonQuery()

                lstView.Items.Add(New ListViewItem(lstViewText))

                MessageBox.Show("Inserted Successfully ")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If


        'If Not (moduleExists) Then
        'lstView.Items.Add(New ListViewItem(lstViewText))
        'Try
        'writer.WriteLine(lstViewText(0) + ";" + lstViewText(1) + ";" + lstViewText(2))
        'Catch ex As IOException
        'MsgBox(ex.ToString)
        'Finally
        'writer.Close()
        'End Try
        'Else
        'MsgBox("Please note that Module Code " + lstViewText(0) + " already exists")
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PrintData.printData("INSERT INTO active_modules(CODE,TITLE,ACTIVE_SEMESTER) VALUES('" + txtModelCode.Text + "', '" + txtModelTitle.Text + "', '" + txtActicationSemester.Text + "')", "\\127.0.0.1\HP_1020")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class