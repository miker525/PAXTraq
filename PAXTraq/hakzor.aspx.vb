Public Class hakzor
    Inherits System.Web.UI.Page
    Private ipx As String
    Private bowser As String
    'IP Address/Browser Information
    Public ReadOnly Property ipaddress() As [String]
        Get
            Return ipx
        End Get
    End Property ' So I can retrieve user IP via  ASPX

    Public ReadOnly Property userbrowser() As [String]
        Get
            Return bowser
        End Get
    End Property ' So I can retrieve user browser via ASPX
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ipx = HttpContext.Current.Request.UserHostAddress.ToString()
        bowser = HttpContext.Current.Request.Browser.Browser.ToString()
        'User gets ipaddress and browser information logged so it can be spit back at them
    End Sub

End Class