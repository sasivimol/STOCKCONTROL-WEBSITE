Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim cls As New clsControllerCurrentStock
        Dim result As clsCurrentStockResultSet
        result = cls.getCurrentStock("1NMTH", "201411")
        Label1.Text = result.Data.Count
    End Sub
End Class