Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class welcomeForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            OpenFileDialog1.InitialDirectory = FolderBrowserDialog1.SelectedPath
            Button2.Enabled = True
            Me.Text = "MMS Reader (" + FolderBrowserDialog1.SelectedPath + ")"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim json As String

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox2.Text = OpenFileDialog1.FileName

            json = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.Default)
            Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

            Label14.Text = read.Item("document").ToString
            Label15.Text = read.Item("companyName").ToString
            Label16.Text = read.Item("address").ToString
            Label17.Text = read.Item("purchaseFrom")("vendorName").ToString
            Label18.Text = read.Item("purchaseFrom")("address").ToString
            Label19.Text = read.Item("shipTo")("companyName").ToString
            Label20.Text = read.Item("shipTo")("address").ToString
            Label21.Text = read.Item("poNumber").ToString
            Label22.Text = read.Item("poDate").ToString
            Label23.Text = read.Item("items")(0)("itemDescription").ToString
            Label24.Text = read.Item("requiredByDate").ToString
            Label37.Text = read.Item("shipTo")("contactName").ToString
            Label38.Text = read.Item("purchaseFrom")("contactName").ToString
            Label39.Text = read.Item("purchaseFrom")("vendorID").ToString
            Label40.Text = read.Item("approvedBy").ToString
            Label41.Text = read.Item("paymentTerms").ToString
            Label42.Text = read.Item("orderTotal").ToString
            Label43.Text = read.Item("salesTax").ToString
            Label44.Text = read.Item("subtotal").ToString
            Label45.Text = read.Item("items")(0)("amount").ToString
            Label46.Text = read.Item("items")(0)("unitPrice").ToString
            Label47.Text = read.Item("items")(0)("quantity").ToString
            Label48.Text = read.Item("shippingMethod").ToString


            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label37.Visible = True
            Label38.Visible = True
            Label39.Visible = True
            Label40.Visible = True
            Label41.Visible = True
            Label42.Visible = True
            Label43.Visible = True
            Label44.Visible = True
            Label45.Visible = True
            Label46.Visible = True
            Label47.Visible = True
            Label48.Visible = True


        End If
    End Sub

End Class
