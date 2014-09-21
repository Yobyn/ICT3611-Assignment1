Module PrintData
    Friend TextToBePrinted As String

    Public Sub printData(ByVal text As String, ByVal printer As String)
        TextToBePrinted = text
        Dim printdoc As New Printing.PrintDocument
        Using (printdoc)
            printdoc.PrinterSettings.PrinterName = printer
            AddHandler printdoc.PrintPage, AddressOf PrintPageHandler
            printdoc.Print()
            RemoveHandler printdoc.PrintPage, AddressOf PrintPageHandler
        End Using
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim myFont As New Font("Arial", 12)
        args.Graphics.DrawString(TextToBePrinted, New Font(myFont, FontStyle.Regular), Brushes.Black, 60, 60)
    End Sub
End Module
