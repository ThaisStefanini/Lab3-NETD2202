Option Strict On
''' Name:   AverageUnitsShippedByEmployee
''' Author: Thais Stefanini
''' Date:   04 March 2018
''' Description:
'''         A form that accept units shipped per day per employee. The user must input 
'''         whole numbers and it will calculate the average after 7 inputs for each employee,
'''         Allowing the user to input the units shipped for the next employee.
'''         After acepting the 7 days of units shipped for all 3 employees, the program calculate
'''         the overall average, for all days and all employees.
'''         The user can input another set of numbers after clearing the screen.
'''
''' References:
'''     To change the font of a label to Bold (because "label.Font.Bold" is ReadOnly): 
'''     https://msdn.microsoft.com/en-us/library/system.drawing.font.bold(v=vs.110).aspx

Public Class frmAverageUnitsShippedByEmployee

    '=========================================
    ' Declarations
    '=========================================
    Private Const lastIndexDays As Integer = 6   ' Indicate 7 days 
    Private Const lastIndexEmployees As Integer = 2  ' Indicate 3 employees
    Private counterDay As Integer = 0           ' Count the number of days inputted per employee
    Private counterEmployee As Integer = 0      ' Count the employee that the user is inputting data

    ' Declaration Array to save the Units of all employees
    Private arrayUnitsShipped(lastIndexDays, lastIndexEmployees) As Integer

    '=========================================
    ' Functions and Events
    '=========================================

    ''' <summary>
    ''' Change the Label Day and the labels Employee on the screen
    ''' </summary>
    ''' <param name="day"></param>
    ''' <param name="employee"></param>
    Private Sub UpdateScreen(ByVal day As Integer, ByVal employee As Integer)
        ' Change the value of the label Day
        lbDay.Text = "Day " & day + 1

        ' Change the label of the Employee to Bold (see References), and others to Regular
        If employee = 0 Then ' Employee 1
            lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Bold)
            lbEmployee2.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
            lbEmployee3.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
        End If
        If employee = 1 Then ' Employee 2
            lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
            lbEmployee2.Font = New Font(lbEmployee1.Font, FontStyle.Bold)
            lbEmployee3.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
        End If
        If employee = 2 Then ' Employee 3
            lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
            lbEmployee2.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
            lbEmployee3.Font = New Font(lbEmployee1.Font, FontStyle.Bold)
        End If

    End Sub

    ''' <summary>
    ''' Output the Units history in the correct textbox on the screen
    ''' </summary>
    ''' <param name="unitsPerEmployee"></param>
    Private Sub Output(ByVal unitsPerEmployee As String)
        ' Display the data from the 2D array in the correct textbox
        If counterEmployee = 0 Then ' Employee 1
            tbUnitsEmployee1.Text = unitsPerEmployee
        End If
        If counterEmployee = 1 Then ' Employee 2
            tbUnitsEmployee2.Text = unitsPerEmployee
        End If
        If counterEmployee = 2 Then ' Employee 3
            tbUnitsEmployee3.Text = unitsPerEmployee
        End If
    End Sub

    ''' <summary>
    ''' Output the result in the correct label on the screen
    ''' </summary>
    ''' <param name="averageUnits"></param>
    Private Sub Output(ByVal averageUnits As Double)
        ' Display the data from the average in the correct label
        If counterEmployee = 0 Then ' Employee 1
            lbAverageEmployee1.Text = "Average: " & averageUnits.ToString("n2")
        End If
        If counterEmployee = 1 Then ' Employee 2
            lbAverageEmployee2.Text = "Average: " & averageUnits.ToString("n2")
        End If
        If counterEmployee = 2 Then ' Employee 3
            lbAverageEmployee3.Text = "Average: " & averageUnits.ToString("n2")
        End If
    End Sub

    ''' <summary>
    ''' Output the final result in the correct label on the screen
    ''' </summary>
    ''' <param name="averageUnits"></param>
    ''' <param name="isFinal"></param>
    Private Sub Output(ByVal averageUnits As Double, ByVal isFinal As Boolean)
        ' Display the data from the overall average in the correct label
        lbAverageTotal.Text = "Average: " & averageUnits.ToString("n2")
    End Sub

    ''' <summary>
    ''' Validate the input, check if is a whole number and if it is in the range.
    ''' Will output if the input is valid.
    ''' The input value as Integer and error message will return as ByRef parameters
    ''' </summary>
    ''' <param name="inputString"></param>
    ''' <param name="inputInteger"></param>
    ''' <param name="errorMessage"></param>
    ''' <returns></returns>
    Private Function ValidInput(ByVal inputString As String, ByRef inputInteger As Integer, ByRef errorMessage As String) As Boolean
        '=========================================
        ' Constants and Variables
        '=========================================
        Const minimumUnits As Integer = 0
        Const maximunUnits As Integer = 1000

        Dim inputDouble As Double = 0.0          ' Holds the user input if it converts to a Double
        Dim isValid As Boolean = False           ' To check if the input is valid

        '=========================================
        ' Validation
        '=========================================
        If (Double.TryParse(inputString, inputDouble)) Then ' Check if the input is a number
            If (Integer.TryParse(inputString, inputInteger)) Then ' Check if the input is an Integer
                If (inputInteger >= minimumUnits AndAlso inputInteger <= maximunUnits) Then ' Check the range
                    isValid = True      ' Set this input as valid, to avoid the error message
                Else    ' From range check
                    errorMessage = "Units shipped must be a whole number with a minimum value 
                                    of " & minimumUnits.ToString() & " and a maximum value of " &
                                    maximunUnits.ToString() & "."
                End If    ' From range check
            Else    ' From TryParse to Integer
                errorMessage = "Units shipped must be a whole number."
            End If    ' From TryParse to Integer
        Else    ' From TryParse to Double
            errorMessage = "Units shipped must be numeric."
        End If    ' From TryParse to Double

        '=========================================
        ' Return
        '=========================================
        ' Return if the input is valid or not, the input value and error message are already editted.
        Return isValid
    End Function


    ''' <summary>
    ''' Validate and accept units inputted by user per employee. 
    ''' After all days inputs are valid, it calculates de average for this employee and move to the next one.
    ''' After all days are inputed for all employess, it calculates the overall average units shipped.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btEnter_Click(sender As Object, e As EventArgs) Handles btEnter.Click
        '=========================================
        ' Variables
        '=========================================
        Dim inputUnitsString As String = String.Empty ' Holds the user input as a string
        Dim inputUnitsInteger As Integer = 0          ' Holds the user input as a Integer after validation
        Dim isValid As Boolean = False                ' To check if the input is valid

        Dim unitsPerEmployee As String = String.Empty     ' Holds the value to print in textbox of each employee
        Dim errorMessage As String = String.Empty     ' Error message that will be displayed

        Dim sumUnits As Integer = 0                   ' Sum of units in the array
        Dim averageUnits As Double = 0.0              ' Average result for units

        '=========================================
        ' Input and Validation
        '=========================================
        inputUnitsString = tbUnitsInput.Text  ' Get the input from the Units textbox

        ' Call a Function to validate the Input
        ' inputUnitsString is the input of the user
        ' inputUnitsInteger is the input of user if valid, 0 if not valid
        ' errorMessage has the eror message if input not valid, empty if valid
        isValid = ValidInput(inputUnitsString, inputUnitsInteger, errorMessage)

        If (isValid) Then   ' Add the input in the 2D array if valid
            arrayUnitsShipped(counterDay, counterEmployee) = inputUnitsInteger ' Add user input in the array

            tbUnitsInput.Text = String.Empty     ' Clear the textbox, so the user can input the next value

            counterDay += 1     ' Change the day counter after a valid input

            ' Change the labels Day and Employees
            If counterDay > lastIndexDays + 1 Then
                ' So the Label will not show the Day grater than lastIndexDays + 1
                UpdateScreen(counterDay - 1, counterEmployee)
            Else
                UpdateScreen(counterDay, counterEmployee)
            End If


        Else        ' If input not valid, display error message
            MessageBox.Show(errorMessage, "Error")

            ' Set focus to the Units textbox and selects its text
            tbUnitsInput.Focus()
            tbUnitsInput.SelectionStart = 0
            tbUnitsInput.SelectionLength = tbUnitsInput.Text.Length
        End If

        '=========================================
        ' Process and Output
        '=========================================

        ' Concatenate units in the 2D array
        For index As Integer = 0 To counterDay - 1 ' counterDay must be decreased for this output, because it was already incresed after the valid input
            unitsPerEmployee += arrayUnitsShipped(index, counterEmployee).ToString() & vbCrLf
        Next index

        ' Output history of units shipped for this employee
        Output(unitsPerEmployee)

        If (counterDay = lastIndexDays + 1) Then     ' Check if all days was inputted already
            ' Sum all units in the array
            For counter As Integer = 0 To lastIndexDays
                sumUnits += arrayUnitsShipped(counter, counterEmployee)
            Next counter

            ' Calculate average per employee
            averageUnits = sumUnits / (lastIndexDays + 1)

            ' Output average per Employee
            Output(averageUnits)

            If (counterEmployee = lastIndexEmployees) Then ' Check if all employes was inputted already
                For counterRow As Integer = 0 To lastIndexDays
                    For counterColumn As Integer = 0 To lastIndexEmployees
                        sumUnits += arrayUnitsShipped(counterRow, counterColumn)
                    Next counterColumn
                Next counterRow

                averageUnits = sumUnits / ((lastIndexDays + 1) + (lastIndexEmployees + 1))

                ' Output final Average
                Output(averageUnits, True)

                ' Disable the button Enter and the Units textbox, to stop the inputting of data
                btEnter.Enabled = False
                tbUnitsInput.ReadOnly = True
                ' Set the focus on the Reset button
                btReset.Focus()

            Else    ' If it is not the last employee
                counterEmployee += 1    ' Move to next employee
                counterDay = 0          ' Reset the day counter
                UpdateScreen(counterDay, counterEmployee)   ' Change the labels Day and Employees
            End If
        End If

    End Sub

    ''' <summary>
    ''' Clear all texts in the screen, and clear all global variables (counters and arrays)
    ''' </summary>
    Private Sub resetForm()
        ' Clear all texts in the screen
        tbUnitsInput.Text = String.Empty
        tbUnitsEmployee1.Text = String.Empty
        tbUnitsEmployee2.Text = String.Empty
        tbUnitsEmployee3.Text = String.Empty
        lbAverageEmployee1.Text = String.Empty
        lbAverageEmployee2.Text = String.Empty
        lbAverageEmployee3.Text = String.Empty

        btEnter.Enabled = True     ' Enable button Enter, if disable
        tbUnitsInput.ReadOnly = False    ' Allow the user to type in this textbox, if disable
        tbUnitsInput.Focus()             ' Set focus to the Units textbox
        counterDay = 0              ' Reset the number of days counter
        counterEmployee = 0         ' Reset the employee counter

        UpdateScreen(counterDay, counterEmployee)   ' Change the labels Day and Employees

        ' Clear the 2D arrayUnitsShipped(Days, Employees)
        For counterRow As Integer = 0 To lastIndexDays
            For counterColumn As Integer = 0 To lastIndexEmployees
                arrayUnitsShipped(counterRow, counterColumn) = 0
            Next counterColumn
        Next counterRow

    End Sub

    ''' <summary>
    ''' Clear the screen.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        resetForm()
    End Sub

    ''' <summary>
    ''' End the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Close()
    End Sub

End Class
