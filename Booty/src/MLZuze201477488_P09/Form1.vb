' *****************************************************************************
' Surname, Initials: Zuze, ML
' Student Number: 201477488
' Practical: P09
' Class name: frmCaptain
' *****************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmCaptain
    Private Grog() As cGrog 'used to create new grog object
    Private Rum() As cRum 'used to create new Rum object
    Private Booty() As cBooty 'used to create new Booty object
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private ExRate As Double
    Private tot As Double


    Private Sub MsRum_Click(sender As Object, e As EventArgs) Handles MsRum.Click
        rtbDisplay.Text += "Rum Information: " + vbCrLf + vbCrLf
        Dim iloop As Integer
        Dim Name As String
        Dim Capacity As Double
        Dim Remains As Double
        Dim numRum As Integer
        Dim Vintage As Integer
        Dim counter1 As Integer
        FS = New FileStream("Rum.IFM", FileMode.Create, FileAccess.Write) 'Creating a new file to write to
        BF = New BinaryFormatter
        Try
            numRum = CInt(InputBox("How many bottles of Rum did the Captain Gain?", "Grog Amount"))
        Catch
            Dim ex As Exception
            MsgBox("You have entered an Invalid value value, Please try again")
            numRum = CInt(InputBox("How many bottles of Rum did the Captain Gain?", "Grog Amount"))
        End Try
        ReDim Rum(numRum)
        For iloop = 1 To numRum
            Name = InputBox("What is the Name of the Rum", "Rum Name")
            Try
                Capacity = CDbl(InputBox("What is the Capacity of the bottle?", "Bottle Capacity"))
                Vintage = CInt(InputBox("Which Year was this Rum Produced?", "Vintage"))
                Remains = CInt(InputBox("How much is Remaining in the bottle" + vbCrLf + "Enter Percenatge", "Amount Remaining"))
            Catch
                Dim ex As Exception
                MsgBox("You have entered an Invalid value value, Please try again")
                Capacity = CDbl(InputBox("What is the Capacity of the bottle (in Letres)?", "Bottle Capacity"))
                Vintage = CInt(InputBox("Which Year was this Rum Produced?", "Vintage"))
                Remains = CInt(InputBox("How much is Remaining in the bottle (in Letres)" + vbCrLf + "Enter Percenatge", "Amount Remaining"))
            End Try
            Rum(iloop) = New cRum(Name, Capacity, Vintage, Remains)
            BF.Serialize(FS, Rum(iloop)) 'converting to binary
            rtbDisplay.Text += Rum(iloop).DisplayInfo + vbCrLf 'Display roster
            If Rum(iloop).Popularity = "A" Then
                counter1 += 1
            End If
        Next
        rtbDisplay.Text += "Number of A-rated Rum: " + CStr(counter1) + vbCrLf
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub MSGrog_Click(sender As Object, e As EventArgs) Handles MSGrog.Click
        rtbDisplay.Text += "Grog Information: " + vbCrLf + vbCrLf
        Dim iloop As Integer
        Dim Name As String
        Dim Capacity As Double
        Dim Content As Double
        Dim numgrog As Integer
        Dim counter As Integer
        FS = New FileStream("Grog.IFM", FileMode.Create, FileAccess.Write) 'Creating a new file to write to
        BF = New BinaryFormatter
        Try
            numgrog = CInt(InputBox("How many bottles of Grog did the Captain Gain?", "Grog Amount"))
        Catch
            Dim ex As Exception
            MsgBox("You have entered an Invalid value value, Please try again")
            numgrog = CInt(InputBox("How many bottles of Grog did the Captain Gain?", "Grog Amount"))
        End Try
        ReDim Grog(numgrog)
        For iloop = 1 To numgrog
            Name = InputBox("What is the Name of the Grog", "Grog Name")
            Try
                Capacity = CDbl(InputBox("What is the Capacity of the bottle (in Letres)?", "Bottle Capacity"))
            Catch
                Dim ex As Exception
                MsgBox("You have entered an Invalid value value, Please try again")
                Capacity = CDbl(InputBox("What is the Capacity of the bottle (in Letres)?", "Bottle Capacity"))
            End Try
            Try
                Content = CDbl(InputBox("What is the Alcohol Content?", "Alcohol Content"))
                If Content <= 30 Then Throw New Less30Content()
            Catch

                Dim ex As Less30Content
                MsgBox("You have input an invalid value, try again")
                Content = CDbl(InputBox("What is the Alcohol Content Percentage?", "Alcohol Content"))
            End Try
            Grog(iloop) = New cGrog(Name, Capacity, Content)
            BF.Serialize(FS, Grog(iloop)) 'converting to binary
            rtbDisplay.Text += Grog(iloop).DisplayInfo + vbCrLf 'Display roster
            If Grog(iloop).Popularity = "C" Then
                counter += 1
            End If
        Next iloop
        rtbDisplay.Text += "Number of C-rated Grog: " + CStr(counter) + vbCrLf
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub MSBooty_Click(sender As Object, e As EventArgs) Handles MSBooty.Click
        rtbDisplay.Text += "Booty Information: " + vbCrLf + vbCrLf
        Dim iloop As Integer
        Dim Name As String
        Dim Value As Double
        Dim numBooty As Integer
        FS = New FileStream("Booty.IFM", FileMode.Create, FileAccess.Write) 'Creating a new file to write to
        BF = New BinaryFormatter
        Try
            numBooty = CInt(InputBox("How much Booty did the Captain Gain?", "Booty Amount"))
            ExRate = CDbl(InputBox("What is the exchage rate from Gold to Silver", "Booty Amount"))
        Catch
            Dim ex As Exception
            MsgBox("You have entered an Invalid value value, Please try again")

            numBooty = CInt(InputBox("How much Booty did the Captain Gain?", "Booty Amount"))
            ExRate = CDbl(InputBox("What is the exchage rate from Gold to Silver", "Exchange Rate"))
        End Try
        ReDim Booty(numBooty)
        For iloop = 1 To numBooty
            Name = InputBox("What is the Name of the Booty", "Booty Name")
            Value = CDbl(InputBox("What is the Value of the Booty (in Gold Coins)?", "Booty Value"))
            Booty(iloop) = New cBooty(Name, Value)
            BF.Serialize(FS, Booty) 'converting to binary
            rtbDisplay.Text += Booty(iloop).DisplayInfo + vbCrLf 'Display roster
            tot += Booty(iloop).GoldtoSilverConverter(ExRate)
        Next iloop
        rtbDisplay.Text += "Total value of Booty in silver: " + CStr(tot) + vbCrLf
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub MsopenBooty_Click(sender As Object, e As EventArgs) Handles MsopenBooty.Click
        rtbDisplay.Text += "Booty Information From File : " + vbCrLf + vbCrLf
        Dim tot As Double = 0
        FS = New FileStream("Booty.IFM", FileMode.Open, FileAccess.Read) 'Opening the file
        BF = New BinaryFormatter
        While FS.Position < FS.Length
            Dim TempBooty As cBooty
            TempBooty = CType(BF.Deserialize(FS), cBooty) 'Converting to booty type
            rtbDisplay.Text += TempBooty.DisplayInfo + vbCrLf
            tot += TempBooty.GoldtoSilverConverter(ExRate)
        End While
        rtbDisplay.Text += "Total value of Booty in silver: " + CStr(tot) + vbCrLf
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub MsOpenGrog_Click(sender As Object, e As EventArgs) Handles MsOpenGrog.Click
        rtbDisplay.Text += "Grog Information From File: " + vbCrLf + vbCrLf
        FS = New FileStream("Grog.IFM", FileMode.Open, FileAccess.Read) 'Opening the file
        BF = New BinaryFormatter
        Dim counter As Integer
        While FS.Position < FS.Length
            Dim TempGrog As cGrog
            TempGrog = CType(BF.Deserialize(FS), cGrog) 'Converting to Grog type
            rtbDisplay.Text += TempGrog.DisplayInfo + vbCrLf
            If TempGrog.Popularity = "C" Then
                counter += 1
            End If
        End While
        rtbDisplay.Text += "Number of C-rated Grog: " + CStr(counter) + vbCrLf
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub MSOpenRum_Click(sender As Object, e As EventArgs) Handles MSOpenRum.Click
        rtbDisplay.Text += "Rum Information From File: " + vbCrLf + vbCrLf
        Dim counter1 As Integer
        FS = New FileStream("Rum.IFM", FileMode.Open, FileAccess.Read) 'Opening the file
        BF = New BinaryFormatter
        While FS.Position < FS.Length
            Dim TempRum As cRum
            TempRum = CType(BF.Deserialize(FS), cRum) 'Converting to rum type
            rtbDisplay.Text += TempRum.DisplayInfo + vbCrLf
            If TempRum.Popularity = "A" Then
                counter1 += 1
            End If
        End While
        rtbDisplay.Text += "Number of A-rated Rum: " + CStr(counter1) + vbCrLf
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub
End Class
