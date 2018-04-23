#Region "#reference"
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
'...
#End Region

Namespace docSaveLoadPrintDocument
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#code"
        ' Create a MemoryStream instance.
        Private stream As New MemoryStream()

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' Create a report instance.
            Dim report As New XtraReport1()

            ' Generate a report document.
            report.CreateDocument()

            ' Save a report document to a stream.
            report.PrintingSystem.SaveDocument(stream)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            ' Create a PrintingSystem instance.
            Dim ps As New PrintingSystemBase()

            ' Load the document from a stream.
            ps.LoadDocument(stream)

            ' Create an instance of the preview dialog.
            Dim preview As New PrintPreviewFormEx()

            ' Load the report document into it.
            preview.PrintingSystem = ps

            ' Show the preview dialog.
            preview.ShowDialog()
        End Sub
#End Region
    End Class
End Namespace