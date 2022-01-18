' *****************************************************************************
' Surname, Initials: ML, Zuze
' Student Number: 201477488
' Practical: P05
' Class name: cCrime
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class cCrime
    Private Shared Case_ID As Integer = 0 'Case ID
    Private Invest_Surname As String 'This is used to input the investigating officer's Surname
    Private Invest_Rank As String 'This is used to input the investigating officer's Rank
    Private ValofLoss As Double 'this is used to input the Value of loss

    Public Sub New() 'Constructor used to instantiate the attributes
        Case_ID = GenerateID()
        Invest_Surname = InputBox("What is the Surname of the Investigating Officer?", "Investigating Officer Surname")
        Invest_Rank = InputBox("What is the Rank of the Investigating Officer?", "Investigating Officer Rank")
        ValofLoss = CDbl(InputBox("What is the Value of Loss?", "Value of Loss"))
    End Sub

    'Properties

    Public ReadOnly Property CaseID() As Integer
        Get
            Return Case_ID
        End Get
    End Property

    Public Property InvestSurname As String
        Get
            Return Invest_Surname
        End Get
        Set(vSurname As String)
            Invest_Surname = vSurname
        End Set
    End Property

    Public Property InvestRank As String
        Get
            Return Invest_Rank
        End Get
        Set(vRank As String)
            Invest_Rank = vRank
        End Set
    End Property

    Public Property ValueOfLoss As Double
        Get
            Return ValofLoss
        End Get
        Set(value As Double)
            ValofLoss = value
        End Set
    End Property

    'Methods

    Public Function CalcOfficerSuccess() As Integer 'This returns a random value between 10 and 100.
        Return CInt(Math.Floor((100 - 10 + 1) * Rnd())) + 10
    End Function

    Public Overridable Function CalcSuccessFactor() As Double 'This is the Officer’s Success Rate
        Return CalcOfficerSuccess()
    End Function

    Public Function CalcRecovery() As Double 'This is the Success Factor as a percentage, multiplied with the Value of Loss
        Return (CalcSuccessFactor() / 100) * ValofLoss
    End Function
    Public Shared Function GenerateID() As Integer 'Generates a Crime ID
        If Case_ID = 0 Then
            Return 1
        Else : Return Case_ID + 1
        End If
    End Function
End Class
