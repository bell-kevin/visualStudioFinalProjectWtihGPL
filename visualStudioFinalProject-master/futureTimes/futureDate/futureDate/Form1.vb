Public Class frmFutureDate
    Private Sub btnCalculateFutureDate_Click(sender As Object, e As EventArgs) Handles btnCalculateFutureDate.Click
        'variables
        Dim intHour, intDay, intMonth, intYear, intNumOfHours, intNumOfDays, intFuHours, intfuDays As Integer
        Dim blnCanCaluclate As Boolean = True
        'input
        'get the starting data for D, M, Y, and H
        'validate these variables - if any are invalid: display an
        'Error Message And do Not try to calculate the future date day And time
        intHour = nudHourStartDate.Value
        intDay = nudDayStartDate.Value
        intMonth = nudMonthStartDate.Value
        intYear = nudYearStartDate.Value
        intNumOfHours = nudNumOfHours.Value
        intNumOfDays = nudNumOfDays.Value
        'work
        'if the data is valid:
        'variables
        'array
        Dim monthEnds() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        monthEnds(1) = IsLeapYear(intYear)
        'work
        CheckInput(intDay, intMonth, monthEnds, blnCanCaluclate)
        intFuHours = intHour + intNumOfHours
        intfuDays = intDay + intNumOfDays
        'repetition
        While blnCanCaluclate
            Do
                'calculate the future hour
                If intFuHours > 24 Then
                    intFuHours = intFuHours - 24
                    intDay = intDay + 1
                End If
                'calculate the future date
                If intfuDays > monthEnds(intMonth - 1) Then
                    intfuDays = intfuDays - monthEnds(intMonth - 1)
                    intMonth = intMonth + 1
                End If
                If intMonth > 12 Then
                    intYear = intYear + 1
                    intMonth = 1
                    monthEnds(1) = IsLeapYear(intYear)
                    CheckInput(intDay, intMonth, monthEnds, blnCanCaluclate)
                End If
            Loop While intfuDays > monthEnds(intMonth - 1) And intFuHours > 24
            'output
            'display the future hour and the future date
            lblOutput.Text = intMonth & "/" & intfuDays & "/" & intYear & vbNewLine & "Hour: " & intFuHours
            If intfuDays <= monthEnds(intMonth - 1) And intFuHours <= 24 Then
                blnCanCaluclate = False
            End If
        End While
    End Sub
    Function IsLeapYear(ByVal Year As Integer) As Integer
        If Year Mod 4 = 0 Then
            Return 29
        Else
            Return 28
        End If
    End Function
    Sub CheckInput(ByVal dayInput As Integer, ByVal MonthInput As Integer, ByVal MonthEnd() As Integer, ByRef canCalc As Boolean)
        Dim blnCheckDay As Boolean
        If MonthInput > 12 Then
            MessageBox.Show("Can't do that. Start month needs to be lower")
            canCalc = False
            blnCheckDay = False
        Else
            canCalc = True
            blnCheckDay = True
        End If
        If blnCheckDay Then
            If dayInput > MonthEnd(MonthInput - 1) Then
                MessageBox.Show("Can't do that. Too many days for that month")
                canCalc = False
            Else
                canCalc = True
            End If
        End If
    End Sub
End Class