
Partial Class PanelDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' First take care of the panel w/ the dynamically generated controls
        ' Show/Hide Panel Contents
        pnlDynamic.Visible = chkVisible.Checked

        ' Generate label controls
        Dim numlabels As Integer = Int32.Parse(ddlLabels.SelectedItem.Value)
        For i As Integer = 1 To numlabels
            Dim lbl As New Label()
            lbl.Text = "Label" & (i).ToString()
            lbl.ID = "Label" & (i).ToString()
            pnlDynamic.Controls.Add(lbl)
            pnlDynamic.Controls.Add(New LiteralControl("<br />"))
        Next

        ' Generate textbox controls
        Dim numBoxes As Integer = Int32.Parse(ddlBoxes.SelectedItem.Value)
        For i As Integer = 1 To numBoxes
            Dim txt As New TextBox()
            txt.Text = "TextBox" & (i).ToString()
            txt.ID = "TextBox" & (i).ToString()
            pnlDynamic.Controls.Add(txt)
            pnlDynamic.Controls.Add(New LiteralControl("<br />"))
        Next

        ' Next take care of the Scrollbar panel.
        Dim strText As New StringBuilder("<p>Four score and seven years ago our fathers brought forth, upon this continent, a new nation, conceived in liberty, and dedicated to the proposition that ""all men are created equal.""</p>")
        strText.Append("<p>Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived, and so dedicated, can long endure. We are met on a great battle field of that war. We have come to dedicate a portion of it, as a final resting place for those who died here, that the nation might live. This we may, in all propriety do. But, in a larger sense, we can not dedicate -- we can not consecrate -- we can not hallow, this ground -- The brave men, living and dead, who struggled here, have hallowed it, far above our poor power to add or detract. The world will little note, nor long remember what we say here; while it can never forget what they did here.</p>")
        strText.Append("<p>It is rather for us, the living, we here be dedicated to the great task remaining before us -- that, from these honored dead we take increased devotion to that cause for which they here, gave the last full measure of devotion -- that we here highly resolve these dead shall not have died in vain; that the nation, shall have a new birth of freedom, and that government of the people by the people for the people, shall not perish from the earth.</p>")

        lblPanelContent.Text = strText.ToString()
    End Sub

    Protected Sub ddlScrollBars_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlScrollBars.SelectedIndexChanged
        Dim ddl As DropDownList = DirectCast(sender, DropDownList)
        Dim strValue As String = ddl.SelectedItem.ToString()
        Dim bars As ScrollBars = DirectCast([Enum].Parse(GetType(ScrollBars), strValue), ScrollBars)
        pnlScroll.ScrollBars = bars
    End Sub


    Protected Sub rblWrap_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rblWrap.SelectedIndexChanged
        Dim rbl As RadioButtonList = DirectCast(sender, RadioButtonList)
        pnlScroll.Wrap = Convert.ToBoolean(rbl.SelectedValue)
    End Sub


End Class
