Imports System
Imports System.Collections.Generic

Public Class Book
    Private _ISBN As String
    Public Property ISBN() As String
        Get
            Return _ISBN
        End Get
        Set(ByVal value As String)
            _ISBN = value
        End Set
    End Property
    Private _Title As String
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property
    Private _Price As Decimal
    Public Property Price() As Decimal
        Get
            Return _Price
        End Get
        Set(ByVal value As Decimal)
            _Price = value
        End Set
    End Property
    Private _ReleaseDate As DateTime
    Public Property ReleaseDate() As DateTime
        Get
            Return _ReleaseDate
        End Get
        Set(ByVal value As DateTime)
            _ReleaseDate = value
        End Set
    End Property

    Public Shared Function GetBookList() As List(Of Book)
        Dim list As New List(Of Book)()
        list.Add(New Book() With {.ISBN = "0596529562", .ReleaseDate = Convert.ToDateTime("2009-07-15"), .Price = 30D, .Title = "Programming ASP.NET 3.5"})
        list.Add(New Book() With {.ISBN = "059652756X", .ReleaseDate = Convert.ToDateTime("2009-06-15"), .Price = 26D, .Title = "Programming .NET 3.5"})
        list.Add(New Book() With {.ISBN = "0596518455", .ReleaseDate = Convert.ToDateTime("2009-07-15"), .Price = 28D, .Title = "Learning ASP.NET 3.5"})
        list.Add(New Book() With {.ISBN = "0596518439", .ReleaseDate = Convert.ToDateTime("2008-03-15"), .Price = 25D, .Title = "Programming Visual Basic 2008"})
        list.Add(New Book() With {.ISBN = "0596527438", .ReleaseDate = Convert.ToDateTime("2008-01-15"), .Price = 31D, .Title = "Programming C# 3.0"})

        Return list
    End Function
End Class


