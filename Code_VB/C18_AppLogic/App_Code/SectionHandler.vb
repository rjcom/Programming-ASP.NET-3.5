Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml

Public Class DataSetSectionHandler
    Implements IConfigurationSectionHandler

    Public Function Create(ByVal parent As Object, ByVal configContext As Object, ByVal section As System.Xml.XmlNode) As Object Implements System.Configuration.IConfigurationSectionHandler.Create

        Dim strSql As String
        strSql = section.Attributes.Item(0).Value
        Dim connectionString As String = "server=(local)\sql2k5;Integrated Security=true;database=AdventureWorksLT"

        ' create the data set command object and the DataSet 
        Dim da As New SqlDataAdapter(strSql, connectionString)
        Dim dsData As New DataSet()

        ' fill the data set object 
        da.Fill(dsData, "Customers")
        Return dsData

    End Function

End Class