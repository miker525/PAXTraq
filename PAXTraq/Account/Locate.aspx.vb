Imports System
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports Owin

Public Class Locate
    Inherits System.Web.UI.Page
    Public email As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strCurrentUserId As String = User.Identity.GetUserId()
        email = User.Identity.GetUserName()
    End Sub

End Class