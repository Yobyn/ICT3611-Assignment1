Imports System.IO
Imports System.Windows.Forms.ListView
Imports System.Data.SqlClient

Public Class frmStudentEnrolment
    'student_enrolment

    'Public Const activeModuleFile As String = "D:/DB_ICT3611_Assg1_Active_Modules.txt"
    'Public Const studentFile As String = "D:/DB_ICT3611_Assg1_Students.txt"
    'Public Const enrolstudentFile As String = "D:/DB_ICT3611_Assg1_Enrolled_Students_Modules.txt"

    Private Sub btnStudentRegistration_Click(sender As Object, e As EventArgs) Handles btnStudentRegistration.Click
        frmStudentRegistration.Visible = True
        frmModuleActivation.Visible = False
        Me.Visible = False
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnModuleRegistration_Click(sender As Object, e As EventArgs) Handles btnModuleRegistration.Click
        frmStudentRegistration.Visible = False
        frmModuleActivation.Visible = False
        Me.Visible = False
        frmModuleRegistration.Visible = True
    End Sub

    Private Sub btnModuleActivation_Click(sender As Object, e As EventArgs) Handles btnModuleActivation.Click
        frmStudentRegistration.Visible = False
        frmModuleActivation.Visible = True
        Me.Visible = False
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnStudentEnrolment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrolment.Click
        frmStudentRegistration.Visible = False
        frmModuleActivation.Visible = False
        Me.Visible = True
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnActivateModule_Click(sender As Object, e As EventArgs) Handles btnActivateModule.Click

        Dim studentExists As Boolean

        studentExists = False

        Dim conStr As String = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"
        Dim con As New SqlClient.SqlConnection(conStr)
        Try
            con.Open()
            Dim lstViewText(7) As String
            Dim sqlStr As String = "SELECT * FROM students"
            Dim comm As New SqlCommand(sqlStr, con)
            Dim rd As SqlDataReader = comm.ExecuteReader

            Do While rd.HasRows

                Do While rd.Read()
                    For num As Integer = 0 To (lstViewText.Length - 2)
                        lstViewText(num) = rd.GetString(num)
                    Next

                    If (txtStudentNr.Text = lstViewText(0)) Then
                        studentExists = True
                        Exit Do
                    End If

                    lstView.Items.Add(New ListViewItem(lstViewText))
                Loop

                rd.NextResult()
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

        If (studentExists) Then
            Try
                Dim lstViewText(3) As String
                lstViewText(0) = cmbModelCodes.SelectedItem.ToString
                lstViewText(1) = txtStudentNr.Text

                Dim entyExists As Boolean

                entyExists = False

                For Each item In lstView.Items
                    If (lstViewText(0) = item.SubItems(0).Text And lstViewText(1) = item.SubItems(1).Text) Then
                        entyExists = True
                    End If
                Next item

                If Not (entyExists) Then

                    lstView.Items.Add(New ListViewItem(lstViewText))

                    con = New SqlConnection
                    Dim inscmd As New SqlCommand
                    con.ConnectionString = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"

                    Try
                        con.Open()
                        inscmd.Connection = con
                        inscmd.CommandText = ("INSERT INTO student_enrolment(ID,MODULE_CODE,STUDENT_NR) VALUES('" + lstViewText(0) + "_" + lstViewText(1) + "', '" + lstViewText(0) + "', '" + lstViewText(1) + "')")
                        inscmd.ExecuteNonQuery()

                        MessageBox.Show("Inserted Successfully ")

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        con.Close()
                    End Try

                Else
                    MsgBox("Please note that Student already enrolled for " + lstViewText(0))
                End If

            Catch ex As NullReferenceException
                MsgBox("Please select a Module to Enroll For")
            End Try
        Else
            MsgBox("Please note that Student Number doesn't exist")
        End If

    End Sub

    Private Sub frmStudentEnrolment_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim conStr As String = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"
        Dim con As New SqlClient.SqlConnection(conStr)
        Try
            con.Open()
            Dim lstViewTextModule(3) As String
            Dim sqlStr As String = "SELECT * FROM active_modules"
            Dim comm As New SqlCommand(sqlStr, con)
            Dim rd As SqlDataReader = comm.ExecuteReader

            Do While rd.HasRows

                Do While rd.Read()
                    For num As Integer = 0 To (lstViewTextModule.Length - 2)
                        lstViewTextModule(num) = rd.GetString(num)
                    Next
                    cmbModelCodes.Items.Add(lstViewTextModule(0))
                Loop

                rd.NextResult()
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        Try
            con.Open()
            Dim lstViewText(2) As String
            Dim sqlStr As String = "SELECT * FROM student_enrolment"
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
    End Sub

End Class