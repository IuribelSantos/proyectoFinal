﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BASEDEDATOS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BASEDEDATOS))
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet = New proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet()
        Me.PRODUCTOSTableAdapter = New proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PRODUCTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PRODUCTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet = New proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet()
        Me.PRODUCTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOSTableAdapter1 = New proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.TableAdapterManager1 = New proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.TableAdapterManager()
        Me.PRODUCTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRODUCTOSBindingNavigator.SuspendLayout()
        CType(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet
        '
        'PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet
        '
        Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet.DataSetName = "PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet"
        Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.PERSONALTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Me.PRODUCTOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PRODUCTOSBindingNavigatorSaveItem
        '
        Me.PRODUCTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRODUCTOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("PRODUCTOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRODUCTOSBindingNavigatorSaveItem.Name = "PRODUCTOSBindingNavigatorSaveItem"
        Me.PRODUCTOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PRODUCTOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PRODUCTOSBindingNavigator
        '
        Me.PRODUCTOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRODUCTOSBindingNavigator.BindingSource = Me.PRODUCTOSBindingSource
        Me.PRODUCTOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRODUCTOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRODUCTOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRODUCTOSBindingNavigatorSaveItem})
        Me.PRODUCTOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRODUCTOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRODUCTOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRODUCTOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRODUCTOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRODUCTOSBindingNavigator.Name = "PRODUCTOSBindingNavigator"
        Me.PRODUCTOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRODUCTOSBindingNavigator.Size = New System.Drawing.Size(776, 25)
        Me.PRODUCTOSBindingNavigator.TabIndex = 0
        Me.PRODUCTOSBindingNavigator.Text = "BindingNavigator1"
        '
        '_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet
        '
        Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.DataSetName = "_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet"
        Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSBindingSource1
        '
        Me.PRODUCTOSBindingSource1.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource1.DataSource = Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet
        '
        'PRODUCTOSTableAdapter1
        '
        Me.PRODUCTOSTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager1.PERSONALTableAdapter = Nothing
        Me.TableAdapterManager1.PRODUCTOSTableAdapter = Me.PRODUCTOSTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRODUCTOSDataGridView
        '
        Me.PRODUCTOSDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PRODUCTOSDataGridView.AutoGenerateColumns = False
        Me.PRODUCTOSDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.PRODUCTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PRODUCTOSDataGridView.DataSource = Me.PRODUCTOSBindingSource1
        Me.PRODUCTOSDataGridView.Location = New System.Drawing.Point(12, 121)
        Me.PRODUCTOSDataGridView.Name = "PRODUCTOSDataGridView"
        Me.PRODUCTOSDataGridView.Size = New System.Drawing.Size(734, 371)
        Me.PRODUCTOSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Inicial"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Inicial"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cuota"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cuota"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Base De Datos Productos"
        '
        'BASEDEDATOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto.My.Resources.Resources.color_degradado_fondos_degradados_multicolor_51200_1500x938
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 504)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PRODUCTOSDataGridView)
        Me.Controls.Add(Me.PRODUCTOSBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BASEDEDATOS"
        Me.Text = "PRODUCTOS"
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRODUCTOSBindingNavigator.ResumeLayout(False)
        Me.PRODUCTOSBindingNavigator.PerformLayout()
        CType(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet As proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet
    Friend WithEvents PRODUCTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager As proyecto.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PRODUCTOSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PRODUCTOSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents _PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet As proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet
    Friend WithEvents PRODUCTOSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUCTOSTableAdapter1 As proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager1 As proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUCTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
