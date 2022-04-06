<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFutureDate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculateFutureDate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudHourStartDate = New System.Windows.Forms.NumericUpDown()
        Me.nudDayStartDate = New System.Windows.Forms.NumericUpDown()
        Me.nudMonthStartDate = New System.Windows.Forms.NumericUpDown()
        Me.nudYearStartDate = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.nudNumOfHours = New System.Windows.Forms.NumericUpDown()
        Me.nudNumOfDays = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudHourStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDayStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMonthStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYearStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumOfHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumOfDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculateFutureDate
        '
        Me.btnCalculateFutureDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCalculateFutureDate.Location = New System.Drawing.Point(12, 194)
        Me.btnCalculateFutureDate.Name = "btnCalculateFutureDate"
        Me.btnCalculateFutureDate.Size = New System.Drawing.Size(118, 23)
        Me.btnCalculateFutureDate.TabIndex = 1
        Me.btnCalculateFutureDate.Text = "Calculate Future Date"
        Me.btnCalculateFutureDate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter a future date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hour, military time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Month, 1 to 12"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Year, from 2000 to 2025"
        '
        'nudHourStartDate
        '
        Me.nudHourStartDate.Location = New System.Drawing.Point(27, 103)
        Me.nudHourStartDate.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudHourStartDate.Name = "nudHourStartDate"
        Me.nudHourStartDate.Size = New System.Drawing.Size(34, 20)
        Me.nudHourStartDate.TabIndex = 9
        '
        'nudDayStartDate
        '
        Me.nudDayStartDate.Location = New System.Drawing.Point(27, 77)
        Me.nudDayStartDate.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudDayStartDate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDayStartDate.Name = "nudDayStartDate"
        Me.nudDayStartDate.Size = New System.Drawing.Size(34, 20)
        Me.nudDayStartDate.TabIndex = 10
        Me.nudDayStartDate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudMonthStartDate
        '
        Me.nudMonthStartDate.Location = New System.Drawing.Point(27, 51)
        Me.nudMonthStartDate.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudMonthStartDate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMonthStartDate.Name = "nudMonthStartDate"
        Me.nudMonthStartDate.Size = New System.Drawing.Size(34, 20)
        Me.nudMonthStartDate.TabIndex = 11
        Me.nudMonthStartDate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudYearStartDate
        '
        Me.nudYearStartDate.Location = New System.Drawing.Point(12, 25)
        Me.nudYearStartDate.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.nudYearStartDate.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudYearStartDate.Name = "nudYearStartDate"
        Me.nudYearStartDate.Size = New System.Drawing.Size(49, 20)
        Me.nudYearStartDate.TabIndex = 12
        Me.nudYearStartDate.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Future Hour, 0 to 24 hours"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Future Day, 0 to 60 days"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(12, 220)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(186, 46)
        Me.lblOutput.TabIndex = 17
        '
        'nudNumOfHours
        '
        Me.nudNumOfHours.Location = New System.Drawing.Point(24, 168)
        Me.nudNumOfHours.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudNumOfHours.Name = "nudNumOfHours"
        Me.nudNumOfHours.Size = New System.Drawing.Size(37, 20)
        Me.nudNumOfHours.TabIndex = 18
        '
        'nudNumOfDays
        '
        Me.nudNumOfDays.Location = New System.Drawing.Point(24, 142)
        Me.nudNumOfDays.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudNumOfDays.Name = "nudNumOfDays"
        Me.nudNumOfDays.Size = New System.Drawing.Size(37, 20)
        Me.nudNumOfDays.TabIndex = 19
        '
        'frmFutureDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 273)
        Me.Controls.Add(Me.nudNumOfDays)
        Me.Controls.Add(Me.nudNumOfHours)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudYearStartDate)
        Me.Controls.Add(Me.nudMonthStartDate)
        Me.Controls.Add(Me.nudDayStartDate)
        Me.Controls.Add(Me.nudHourStartDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculateFutureDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFutureDate"
        Me.Text = "Date Calculator"
        CType(Me.nudHourStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDayStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMonthStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYearStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumOfHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumOfDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculateFutureDate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nudHourStartDate As NumericUpDown
    Friend WithEvents nudDayStartDate As NumericUpDown
    Friend WithEvents nudMonthStartDate As NumericUpDown
    Friend WithEvents nudYearStartDate As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateFutureDate.Click

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents nudNumOfHours As NumericUpDown
    Friend WithEvents nudNumOfDays As NumericUpDown
End Class
