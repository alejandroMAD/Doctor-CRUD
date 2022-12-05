<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbDatosPaciente = New System.Windows.Forms.GroupBox()
        Me.numEdad = New System.Windows.Forms.NumericUpDown()
        Me.cboxSexo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtApellidosPaciente = New System.Windows.Forms.TextBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatosCita = New System.Windows.Forms.GroupBox()
        Me.txtIDCita = New System.Windows.Forms.TextBox()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbDatosMedico = New System.Windows.Forms.GroupBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtNombreMedico = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbNombreMedico = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.rbFechaCita = New System.Windows.Forms.RadioButton()
        Me.rbApellidosPaciente = New System.Windows.Forms.RadioButton()
        Me.rbIDCita = New System.Windows.Forms.RadioButton()
        Me.lvwCitas = New System.Windows.Forms.ListView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gbDatosPaciente.SuspendLayout()
        CType(Me.numEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosCita.SuspendLayout()
        Me.gbDatosMedico.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatosPaciente
        '
        Me.gbDatosPaciente.Controls.Add(Me.numEdad)
        Me.gbDatosPaciente.Controls.Add(Me.cboxSexo)
        Me.gbDatosPaciente.Controls.Add(Me.Label10)
        Me.gbDatosPaciente.Controls.Add(Me.txtTelefono)
        Me.gbDatosPaciente.Controls.Add(Me.txtApellidosPaciente)
        Me.gbDatosPaciente.Controls.Add(Me.txtNombrePaciente)
        Me.gbDatosPaciente.Controls.Add(Me.Label4)
        Me.gbDatosPaciente.Controls.Add(Me.Label3)
        Me.gbDatosPaciente.Controls.Add(Me.Label2)
        Me.gbDatosPaciente.Controls.Add(Me.Label1)
        Me.gbDatosPaciente.Location = New System.Drawing.Point(21, 21)
        Me.gbDatosPaciente.Name = "gbDatosPaciente"
        Me.gbDatosPaciente.Size = New System.Drawing.Size(548, 183)
        Me.gbDatosPaciente.TabIndex = 0
        Me.gbDatosPaciente.TabStop = False
        Me.gbDatosPaciente.Text = "Datos del paciente"
        '
        'numEdad
        '
        Me.numEdad.Location = New System.Drawing.Point(370, 135)
        Me.numEdad.Name = "numEdad"
        Me.numEdad.Size = New System.Drawing.Size(120, 20)
        Me.numEdad.TabIndex = 5
        Me.numEdad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cboxSexo
        '
        Me.cboxSexo.FormattingEnabled = True
        Me.cboxSexo.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.cboxSexo.Location = New System.Drawing.Point(94, 135)
        Me.cboxSexo.Name = "cboxSexo"
        Me.cboxSexo.Size = New System.Drawing.Size(135, 21)
        Me.cboxSexo.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Sexo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(94, 100)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(396, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtApellidosPaciente
        '
        Me.txtApellidosPaciente.Location = New System.Drawing.Point(94, 65)
        Me.txtApellidosPaciente.Name = "txtApellidosPaciente"
        Me.txtApellidosPaciente.Size = New System.Drawing.Size(396, 20)
        Me.txtApellidosPaciente.TabIndex = 2
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(94, 30)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(396, 20)
        Me.txtNombrePaciente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Edad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'gbDatosCita
        '
        Me.gbDatosCita.Controls.Add(Me.txtIDCita)
        Me.gbDatosCita.Controls.Add(Me.dtpHora)
        Me.gbDatosCita.Controls.Add(Me.dtpFecha)
        Me.gbDatosCita.Controls.Add(Me.Label9)
        Me.gbDatosCita.Controls.Add(Me.Label8)
        Me.gbDatosCita.Controls.Add(Me.Label7)
        Me.gbDatosCita.Location = New System.Drawing.Point(380, 216)
        Me.gbDatosCita.Name = "gbDatosCita"
        Me.gbDatosCita.Size = New System.Drawing.Size(189, 142)
        Me.gbDatosCita.TabIndex = 9
        Me.gbDatosCita.TabStop = False
        Me.gbDatosCita.Text = "Datos de la cita"
        '
        'txtIDCita
        '
        Me.txtIDCita.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDCita.Enabled = False
        Me.txtIDCita.Location = New System.Drawing.Point(74, 30)
        Me.txtIDCita.Name = "txtIDCita"
        Me.txtIDCita.Size = New System.Drawing.Size(90, 20)
        Me.txtIDCita.TabIndex = 10
        Me.txtIDCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpHora
        '
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(74, 100)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(90, 20)
        Me.dtpHora.TabIndex = 9
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(74, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Hora:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fecha:"
        '
        'gbDatosMedico
        '
        Me.gbDatosMedico.Controls.Add(Me.txtEspecialidad)
        Me.gbDatosMedico.Controls.Add(Me.txtNombreMedico)
        Me.gbDatosMedico.Controls.Add(Me.Label6)
        Me.gbDatosMedico.Controls.Add(Me.Label5)
        Me.gbDatosMedico.Location = New System.Drawing.Point(21, 216)
        Me.gbDatosMedico.Name = "gbDatosMedico"
        Me.gbDatosMedico.Size = New System.Drawing.Size(340, 142)
        Me.gbDatosMedico.TabIndex = 6
        Me.gbDatosMedico.TabStop = False
        Me.gbDatosMedico.Text = "Datos del médico"
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Location = New System.Drawing.Point(110, 81)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(205, 20)
        Me.txtEspecialidad.TabIndex = 8
        '
        'txtNombreMedico
        '
        Me.txtNombreMedico.Location = New System.Drawing.Point(110, 46)
        Me.txtNombreMedico.Name = "txtNombreMedico"
        Me.txtNombreMedico.Size = New System.Drawing.Size(205, 20)
        Me.txtNombreMedico.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Especialidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbNombreMedico)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.txtBusqueda)
        Me.GroupBox4.Controls.Add(Me.rbFechaCita)
        Me.GroupBox4.Controls.Add(Me.rbApellidosPaciente)
        Me.GroupBox4.Controls.Add(Me.rbIDCita)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(548, 112)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar por"
        '
        'rbNombreMedico
        '
        Me.rbNombreMedico.AutoSize = True
        Me.rbNombreMedico.Location = New System.Drawing.Point(280, 25)
        Me.rbNombreMedico.Name = "rbNombreMedico"
        Me.rbNombreMedico.Size = New System.Drawing.Size(116, 17)
        Me.rbNombreMedico.TabIndex = 20
        Me.rbNombreMedico.Text = "Nombre del médico"
        Me.rbNombreMedico.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(429, 60)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 25)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(30, 60)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(370, 25)
        Me.txtBusqueda.TabIndex = 22
        '
        'rbFechaCita
        '
        Me.rbFechaCita.AutoSize = True
        Me.rbFechaCita.Location = New System.Drawing.Point(415, 25)
        Me.rbFechaCita.Name = "rbFechaCita"
        Me.rbFechaCita.Size = New System.Drawing.Size(101, 17)
        Me.rbFechaCita.TabIndex = 21
        Me.rbFechaCita.Text = "Fecha de la cita"
        Me.rbFechaCita.UseVisualStyleBackColor = True
        '
        'rbApellidosPaciente
        '
        Me.rbApellidosPaciente.AutoSize = True
        Me.rbApellidosPaciente.Location = New System.Drawing.Point(135, 25)
        Me.rbApellidosPaciente.Name = "rbApellidosPaciente"
        Me.rbApellidosPaciente.Size = New System.Drawing.Size(128, 17)
        Me.rbApellidosPaciente.TabIndex = 19
        Me.rbApellidosPaciente.Text = "Apellidos del paciente"
        Me.rbApellidosPaciente.UseVisualStyleBackColor = True
        '
        'rbIDCita
        '
        Me.rbIDCita.AutoSize = True
        Me.rbIDCita.Checked = True
        Me.rbIDCita.Location = New System.Drawing.Point(35, 25)
        Me.rbIDCita.Name = "rbIDCita"
        Me.rbIDCita.Size = New System.Drawing.Size(82, 17)
        Me.rbIDCita.TabIndex = 18
        Me.rbIDCita.TabStop = True
        Me.rbIDCita.Text = "ID de la cita"
        Me.rbIDCita.UseVisualStyleBackColor = True
        '
        'lvwCitas
        '
        Me.lvwCitas.HideSelection = False
        Me.lvwCitas.Location = New System.Drawing.Point(21, 550)
        Me.lvwCitas.Name = "lvwCitas"
        Me.lvwCitas.Size = New System.Drawing.Size(704, 145)
        Me.lvwCitas.TabIndex = 24
        Me.lvwCitas.UseCompatibleStateImageBehavior = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(60, 376)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 25)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(190, 376)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 25)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(320, 376)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(90, 25)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(450, 376)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(90, 25)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblResultados
        '
        Me.lblResultados.AutoSize = True
        Me.lblResultados.Location = New System.Drawing.Point(20, 702)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(136, 13)
        Me.lblResultados.TabIndex = 21
        Me.lblResultados.Text = "0 resultado/s encontrado/s"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Doctor_CRUD.My.Resources.Resources.drCRUD
        Me.PictureBox1.Location = New System.Drawing.Point(600, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 367)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Doctor_CRUD.My.Resources.Resources.logoDR
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(588, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 50)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Doctor_CRUD.My.Resources.Resources.logoCRUD
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(588, 476)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(137, 50)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 723)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblResultados)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lvwCitas)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbDatosMedico)
        Me.Controls.Add(Me.gbDatosCita)
        Me.Controls.Add(Me.gbDatosPaciente)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DOCTOR CRUD - Citas de pacientes"
        Me.gbDatosPaciente.ResumeLayout(False)
        Me.gbDatosPaciente.PerformLayout()
        CType(Me.numEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosCita.ResumeLayout(False)
        Me.gbDatosCita.PerformLayout()
        Me.gbDatosMedico.ResumeLayout(False)
        Me.gbDatosMedico.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbDatosPaciente As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbDatosCita As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gbDatosMedico As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtApellidosPaciente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents numEdad As NumericUpDown
    Friend WithEvents cboxSexo As ComboBox
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents txtNombreMedico As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents rbFechaCita As RadioButton
    Friend WithEvents rbApellidosPaciente As RadioButton
    Friend WithEvents rbIDCita As RadioButton
    Friend WithEvents lvwCitas As ListView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblResultados As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents rbNombreMedico As RadioButton
    Friend WithEvents txtIDCita As TextBox
    Friend WithEvents dtpHora As DateTimePicker
End Class
