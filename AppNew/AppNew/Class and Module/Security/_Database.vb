Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Module _Database
    Public DataAdapter As SqlDataAdapter
    Public Data As New DataTable
    Public Con As SqlConnection
    Public Cmd As SqlCommand
    Public Read As SqlDataReader
    Private db As New ClassCon
    Private Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Server", Nothing)
    Private Database = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Database", Nothing)
    Private Userid = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "UserID", Nothing)
    Private password = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Password", Nothing)
    Private Config = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Konfigurasi", Nothing)
    Private Type = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "type", Nothing)
    Public Sub Connected()
        Cmd = New SqlCommand
        With db
            .Server = Server
            .Database = Database
            .User = Userid
            .Password = password
            .Connection()
        End With
    End Sub
    Public Sub Disconnected()
        Con.Close()
    End Sub
    Public Sub Clear_Adapter()
        Data.Clear()
        Data.Rows.Clear()
        Data.Columns.Clear()
    End Sub
    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", " Satu", " Dua", " Tiga", " Empat", " Lima", _
        " Enam", " Tujuh", " Delapan", " Sembilan", " Sepuluh", " Sebelas"}
        If nilai < 12 Then
            Return "" & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " Belas "
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " Puluh ") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " Seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " Ratus ") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " Seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " Ribu ") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " Juta ") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " Milyar ") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " Trilyun ") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function
    Public Sub load_db()
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_db"
            Read = .ExecuteReader
            While Read.Read
                F_Config.ComboBoxEdit3.Properties.Items.Add(Read(0))
            End While
            F_Config.ComboBoxEdit3.Properties.ActionButtonIndex = 0
        End With
        Read.Close()
        Disconnected()
    End Sub
    Public Sub load_db_Registry()
        F_Config.TextEdit1.EditValue = Server
        F_Config.ComboBoxEdit3.EditValue = Database
        F_Config.TextEdit2.EditValue = Userid
        F_Config.TextEdit3.EditValue = password
        F_Config.ComboBoxEdit1.EditValue = Config
        F_Config.ComboBoxEdit2.EditValue = Type
    End Sub
    Public Sub Save_Config(ByVal user As String, ByVal password As String)
        Connected()
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "insert into tbl_login(id_user,nama,username,password,akses)values('USER-01','Administrator','" + user + "',HASHBYTES('MD5', '" + password + "'),'Admin')"
            .ExecuteNonQuery()
        End With
    End Sub
End Module
