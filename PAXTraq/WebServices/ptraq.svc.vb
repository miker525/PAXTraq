Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports System.Web.Script.Serialization

<ServiceContract(Namespace:="")>
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class ptraq

    ' To use HTTP GET, add <WebGet()> attribute. (Default ResponseFormat is WebMessageFormat.Json)
    ' To create an operation that returns XML,
    '     add <WebGet(ResponseFormat:=WebMessageFormat.Xml)>,
    '     and include the following line in the operation body:
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"
    <OperationContract()>
    Public Function HelloWorld(ByVal name As String) As String
        Dim user As String = HttpContext.Current.User.Identity.Name
        Return String.Format("Hey there, {0}!", name)
    End Function

    Public Function GetPaxes() As String
        Dim busProduct As New BusinessLogic.PAXBus
        Dim products As List(Of Entity.PAX) = busProduct.GetAll()
        Dim js As New JavaScriptSerializer
        Return js.Serialize(products)
    End Function
    <OperationContract()>
    Public Function DoWork() As Integer
        Dim r As New Random()
        Dim numone As Integer = r.Next(0, 10000)
        Dim numtwo As Integer = r.Next(0, 10000)
        Dim answer As Integer = numone + numtwo
        Return answer
    End Function

    ' Add more operations here and mark them with <OperationContract()>

End Class
