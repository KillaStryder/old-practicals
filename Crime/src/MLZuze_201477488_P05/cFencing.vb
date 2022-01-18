' *****************************************************************************
' Surname, Initials: ML, Zuze
' Student Number: 201477488
' Practical: P05
' Class name: cFencing
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class cFencing
    Inherits cCrime 'used to inherit all the properties, methods and constructor from the base class
    Private MobilityofGoods As Integer 'used to input a value of the mobility of goodsa from 1 to 10

    Public Sub New(ByVal Mobility As Integer) 'constructor used to instantiate attribute
        MobilityofGoods = Mobility
    End Sub

    'Property

    Public Property Mobility As Integer
        Get
            Return MobilityofGoods
        End Get
        Set(vMobility As Integer)
            If vMobility > 10 Then 'Validation
                vMobility = 10
            ElseIf vMobility < 1 Then
                vMobility = 1
            End If
            MobilityofGoods = vMobility
        End Set
    End Property

    'Method

    Public Overrides Function CalcSuccessFactor() As Double 'overrides the base function and This is the Officer’s Success Rate, minus the mobility of the Goods.
        Return MyBase.CalcSuccessFactor() - MobilityofGoods
    End Function
End Class
