Public Class clsSODataResultSet


    Private p_data As New List(Of clsModelSOData)
    Public Property Data() As List(Of clsModelSOData)
        Get
            Return p_data
        End Get
        Set(ByVal value As List(Of clsModelSOData))
            p_data = value
        End Set
    End Property


End Class
