<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentEnrolment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStudentRegistration = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStudentEnrolment = New System.Windows.Forms.Button()
        Me.btnModuleRegistration = New System.Windows.Forms.Button()
        Me.btnModuleActivation = New System.Windows.Forms.Button()
        Me.cmbModelCodes = New System.Windows.Forms.ComboBox()
        Me.btnActivateModule = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentNr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.StudentNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModuleCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ActivationSemester = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 7
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
        'btnStudentEnrolment
        '
        Me.btnStudentEnrolment.Location = New System.Drawing.Point(606, 39)
        Me.btnStudentEnrolment.Name = "btnStudentEnrolment"
        Me.btnStudentEnrolment.Size = New System.Drawing.Size(148, 39)
        Me.btnStudentEnrolment.TabIndex = 4
        Me.btnStudentEnrolment.Text = "Student Enrolment"
        Me.btnStudentEnrolment.UseVisualStyleBackColor = True
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
        'cmbModelCodes
        '
        Me.cmbModelCodes.FormattingEnabled = True
        Me.cmbModelCodes.Location = New System.Drawing.Point(138, 157)
        Me.cmbModelCodes.Name = "cmbModelCodes"
        Me.cmbModelCodes.Size = New System.Drawing.Size(208, 21)
        Me.cmbModelCodes.TabIndex = 35
        '
        'btnActivateModule
        '
        Me.btnActivateModule.Location = New System.Drawing.Point(459, 138)
        Me.btnActivateModule.Name = "btnActivateModule"
        Me.btnActivateModule.Size = New System.Drawing.Size(208, 35)
        Me.btnActivateModule.TabIndex = 34
        Me.btnActivateModule.Text = "Enroll Student"
        Me.btnActivateModule.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Model code"
        '
        'txtStudentNr
        '
        Me.txtStudentNr.Location = New System.Drawing.Point(138, 131)
        Me.txtStudentNr.Name = "txtStudentNr"
        Me.txtStudentNr.Size = New System.Drawing.Size(208, 20)
        Me.txtStudentNr.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Student Number"
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.StudentNumber, Me.ModuleCode, Me.ActivationSemester})
        Me.lstView.Location = New System.Drawing.Point(28, 198)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(727, 351)
        Me.lstView.TabIndex = 38
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'StudentNumber
        '
        Me.StudentNumber.Text = "Student Number"
        Me.StudentNumber.Width = 193
        '
        'ModuleCode
        '
        Me.ModuleCode.Text = "Module Code"
        Me.ModuleCode.Width = 338
        '
        'ActivationSemester
        '
        Me.ActivationSemester.Text = "Activation Semester"
        Me.ActivationSemester.Width = 186
        '
        'frmStudentEnrolment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.txtStudentNr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbModelCodes)
        Me.Controls.Add(Me.btnActivateModule)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStudentEnrolment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Enrolment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnStudentRegistration As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStudentEnrolment As System.Windows.Forms.Button
    Friend WithEvents btnModuleRegistration As System.Windows.Forms.Button
    Friend WithEvents btnModuleActivation As System.Windows.Forms.Button
    Friend WithEvents cmbModelCodes As System.Windows.Forms.ComboBox
    Friend WithEvents btnActivateModule As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents StudentNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents ModuleCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ActivationSemester As System.Windows.Forms.ColumnHeader
End Class
