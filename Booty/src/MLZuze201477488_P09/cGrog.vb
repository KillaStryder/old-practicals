' *****************************************************************************
' Surname, Initials: Zuze, ML
' Student Number: 201477488
' Practical: P09
' Class name:  cGrog
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class cGrog
    Inherits cGains
    Private AContent As Double 'Used to store the content of the grog

    Public Sub New(ByVal Nme As String, ByVal Cap As Double, ByVal Content As Double) 'Constructor
        MyBase.New(Nme, Cap)
        AContent = Content
    End Sub

    'Property

    Public Property Content As Double
        Get
            Return AContent
        End Get
        Set(vContent As Double)
            AContent = vContent
        End Set
    End Property

    Public Overrides Function Popularity() As Char 'Calculates the popularity of the Grog depending on the content
        Dim popular As Char
        Select Case AContent
            Case 50 To 70
                popular = CChar("B")
            Case 40 To 50
                popular = CChar("C")
            Case Is > 70
                popular = CChar("A")
        End Select
        Return popular
    End Function


    Public Overrides Function DisplayInfo() As String 'Display Roster
        Return MyBase.DisplayInfo() + vbCrLf + "Content: " + CStr(AContent) + "%" + vbCrLf
    End Function

End Class
