Imports Microsoft.VisualBasic
Imports System.Data

Public Class Customer
    Private _CustomerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Integer)
            _CustomerID = value
        End Set
    End Property
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _City As String
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property

    Public Sub New()
    End Sub

    ''' <summary>
    ''' Gets Customers and returns them in DataSet
    ''' </summary>
    Public Function GetCustomers() As DataSet
        ' Add logic here for actual retrieval of data from DB

        Dim ds As New DataSet()

        Dim dt As New DataTable("Customers")
        dt.Columns.Add("CustomerId", GetType(Integer))
        dt.Columns.Add("CustomerName", GetType(String))
        dt.Columns.Add("CustomerCity", GetType(String))

        dt.Rows.Add(New Object() {1, "Test Customer", "Glasgow"})

        ds.Tables.Add(dt)
        Return ds
    End Function

    'Public Function GetCustomer(ByVal CustomerId As Integer) As DataSet
    '    Return New DataSet()
    'End Function

    'Public Function AddCustomer(ByVal c As Customer) As Integer
    '    Return 0
    'End Function

    'Public Function UpdateCustomer(ByVal c As Customer) As Boolean
    '    Return False
    'End Function

End Class

