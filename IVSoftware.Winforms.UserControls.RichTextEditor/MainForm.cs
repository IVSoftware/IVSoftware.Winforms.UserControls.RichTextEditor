// IVSoftware Proprietary
// Copyright © 2023 IVSoftware, LLC and Thomas C. Gregor all rights reserved.



namespace IVSoftware.Winforms.UserControls.RichTextEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            checkBoxReadOnly.CheckedChanged += (sender, e) => ucDocumentView.IsReadOnly = checkBoxReadOnly.Checked;
            ucDocumentView.PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(ucDocumentView.IsReadOnly):
                        checkBoxReadOnly.ForeColor = ucDocumentView.IsReadOnly ? 
                            ucDocumentView.BackColor : 
                            Color.LimeGreen;
                        break;
                }
            };
            checkBoxReadOnly.Checked = true;
        }
    }
}