Imports System.Data.SQLite

'Módulo con objetos y cadenas de conexión a base de datos públicos para su uso desde el Formulario.

Module modDatabase

    Public con As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public dr As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public query As String

    Public dbFullPath As String = Application.StartupPath & "\\doctorCRUD.db3"
    Public conStr As String = String.Format("Data Source = {0}; version = 3;", dbFullPath)

    Public Sub openCon()
        Try
            con = New SQLiteConnection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.ConnectionString = conStr
            con.Open()

            'MsgBox("Conectado a la base de datos con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message & "openCon", "Error de conexión a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
