﻿
Partial Class Calendar_Calendar_MoreSelections
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Calendar1.VisibleDate = Calendar1.TodaysDate
            ddl.SelectedIndex = Calendar1.VisibleDate.Month - 1
        End If
        lblTodaysDate.Text = "Today's Date is " & Calendar1.TodaysDate.ToShortDateString()
    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Calendar1.SelectionChanged
        lblSelectedUpdate()
        lblCountUpdate()
        txtClear()
    End Sub

    Private Sub lblSelectedUpdate()
        If Calendar1.SelectedDate <> DateTime.MinValue Then
            lblSelected.Text = "The date selected is " & Calendar1.SelectedDate.ToShortDateString()
        End If
    End Sub

    Private Sub lblCountUpdate()
        lblCount.Text = "Count of Days Selected: " & Calendar1.SelectedDates.Count.ToString()
    End Sub

    Protected Sub ddl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl.SelectedIndexChanged
        Calendar1.SelectedDates.Clear()
        lblSelectedUpdate()
        lblCountUpdate()
        Calendar1.VisibleDate = New DateTime(Calendar1.VisibleDate.Year, Int32.Parse(ddl.SelectedItem.Value), 1)
        txtClear()
    End Sub

    Protected Sub btnTgif_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTgif.Click
        Dim currentMonth As Integer = Calendar1.VisibleDate.Month
        Dim currentYear As Integer = Calendar1.VisibleDate.Year
        Calendar1.SelectedDates.Clear()
        For i As Integer = 1 To System.DateTime.DaysInMonth(currentYear, currentMonth)
            Dim [date] As New DateTime(currentYear, currentMonth, i)
            If [date].DayOfWeek = DayOfWeek.Friday Then
                Calendar1.SelectedDates.Add([date])
            End If
        Next
        lblSelectedUpdate()
        lblCountUpdate()
        txtClear()
    End Sub

    Protected Sub btnRange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRange.Click
        Dim currentMonth As Integer = Calendar1.VisibleDate.Month
        Dim currentYear As Integer = Calendar1.VisibleDate.Year
        Dim StartDate As New DateTime(currentYear, currentMonth, Int32.Parse(txtStart.Text))
        Dim EndDate As New DateTime(currentYear, currentMonth, Int32.Parse(txtEnd.Text))
        Calendar1.SelectedDates.Clear()
        Calendar1.SelectedDates.SelectRange(StartDate, EndDate)
        lblSelectedUpdate()
        lblCountUpdate()
    End Sub

    Private Sub txtClear()
        txtStart.Text = ""
        txtEnd.Text = ""
    End Sub
End Class
