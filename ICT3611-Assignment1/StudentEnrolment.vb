Imports System.IO
Imports System.Windows.Forms.ListView

Public Class frmStudentEnrolment

    Public Const activeModuleFile As String = "D:/DB_ICT3611_Assg1_Active_Modules.txt"
    Public Const studentFile As String = "D:/DB_ICT3611_Assg1_Students.txt"
    Public Const enrolstudentFile As String = "D:/DB_ICT3611_Assg1_Enrolled_Students_Modules.txt"

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

        If (My.Computer.FileSystem.FileExists(studentFile)) Then

            Dim reader As New StreamReader(studentFile, False)

            Try
                Do
                    Dim lstViewText(7) As String

                    Dim line As String
                    Dim pos As Integer

                    line = reader.ReadLine()
                    If line Is Nothing Then Exit Do

                    pos = 0
                    For Each item In line.Split(";")
                        lstViewText(pos) = item.ToString
                        pos += 1
                    Next

                    If (txtStudentNr.Text = lstViewText(0)) Then
                        studentExists = True
                        Exit Do
                    End If

                Loop

            Catch ex As IOException
                MsgBox(ex.ToString)
            Finally
                reader.Close()
            End Try

        End If

        If (studentExists) Then
            Try
                Dim writer As StreamWriter
                writer = New StreamWriter(enrolstudentFile, True)

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
                    Try
                        writer.WriteLine(lstViewText(0) + ";" + lstViewText(1))
                    Catch ex As IOException
                        MsgBox(ex.ToString)
                    Finally
                        writer.Close()
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

        If (My.Computer.FileSystem.FileExists(activeModuleFile)) Then

            Dim reader As New StreamReader(activeModuleFile, False)

            Try
                Do
                    Dim lstViewText(4) As String

                    Dim line As String
                    Dim pos As Integer

                    line = reader.ReadLine()
                    If line Is Nothing Then Exit Do

                    pos = 0
                    For Each item In line.Split(";")
                        lstViewText(pos) = item.ToString
                        pos += 1
                    Next

                    cmbModelCodes.Items.Add(lstViewText(0))

                Loop

            Catch ex As IOException
                MsgBox(ex.ToString)
            Finally
                reader.Close()
            End Try

        End If

        If (My.Computer.FileSystem.FileExists(enrolstudentFile)) Then

            Dim reader As New StreamReader(enrolstudentFile, False)

            Try
                Do
                    Dim lstViewText(2) As String

                    Dim line As String
                    Dim pos As Integer

                    line = reader.ReadLine()
                    If line Is Nothing Then Exit Do

                    pos = 0
                    For Each item In line.Split(";")
                        lstViewText(pos) = item.ToString
                        pos += 1
                    Next

                    lstView.Items.Add(New ListViewItem(lstViewText))

                Loop

            Catch ex As IOException
                MsgBox(ex.ToString)
            Finally
                reader.Close()
            End Try

        End If

    End Sub

End Class