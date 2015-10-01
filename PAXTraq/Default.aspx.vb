Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '        Dim PAXES As New List(Of Entity.PAX)
        '       Using grossButthole As New Entity.ADOModelContainer
        'Dim queryButthole As IQueryable(Of Entity.PAX) = From p In grossButthole.PAXes Select p
        'PAXES = queryButthole.ToList()
        'End Using

        If Not Page.IsPostBack Then
            refresh()
            pane.Visible = False
        Else
            refresh()
        End If


    End Sub
    Public Sub refresh()
        lToday.Text = ""
        llToday.Text = ""
        lTomorrow.Text = ""
        lToday.Text = "Today's Date is: " + Now.ToShortDateString()
        llToday.Text = "Today is: " + Now.ToLongDateString()
        lTomorrow.Text = "Tomorrow is: " + Now.AddDays(1)
    End Sub
    Public Sub calfunc()
        callbl.Text = Calendar.SelectedDate.ToString
    End Sub

    Public Sub radiofunc()
        Dim item As ListItem
        For Each item In rdiolst.Items
            If item.Selected Then
                rdiolbl.Text = "You Selected " + item.Text
            End If
        Next
    End Sub

    Public Sub paneclk()
        If pane.Visible = True Then
            pane.Visible = False
            panebutton.Text = "Show"
        Else
            pane.Visible = True
            panebutton.Text = "Hide"
        End If
    End Sub

End Class