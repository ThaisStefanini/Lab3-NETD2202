<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lbAverageEmployee3 = New System.Windows.Forms.Label()
        Me.tbUnitsEmployee3 = New System.Windows.Forms.TextBox()
        Me.lbEmployee3 = New System.Windows.Forms.Label()
        Me.lbAverageEmployee2 = New System.Windows.Forms.Label()
        Me.tbUnitsEmployee2 = New System.Windows.Forms.TextBox()
        Me.lbEmployee2 = New System.Windows.Forms.Label()
        Me.lbAverageTotal = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btEnter = New System.Windows.Forms.Button()
        Me.lbAverageEmployee1 = New System.Windows.Forms.Label()
        Me.tbUnitsEmployee1 = New System.Windows.Forms.TextBox()
        Me.tbUnitsInput = New System.Windows.Forms.TextBox()
        Me.lbEmployee1 = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbAverageEmployee3
        '
        Me.lbAverageEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageEmployee3.Location = New System.Drawing.Point(276, 231)
        Me.lbAverageEmployee3.Name = "lbAverageEmployee3"
        Me.lbAverageEmployee3.Size = New System.Drawing.Size(126, 23)
        Me.lbAverageEmployee3.TabIndex = 11
        Me.lbAverageEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbAverageEmployee3, "Average of units shipped by this employee per day.")
        '
        'tbUnitsEmployee3
        '
        Me.tbUnitsEmployee3.BackColor = System.Drawing.SystemColors.Window
        Me.tbUnitsEmployee3.Location = New System.Drawing.Point(276, 107)
        Me.tbUnitsEmployee3.Multiline = True
        Me.tbUnitsEmployee3.Name = "tbUnitsEmployee3"
        Me.tbUnitsEmployee3.ReadOnly = True
        Me.tbUnitsEmployee3.Size = New System.Drawing.Size(126, 120)
        Me.tbUnitsEmployee3.TabIndex = 10
        Me.ttToolTip.SetToolTip(Me.tbUnitsEmployee3, "All data inputted for this employee.")
        '
        'lbEmployee3
        '
        Me.lbEmployee3.Location = New System.Drawing.Point(276, 81)
        Me.lbEmployee3.Name = "lbEmployee3"
        Me.lbEmployee3.Size = New System.Drawing.Size(126, 23)
        Me.lbEmployee3.TabIndex = 9
        Me.lbEmployee3.Text = "Employee 3"
        Me.lbEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbEmployee3, "Employee 3")
        '
        'lbAverageEmployee2
        '
        Me.lbAverageEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageEmployee2.Location = New System.Drawing.Point(144, 231)
        Me.lbAverageEmployee2.Name = "lbAverageEmployee2"
        Me.lbAverageEmployee2.Size = New System.Drawing.Size(126, 23)
        Me.lbAverageEmployee2.TabIndex = 8
        Me.lbAverageEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbAverageEmployee2, "Average of units shipped by this employee per day.")
        '
        'tbUnitsEmployee2
        '
        Me.tbUnitsEmployee2.BackColor = System.Drawing.SystemColors.Window
        Me.tbUnitsEmployee2.Location = New System.Drawing.Point(144, 107)
        Me.tbUnitsEmployee2.Multiline = True
        Me.tbUnitsEmployee2.Name = "tbUnitsEmployee2"
        Me.tbUnitsEmployee2.ReadOnly = True
        Me.tbUnitsEmployee2.Size = New System.Drawing.Size(126, 120)
        Me.tbUnitsEmployee2.TabIndex = 7
        Me.ttToolTip.SetToolTip(Me.tbUnitsEmployee2, "All data inputted for this employee.")
        '
        'lbEmployee2
        '
        Me.lbEmployee2.Location = New System.Drawing.Point(144, 81)
        Me.lbEmployee2.Name = "lbEmployee2"
        Me.lbEmployee2.Size = New System.Drawing.Size(126, 23)
        Me.lbEmployee2.TabIndex = 6
        Me.lbEmployee2.Text = "Employee 2"
        Me.lbEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbEmployee2, "Employee 2")
        '
        'lbAverageTotal
        '
        Me.lbAverageTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageTotal.Location = New System.Drawing.Point(12, 258)
        Me.lbAverageTotal.Name = "lbAverageTotal"
        Me.lbAverageTotal.Size = New System.Drawing.Size(390, 23)
        Me.lbAverageTotal.TabIndex = 12
        Me.lbAverageTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbAverageTotal, "Average of units shipped by all employees per day.")
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(279, 285)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(123, 42)
        Me.btExit.TabIndex = 15
        Me.btExit.Text = "E&xit"
        Me.ttToolTip.SetToolTip(Me.btExit, "End application.")
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btReset.Location = New System.Drawing.Point(144, 285)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(126, 42)
        Me.btReset.TabIndex = 14
        Me.btReset.Text = "&Reset"
        Me.ttToolTip.SetToolTip(Me.btReset, "Clear all data in the screen.")
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btEnter
        '
        Me.btEnter.Location = New System.Drawing.Point(12, 285)
        Me.btEnter.Name = "btEnter"
        Me.btEnter.Size = New System.Drawing.Size(126, 42)
        Me.btEnter.TabIndex = 13
        Me.btEnter.Text = "&Enter"
        Me.ttToolTip.SetToolTip(Me.btEnter, "Add number of units for this employee in this day.")
        Me.btEnter.UseVisualStyleBackColor = True
        '
        'lbAverageEmployee1
        '
        Me.lbAverageEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageEmployee1.Location = New System.Drawing.Point(12, 231)
        Me.lbAverageEmployee1.Name = "lbAverageEmployee1"
        Me.lbAverageEmployee1.Size = New System.Drawing.Size(126, 23)
        Me.lbAverageEmployee1.TabIndex = 5
        Me.lbAverageEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbAverageEmployee1, "Average of units shipped by this employee per day.")
        '
        'tbUnitsEmployee1
        '
        Me.tbUnitsEmployee1.BackColor = System.Drawing.SystemColors.Window
        Me.tbUnitsEmployee1.Location = New System.Drawing.Point(12, 107)
        Me.tbUnitsEmployee1.Multiline = True
        Me.tbUnitsEmployee1.Name = "tbUnitsEmployee1"
        Me.tbUnitsEmployee1.ReadOnly = True
        Me.tbUnitsEmployee1.Size = New System.Drawing.Size(126, 120)
        Me.tbUnitsEmployee1.TabIndex = 4
        Me.ttToolTip.SetToolTip(Me.tbUnitsEmployee1, "All data inputted for this employee.")
        '
        'tbUnitsInput
        '
        Me.tbUnitsInput.Location = New System.Drawing.Point(61, 48)
        Me.tbUnitsInput.Name = "tbUnitsInput"
        Me.tbUnitsInput.Size = New System.Drawing.Size(100, 22)
        Me.tbUnitsInput.TabIndex = 2
        Me.ttToolTip.SetToolTip(Me.tbUnitsInput, "Number of Units shipped by this employee in this day.")
        '
        'lbEmployee1
        '
        Me.lbEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmployee1.Location = New System.Drawing.Point(12, 81)
        Me.lbEmployee1.Name = "lbEmployee1"
        Me.lbEmployee1.Size = New System.Drawing.Size(126, 23)
        Me.lbEmployee1.TabIndex = 3
        Me.lbEmployee1.Text = "Employee 1"
        Me.lbEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbEmployee1, "Employee 1")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(9, 48)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(43, 23)
        Me.lbUnits.TabIndex = 1
        Me.lbUnits.Text = "&Units: "
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDay
        '
        Me.lbDay.Location = New System.Drawing.Point(9, 9)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(50, 23)
        Me.lbDay.TabIndex = 0
        Me.lbDay.Text = "Day 1"
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToolTip.SetToolTip(Me.lbDay, "Number of the day related to Input data")
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btReset
        Me.ClientSize = New System.Drawing.Size(420, 339)
        Me.Controls.Add(Me.lbAverageEmployee3)
        Me.Controls.Add(Me.tbUnitsEmployee3)
        Me.Controls.Add(Me.lbEmployee3)
        Me.Controls.Add(Me.lbAverageEmployee2)
        Me.Controls.Add(Me.tbUnitsEmployee2)
        Me.Controls.Add(Me.lbEmployee2)
        Me.Controls.Add(Me.lbAverageTotal)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btEnter)
        Me.Controls.Add(Me.lbAverageEmployee1)
        Me.Controls.Add(Me.tbUnitsEmployee1)
        Me.Controls.Add(Me.tbUnitsInput)
        Me.Controls.Add(Me.lbEmployee1)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbAverageEmployee3 As Label
    Friend WithEvents tbUnitsEmployee3 As TextBox
    Friend WithEvents lbEmployee3 As Label
    Friend WithEvents lbAverageEmployee2 As Label
    Friend WithEvents tbUnitsEmployee2 As TextBox
    Friend WithEvents lbEmployee2 As Label
    Friend WithEvents lbAverageTotal As Label
    Friend WithEvents btExit As Button
    Friend WithEvents btReset As Button
    Friend WithEvents btEnter As Button
    Friend WithEvents lbAverageEmployee1 As Label
    Friend WithEvents tbUnitsEmployee1 As TextBox
    Friend WithEvents tbUnitsInput As TextBox
    Friend WithEvents lbEmployee1 As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents ttToolTip As ToolTip
End Class
