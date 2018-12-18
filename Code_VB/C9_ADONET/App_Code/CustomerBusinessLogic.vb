Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Module CustomerBusinessLogic

    Public Sub UpdateCustomerInformation(ByVal customer As AdvWorksCustomer)
        Dim returnValue As Boolean = customer.Save()
        If returnValue = False Then
            Throw New ApplicationException("Unable to update customer")
        End If
    End Sub

    Public Function GetCustomer(ByVal custID As String) As AdvWorksCustomer
        Return New AdvWorksCustomer(custID)
    End Function

    Public Function GetAllCustomers() As ICollection
        Dim allCustomers As New ArrayList()
        Dim cmdAllCustomersString As String = "Select CustomerID from SalesLT.Customer"
        Dim connString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True"
        Dim dataSource As New SqlDataSource(connString, cmdAllCustomersString)

        Try
            ' select with no arguments
            Dim CustomerIDs As IEnumerable = dataSource.[Select](DataSourceSelectArguments.Empty)

            Dim enumerator As IEnumerator = CustomerIDs.GetEnumerator()
            While enumerator.MoveNext()
                Dim drv As DataRowView = TryCast(enumerator.Current, DataRowView)
                If drv IsNot Nothing Then
                    Dim customerID As String = drv("CustomerID").ToString()
                    Dim cust As New AdvWorksCustomer(customerID)
                    allCustomers.Add(cust)
                End If
            End While
        Finally
            dataSource.Dispose()
        End Try
        Return allCustomers
    End Function
End Module


Public Class AdvWorksCustomer
    Private customerID As Object
    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property
    Private _MiddleName As String
    Public Property MiddleName() As String
        Get
            Return _MiddleName
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property
    Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property
    Private _Suffix As String
    Public Property Suffix() As String
        Get
            Return _Suffix
        End Get
        Set(ByVal value As String)
            _Suffix = value
        End Set
    End Property
    Private _CompanyName As String
    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property
    Private _SalesPerson As String
    Public Property SalesPerson() As String
        Get
            Return _SalesPerson
        End Get
        Set(ByVal value As String)
            _SalesPerson = value
        End Set
    End Property
    Private _EmailAddress As String
    Public Property EmailAddress() As String
        Get
            Return _EmailAddress
        End Get
        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property
    Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
    Private _ModifiedDate As DateTime
    Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property
    Private _PasswordHash As String
    Public Property PasswordHash() As String
        Get
            Return _PasswordHash
        End Get
        Set(ByVal value As String)
            _PasswordHash = value
        End Set
    End Property
    Private _PasswordSalt As String
    Public Property PasswordSalt() As String
        Get
            Return _PasswordSalt
        End Get
        Set(ByVal value As String)
            _PasswordSalt = value
        End Set
    End Property

    Public Function Save() As Boolean
        Return True
    End Function

    ' default constructor
    Public Sub New()
        customerID = DBNull.Value
        FirstName = [String].Empty
        MiddleName = [String].Empty
        LastName = [String].Empty
        Suffix = [String].Empty
        CompanyName = [String].Empty
        SalesPerson = [String].Empty
        EmailAddress = [String].Empty
        Phone = [String].Empty
        PasswordHash = [String].Empty
        PasswordSalt = [String].Empty
        ModifiedDate = DateTime.MinValue
    End Sub

    ' Business object representing a Customer from the AdventureWorksLT database
    Public Sub New(ByVal customerID As String)
        Dim connString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True"

        Dim cmdString As New StringBuilder("Select FirstName, MiddleName, LastName, Suffix, ")
        cmdString.Append("CompanyName, SalesPerson, EmailAddress, Phone, ")
        cmdString.Append("PasswordHash, PasswordSalt, ModifiedDate ")
        cmdString.Append("from SalesLT.Customer ")
        cmdString.Append("where CustomerID = @customerID")

        ' Create connection and command objects 
        Dim conn As New SqlConnection(connString)
        Dim cmd As New SqlCommand(cmdString.ToString(), conn)
        cmd.Parameters.Add("@customerID", SqlDbType.VarChar).Value = customerID

        Try
            conn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr IsNot Nothing AndAlso dr.Read() Then
                FirstName = dr("FirstName").ToString()
                MiddleName = dr("MiddleName").ToString()
                LastName = dr("LastName").ToString()
                Suffix = dr("Suffix").ToString()
                CompanyName = dr("CompanyName").ToString()
                SalesPerson = dr("SalesPerson").ToString()
                EmailAddress = dr("EmailAddress").ToString()
                Phone = dr("Phone").ToString()
                PasswordHash = dr("PasswordHash").ToString()
                PasswordSalt = dr("PasswordSalt").ToString()
                ModifiedDate = Convert.ToDateTime(dr("ModifiedDate"))
            Else
                Throw New ApplicationException("Data not found for customer ID " & customerID)
            End If
            dr.Close()
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
End Class

