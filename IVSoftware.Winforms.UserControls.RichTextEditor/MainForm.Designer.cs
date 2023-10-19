namespace IVSoftware.Winforms.UserControls.RichTextEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            checkBoxReadOnly = new CheckBox();
            ucDocumentView = new DocumentView();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(checkBoxReadOnly, 0, 1);
            tableLayoutPanel.Controls.Add(ucDocumentView, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.Size = new Size(778, 1044);
            tableLayoutPanel.TabIndex = 0;
            // 
            // checkBoxReadOnly
            // 
            checkBoxReadOnly.Anchor = AnchorStyles.None;
            checkBoxReadOnly.Appearance = Appearance.Button;
            checkBoxReadOnly.Location = new Point(298, 982);
            checkBoxReadOnly.Name = "checkBoxReadOnly";
            checkBoxReadOnly.Size = new Size(182, 44);
            checkBoxReadOnly.TabIndex = 1;
            checkBoxReadOnly.Text = "🔒";
            checkBoxReadOnly.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // ucDocumentView
            // 
            ucDocumentView.BackColor = Color.DarkGray;
            ucDocumentView.Dock = DockStyle.Fill;
            ucDocumentView.IsReadOnly = false;
            ucDocumentView.Location = new Point(0, 0);
            ucDocumentView.Margin = new Padding(0);
            ucDocumentView.Name = "ucDocumentView";
            ucDocumentView.Padding = new Padding(5);
            ucDocumentView.Size = new Size(778, 964);
            ucDocumentView.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 1044);
            Controls.Add(tableLayoutPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private CheckBox checkBoxReadOnly;
        private DocumentView ucDocumentView;
    }
}