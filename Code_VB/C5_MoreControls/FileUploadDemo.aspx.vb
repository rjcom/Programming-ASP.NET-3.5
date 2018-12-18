Imports System.IO

Partial Class FileUploadDemo
    Inherits System.Web.UI.Page


    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim str As New StringBuilder()
        If FileUpload1.HasFile Then
            Try
                str.AppendFormat("Uploaded file: {0}", FileUpload1.FileName)

                ' Save the file
                FileUpload1.SaveAs("d:\desktop\screenshots\" & FileUpload1.FileName)

                ' show info about the file
                str.AppendFormat("<br/>Saved As: {0}", FileUpload1.PostedFile.FileName)
                str.AppendFormat("<br/>File Type: {0}", FileUpload1.PostedFile.ContentType)
                str.AppendFormat("<br/>File Length (bytes): {0}", FileUpload1.PostedFile.ContentLength)
                str.AppendFormat("<br/>PostedFile File Name: {0}", FileUpload1.PostedFile.FileName)
            Catch ex As Exception
                str.Append("<br/><b>Error</b><br/>")
                str.AppendFormat("Unable to save d:\documents\{0}<br />{1}", FileUpload1.FileName, ex.Message)
            End Try
        Else
            lblMessage.Text = "No file uploaded."
        End If
        lblMessage.Text = str.ToString()
        lblDisplay.Text = ""
    End Sub

    Protected Sub btnDisplay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisplay.Click
        Dim str As New StringBuilder()
        str.AppendFormat("<u>File: {0}</u><br/>", FileUpload1.FileName)
        If FileUpload1.HasFile Then
            Try
                Dim stream As Stream = FileUpload1.FileContent
                Dim reader As New StreamReader(stream)
                Dim strLine As String = ""
                Do
                    strLine = reader.ReadLine()
                    str.Append(strLine)
                Loop While strLine IsNot Nothing
            Catch ex As Exception
                str.AppendFormat("<br/><b>Error</b><br/>")
                str.AppendFormat("Unable to display {0}<br/>{1}", FileUpload1.FileName, ex.Message)
            End Try
        Else
            lblDisplay.Text = "No file uploaded."
        End If
        lblDisplay.Text = str.ToString()
        lblMessage.Text = ""
    End Sub


End Class
