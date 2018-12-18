Imports System.Collections.Generic
Imports System.Linq

Public Class BookStats
    Private _Sales As Integer
    Public Property Sales() As Integer
        Get
            Return _Sales
        End Get
        Set(ByVal value As Integer)
            _Sales = value
        End Set
    End Property
    Private _Pages As Integer
    Public Property Pages() As Integer
        Get
            Return _Pages
        End Get
        Set(ByVal value As Integer)
            _Pages = value
        End Set
    End Property
    Private _Rank As Integer
    Public Property Rank() As Integer
        Get
            Return _Rank
        End Get
        Set(ByVal value As Integer)
            _Rank = value
        End Set
    End Property
    Private _ISBN As String
    Public Property ISBN() As String
        Get
            Return _ISBN
        End Get
        Set(ByVal value As String)
            _ISBN = value
        End Set
    End Property

    Public Shared Function GetBookStats() As IEnumerable(Of BookStats)
        Dim stats As BookStats() = { _
            New BookStats() With {.ISBN = "0596529562", .Pages = 904, .Rank = 1, .Sales = 109000}, _
            New BookStats() With {.ISBN = "0596527438", .Pages = 607, .Rank = 2, .Sales = 58000}, _
            New BookStats() With {.ISBN = "059652756X", .Pages = 704, .Rank = 3, .Sales = 75000}, _
            New BookStats() With {.ISBN = "0596518455", .Pages = 552, .Rank = 4, .Sales = 120000}, _
            New BookStats() With {.ISBN = "0596518439", .Pages = 752, .Rank = 5, .Sales = 37500}}

        Return stats.OfType(Of BookStats)()
    End Function
End Class

