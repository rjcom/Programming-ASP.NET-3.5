Imports System
Imports System.Collections.Specialized
Imports System.Web.Profile

''' <summary> 
''' Summary description for CustomProfile 
''' </summary> 
Public Class CustomProfile
    Inherits ProfileBase
    Public Property lastName() As String
        Get
            Return TryCast(MyBase.Item("LastName"), String)
        End Get
        Set(ByVal value As String)
            MyBase.Item("LastName") = value
        End Set
    End Property

    Public Property firstName() As String
        Get
            Return TryCast(MyBase.Item("FirstName"), String)
        End Get
        Set(ByVal value As String)
            MyBase.Item("FirstName") = value
        End Set
    End Property

    Public Property phoneNumber() As String
        Get
            Return TryCast(MyBase.Item("PhoneNumber"), String)
        End Get
        Set(ByVal value As String)
            MyBase.Item("PhoneNumber") = value
        End Set
    End Property

    Public Property birthDate() As DateTime
        Get
            Return DirectCast((MyBase.Item("BirthDate")), DateTime)
        End Get
        Set(ByVal value As DateTime)
            MyBase.Item("BirthDate") = value
        End Set
    End Property

    <SettingsAllowAnonymous(True)> _
    Public Property favoriteBooks() As StringCollection
        Get
            Return TryCast(MyBase.Item("FavoriteBooks"), StringCollection)
        End Get
        Set(ByVal value As StringCollection)
            MyBase.Item("FavoriteBooks") = value
        End Set
    End Property
End Class