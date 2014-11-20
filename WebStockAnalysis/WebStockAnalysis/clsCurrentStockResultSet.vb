Public Class clsCurrentStockResultSet


    Private p_data As New List(Of clsModelCurrentStock)
    Public Property Data() As List(Of clsModelCurrentStock)
        Get
            Return p_data
        End Get
        Set(ByVal value As List(Of clsModelCurrentStock))
            p_data = value
        End Set
    End Property

End Class
