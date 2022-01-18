' *****************************************************************************
' Surname, Initials: ML, Zuze
' Student Number: 201477488
' Practical: P05
' Class name: cLaundering
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class cLaundering
    Inherits cCrime 'used to inherit all the properties, methods and constructor from the base class
    Private NumDiffCurrencies As Integer 'used to input and display the number of different currencies involved
    Private NumAccInvolved As Integer 'used to input and display the number of different accounts involved

    Public Sub New(ByVal Currencies As Integer, ByVal Accounts As Integer) 'constructor used to instantiate the attributes
        NumDiffCurrencies = Currencies
        NumAccInvolved = Accounts
    End Sub

    'Properties

    Public Property DiffCurrencies As Integer
        Get
            Return NumDiffCurrencies
        End Get
        Set(vCurrencies As Integer)
            If vCurrencies < 1 Then 'Validation
                vCurrencies = 1
            End If
            NumDiffCurrencies = vCurrencies
        End Set
    End Property

    Public Property AccInvolved As Integer
        Get
            Return NumAccInvolved
        End Get
        Set(vAccounts As Integer)
            If vAccounts < 1 Then 'Validation
                vAccounts = 1
            End If
            NumAccInvolved = vAccounts
        End Set
    End Property

    'Method

    Public Overrides Function CalcSuccessFactor() As Double 'overrides the base function and This is the number of different currencies involved, divided by the number of accountants involved, plus the Officer’s Success Rate.
        Return MyBase.CalcSuccessFactor() + (NumDiffCurrencies / NumAccInvolved)
    End Function
End Class
