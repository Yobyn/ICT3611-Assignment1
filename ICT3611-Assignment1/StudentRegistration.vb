Imports System.IO
Imports System.Windows.Forms.ListView

Public Class frmStudentRegistration

    Public Const file As String = "D:/DB_ICT3611_Assg1_Students.txt"

    Private Sub btnModuleRegistration_Click(sender As Object, e As EventArgs) Handles btnModuleRegistration.Click
        Me.Visible = False
        frmModuleActivation.Visible = False
        frmStudentEnrolment.Visible = False
        frmModuleRegistration.Visible = True

    End Sub

    Private Sub btnModuleActivation_Click(sender As Object, e As EventArgs) Handles btnModuleActivation.Click
        Me.Visible = False
        frmModuleActivation.Visible = True
        frmStudentEnrolment.Visible = False
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnStudentRegistration_Click(sender As Object, e As EventArgs) Handles btnStudentRegistration.Click
        Me.Visible = True
        frmModuleActivation.Visible = False
        frmStudentEnrolment.Visible = False
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnStudentEnrolment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrolment.Click
        Me.Visible = False
        frmModuleActivation.Visible = False
        frmStudentEnrolment.Visible = True
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Computer.FileSystem.FileExists(file)) Then

            Dim reader As New StreamReader(file, False)

            Try
                Dim lstViewText(7) As String

                Dim line As String
                Dim pos As Integer

                Do
                    line = reader.ReadLine()
                    If line Is Nothing Then Exit Do

                    pos = 0
                    For Each item In line.Split(";")
                        lstViewText(pos) = item
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateStudent.Click

        Dim writer As StreamWriter
        writer = New StreamWriter(file, True)

        Dim studentNumber As String
        Dim oldStudentNumber As String

        If (lstView.Items.Count > 0) Then
            oldStudentNumber = lstView.Items(lstView.Items.Count - 1).SubItems(0).Text.ToString()
        Else
            oldStudentNumber = ""
        End If

        studentNumber = generateNewStudentNumber(oldStudentNumber)

        Dim lstViewText(7) As String
        lstViewText(0) = studentNumber
        lstViewText(1) = txtTitle.Text
        lstViewText(2) = txtInitials.Text
        lstViewText(3) = txtSurname.Text
        lstViewText(4) = txtAddress.Text
        lstViewText(5) = txtBirthDate.Text
        lstViewText(6) = txtGender.Text

        lstView.Items.Add(New ListViewItem(lstViewText))

        Try
            writer.WriteLine(studentNumber + ";" + txtTitle.Text + ";" + txtInitials.Text + ";" + txtSurname.Text + ";" + txtAddress.Text + ";" + txtBirthDate.Text + ";" + txtGender.Text)
        Catch ex As IOException
            MsgBox(ex.ToString)
        Finally
            writer.Close()
        End Try

    End Sub
End Class
