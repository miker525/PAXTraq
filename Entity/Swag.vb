'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Swag
    Public Property Id As Integer
    Public Property ParentID As String
    Public Property SwagYear As Long
    Public Property Company As String
    Public Property Game As String
    Public Property SwagType As String
    Public Property Method As String

    Public Overridable Property PAXes As ICollection(Of PAX) = New HashSet(Of PAX)

End Class