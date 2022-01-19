' *****************************************************************************
' Surname, Initials: Zuze, ML
' Student Number: 201477488
' Practical: P09
' Class name: cGains
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public MustInherit Class cGains
    Private aName As String 'Name of the alcohol
    Private BottleCapacity As Double 'Capacity of the alcohol

    Public Sub New(ByVal Nme As String, ByVal Capacity As Double) 'Constructor
        aName = Nme
        BottleCapacity = Capacity
    End Sub

    'Property

    Public Property Name As String
        Get
            Return aName
        End Get
        Set(VName As String)
            aName = VName
        End Set
    End Property

    Public Property Capacity As Double
        Get
            Return BottleCapacity
        End Get
        Set(vCapacity As Double)
            validate(vCapacity)
            BottleCapacity = vCapacity
        End Set
    End Property

    Protected Sub validate(Value As Double) 'Validation
        If Value <= 0 Then
            Value = 1
        End If
    End Sub

    Public MustOverride Function Popularity() As Char


    Public Overridable Function DisplayInfo() As String 'Display Roster
        Return "Bottle Name: " + Name + vbCrLf + "Bottle Capacity: " + CStr(BottleCapacity) + "l"
    End Function


End Class
