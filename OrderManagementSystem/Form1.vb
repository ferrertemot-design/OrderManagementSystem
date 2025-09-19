Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        If String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Please enter Customer Name", "Missing Information")
                Return
            End If
            If cmbMenu.SelectedIndex = -1 Then
                MessageBox.Show("Please select a beverage", "Missing Selection")
                Return
            End If
            If nudQuanti.Value <= 0 Then
                MessageBox.Show("Please enter a valid quantity (1 or more)", "Invalid Quantity")
                Return
            End If

            Dim selectedBeverage As String = cmbMenu.SelectedItem.ToString()
            Dim price As Decimal = 0

            If selectedBeverage = "Espresso" Then
                price = 120
            ElseIf selectedBeverage = "Latte" Then
                price = 150
            ElseIf selectedBeverage = "Cappuccino" Then
                price = 160
            ElseIf selectedBeverage = "Americano" Then
                price = 130
            ElseIf selectedBeverage = "Mocha" Then
                price = 170
            End If

            Dim quantity As Integer = nudQuanti.Value
            Dim subtotal As Decimal = price * quantity
            Dim discountAmount As Decimal = 0
            Dim finalTotal As Decimal = subtotal

            If chboxDiscount.Checked Then
                discountAmount = subtotal * 0.1
                finalTotal = subtotal - discountAmount
            End If
            lblSub.Text = subtotal.ToString() & "PHP"
            lblDiscount.Text = discountAmount.ToString() & "PHP"
            lblResult.Text = lblTotal.ToString() & "PHP"

        MessageBox.Show("Your Total is: " & finalTotal.ToString & "", "Thank you " & txtName.Text & "!")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSub.Text = "0.00PHP"
        lblDiscount.Text = "0.00PHP"
        lblResult.Text = "0.00PHP"
        nudQuanti.Value = 1
    End Sub
End Class
