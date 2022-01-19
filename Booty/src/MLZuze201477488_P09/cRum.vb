' *****************************************************************************
' Surname, Initials: Zuze, ML
' Student Number: 201477488
' Practical: P09
' Class name: cRum
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class cRum
    Inherits cGains
    Private Vintage As Integer 'Used to store the year in which the rum was made
    Private RemainAmt As Double 'used to store the amount remaining in the bottle

    Public Sub New(ByVal Nme As String, ByVal Cap As Double, Vint As Integer, Remains As Double) 'Constructor
        MyBase.New(Nme, Cap)
        Vintage = Vint
        RemainAmt = Remains
    End Sub

    'Properties

    Public Property Vint As Integer
        Get
            Return Vintage
        End Get
        Set(vVintage As Integer)
            validate(vVintage)
            If vVintage > 2014 Then 'Validation
                vVintage = 2014
            End If
            Vintage = vVintage
        End Set
    End Property

    Public Property RemainingAmount As Double
        Get
            Return RemainAmt
        End Get
        Set(vRemains As Double)
            validate(vRemains) 'Validation
            RemainAmt = vRemains
        End Set
    End Property

    'Methods

    Public Overrides Function Popularity() As Char 'Calculates the popularity of the Rum depending on the remainAmt
        Select Case RemainAmt
            Case Is > 10
                Return CChar("B")
            Case Is >= 60
                Return CChar("C")
            Case Else
                Return CChar("A")
        End Select
    End Function

    Public Overrides Function DisplayInfo() As String 'Display Roster
        Return MyBase.DisplayInfo() + vbCrLf + "Vintage: " + CStr(Vintage) + vbCrLf + "Remaining Amount: " + CStr(RemainAmt) + "%" + vbCrLf + "Popularity: " + CStr(Popularity()) + vbCrLf
    End Function

End Class
