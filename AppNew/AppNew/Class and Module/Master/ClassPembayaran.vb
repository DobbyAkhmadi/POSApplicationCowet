Imports System.Data.SqlClient
Public Class ClassPembayaran
    Private V_ID_Pembayaran As String
    Private V_Nama As String
#Region "Property"
    Property Db_ID_Pembayaran()
        Get
            Db_ID_Pembayaran = V_ID_Pembayaran
        End Get
        Set(ByVal value)
            V_ID_Pembayaran = value
        End Set
    End Property
    Property Db_Nama()
        Get
            Db_Nama = V_Nama
        End Get
        Set(ByVal value)
            V_Nama = value
        End Set
    End Property
#End Region

#Region "Method"
    Public Function Save(ByVal SP_SAVE As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_SAVE
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", Db_Nama)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Return SP_SAVE
        Disconnected()
    End Function
    Public Function Delete(ByVal SP_DELETE As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_DELETE
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", Db_ID_Pembayaran)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Disconnected()
        Return SP_DELETE
    End Function
    Public Function View(ByVal SP_VIEW As String)
        Connected()
        Clear_Adapter()
        F_Pembayaran.GridView1.OptionsBehavior.Editable = 0
        While F_Pembayaran.GridView1.RowCount <> 0
            F_Pembayaran.GridView1.SelectAll()
            F_Pembayaran.GridView1.DeleteSelectedRows()
        End While
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = SP_VIEW
            Data.Load(.ExecuteReader)
            F_Pembayaran.GridControl1.DataSource = Data
            F_Pembayaran.GridControl1.DataMember = Data.TableName
            .Dispose()
        End With

        Disconnected()
        Return SP_VIEW
    End Function
#End Region
End Class
