Imports System.IO
Imports System.Windows.Forms.ListView
Imports System.Data.SqlClient

Public Class frmModuleActivation

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


        Dim conStr As String = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"
        Dim con As New SqlClient.SqlConnection(conStr)
        Try
            con.Open()
            Dim lstViewTextModule(3) As String
            Dim sqlStr As String = "SELECT * FROM modules"
            Dim comm As New SqlCommand(sqlStr, con)
            Dim rd As SqlDataReader = comm.ExecuteReader

            Do While rd.HasRows

                Do While rd.Read()
                    For num As Integer = 0 To (lstViewTextModule.Length - 2)
                        lstViewTextModule(num) = rd.GetString(num)
                    Next

                    cmbModelCodes.Items.Add(New ListViewItem(lstViewTextModule))
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
            Dim lstViewText(3) As String
            Dim sqlStr As String = "SELECT * FROM active_modules"
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

    Private Sub btnActivateModule_Click_1(sender As Object, e As EventArgs) Handles btnActivateModule.Click

        Try

            Dim moduleActivated As Boolean

            moduleActivated = False



            For Each item In lstView.Items
                If (item.SubItems(0).Text = cmbModelCodes.SelectedItem.ToString) Then
                    moduleActivated = True
                End If
            Next


            If Not (moduleActivated) Then

                Dim con As New SqlConnection
                Dim inscmd As New SqlCommand
                con.ConnectionString = "Data Source=(local);Initial Catalog=ict_3611;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False"

                Try
                    con.Open()
                    inscmd.Connection = con
                    inscmd.CommandText = ("INSERT INTO active_modules(CODE,TITLE,ACTIVE_SEMESTER) VALUES('" + cmbModelCodes.SelectedItem.SubItems(0).Text + "', '" + cmbModelCodes.SelectedItem.SubItems(1).Text + "', '" + cmbModelCodes.SelectedItem.SubItems(2).Text + "')")
                    inscmd.ExecuteNonQuery()

                  
                    lstView.Items.Add(cmbModelCodes.SelectedItem)

                    MessageBox.Show(cmbModelCodes.SelectedItem.SubItems(0).Text + " - Activated Successfully")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MsgBox("Module Already activated for " + Date.Today.Year.ToString)

            End If
        Catch ex As NullReferenceException
            MsgBox("Please select a Module to Activate")
        End Try
    End Sub
End Class