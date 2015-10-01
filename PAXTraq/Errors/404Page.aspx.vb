Public Class _404Page
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Status = "404 Not Found"
        Response.StatusCode = 404

        Response.TrySkipIisCustomErrors = True
    End Sub

End Class