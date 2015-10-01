Imports System.Xml
Imports System.DateTime
Public Class futurepax
    Inherits System.Web.UI.Page
    'Storing the dates of the events to create a count down
    Dim primeDate As Date = CDate("8/28/2015")
    Dim eastDate As Date = CDate("3/5/2015")
    Dim southDate As Date = CDate("1/23/2015")
    Dim ausDate As Date = CDate("10/30/2015")
    Dim dateArray() As Date
    Dim dayArray() As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Determining how many days until the next PAX event based off the current date of users computer
        Dim start As Date = Now.ToShortDateString()
        Dim ts As TimeSpan = eastDate.Subtract(start)
        Eastd.Text = Convert.ToInt32(ts.Days).ToString + " Days Left Until PAX East!"
        ts = southDate.Subtract(start)
        Southd.Text = Convert.ToInt32(ts.Days).ToString + " Days Left Until PAX South!"
        ts = ausDate.Subtract(start)
        Ausd.Text = Convert.ToInt32(ts.Days).ToString + " Days Left Until PAX Australia!"
        ts = primeDate.Subtract(start)
        Primed.Text = Convert.ToInt32(ts.Days).ToString + " Days Left Until PAX Prime!"
        'Primed.Text = "N/A Days Left Until PAX Prime!"

    End Sub

    Public Sub loadDates()

    End Sub


End Class