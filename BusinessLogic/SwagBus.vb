Imports Entity

Public Class SwagBus
    'Get All function to return a List of PAX events
    Public Function GetAll() As List(Of Swag)
        Dim swags As New List(Of Swag)
        Dim Wolfenbag As New Swag()
        Dim OrderShirt As New Swag()
        'Fillin that list up with some fake data
        Wolfenbag.Id = 1
        OrderShirt.Id = 2
        Wolfenbag.Company = "Bethesda"
        Wolfenbag.Game = "Wolfenstein"
        Wolfenbag.Method = "Neumond Record Group Party"
        Wolfenbag.SwagType = "Bags"
        Wolfenbag.SwagYear = 2014
        OrderShirt.Company = "Sony"
        OrderShirt.Game = "The Order 1886"
        OrderShirt.SwagType = "Shirts"
        OrderShirt.SwagYear = 2014
        OrderShirt.Method = "Sony Booth"
        swags.Add(Wolfenbag)
        swags.Add(OrderShirt)
        'Printin that list to console and then returning the list
        Dim swarg As New Entity.Swag()
        For Each swarg In swags
            Console.Write(swarg.Company + " gave away " + swarg.SwagType + " at " + swarg.Method + " for their upcoming game " + swarg.Game)
        Next
        Return swags
    End Function

End Class
