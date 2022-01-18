' *****************************************************************************
' Surname, Initials: ML, Zuze
' Student Number: 201477488
' Practical: P05
' Class name: FrmCCU
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class FrmCCU
    Private Fencing As cFencing 'Of type cFencing in order to instantiate a new Fencing Class
    Private Fraud As cFraud 'Of type cFraud in order to instantiate a new Fraud Class
    Private Laundering As cLaundering 'Of type cLaundering in order to instantiate a new Laundering Class
    Private Rows As Integer = 0 'Used to increase the amount of Rows everytime a crime is created

    Private Sub ResizeGrd(ByVal Row As Integer) 'used to resize grid
        GrdDisplay.Rows = Rows + 1
    End Sub
    Private Sub DispInGrd(ByVal Row As Integer, ByVal Col As Integer, ByVal txt As String) 'In order to display information in the grid
        GrdDisplay.Col = Col
        GrdDisplay.Row = Row
        GrdDisplay.Text = txt
    End Sub
    Private Sub btnFencing_Click(sender As Object, e As EventArgs) Handles btnFencing.Click
        Dim Mobility As Integer = CInt(InputBox("What is the Mobility of the Goods (Enter Value between 1 and 10)?", "Mobility of Goods")) 'Prompt for the mobility of Goods
        Rows += 1
        ResizeGrd(Rows) 'resize grid
        Fencing = New cFencing(Mobility) 'Instantiates a new Fencing Crime
        DispInGrd(Rows, 0, CStr(Fencing.CaseID))
        DispInGrd(Rows, 1, Fencing.InvestRank + ": " + Fencing.InvestSurname)
        DispInGrd(Rows, 2, "R" + CStr(Math.Round(Fencing.ValueOfLoss, 2)))
        DispInGrd(Rows, 3, CStr(Fencing.CalcOfficerSuccess))
        DispInGrd(Rows, 4, CStr(Fencing.CalcRecovery))
    End Sub

    Private Sub btnFraud_Click(sender As Object, e As EventArgs) Handles btnFraud.Click
        Dim Days As Integer = CInt(InputBox("How many Days has it been Since Crime took Place?", "Days Since Crime")) 'Prompt for the number of days since crime happened
        Rows += 1
        ResizeGrd(Rows)
        Fraud = New cFraud(Days)
        DispInGrd(Rows, 0, CStr(Fraud.CaseID))
        DispInGrd(Rows, 1, Fraud.InvestRank + ": " + Fraud.InvestSurname)
        DispInGrd(Rows, 2, "R" + CStr(Math.Round(Fraud.ValueOfLoss, 2)))
        DispInGrd(Rows, 3, CStr(Fraud.CalcOfficerSuccess))
        DispInGrd(Rows, 4, CStr(Fraud.CalcRecovery))
    End Sub

    Private Sub btnLaundering_Click(sender As Object, e As EventArgs) Handles btnLaundering.Click
        Dim Currencies As Integer = CInt(InputBox("How Many Currencies were involved in the Laundering?", "Number of Different Currencies")) 'Prompt for the number of currencies involved
        Dim Accounts As Integer = CInt(InputBox("How many Accounts were involved?", "Number of Accounts")) 'Prompt for the number of accounts involved
        Laundering = New cLaundering(Currencies, Accounts)
        Rows += 1
        ResizeGrd(Rows) 'Resize grid
        DispInGrd(Rows, 0, CStr(Laundering.CaseID))
        DispInGrd(Rows, 1, Laundering.InvestRank + ": " + Laundering.InvestSurname)
        DispInGrd(Rows, 2, "R" + CStr(Math.Round(Fraud.ValueOfLoss, 2)))
        DispInGrd(Rows, 3, CStr(Laundering.CalcOfficerSuccess))
        DispInGrd(Rows, 4, CStr(Laundering.CalcRecovery))
    End Sub

    Private Sub FrmCCU_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'used to add headings to grid
        DispInGrd(0, 0, "Case ID")
        DispInGrd(0, 1, "Rank and Surname of Investigating Officer")
        DispInGrd(0, 2, "Value of Loss")
        DispInGrd(0, 3, "Success Rate of the Officer")
        DispInGrd(0, 4, "Value Recovered")
    End Sub
End Class
