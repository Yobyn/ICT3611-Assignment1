Imports System.IO
Imports System.Windows.Forms.ListView

Public Class frmModuleActivation

    Public Const moduleFile As String = "D:/DB_ICT3611_Assg1_Modules.txt"
    Public Const activeModuleFile As String = "D:/DB_ICT3611_Assg1_Active_Modules.txt"

    Private Sub btnModuleRegistration_Click(sender As Object, e As EventArgs) Handles btnModuleRegistration.Click
        frmStudentRegistration.Visible = False
        Me.Visible = False
        frmStudentEnrolment.Visible = False
        frmModuleRegistration.Visible = True

    End Sub

    Private Sub btnStudentRegistration_Click(sender As Object, e As EventArgs) Handles btnStudentRegistration.Click
        frmStudentRegistration.Visible = True
        Me.Visible = False
        frmStudentEnrolment.Visible = False
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnModuleActivation_Click(sender As Object, e As EventArgs) Handles btnModuleActivation.Click
        frmStudentRegistration.Visible = False
        Me.Visible = True
        frmStudentEnrolment.Visible = False
        frmModuleRegistration.Visible = False
    End Sub

    Private Sub btnStudentEnrolment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrolment.Click
        frmStudentRegistration.Visible = False
        Me.Visible = False
        frmStudentEnrolment.Visible = True
        frmModuleRegistration.Visible = False
    End Sub



    Private Sub frmStudentEnrolment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Computer.FileSystem.FileExists(moduleFile)) Then

            Dim reader As New StreamReader(moduleFile, False)

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


        If (My.Computer.FileSystem.FileExists(activeModuleFile)) Then

            Dim reader As New StreamReader(activeModuleFile, False)

            Try
                Do
                    Dim lstViewText(3) As String

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

    Private Sub btnActivateModule_Click_1(sender As Object, e As EventArgs) Handles btnActivateModule.Click

        Try
            If (My.Computer.FileSystem.FileExists(moduleFile)) Then

                Dim reader As New StreamReader(moduleFile, False)
                Try
                    Do
                        Dim lstViewText(3) As String

                        Dim line As String
                        Dim pos As Integer

                        line = reader.ReadLine()
                        If line Is Nothing Then Exit Do

                        pos = 0
                        For Each item In line.Split(";")
                            lstViewText(pos) = item.ToString
                            pos += 1
                        Next

                        Dim moduleActivated As Boolean

                        moduleActivated = False

                        For Each item In lstView.Items
                            If (item.SubItems(0).Text = cmbModelCodes.SelectedItem.ToString) Then
                                moduleActivated = True
                            End If
                        Next

                        If Not (moduleActivated) Then
                            If (lstViewText(0) = cmbModelCodes.SelectedItem.ToString) Then
                                lstView.Items.Add(New ListViewItem(lstViewText))

                                Dim writer As StreamWriter
                                writer = New StreamWriter(activeModuleFile, True)

                                Try
                                    writer.WriteLine(lstViewText(0) + ";" + lstViewText(1) + ";" + lstViewText(2))
                                Catch ex As IOException
                                    MsgBox(ex.ToString)
                                Finally
                                    writer.Close()
                                End Try

                                Exit Do
                            End If
                        Else
                            MsgBox("Module Already activated for " + Date.Today.Year.ToString)
                            Exit Do
                        End If

                    Loop

                Catch ex As IOException
                    MsgBox(ex.ToString)
                Finally
                    reader.Close()
                End Try

            End If

        Catch ex As NullReferenceException
            MsgBox("Please select a Module to Activate")
        End Try
    End Sub
End Class