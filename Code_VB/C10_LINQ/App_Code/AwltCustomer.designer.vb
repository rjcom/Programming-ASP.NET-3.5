﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="AdventureWorksLT")>  _
Partial Public Class AwltCustomerDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCustomer(instance As Customer)
    End Sub
  Partial Private Sub UpdateCustomer(instance As Customer)
    End Sub
  Partial Private Sub DeleteCustomer(instance As Customer)
    End Sub
  Partial Private Sub InsertAddress(instance As Address)
    End Sub
  Partial Private Sub UpdateAddress(instance As Address)
    End Sub
  Partial Private Sub DeleteAddress(instance As Address)
    End Sub
  Partial Private Sub InsertCustomerAddress(instance As CustomerAddress)
    End Sub
  Partial Private Sub UpdateCustomerAddress(instance As CustomerAddress)
    End Sub
  Partial Private Sub DeleteCustomerAddress(instance As CustomerAddress)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("AdventureWorksLTConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customer)
		Get
			Return Me.GetTable(Of Customer)
		End Get
	End Property
	
	Public ReadOnly Property Addresses() As System.Data.Linq.Table(Of Address)
		Get
			Return Me.GetTable(Of Address)
		End Get
	End Property
	
	Public ReadOnly Property CustomerAddresses() As System.Data.Linq.Table(Of CustomerAddress)
		Get
			Return Me.GetTable(Of CustomerAddress)
		End Get
	End Property
End Class

<Table(Name:="SalesLT.Customer")>  _
Partial Public Class Customer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CustomerID As Integer
	
	Private _NameStyle As Boolean
	
	Private _Title As String
	
	Private _FirstName As String
	
	Private _MiddleName As String
	
	Private _LastName As String
	
	Private _Suffix As String
	
	Private _CompanyName As String
	
	Private _SalesPerson As String
	
	Private _EmailAddress As String
	
	Private _Phone As String
	
	Private _PasswordHash As String
	
	Private _PasswordSalt As String
	
	Private _rowguid As System.Guid
	
	Private _ModifiedDate As Date
	
	Private _CustomerAddresses As EntitySet(Of CustomerAddress)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnNameStyleChanging(value As Boolean)
    End Sub
    Partial Private Sub OnNameStyleChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnMiddleNameChanging(value As String)
    End Sub
    Partial Private Sub OnMiddleNameChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    Partial Private Sub OnSuffixChanging(value As String)
    End Sub
    Partial Private Sub OnSuffixChanged()
    End Sub
    Partial Private Sub OnCompanyNameChanging(value As String)
    End Sub
    Partial Private Sub OnCompanyNameChanged()
    End Sub
    Partial Private Sub OnSalesPersonChanging(value As String)
    End Sub
    Partial Private Sub OnSalesPersonChanged()
    End Sub
    Partial Private Sub OnEmailAddressChanging(value As String)
    End Sub
    Partial Private Sub OnEmailAddressChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnPasswordHashChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordHashChanged()
    End Sub
    Partial Private Sub OnPasswordSaltChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordSaltChanged()
    End Sub
    Partial Private Sub OnrowguidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnrowguidChanged()
    End Sub
    Partial Private Sub OnModifiedDateChanging(value As Date)
    End Sub
    Partial Private Sub OnModifiedDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._CustomerAddresses = New EntitySet(Of CustomerAddress)(AddressOf Me.attach_CustomerAddresses, AddressOf Me.detach_CustomerAddresses)
		OnCreated
	End Sub
	
	<Column(Storage:="_CustomerID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property CustomerID() As Integer
		Get
			Return Me._CustomerID
		End Get
		Set
			If ((Me._CustomerID = value)  _
						= false) Then
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_NameStyle", DbType:="Bit NOT NULL")>  _
	Public Property NameStyle() As Boolean
		Get
			Return Me._NameStyle
		End Get
		Set
			If ((Me._NameStyle = value)  _
						= false) Then
				Me.OnNameStyleChanging(value)
				Me.SendPropertyChanging
				Me._NameStyle = value
				Me.SendPropertyChanged("NameStyle")
				Me.OnNameStyleChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Title", DbType:="NVarChar(8)")>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If (String.Equals(Me._Title, value) = false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_FirstName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstName() As String
		Get
			Return Me._FirstName
		End Get
		Set
			If (String.Equals(Me._FirstName, value) = false) Then
				Me.OnFirstNameChanging(value)
				Me.SendPropertyChanging
				Me._FirstName = value
				Me.SendPropertyChanged("FirstName")
				Me.OnFirstNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_MiddleName", DbType:="NVarChar(50)")>  _
	Public Property MiddleName() As String
		Get
			Return Me._MiddleName
		End Get
		Set
			If (String.Equals(Me._MiddleName, value) = false) Then
				Me.OnMiddleNameChanging(value)
				Me.SendPropertyChanging
				Me._MiddleName = value
				Me.SendPropertyChanged("MiddleName")
				Me.OnMiddleNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_LastName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property LastName() As String
		Get
			Return Me._LastName
		End Get
		Set
			If (String.Equals(Me._LastName, value) = false) Then
				Me.OnLastNameChanging(value)
				Me.SendPropertyChanging
				Me._LastName = value
				Me.SendPropertyChanged("LastName")
				Me.OnLastNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Suffix", DbType:="NVarChar(10)")>  _
	Public Property Suffix() As String
		Get
			Return Me._Suffix
		End Get
		Set
			If (String.Equals(Me._Suffix, value) = false) Then
				Me.OnSuffixChanging(value)
				Me.SendPropertyChanging
				Me._Suffix = value
				Me.SendPropertyChanged("Suffix")
				Me.OnSuffixChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_CompanyName", DbType:="NVarChar(128)")>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If (String.Equals(Me._CompanyName, value) = false) Then
				Me.OnCompanyNameChanging(value)
				Me.SendPropertyChanging
				Me._CompanyName = value
				Me.SendPropertyChanged("CompanyName")
				Me.OnCompanyNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_SalesPerson", DbType:="NVarChar(256)")>  _
	Public Property SalesPerson() As String
		Get
			Return Me._SalesPerson
		End Get
		Set
			If (String.Equals(Me._SalesPerson, value) = false) Then
				Me.OnSalesPersonChanging(value)
				Me.SendPropertyChanging
				Me._SalesPerson = value
				Me.SendPropertyChanged("SalesPerson")
				Me.OnSalesPersonChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_EmailAddress", DbType:="NVarChar(50)")>  _
	Public Property EmailAddress() As String
		Get
			Return Me._EmailAddress
		End Get
		Set
			If (String.Equals(Me._EmailAddress, value) = false) Then
				Me.OnEmailAddressChanging(value)
				Me.SendPropertyChanging
				Me._EmailAddress = value
				Me.SendPropertyChanged("EmailAddress")
				Me.OnEmailAddressChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Phone", DbType:="NVarChar(25)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PasswordHash", DbType:="VarChar(128) NOT NULL", CanBeNull:=false)>  _
	Public Property PasswordHash() As String
		Get
			Return Me._PasswordHash
		End Get
		Set
			If (String.Equals(Me._PasswordHash, value) = false) Then
				Me.OnPasswordHashChanging(value)
				Me.SendPropertyChanging
				Me._PasswordHash = value
				Me.SendPropertyChanged("PasswordHash")
				Me.OnPasswordHashChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PasswordSalt", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property PasswordSalt() As String
		Get
			Return Me._PasswordSalt
		End Get
		Set
			If (String.Equals(Me._PasswordSalt, value) = false) Then
				Me.OnPasswordSaltChanging(value)
				Me.SendPropertyChanging
				Me._PasswordSalt = value
				Me.SendPropertyChanged("PasswordSalt")
				Me.OnPasswordSaltChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_rowguid", DbType:="UniqueIdentifier NOT NULL")>  _
	Public Property rowguid() As System.Guid
		Get
			Return Me._rowguid
		End Get
		Set
			If ((Me._rowguid = value)  _
						= false) Then
				Me.OnrowguidChanging(value)
				Me.SendPropertyChanging
				Me._rowguid = value
				Me.SendPropertyChanged("rowguid")
				Me.OnrowguidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ModifiedDate", DbType:="DateTime NOT NULL")>  _
	Public Property ModifiedDate() As Date
		Get
			Return Me._ModifiedDate
		End Get
		Set
			If ((Me._ModifiedDate = value)  _
						= false) Then
				Me.OnModifiedDateChanging(value)
				Me.SendPropertyChanging
				Me._ModifiedDate = value
				Me.SendPropertyChanged("ModifiedDate")
				Me.OnModifiedDateChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Customer_CustomerAddress", Storage:="_CustomerAddresses", ThisKey:="CustomerID", OtherKey:="CustomerID")>  _
	Public Property CustomerAddresses() As EntitySet(Of CustomerAddress)
		Get
			Return Me._CustomerAddresses
		End Get
		Set
			Me._CustomerAddresses.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_CustomerAddresses(ByVal entity As CustomerAddress)
		Me.SendPropertyChanging
		entity.Customer = Me
	End Sub
	
	Private Sub detach_CustomerAddresses(ByVal entity As CustomerAddress)
		Me.SendPropertyChanging
		entity.Customer = Nothing
	End Sub
End Class

<Table(Name:="SalesLT.Address")>  _
Partial Public Class Address
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _AddressID As Integer
	
	Private _AddressLine1 As String
	
	Private _AddressLine2 As String
	
	Private _City As String
	
	Private _StateProvince As String
	
	Private _CountryRegion As String
	
	Private _PostalCode As String
	
	Private _rowguid As System.Guid
	
	Private _ModifiedDate As Date
	
	Private _CustomerAddresses As EntitySet(Of CustomerAddress)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnAddressIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnAddressIDChanged()
    End Sub
    Partial Private Sub OnAddressLine1Changing(value As String)
    End Sub
    Partial Private Sub OnAddressLine1Changed()
    End Sub
    Partial Private Sub OnAddressLine2Changing(value As String)
    End Sub
    Partial Private Sub OnAddressLine2Changed()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnStateProvinceChanging(value As String)
    End Sub
    Partial Private Sub OnStateProvinceChanged()
    End Sub
    Partial Private Sub OnCountryRegionChanging(value As String)
    End Sub
    Partial Private Sub OnCountryRegionChanged()
    End Sub
    Partial Private Sub OnPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnPostalCodeChanged()
    End Sub
    Partial Private Sub OnrowguidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnrowguidChanged()
    End Sub
    Partial Private Sub OnModifiedDateChanging(value As Date)
    End Sub
    Partial Private Sub OnModifiedDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._CustomerAddresses = New EntitySet(Of CustomerAddress)(AddressOf Me.attach_CustomerAddresses, AddressOf Me.detach_CustomerAddresses)
		OnCreated
	End Sub
	
	<Column(Storage:="_AddressID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property AddressID() As Integer
		Get
			Return Me._AddressID
		End Get
		Set
			If ((Me._AddressID = value)  _
						= false) Then
				Me.OnAddressIDChanging(value)
				Me.SendPropertyChanging
				Me._AddressID = value
				Me.SendPropertyChanged("AddressID")
				Me.OnAddressIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_AddressLine1", DbType:="NVarChar(60) NOT NULL", CanBeNull:=false)>  _
	Public Property AddressLine1() As String
		Get
			Return Me._AddressLine1
		End Get
		Set
			If (String.Equals(Me._AddressLine1, value) = false) Then
				Me.OnAddressLine1Changing(value)
				Me.SendPropertyChanging
				Me._AddressLine1 = value
				Me.SendPropertyChanged("AddressLine1")
				Me.OnAddressLine1Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_AddressLine2", DbType:="NVarChar(60)")>  _
	Public Property AddressLine2() As String
		Get
			Return Me._AddressLine2
		End Get
		Set
			If (String.Equals(Me._AddressLine2, value) = false) Then
				Me.OnAddressLine2Changing(value)
				Me.SendPropertyChanging
				Me._AddressLine2 = value
				Me.SendPropertyChanged("AddressLine2")
				Me.OnAddressLine2Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_City", DbType:="NVarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_StateProvince", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property StateProvince() As String
		Get
			Return Me._StateProvince
		End Get
		Set
			If (String.Equals(Me._StateProvince, value) = false) Then
				Me.OnStateProvinceChanging(value)
				Me.SendPropertyChanging
				Me._StateProvince = value
				Me.SendPropertyChanged("StateProvince")
				Me.OnStateProvinceChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_CountryRegion", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property CountryRegion() As String
		Get
			Return Me._CountryRegion
		End Get
		Set
			If (String.Equals(Me._CountryRegion, value) = false) Then
				Me.OnCountryRegionChanging(value)
				Me.SendPropertyChanging
				Me._CountryRegion = value
				Me.SendPropertyChanged("CountryRegion")
				Me.OnCountryRegionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PostalCode", DbType:="NVarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If (String.Equals(Me._PostalCode, value) = false) Then
				Me.OnPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._PostalCode = value
				Me.SendPropertyChanged("PostalCode")
				Me.OnPostalCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_rowguid", DbType:="UniqueIdentifier NOT NULL")>  _
	Public Property rowguid() As System.Guid
		Get
			Return Me._rowguid
		End Get
		Set
			If ((Me._rowguid = value)  _
						= false) Then
				Me.OnrowguidChanging(value)
				Me.SendPropertyChanging
				Me._rowguid = value
				Me.SendPropertyChanged("rowguid")
				Me.OnrowguidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ModifiedDate", DbType:="DateTime NOT NULL")>  _
	Public Property ModifiedDate() As Date
		Get
			Return Me._ModifiedDate
		End Get
		Set
			If ((Me._ModifiedDate = value)  _
						= false) Then
				Me.OnModifiedDateChanging(value)
				Me.SendPropertyChanging
				Me._ModifiedDate = value
				Me.SendPropertyChanged("ModifiedDate")
				Me.OnModifiedDateChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Address_CustomerAddress", Storage:="_CustomerAddresses", ThisKey:="AddressID", OtherKey:="AddressID")>  _
	Public Property CustomerAddresses() As EntitySet(Of CustomerAddress)
		Get
			Return Me._CustomerAddresses
		End Get
		Set
			Me._CustomerAddresses.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_CustomerAddresses(ByVal entity As CustomerAddress)
		Me.SendPropertyChanging
		entity.Address = Me
	End Sub
	
	Private Sub detach_CustomerAddresses(ByVal entity As CustomerAddress)
		Me.SendPropertyChanging
		entity.Address = Nothing
	End Sub
End Class

<Table(Name:="SalesLT.CustomerAddress")>  _
Partial Public Class CustomerAddress
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CustomerID As Integer
	
	Private _AddressID As Integer
	
	Private _AddressType As String
	
	Private _rowguid As System.Guid
	
	Private _ModifiedDate As Date
	
	Private _Address As EntityRef(Of Address)
	
	Private _Customer As EntityRef(Of Customer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnAddressIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnAddressIDChanged()
    End Sub
    Partial Private Sub OnAddressTypeChanging(value As String)
    End Sub
    Partial Private Sub OnAddressTypeChanged()
    End Sub
    Partial Private Sub OnrowguidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnrowguidChanged()
    End Sub
    Partial Private Sub OnModifiedDateChanging(value As Date)
    End Sub
    Partial Private Sub OnModifiedDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Address = CType(Nothing, EntityRef(Of Address))
		Me._Customer = CType(Nothing, EntityRef(Of Customer))
		OnCreated
	End Sub
	
	<Column(Storage:="_CustomerID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property CustomerID() As Integer
		Get
			Return Me._CustomerID
		End Get
		Set
			If ((Me._CustomerID = value)  _
						= false) Then
				If Me._Customer.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_AddressID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property AddressID() As Integer
		Get
			Return Me._AddressID
		End Get
		Set
			If ((Me._AddressID = value)  _
						= false) Then
				If Me._Address.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnAddressIDChanging(value)
				Me.SendPropertyChanging
				Me._AddressID = value
				Me.SendPropertyChanged("AddressID")
				Me.OnAddressIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_AddressType", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property AddressType() As String
		Get
			Return Me._AddressType
		End Get
		Set
			If (String.Equals(Me._AddressType, value) = false) Then
				Me.OnAddressTypeChanging(value)
				Me.SendPropertyChanging
				Me._AddressType = value
				Me.SendPropertyChanged("AddressType")
				Me.OnAddressTypeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_rowguid", DbType:="UniqueIdentifier NOT NULL")>  _
	Public Property rowguid() As System.Guid
		Get
			Return Me._rowguid
		End Get
		Set
			If ((Me._rowguid = value)  _
						= false) Then
				Me.OnrowguidChanging(value)
				Me.SendPropertyChanging
				Me._rowguid = value
				Me.SendPropertyChanged("rowguid")
				Me.OnrowguidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ModifiedDate", DbType:="DateTime NOT NULL")>  _
	Public Property ModifiedDate() As Date
		Get
			Return Me._ModifiedDate
		End Get
		Set
			If ((Me._ModifiedDate = value)  _
						= false) Then
				Me.OnModifiedDateChanging(value)
				Me.SendPropertyChanging
				Me._ModifiedDate = value
				Me.SendPropertyChanged("ModifiedDate")
				Me.OnModifiedDateChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Address_CustomerAddress", Storage:="_Address", ThisKey:="AddressID", OtherKey:="AddressID", IsForeignKey:=true)>  _
	Public Property Address() As Address
		Get
			Return Me._Address.Entity
		End Get
		Set
			Dim previousValue As Address = Me._Address.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Address.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Address.Entity = Nothing
					previousValue.CustomerAddresses.Remove(Me)
				End If
				Me._Address.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.CustomerAddresses.Add(Me)
					Me._AddressID = value.AddressID
				Else
					Me._AddressID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Address")
			End If
		End Set
	End Property
	
	<Association(Name:="Customer_CustomerAddress", Storage:="_Customer", ThisKey:="CustomerID", OtherKey:="CustomerID", IsForeignKey:=true)>  _
	Public Property Customer() As Customer
		Get
			Return Me._Customer.Entity
		End Get
		Set
			Dim previousValue As Customer = Me._Customer.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Customer.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Customer.Entity = Nothing
					previousValue.CustomerAddresses.Remove(Me)
				End If
				Me._Customer.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.CustomerAddresses.Add(Me)
					Me._CustomerID = value.CustomerID
				Else
					Me._CustomerID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Customer")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
