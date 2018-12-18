Imports System

Public Module StringExt

    <System.Runtime.CompilerServices.Extension()> _
    Public Function PrefixWith(ByVal someString As String, ByVal prefixString As String) As String
        Return prefixString + someString
    End Function
End Module

