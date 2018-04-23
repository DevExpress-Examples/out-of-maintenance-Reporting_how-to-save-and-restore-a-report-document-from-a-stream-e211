#region #reference
using System;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
//...
#endregion #reference

namespace docSaveLoadPrintDocument {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
// Create a MemoryStream instance.
MemoryStream stream = new MemoryStream();

private void button1_Click(object sender, EventArgs e) {
    // Create a report instance.
    XtraReport1 report = new XtraReport1();

    // Generate a report document.
    report.CreateDocument();
            
    // Save a report document to a stream.
    report.PrintingSystem.SaveDocument(stream);
}

private void button2_Click(object sender, EventArgs e) {
    // Create a PrintingSystem instance.
    PrintingSystemBase ps = new PrintingSystemBase();
            
    // Load the document from a stream.
    ps.LoadDocument(stream);

    // Create an instance of the preview dialog.
    PrintPreviewFormEx preview = new PrintPreviewFormEx();

    // Load the report document into it.
    preview.PrintingSystem = ps;

    // Show the preview dialog.
    preview.ShowDialog();
}
#endregion #code
    }
}