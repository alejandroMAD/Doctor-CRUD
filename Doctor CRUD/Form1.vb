Imports System.Data.SQLite

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim anchura As Integer = lvwCitas.Width - 20

        With lvwCitas
            .FullRowSelect = True
            .GridLines = True
            .View = View.Details
            .Columns.Clear()
            .Columns.Add("ID", CInt(anchura * 0.075))
            .Columns.Add("Paciente", CInt(anchura * 0.25))
            .Columns.Add("Teléfono", CInt(anchura * 0.125))
            .Columns.Add("Médico", CInt(anchura * 0.35))
            .Columns.Add("Fecha y hora", CInt(anchura * 0.175))
        End With

        dtpHora.Format = DateTimePickerFormat.Custom
        dtpHora.CustomFormat = "HH:mm"
        dtpHora.ShowUpDown = True

        getCitas()
    End Sub

    Public Sub getCitas()
        openCon()
        Try
            query = "SELECT id_cita,
                            nombre_paciente,
                            apellidos_paciente,
                            telefono,
                            sexo,
                            edad,
                            nombre_medico,
                            especialidad,
                            STRFTIME('%d-%m-%Y', fecha_cita),
                            STRFTIME('%H:%M', hora_cita)
                    FROM tabla_citas"
            cmd = New SQLiteCommand(query, con)
            dr = cmd.ExecuteReader

            lvwCitas.Items.Clear()

            Dim numeroRegistros As Integer = 0

            While dr.Read
                Dim citas As ListViewItem = lvwCitas.Items.Add(dr.Item(0).ToString)
                Dim nombreCompletoPaciente As String = dr.Item(1).ToString & " " & dr.Item(2).ToString
                citas.SubItems.Add(1).Text = nombreCompletoPaciente
                citas.SubItems.Add(2).Text = dr.Item(3)
                citas.SubItems.Add(3).Text = dr.Item(6) & " — " & dr.Item(7)
                citas.SubItems.Add(4).Text = dr.Item(8).ToString & ", " & dr.Item(9)
                numeroRegistros += 1
            End While
            lblResultados.Text = lvwCitas.Items.Count & " resultado/s encontrado/s"
            txtIDCita.Text = numeroRegistros + 1  'El siguiente ID autoincrementado será filas + 1
        Catch ex As Exception
            MessageBox.Show(ex.Message & ", getCitas()", "Mostrar todas las citas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub limpiarFomulario()
        'Bucles iteran por los GroupBox y sus Controles interiores, identificando cuáles son TextBox y limpiándolos
        For Each group As Object In Me.Controls.OfType(Of GroupBox)
            For Each control As Object In group.Controls
                If TypeOf control Is TextBox Then
                    control.Clear
                End If
            Next
        Next

        cboxSexo.Text = ""
        dtpFecha.Value = Now
        dtpHora.Value = Now
        numEdad.Value = 1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        openCon()
        Try
            query = "INSERT INTO tabla_citas 
                        (nombre_paciente, apellidos_paciente, telefono, sexo, edad, nombre_medico, especialidad, fecha_cita, hora_cita) 
                    VALUES 
                        (@n_paciente, @a_paciente, @tlf, @sexo, @edad, @n_medico, @esp, @fecha, @hora)"
            cmd = New SQLiteCommand(query, con)

            With cmd
                .Parameters.AddWithValue("@n_paciente", txtNombrePaciente.Text.Trim)
                .Parameters.AddWithValue("@a_paciente", txtApellidosPaciente.Text.Trim)
                .Parameters.AddWithValue("@tlf", txtTelefono.Text.Trim)
                .Parameters.AddWithValue("@sexo", cboxSexo.Text)
                .Parameters.AddWithValue("@edad", numEdad.Value)
                .Parameters.AddWithValue("@n_medico", txtNombreMedico.Text.Trim)
                .Parameters.AddWithValue("@esp", txtEspecialidad.Text.Trim)
                .Parameters.AddWithValue("@fecha", dtpFecha.Value)
                .Parameters.AddWithValue("@hora", dtpHora.Value)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Se ha añadido una cita a la base de datos", "Añadir Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarFomulario()
            getCitas()
            txtNombrePaciente.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message & ", añadirCita", "Añadir Cita", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        openCon()
        Try
            query = "UPDATE tabla_citas SET nombre_paciente=@n_paciente,
                                            apellidos_paciente=@a_paciente,
                                            telefono=@tlf,
                                            sexo=@sexo,
                                            edad=@edad,
                                            nombre_medico=@n_medico,
                                            especialidad=@esp,
                                            fecha_cita=@fecha,
                                            hora_cita=@hora
                    WHERE id_cita = '" & txtIDCita.Text & "'"
            cmd = New SQLiteCommand(query, con)

            With cmd
                .Parameters.AddWithValue("@n_paciente", txtNombrePaciente.Text.Trim)
                .Parameters.AddWithValue("@a_paciente", txtApellidosPaciente.Text.Trim)
                .Parameters.AddWithValue("@tlf", txtTelefono.Text.Trim)
                .Parameters.AddWithValue("@sexo", cboxSexo.Text)
                .Parameters.AddWithValue("@edad", numEdad.Value)
                .Parameters.AddWithValue("@n_medico", txtNombreMedico.Text.Trim)
                .Parameters.AddWithValue("@esp", txtEspecialidad.Text.Trim)
                .Parameters.AddWithValue("@fecha", dtpFecha.Value)
                .Parameters.AddWithValue("@hora", dtpHora.Value)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Se ha modificado la cita en la base de datos", "Modificar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
            getCitas()
            limpiarFomulario()
            btnModificar.Enabled = False
            btnGuardar.Enabled = True
            txtNombrePaciente.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message & ", modificarCita", "Modificar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If lvwCitas.SelectedItems.Count = 0 Then
            MessageBox.Show("Por favor, seleccione una cita de la lista", "Borrar Cita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lvwCitas.Focus()
        Else
            openCon()
            Try
                query = "DELETE FROM tabla_citas WHERE id_cita = '" & lvwCitas.SelectedItems(0).SubItems(0).Text & "'"
                cmd = New SQLiteCommand(query, con)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha borrado una cita de la base de datos", "Borrar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information)
                getCitas()
            Catch ex As Exception
                MessageBox.Show(ex.Message & ", borrarCita", "Borrar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        limpiarFomulario()
        getCitas()

        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtNombrePaciente.Focus()
    End Sub

    Private Sub lvwCitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCitas.SelectedIndexChanged
        If btnGuardar.Enabled = True Then
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        End If
        If lvwCitas.SelectedItems.Count > 0 Then
            openCon()
            Try
                query = "SELECT * FROM tabla_citas WHERE id_cita = '" & lvwCitas.SelectedItems(0).SubItems(0).Text & "'"
                cmd = New SQLiteCommand(query, con)
                dr = cmd.ExecuteReader

                While dr.Read
                    txtIDCita.Text = dr.Item(0).ToString
                    txtNombrePaciente.Text = dr.Item(1).ToString
                    txtApellidosPaciente.Text = dr.Item(2).ToString
                    txtTelefono.Text = dr.Item(3).ToString
                    cboxSexo.Text = dr.Item(4).ToString
                    numEdad.Value = dr.Item(5)
                    txtNombreMedico.Text = dr.Item(6).ToString
                    txtEspecialidad.Text = dr.Item(7).ToString
                    dtpFecha.Value = dr.Item(8)
                    dtpHora.Value = dr.Item(9)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message & ", seleccionarCita", "Seleccionar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        openCon()
        Try
            query = "SELECT id_cita,
                            nombre_paciente,
                            apellidos_paciente,
                            telefono,
                            sexo,
                            edad,
                            nombre_medico,
                            especialidad,
                            STRFTIME('%d-%m-%Y', fecha_cita),
                            STRFTIME('%H:%M', hora_cita)
                    FROM tabla_citas"
            If rbIDCita.Checked = True Then
                query += " WHERE id_cita = '" & txtBusqueda.Text.Trim & "'"
            ElseIf rbApellidosPaciente.Checked = True Then
                query += " WHERE apellidos_paciente LIKE '%" & txtBusqueda.Text.Trim & "%'"
            ElseIf rbNombreMedico.Checked = True Then
                query += " WHERE nombre_medico LIKE '%" & txtBusqueda.Text.Trim & "%'"
            ElseIf rbFechaCita.Checked = True Then
                'Recupera solo la primera columna del SQLite DATE para comparar válidamente
                query += " WHERE STRFTIME('%d-%m-%Y', fecha_cita) = '" & txtBusqueda.Text.Trim & "'"
            End If

            cmd = New SQLiteCommand(query, con)
            dr = cmd.ExecuteReader

            lvwCitas.Items.Clear()

            While dr.Read
                Dim citas As ListViewItem = lvwCitas.Items.Add(dr.Item(0).ToString)
                Dim nombreCompletoPaciente As String = dr.Item(1).ToString & " " & dr.Item(2).ToString
                citas.SubItems.Add(1).Text = nombreCompletoPaciente
                citas.SubItems.Add(2).Text = dr.Item(3)
                citas.SubItems.Add(3).Text = dr.Item(6) & " — " & dr.Item(7)
                citas.SubItems.Add(4).Text = dr.Item(8).ToString & ", " & dr.Item(9)
            End While

            lblResultados.Text = lvwCitas.Items.Count & " resultado/s encontrado/s"
        Catch ex As Exception
            MessageBox.Show(ex.Message & ", buscarCita", "Buscar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
