Imports System
Imports GemBox.Pdf
Imports GemBox.Pdf.Forms

Module Program
    Sub Main(args As String())
        ComponentInfo.SetLicense("FREE-LIMITED-KEY")
        TestNullRefenceException()

        Console.WriteLine("Done!")
    End Sub



    Function TestNullRefenceException() As Integer
        Using document = PdfDocument.Load("..\..\..\Antrag.pdf")
            'Test with CR LF and CRLF

            Dim new_Test As String = "Greg Tester"
            'fill Textfeld 1 which shows the error
            Dim formField As PdfField = document.Form.Fields("Textfeld 1")
            Dim tmp As PdfTextField = formField
            tmp.Value = new_Test

            document.Save("..\..\..\Antrag_Filled.pdf")
            document.Close()
        End Using
        Return 0
    End Function

End Module
