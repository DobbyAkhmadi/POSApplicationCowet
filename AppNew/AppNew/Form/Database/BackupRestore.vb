

''Based on code from below

''Wilson Kutegeka | Microsoft MVP - Visual Basic | C#
''Developer | Promoter | ClinicMaster Software
''JCRC | Plot 893 Ring Rd, Butikiro HSE-Mengo, Kampala-Uganda
''cel: +256 772 609113 | email: info@clinicmaster.net
''web: http://www.clinicmaster.net/
''MVP Profile: https://mvp.support.microsoft.com/profile/Wilson.Kutegeka
''
'Imports Microsoft.SqlServer.Management.Smo
'Imports System.IO

'Public Class Backuprestore

'    Private Sub SimpleButtonLoadServers_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButtonLoadServers.Click
'        Try
'            Me.Cursor = Cursors.WaitCursor()
'            '  Dim myServers As New DataTable

'            '   myServers = SmoApplication.EnumAvailableSqlServers(True) 'True gives a list of local available instances of SQL Server, instances on other computers not wanted

'            '   Me.ComboBoxServers.DataSource = myServers
'            '  Me.ComboBoxServers.DisplayMember = "Name"

'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        Finally
'            Me.Cursor = Cursors.Default()
'        End Try
'    End Sub


'    Private Sub SimpleButtonLoadDatabases_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButtonLoadDatabases.Click
'        Try
'            Me.Cursor = Cursors.WaitCursor()

'            Me.ComboBoxDatabases.Items.Clear()

'            '  Dim server As New Server(ComboBoxServers.Text)

'            For Each database As Database In server.Databases
'                Me.ComboBoxDatabases.Items.Add(database.Name)
'            Next
'            Try

'            Catch ex As Exception

'            End Try
'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        Finally
'            Me.Cursor = Cursors.Default()
'        End Try
'    End Sub

'    Private Sub BarButtonItemBackup_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemBackup.ItemClick
'        Try

'            Cursor.Current = Cursors.WaitCursor()

'            Dim serverName As String = Me.ComboBoxServers.Text
'            Dim pathName As String = Me.TextEdit1.Text
'            Dim databaseName As String = Me.ComboBoxDatabases.Text

'            If String.IsNullOrEmpty(serverName) Then Throw New ArgumentException("Enter server name")
'            If String.IsNullOrEmpty(pathName) Then Throw New ArgumentException("Set backup file path")
'            If String.IsNullOrEmpty(databaseName) Then Throw New ArgumentException("Must set database name")


'            Dim _Day As String = Today.Day.ToString().PadLeft(2, CChar("0"))
'            Dim _Month As String = Today.Month.ToString().PadLeft(2, CChar("0"))
'            Dim _Year As String = Today.Year.ToString().Substring(2)
'            Dim _Hour As String = Now.Hour.ToString().PadLeft(2, "0"c)
'            Dim _Minute As String = Now.Minute.ToString().PadLeft(2, "0"c)

'            Dim fileName As String = databaseName + "-" + _Day + _Month + _Year + _Hour + _Minute

'            If Not Directory.Exists(Me.TextEdit1.Text) Then Directory.CreateDirectory(Me.TextEdit1.Text)
'            fileName = Me.TextEdit1.Text + "\\" + fileName

'            Dim backupServer As New Server(serverName)
'            Dim dataBackup As New Backup()

'            dataBackup.Action = BackupActionType.Database
'            dataBackup.Database = databaseName

'            'set the devices: file, tape etc
'            dataBackup.Devices.AddDevice(fileName, DeviceType.File)

'            'progress meter stuff
'            ' Initializing progress bar properties 
'            ProgressBarControl1.Properties.Step = 10
'            ProgressBarControl1.Properties.PercentView = True
'            ProgressBarControl1.Properties.Maximum = 100
'            ProgressBarControl1.Properties.Minimum = 0

'            ''this gives the % complete by handling the event
'            ''provided by SMO on the percent complete; we will
'            ''update the progress meter in the event handler

'            ''set the progress meter to 1% by default
'            dataBackup.PercentCompleteNotification = 10
'            AddHandler dataBackup.PercentComplete, AddressOf Me.BackupProgressEventHandler

'            '  dataBackup.SqlBackup(backupServer)

'            Me.BarStaticItem1.Caption = "Backup of " & databaseName & " completed sucessfully"


'        Catch exSMO As SmoException
'            Me.ProgressBarControl1.EditValue = 0
'            'MessageBox.Show(exSMO.Message)
'            Me.BarStaticItem1.Caption = exSMO.Message

'        Catch ex As Exception
'            Me.ProgressBarControl1.EditValue = 0
'            'MessageBox.Show(ex.Message)
'            Me.BarStaticItem1.Caption = ex.Message
'        Finally
'            Me.ProgressBarControl1.EditValue = 0
'            Cursor.Current = Cursors.Default()

'        End Try

'    End Sub

'    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
'        Dim dlgFolder As New FolderBrowserDialog()

'        Try
'            Me.Cursor = Cursors.WaitCursor

'            dlgFolder.ShowNewFolderButton = True

'            If dlgFolder.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
'                Me.TextEdit1.Text = dlgFolder.SelectedPath.ToString()

'            End If

'        Catch eX As Exception
'            MessageBox.Show(eX.Message)

'        Finally
'            Me.Cursor = Cursors.Default

'        End Try
'    End Sub

'    Private Sub BackupProgressEventHandler(ByVal sender As System.Object, ByVal e As PercentCompleteEventArgs)
'        'increase the progress bar up by the percent
'        Me.ProgressBarControl1.PerformStep()
'        Me.ProgressBarControl1.Update()

'    End Sub

'    Private Sub BarButtonItemClose_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemClose.ItemClick
'        My.Settings.BackupTime = ComboBoxEdit1.Text
'        My.Settings.BackupLocation = Me.TextEdit1.Text
'        Me.Close()
'    End Sub

'    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
'        Dim OpenFileDialog1 As New OpenFileDialog()

'        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
'            Try
'                Me.TextEditRestoreLocation.Text = OpenFileDialog1.FileName.ToString


'            Catch Ex As Exception
'                MessageBox.Show(Ex.Message)
'            Finally

'            End Try
'        End If
'    End Sub

'    Private Sub BarButtonItemRestore_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRestore.ItemClick
'        Dim res As New Restore
'        Dim serverName As String = Me.ComboBoxServers.Text
'        Dim fileName As String = Me.TextEditRestoreLocation.Text
'        Dim databaseName As String = Me.ComboBoxDatabases.Text
'        Dim restoreServer As New Server(serverName)

'        Try

'            If String.IsNullOrEmpty(serverName) Then Throw New ArgumentException("Enter server name")
'            If String.IsNullOrEmpty(fileName) Then Throw New ArgumentException("Set restore file path")
'            If String.IsNullOrEmpty(databaseName) Then Throw New ArgumentException("Must set database name")


'            res.Database = databaseName
'            res.Action = RestoreActionType.Database
'            res.Devices.AddDevice(fileName, DeviceType.File)

'            'progress meter stuff
'            ' Initializing progress bar properties 
'            ProgressBarControl1.Properties.Step = 10
'            ProgressBarControl1.Properties.PercentView = True
'            ProgressBarControl1.Properties.Maximum = 100
'            ProgressBarControl1.Properties.Minimum = 0

'            ''this gives the % complete by handling the event
'            ''provided by SMO on the percent complete; we will
'            ''update the progress meter in the event handler

'            ''set the progress meter to 1% by default
'            res.PercentCompleteNotification = 1
'            AddHandler res.PercentComplete, AddressOf Me.BackupProgressEventHandler
'            ' res.SqlRestore(restoreServer)

'            'MessageBox.Show("Restore of " + databaseName + " Complete", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Me.BarStaticItem1.Caption = "Restore of " & databaseName & " completed successfully."

'        Catch exSMO As SmoException
'            Me.ProgressBarControl1.EditValue = 0
'            'MessageBox.Show(exSMO.Message)
'            Me.BarStaticItem1.Caption = exSMO.Message
'        Catch ex As Exception
'            Me.ProgressBarControl1.EditValue = 0
'            'MessageBox.Show(ex.Message)
'            Me.BarStaticItem1.Caption = ex.Message
'        Finally
'            Me.ProgressBarControl1.EditValue = 0
'            Cursor.Current = Cursors.Default()

'        End Try
'    End Sub
'    Dim BackUpDoneToday As Boolean = False
'    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
'        If Me.BarCheckItemBackup.Checked = False Then Exit Sub
'        If Now.TimeOfDay.Hours = My.Settings.BackupTime And BackUpDoneToday = False Then
'            Me.BarStaticItem1.Caption = "Backup done"
'            'MessageBox.Show("Backup")
'            Me.BarButtonItemBackup.PerformClick()
'            BackUpDoneToday = True
'        ElseIf Now.TimeOfDay.Hours <> My.Settings.BackupTime Then
'            BackUpDoneToday = False
'            'Me.BarStaticItem1.Caption = "Backup cancelled wrong hour reset"
'        Else
'            'Me.BarStaticItem1.Caption = "Backup cancelled done this hour"
'        End If

'    End Sub

'    Private Sub Backuprestore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
'        GC.KeepAlive(Me.Timer1)
'        Me.ComboBoxEdit1.Text = My.Settings.BackupTime
'        Me.TextEdit1.Text = My.Settings.BackupLocation
'    End Sub

'    Private Sub BarCheckItemBackup_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItemBackup.CheckedChanged
'        If Me.BarCheckItemBackup.Checked = False Then Me.BarCheckItemBackup.Caption = "Schedule off"
'        If Me.BarCheckItemBackup.Checked = True Then Me.BarCheckItemBackup.Caption = "Schedule on"
'    End Sub

'    Private Sub BarButtonItemVerify_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemVerify.ItemClick
'        Dim res As New Restore
'        Dim serverName As String = Me.ComboBoxServers.Text
'        Dim fileName As String = Me.TextEditRestoreLocation.Text
'        'Dim databaseName As String = Me.ComboBoxDatabases.Text
'        Dim restoreServer As New Server(serverName)

'        Try

'            If String.IsNullOrEmpty(serverName) Then Throw New ArgumentException("Enter server name")
'            If String.IsNullOrEmpty(fileName) Then Throw New ArgumentException("Set verification file path")
'            'If String.IsNullOrEmpty(databaseName) Then Throw New ArgumentException("Must set database name")


'            'res.Database = databaseName
'            res.Action = RestoreActionType.Database
'            res.Devices.AddDevice(fileName, DeviceType.File)

'            'progress meter stuff
'            ' Initializing progress bar properties 
'            ProgressBarControl1.Properties.Step = 10
'            ProgressBarControl1.Properties.PercentView = True
'            ProgressBarControl1.Properties.Maximum = 100
'            ProgressBarControl1.Properties.Minimum = 0

'            ''this gives the % complete by handling the event
'            ''provided by SMO on the percent complete; we will
'            ''update the progress meter in the event handler

'            ''set the progress meter to 1% by default
'            res.PercentCompleteNotification = 1
'            AddHandler res.PercentComplete, AddressOf Me.BackupProgressEventHandler
'            res.SqlVerify(restoreServer)

'            'MessageBox.Show("Restore of " + databaseName + " Complete", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Me.BarStaticItem1.Caption = "Verification of " & fileName & " completed successfully."

'        Catch exSMO As SmoException
'            Me.ProgressBarControl1.EditValue = 0
'            'MessageBox.Show(exSMO.Message)
'            Me.BarStaticItem1.Caption = exSMO.Message
'        Catch ex As Exception
'            Me.ProgressBarControl1.EditValue = 0
'            'MessageBox.Show(ex.Message)
'            Me.BarStaticItem1.Caption = ex.Message
'        Finally
'            Me.ProgressBarControl1.EditValue = 0
'            Cursor.Current = Cursors.Default()

'        End Try
'    End Sub
'End Class