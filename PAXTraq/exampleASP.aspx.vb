Public Class exampleASP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Console.Write("WOOPIE")
    End Sub


    Protected Sub changeButton(ByVal sender As Object, ByVal e As System.EventArgs)
        button.Text = "I DID IT"
    End Sub
End Class