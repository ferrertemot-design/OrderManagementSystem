<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBev = New System.Windows.Forms.Label()
        Me.lblQuanti = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.nudQuanti = New System.Windows.Forms.NumericUpDown()
        Me.chboxDiscount = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.nudQuanti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(410, 131)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(85, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Customer Name:"
        '
        'lblBev
        '
        Me.lblBev.AutoSize = True
        Me.lblBev.Location = New System.Drawing.Point(410, 154)
        Me.lblBev.Name = "lblBev"
        Me.lblBev.Size = New System.Drawing.Size(95, 13)
        Me.lblBev.TabIndex = 1
        Me.lblBev.Text = "Beverage Chosen:"
        '
        'lblQuanti
        '
        Me.lblQuanti.AutoSize = True
        Me.lblQuanti.Location = New System.Drawing.Point(410, 179)
        Me.lblQuanti.Name = "lblQuanti"
        Me.lblQuanti.Size = New System.Drawing.Size(46, 13)
        Me.lblQuanti.TabIndex = 2
        Me.lblQuanti.Text = "Quantity"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(410, 206)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(49, 13)
        Me.lblSub.TabIndex = 3
        Me.lblSub.Text = "Subtotal:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(410, 230)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.lblDiscount.TabIndex = 4
        Me.lblDiscount.Text = "Discount:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(410, 260)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Final Total:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(136, 124)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 6
        '
        'cmbMenu
        '
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Items.AddRange(New Object() {"Espresso", "Latte", "Cappuccino", "Americano", "Mocha"})
        Me.cmbMenu.Location = New System.Drawing.Point(136, 151)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(121, 21)
        Me.cmbMenu.TabIndex = 7
        '
        'nudQuanti
        '
        Me.nudQuanti.Location = New System.Drawing.Point(136, 179)
        Me.nudQuanti.Name = "nudQuanti"
        Me.nudQuanti.Size = New System.Drawing.Size(120, 20)
        Me.nudQuanti.TabIndex = 8
        '
        'chboxDiscount
        '
        Me.chboxDiscount.AutoSize = True
        Me.chboxDiscount.Location = New System.Drawing.Point(136, 206)
        Me.chboxDiscount.Name = "chboxDiscount"
        Me.chboxDiscount.Size = New System.Drawing.Size(133, 17)
        Me.chboxDiscount.TabIndex = 9
        Me.chboxDiscount.Text = "Apply Loyalty Discount"
        Me.chboxDiscount.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(136, 230)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 10
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(136, 260)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(68, 13)
        Me.lblResult.TabIndex = 11
        Me.lblResult.Text = "Display Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.chboxDiscount)
        Me.Controls.Add(Me.nudQuanti)
        Me.Controls.Add(Me.cmbMenu)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lblQuanti)
        Me.Controls.Add(Me.lblBev)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudQuanti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblBev As Label
    Friend WithEvents lblQuanti As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents nudQuanti As NumericUpDown
    Friend WithEvents chboxDiscount As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblResult As Label
End Class
