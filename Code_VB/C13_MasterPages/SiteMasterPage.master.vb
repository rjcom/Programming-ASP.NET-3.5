
Partial Class SiteMasterPage
    Inherits System.Web.UI.MasterPage

    Public Property AnimalImage() As Image
        Get
            Return imgAnimal
        End Get
        Set(ByVal value As Image)
            imgAnimal = value
        End Set
    End Property

End Class

