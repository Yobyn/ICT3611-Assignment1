<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Surname As System.Windows.Forms.ColumnHeader
        Me.btnStudentRegistration = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModuleRegistration = New System.Windows.Forms.Button()
        Me.btnModuleActivation = New System.Windows.Forms.Button()
        Me.btnStudentEnrolment = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtInitials = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnCreateStudent = New System.Windows.Forms.Button()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.StudentNumber1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Intitials = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BirthDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Surname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStudentRegistration
        '
        Me.btnStudentRegistration.Location = New System.Drawing.Point(27, 39)
        Me.btnStudentRegistration.Name = "btnStudentRegistration"
        Me.btnStudentRegistration.Size = New System.Drawing.Size(148, 39)
        Me.btnStudentRegistration.TabIndex = 0
        Me.btnStudentRegistration.Text = "Student registration"
        Me.btnStudentRegistration.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Navigation:"
        '
        'btnModuleRegistration
        '
        Me.btnModuleRegistration.Location = New System.Drawing.Point(215, 39)
        Me.btnModuleRegistration.Name = "btnModuleRegistration"
        Me.btnModuleRegistration.Size = New System.Drawing.Size(148, 39)
        Me.btnModuleRegistration.TabIndex = 2
        Me.btnModuleRegistration.Text = "Module registration"
        Me.btnModuleRegistration.UseVisualStyleBackColor = True
        '
        'btnModuleActivation
        '
        Me.btnModuleActivation.Location = New System.Drawing.Point(411, 39)
        Me.btnModuleActivation.Name = "btnModuleActivation"
        Me.btnModuleActivation.Size = New System.Drawing.Size(148, 39)
        Me.btnModuleActivation.TabIndex = 3
        Me.btnModuleActivation.Text = "Module activation"
        Me.btnModuleActivation.UseVisualStyleBackColor = True
        '
        'btnStudentEnrolment
        '
        Me.btnStudentEnrolment.Location = New System.Drawing.Point(606, 39)
        Me.btnStudentEnrolment.Name = "btnStudentEnrolment"
        Me.btnStudentEnrolment.Size = New System.Drawing.Size(148, 39)
        Me.btnStudentEnrolment.TabIndex = 4
        Me.btnStudentEnrolment.Text = "Student Enrolment"
        Me.btnStudentEnrolment.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnStudentRegistration)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnStudentEnrolment)
        Me.Panel1.Controls.Add(Me.btnModuleRegistration)
        Me.Panel1.Controls.Add(Me.btnModuleActivation)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 109)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tilte"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Initials"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Birth date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Gender"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(141, 132)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(208, 20)
        Me.txtTitle.TabIndex = 12
        '
        'txtInitials
        '
        Me.txtInitials.Location = New System.Drawing.Point(141, 159)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(208, 20)
        Me.txtInitials.TabIndex = 13
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(141, 186)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(208, 20)
        Me.txtSurname.TabIndex = 14
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(141, 214)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(208, 20)
        Me.txtAddress.TabIndex = 15
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Location = New System.Drawing.Point(485, 129)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(208, 20)
        Me.txtBirthDate.TabIndex = 16
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(485, 158)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(208, 20)
        Me.txtGender.TabIndex = 17
        '
        'btnCreateStudent
        '
        Me.btnCreateStudent.Location = New System.Drawing.Point(485, 197)
        Me.btnCreateStudent.Name = "btnCreateStudent"
        Me.btnCreateStudent.Size = New System.Drawing.Size(208, 35)
        Me.btnCreateStudent.TabIndex = 18
        Me.btnCreateStudent.Text = "Create Student"
        Me.btnCreateStudent.UseVisualStyleBackColor = True
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.StudentNumber1, Me.Title, Me.Intitials, Surname, Me.Address, Me.BirthDate, Me.Gender})
        Me.lstView.Location = New System.Drawing.Point(28, 251)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(727, 298)
        Me.lstView.TabIndex = 19
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'StudentNumber1
        '
        Me.StudentNumber1.Text = "Student Number"
        Me.StudentNumber1.Width = 105
        '
        'Title
        '
        Me.Title.Text = "Title"
        '
        'Intitials
        '
        Me.Intitials.Text = "Intitials"
        Me.Intitials.Width = 69
        '
        'Surname
        '
        Surname.Text = "Surname"
        Surname.Width = 127
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 205
        '
        'BirthDate
        '
        Me.BirthDate.Text = "Birth Date"
        Me.BirthDate.Width = 95
        '
        'Gender
        '
        Me.Gender.Text = "Gender"
        '
        'frmStudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnCreateStudent)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtBirthDate)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtInitials)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStudentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStudentRegistration As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModuleRegistration As System.Windows.Forms.Button
    Friend WithEvents btnModuleActivation As System.Windows.Forms.Button
    Friend WithEvents btnStudentEnrolment As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtInitials As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthDate As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateStudent As System.Windows.Forms.Button
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents StudentNumber1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents Intitials As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents BirthDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gender As System.Windows.Forms.ColumnHeader

End Class
