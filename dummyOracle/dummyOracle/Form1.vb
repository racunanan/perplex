Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            OpenFileDialog1.InitialDirectory = FolderBrowserDialog1.SelectedPath
            Button2.Enabled = True
            Me.Text = "Oracle Reader (" + FolderBrowserDialog1.SelectedPath + ")"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim json As String

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox2.Text = OpenFileDialog1.FileName

            json = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.Default)
            Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

            Label14.Text = read.Item("type").ToString
            Label15.Text = read.Item("supplier").ToString
            Label16.Text = read.Item("shipTo").ToString
            Label17.Text = read.Item("site").ToString
            Label18.Text = read.Item("PO").ToString
            Label19.Text = read.Item("created").ToString
            Label20.Text = read.Item("items")(0)("num").ToString
            Label21.Text = read.Item("items")(0)("item").ToString
            Label22.Text = read.Item("items")(0)("description").ToString
            Label23.Text = read.Item("items")(0)("UOM").ToString
            Label24.Text = read.Item("items")(0)("needBy").ToString
            Label37.Text = read.Item("items")(0)("rev").ToString
            Label38.Text = read.Item("items")(0)("type").ToString
            Label39.Text = read.Item("currency").ToString
            Label40.Text = read.Item("contact").ToString
            Label41.Text = read.Item("pCard").ToString
            Label42.Text = read.Item("status").ToString
            Label43.Text = read.Item("billTo").ToString
            Label44.Text = read.Item("rev").ToString
            Label45.Text = read.Item("operatingUnit").ToString
            Label46.Text = read.Item("description").ToString
            Label47.Text = read.Item("buyer").ToString
            Label48.Text = read.Item("items")(0)("quantity").ToString
            Label49.Text = read.Item("items")(0)("job").ToString
            Label52.Text = read.Item("items")(0)("category").ToString
            Label53.Text = read.Item("items")(0)("price").ToString
            Label56.Text = read.Item("items")(0)("promised").ToString
            Label57.Text = read.Item("items")(0)("amount").ToString
            Label60.Text = read.Item("items")(0)("supplierItem").ToString
            Label61.Text = read.Item("total").ToString
            Label64.Text = read.Item("items")(0)("chargeAccount").ToString
            Label66.Text = read.Item("items")(0)("supplierConfigID").ToString

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
            Label49.Visible = True
            Label52.Visible = True
            Label53.Visible = True
            Label56.Visible = True
            Label57.Visible = True
            Label60.Visible = True
            Label61.Visible = True
            Label64.Visible = True
            Label66.Visible = True


        End If
    End Sub
End Class
