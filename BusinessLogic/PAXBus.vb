Imports Entity
Public Class PAXBus
    'Get All function to return a List of PAX events
    Public Function GetAll() As List(Of PAX)
        'Spoof data below, information about PAX East and PAX Prime
        Dim paxes As New List(Of PAX)
        Dim paxEast As New PAX()
        paxEast.Id = 1
        paxEast.Location = "BCEC"
        Dim dt As DateTime = Convert.ToDateTime("4/12/2014")
        paxEast.Year = dt.Year
        paxEast.Type = "East"
        Dim paxPrime As New PAX()
        paxPrime.Id = 2
        paxPrime.Type = "Prime"
        paxPrime.Location = "WSCC"
        dt = Convert.ToDateTime("8/22/2014")
        paxPrime.Year = dt.Year
        'Adding our spoof data to our current List of PAX's
        paxes.Add(paxEast)
        paxes.Add(paxPrime)
        'Filtering through the PAX events in our PAX database to the console + returning the list
        Dim parx As New PAX()
        For Each parx In paxes
            Console.Write("PAX " + parx.Type + " " + parx.Year.ToString)
        Next
        Return paxes
    End Function


End Class
