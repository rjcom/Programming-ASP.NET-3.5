
Partial Class SimpleSqlQuery
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Using db As New AwltCustomerDataContext()
            Dim firstFiveCustomers = From customer In db.Customers.Take(5) _
                Select customer

            For Each customer In firstFiveCustomers
                lblCustomers.Text += String.Format("<p>{0} {1}</p>", customer.FirstName, customer.LastName)
            Next
        End Using
    End Sub


End Class
