﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario1
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
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TMensaje = New System.Windows.Forms.TextBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(41, 121)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 0
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(131, 121)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 1
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(38, 46)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 2
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(38, 83)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(88, 46)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 20)
        Me.TApellido.TabIndex = 4
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(88, 83)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 20)
        Me.TNombre.TabIndex = 5
        '
        'TMensaje
        '
        Me.TMensaje.Location = New System.Drawing.Point(267, 46)
        Me.TMensaje.Multiline = True
        Me.TMensaje.Name = "TMensaje"
        Me.TMensaje.Size = New System.Drawing.Size(174, 125)
        Me.TMensaje.TabIndex = 6
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(366, 177)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 7
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.TMensaje)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.KeyPreview = True
        Me.Name = "Formulario1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Primer Forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TMensaje As TextBox
    Friend WithEvents BSalir As Button
End Class
