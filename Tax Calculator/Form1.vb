Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PreTax, PerTax, DecTax, TaxVal, PostTax As Decimal
        PreTax = PreTaxBox.Text
        PerTax = PerTaxBox.Value
        DecTax = PerTax / 100
        TaxVal = (PreTax * DecTax)
        TaxVal = TaxVal.Round(TaxVal, 2)
        TaxValBox.Text = "£" & TaxVal
        PostTax = PreTax - TaxVal
        PostTaxBox.Text = "£" & PostTax


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
