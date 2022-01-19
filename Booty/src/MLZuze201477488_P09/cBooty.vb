' *****************************************************************************
' Surname, Initials: Zuze, ML
' Student Number: 201477488
' Practical: P09
' Class name: cBooty
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class cBooty
    Private Name As String 'Name of the booty
    Private Value As Double 'Value of booty in gold

    Public Sub New(ByVal Nme As String, ByVal val As Double) 'Constructor
        Name = Nme
        Value = val
    End Sub

    'Property

    Public Property BootyName As String
        Get
            Return Name
        End Get
        Set(vName As String)
            Name = vName
        End Set
    End Property

    Public Property Val As Double
        Get
            Return Value
        End Get
        Set(vValue As Double)
            If vValue <= 0.0 Then  'Validation
                Value = 0.1
            End If
            Value = vValue
        End Set
    End Property

    'Methods

    Public Function GoldtoSilverConverter(ByVal exRate As Double) As Double 'converts the value of booty to gold
        Return exRate * Value
    End Function

    Public Function DisplayInfo() As String 'Display Roster
        Return "Name: " + Name + vbCrLf + "Value of Booty (Gold Coins): " + CStr(Value) + vbCrLf
    End Function

End Class
