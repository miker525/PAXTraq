Imports Entity
Imports BusinessLogic
Public Class swags
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Creating a SWAG Bus and a list of Swag
        Dim swaggers As New BusinessLogic.SwagBus()
        Dim swags As List(Of Entity.Swag)
        'Pull the fake data from SwagBus into our list
        swags = swaggers.GetAll()
        For Each Swag In swags
            'Pump fake data into a combolist
            DropDownList1.Items.Add(Swag.Game)
        Next
        'Do that process again but for PAX instead of swag
        Dim paxers As New BusinessLogic.PAXBus()
        Dim paxs As List(Of Entity.PAX)
        paxs = paxers.GetAll()
        For Each PAX In paxs
            DropDownList2.Items.Add(PAX.Type + " " + PAX.Year.ToString)
        Next
        'Sit back and relax...
    End Sub

End Class