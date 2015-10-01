Public Class DefaultErr
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Status = "500 Not Found"
        Response.StatusCode = 500

        Response.TrySkipIisCustomErrors = True
    End Sub

End Class