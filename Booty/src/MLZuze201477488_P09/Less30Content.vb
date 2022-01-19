' *****************************************************************************
' Surname, Initials: Zuze, ML
' Student Number: 201477488
' Practical: P09
' Class name: Less30Content
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class Less30Content
    Inherits Exception
    'used to validate whether the grog content is less than 30
    Public Sub New()
        MyBase.New("The Number you have input does not Exist as a Content")
    End Sub
End Class
