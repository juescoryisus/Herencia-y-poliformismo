<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrar = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxTipo = New System.Windows.Forms.ComboBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtDocumentos = New System.Windows.Forms.TextBox()
        Me.cboxContrato = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.cboxContrato)
        Me.GroupBox1.Controls.Add(Me.txtDocumentos)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.cboxTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'dgvRegistrar
        '
        Me.dgvRegistrar.AllowUserToAddRows = False
        Me.dgvRegistrar.AllowUserToOrderColumns = True
        Me.dgvRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Nombres, Me.Apellidos, Me.Documento, Me.Sueldo})
        Me.dgvRegistrar.Location = New System.Drawing.Point(522, 12)
        Me.dgvRegistrar.Name = "dgvRegistrar"
        Me.dgvRegistrar.RowHeadersVisible = False
        Me.dgvRegistrar.RowHeadersWidth = 62
        Me.dgvRegistrar.RowTemplate.Height = 28
        Me.dgvRegistrar.Size = New System.Drawing.Size(932, 275)
        Me.dgvRegistrar.TabIndex = 1
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 8
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 150
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.MinimumWidth = 8
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Width = 150
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.MinimumWidth = 8
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Width = 150
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.MinimumWidth = 8
        Me.Documento.Name = "Documento"
        Me.Documento.Width = 150
        '
        'Sueldo
        '
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.MinimumWidth = 8
        Me.Sueldo.Name = "Sueldo"
        Me.Sueldo.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contrato:"
        '
        'cboxTipo
        '
        Me.cboxTipo.FormattingEnabled = True
        Me.cboxTipo.Items.AddRange(New Object() {"Vendedor", "Cajero", "Administrador"})
        Me.cboxTipo.Location = New System.Drawing.Point(71, 32)
        Me.cboxTipo.Name = "cboxTipo"
        Me.cboxTipo.Size = New System.Drawing.Size(121, 28)
        Me.cboxTipo.TabIndex = 4
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(90, 99)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(189, 26)
        Me.txtNombres.TabIndex = 5
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(285, 99)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(192, 26)
        Me.txtApellidos.TabIndex = 6
        '
        'txtDocumentos
        '
        Me.txtDocumentos.Location = New System.Drawing.Point(109, 153)
        Me.txtDocumentos.Name = "txtDocumentos"
        Me.txtDocumentos.Size = New System.Drawing.Size(208, 26)
        Me.txtDocumentos.TabIndex = 7
        '
        'cboxContrato
        '
        Me.cboxContrato.FormattingEnabled = True
        Me.cboxContrato.Items.AddRange(New Object() {"C", "N"})
        Me.cboxContrato.Location = New System.Drawing.Point(90, 225)
        Me.cboxContrato.Name = "cboxContrato"
        Me.cboxContrato.Size = New System.Drawing.Size(121, 28)
        Me.cboxContrato.TabIndex = 8
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(311, 211)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(186, 45)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1466, 450)
        Me.Controls.Add(Me.dgvRegistrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRegistrar As DataGridView
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cboxContrato As ComboBox
    Friend WithEvents txtDocumentos As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents cboxTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
