Public Class clsModelCurrentStock



    Private p_FacCode As String
    Public Property FacCode() As String
        Get
            Return p_FacCode
        End Get
        Set(ByVal value As String)
            p_FacCode = value
        End Set
    End Property

    Private p_StockMonth As String
    Public Property StockMonth() As String
        Get
            Return p_StockMonth
        End Get
        Set(ByVal value As String)
            p_StockMonth = value
        End Set
    End Property


    Private p_CustomerCode As String
    Public Property CustomerCode() As String
        Get
            Return p_CustomerCode
        End Get
        Set(ByVal value As String)
            p_CustomerCode = value
        End Set
    End Property


    Private p_ShipTo As String
    Public Property ShipTo() As String
        Get
            Return p_ShipTo
        End Get
        Set(ByVal value As String)
            p_ShipTo = value
        End Set
    End Property


    Private p_CustomerPartNo As String
    Public Property CustomerPartNo() As String
        Get
            Return p_CustomerPartNo
        End Get
        Set(ByVal value As String)
            p_CustomerPartNo = value
        End Set
    End Property


    Private p_CustomerPartName As String
    Public Property CustomerPartName() As String
        Get
            Return p_CustomerPartName
        End Get
        Set(ByVal value As String)
            p_CustomerPartName = value
        End Set
    End Property




    Private p_ItemCd As String
    Public Property ItemCd() As String
        Get
            Return p_ItemCd
        End Get
        Set(ByVal value As String)
            p_ItemCd = value
        End Set
    End Property


    Private p_ItemDesc As String
    Public Property ItemDesc() As String
        Get
            Return p_ItemDesc
        End Get
        Set(ByVal value As String)
            p_ItemDesc = value
        End Set
    End Property


    Private p_StockLocation As String
    Public Property StockLocation() As String
        Get
            Return p_StockLocation
        End Get
        Set(ByVal value As String)
            p_StockLocation = value
        End Set
    End Property


    Private p_LotNo As String
    Public Property LotNo() As String
        Get
            Return p_LotNo
        End Get
        Set(ByVal value As String)
            p_LotNo = value
        End Set
    End Property


    Private p_StartStock As Decimal
    Public Property StartStock() As Decimal
        Get
            Return p_StartStock
        End Get
        Set(ByVal value As Decimal)
            p_StartStock = value
        End Set
    End Property


    Private p_ItemClass As String
    Public Property ItemClass() As String
        Get
            Return p_ItemClass
        End Get
        Set(ByVal value As String)
            p_ItemClass = value
        End Set
    End Property



End Class
