﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblVector = New System.Windows.Forms.ListBox()
        Me.lblVectors = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ejecutar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblVector
        '
        Me.lblVector.FormattingEnabled = True
        Me.lblVector.Location = New System.Drawing.Point(12, 12)
        Me.lblVector.Name = "lblVector"
        Me.lblVector.Size = New System.Drawing.Size(120, 238)
        Me.lblVector.TabIndex = 1
        '
        'lblVectors
        '
        Me.lblVectors.FormattingEnabled = True
        Me.lblVectors.Location = New System.Drawing.Point(151, 12)
        Me.lblVectors.Name = "lblVectors"
        Me.lblVectors.Size = New System.Drawing.Size(120, 238)
        Me.lblVectors.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVectors)
        Me.Controls.Add(Me.lblVector)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblVector As ListBox
    Friend WithEvents lblVectors As ListBox
End Class
