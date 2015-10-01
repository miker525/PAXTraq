Public Class About
    Inherits Page
    Public Function GenRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        'Random Number Generation function
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    'number variables to be used in the verification. Two numbers which will need to be added.
    Dim numone As Integer
    Dim numtwo As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'PRE POSTBACK
            resetHumanVer()
            paner.Visible = True
            sent.Visible = False
        Else
            If Integer.Parse(Human.Value) = Integer.Parse(Session("humanver")) Then
                'If the verification number was correct proceed
                paner.Visible = False
                subbutt.Visible = False
                sent.Visible = True
                Fname.Value = Convert.ToString(Session("name"))
                Email.Value = Convert.ToString(Session("email"))
                Subject.Value = ""
                Message.Value = ""
                Human.Value = ""
            Else
                'If verification was not correct reset verification and ask again
                resetHumanVer()
            End If
        End If
        
    End Sub

    Public Sub resetHumanVer()
        'Resets human verification number
        numone = GenRandom(100, 999)
        numtwo = GenRandom(1, 5)
        Humanlbl.InnerText = "Human Verification: What is " + numone.ToString + " + " + numtwo.ToString
        Session("humanver") = numone + numtwo
    End Sub
    'The code below is for testing right now please ignore
    '
    '
    Public Sub submit()
 
    End Sub

    Private Sub subbutt_Click(sender As Object, e As EventArgs) Handles subbutt.Click
        Session("name") = "poopfudge"

        'Session.Add("name", Fname.Value.ToString())
        Session.Add("email", Email.Value.ToString())
        Session.Add("subject", Subject.Value.ToString())
        Session.Add("message", Message.Value.ToString())

    End Sub
End Class