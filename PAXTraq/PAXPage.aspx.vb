Imports System.IO
Imports Elmah

Public Class PAXPage
    Inherits System.Web.UI.Page
    Private imgurl As String 'image url to load based on event
    Private PAXEvent As Char ' e=east, a=aus, p=prime, s=south - To be used for functions like image loading, etc. at a later point
    Private swagger As New List(Of Entity.Swag)
    Private yearly As Integer ' Year of the event that we will use
    Public ReadOnly Property iurl() As [String]
        Get
            Return imgurl
        End Get
    End Property ' So I can retrieve image url via  ASPX

    Public ReadOnly Property getSwag() As List(Of Entity.Swag)
        Get
            Return swagger
        End Get
    End Property 'So I can retrieve swag listing via ASPX

    Public ReadOnly Property year() As Integer
        Get
            Return yearly
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' CODE BLOCK FOR DATA LOADING
        Dim paxz As New List(Of Entity.PAX)
        Dim swagger As New List(Of Entity.Swag)
        Using myEntities As New Entity.ADOModelContainer
            Dim paxquery As IQueryable(Of Entity.PAX) = From p In myEntities.PAXes Select p
            paxz = paxquery.ToList()
            Dim swagquery As IQueryable(Of Entity.Swag) = From p In myEntities.Swags Select p
            swagger = swagquery.ToList()
        End Using 'LINQ Query to get PAX Events
        For Each Swag In swagger
            'Pump fake data igto a combolist
            DropDownListSwag.Items.Add(Swag.Game)
        Next

        'CODE BLOCK FOR IMAGE LOADING
        Dim str As String
        str = Request.QueryString("event")
        If (str = "east") Then
            imgurl = "images/content/palogos/paxeastlogo.png"
            PAXEvent = "e"
        ElseIf (str = "prime") Then
            imgurl = "images/content/palogos/paxprimelogo.png"
            PAXEvent = "p"
        ElseIf (str = "south") Then
            imgurl = "images/content/palogos/paxsouthlogo.png"
            PAXEvent = "s"
        ElseIf (str = "aus") Then
            imgurl = "images/content/palogos/paxauslogo.png"
            PAXEvent = "a"
        Else
            Response.Redirect("hakzor.aspx") ' Redirects user if caught modifying data
        End If
        ' A nice block of code designed to receive variables from page params to get which pax
        ' Then set the logo accordingly OR detect if someone's been messing with the params

        'Code to load the maps into the site area.
        Dim filesindirectory As String() = Directory.GetFiles(Server.MapPath("~/images/content/paxmaps/" + PAXEvent.ToString()))
        Dim images As List(Of [String]) = New List(Of String)(filesindirectory.Count())
        For Each item As String In filesindirectory
            images.Add([String].Format("~/images/content/paxmaps/" + PAXEvent.ToString() + "/{0}", System.IO.Path.GetFileName(item)))
        Next
        RepeaterImages.DataSource = images
        RepeaterImages.DataBind()

        ' EXHIBITORS:
        ' Functions similar to above. Reads Exhibitors from a text file.
        ' Lexing was planned but unfortunately not incorporated. Text file was originally to supprt url's and the site would automatically understand
        ' Yeah yeah databases could do the same but BLEH I did it this way for super quick updates.
        Try
            Dim OpenPath As String = Server.MapPath("~/data/" + PAXEvent.ToString() + "/exhibitors.txt")
            Dim finfo As FileInfo = New FileInfo(OpenPath)
            Dim Lines() As String = IO.File.ReadAllLines(OpenPath)
            Dim exhibitors As List(Of [String]) = New List(Of String)(finfo.Length)
            For Each f As String In Lines
                exhibitors.Add(f.ToString())
            Next
            RepeaterExhibitors.DataSource = exhibitors
            RepeaterExhibitors.DataBind()
        Catch ex As Exception
            ErrorSignal.FromCurrentContext().Raise(ex)
        End Try
        'CONCERTS
        'Same exact system as above, line for line with variable changes except this is for concert acts.
        Try
            Dim COpenPath As String = Server.MapPath("~/data/" + PAXEvent.ToString() + "/concerts.txt")
            Dim finfoConcerts As FileInfo = New FileInfo(COpenPath)
            Dim Lines2() As String = IO.File.ReadAllLines(COpenPath)
            Dim concerts As List(Of [String]) = New List(Of String)(finfoConcerts.Length)
            For Each f As String In Lines2
                concerts.Add(f.ToString())
            Next
            RepeaterConcerts.DataSource = concerts
            RepeaterConcerts.DataBind()
        Catch ex As Exception
            ErrorSignal.FromCurrentContext().Raise(ex)
        End Try


    End Sub

End Class