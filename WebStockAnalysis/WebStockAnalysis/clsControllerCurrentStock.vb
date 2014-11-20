Public Class clsControllerCurrentStock



    Dim StockNMTHConnStr As String = "DSN=IPS"
    Dim StockNMTHConn As New Odbc.OdbcConnection(StockNMTHConnStr)



    Public Function getCurrentStock(ByVal pFacCode As String, ByVal pPeriod As String) As clsCurrentStockResultSet
        Dim result As New clsCurrentStockResultSet
        Dim SQLCommand As String
        Dim resultDataReader As Odbc.OdbcDataReader

        SQLCommand = String.Format("SELECT * FROM IPS_STOCKCONTROL WHERE I_FAC_CD = '{0}' AND PERIOD_MONTH = '{1}'", pFacCode, pPeriod)
        Using StockNMTHConn
            StockNMTHConn.Open()

            Using StockNMTHCmd As New Odbc.OdbcCommand(SQLCommand, StockNMTHConn)
                StockNMTHCmd.CommandType = CommandType.Text
                resultDataReader = StockNMTHCmd.ExecuteReader

                Dim itemReader As Object

                For Each itemReader In resultDataReader
                    Dim item As New clsModelCurrentStock
                    item.CustomerCode = Trim(itemReader("ips_cust_cd"))
                    item.FacCode = Trim(pFacCode)
                    item.StockMonth = Trim(itemReader("period_month"))
                    item.CustomerPartName = Trim(itemReader("i_trade_item_cd"))
                    item.CustomerPartNo = Trim(itemReader("i_trade_item_cd"))
                    item.ItemCd = Trim(itemReader("i_item_cd"))
                    item.ItemDesc = Trim(itemReader("i_item_cd"))
                    item.ShipTo = Trim(itemReader("ips_cust_cd"))
                    item.StockLocation = Trim(itemReader("store_location"))
                    item.StartStock = itemReader("begin_qty")
                    result.Data.Add(item)
                Next
            End Using

            StockNMTHConn.Close()
        End Using
        Return result
    End Function



End Class
