' *****************************************************************************
' Surname, Initials: ML, Zuze
' Student Number: 201477488
' Practical: P05
' Class name: cFraud
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class cFraud
    Inherits cCrime 'used to inherit all the properties, methods and constructor from the base class
    Private DaysSinceCrime As Integer 'Used to input the number of days since the crime

    Public Sub New(ByVal Days As Integer) 'constructor used to instantiate attribute
        DaysSinceCrime = Days
    End Sub

    'Property

    Public Property SinceCrime As Integer
        Get
            Return DaysSinceCrime
        End Get
        Set(vDays As Integer)
            If vDays < 0 Then 'Validation 
                vDays = 0
            End If
            DaysSinceCrime = vDays
        End Set
    End Property

    'Methods

    Public Overrides Function CalcSuccessFactor() As Double 'overrides the base function and This is the Officer’s Success Rate, divided by the number of days since the crime took place.
        Return MyBase.CalcSuccessFactor() / DaysSinceCrime
    End Function
End Class
