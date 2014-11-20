Public Class clsModelSOData

    Private p_Customer As String
    Public Property Customer() As String
        Get
            Return p_Customer
        End Get
        Set(ByVal value As String)
            p_Customer = value
        End Set
    End Property


    Private p_FacCode As String
    Public Property FacCode() As String
        Get
            Return p_FacCode
        End Get
        Set(ByVal value As String)
            p_FacCode = value
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



    Private p_ShippingDate As Date
    Public Property ShippingDate() As Date
        Get
            Return p_ShippingDate
        End Get
        Set(ByVal value As Date)
            p_ShippingDate = value
        End Set
    End Property



    Private p_ShippingTime As String
    Public Property ShippingTime() As String
        Get
            Return p_ShippingTime
        End Get
        Set(ByVal value As String)
            p_ShippingTime = value
        End Set
    End Property


    Private p_CustomerOrderNo As String
    Public Property CustomerOrderNo() As String
        Get
            Return p_CustomerOrderNo
        End Get
        Set(ByVal value As String)
            p_CustomerOrderNo = value
        End Set
    End Property



    Private p_SONo As String
    Public Property SONo() As String
        Get
            Return p_SONo
        End Get
        Set(ByVal value As String)
            p_SONo = value
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



    Private p_CustomerPartDesc As String
    Public Property CustomerPartDesc() As String
        Get
            Return p_CustomerPartDesc
        End Get
        Set(ByVal value As String)
            p_CustomerPartDesc = value
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



    Private p_ShippingQty As Decimal
    Public Property ShippingQty() As Decimal
        Get
            Return p_ShippingQty
        End Get
        Set(ByVal value As Decimal)
            p_ShippingQty = value
        End Set
    End Property


End Class
