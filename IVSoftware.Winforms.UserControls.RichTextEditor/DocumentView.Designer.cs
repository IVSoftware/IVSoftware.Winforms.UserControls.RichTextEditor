

namespace IVSoftware.Winforms
{
    partial class DocumentView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
            radRichTextEditor = new Telerik.WinControls.UI.RadRichTextEditor();
            radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            radRichTextEditorRuler1 = new Telerik.WinControls.UI.RadRichTextEditorRuler();
            telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)richTextEditorRibbonBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radRichTextEditor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radRichTextEditorRuler1).BeginInit();
            radRichTextEditorRuler1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextEditorRibbonBar1
            // 
            richTextEditorRibbonBar1.AssociatedRichTextEditor = radRichTextEditor;
            richTextEditorRibbonBar1.BackColor = SystemColors.ControlLightLight;
            richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
            richTextEditorRibbonBar1.EnableKeyMap = false;
            richTextEditorRibbonBar1.Location = new Point(4, 4);
            richTextEditorRibbonBar1.Margin = new Padding(9);
            richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
            // 
            // 
            // 
            richTextEditorRibbonBar1.RootElement.ControlBounds = new Rectangle(5, 5, 400, 108);
            richTextEditorRibbonBar1.ShowLayoutModeButton = true;
            richTextEditorRibbonBar1.Size = new Size(792, 166);
            richTextEditorRibbonBar1.TabIndex = 0;
            richTextEditorRibbonBar1.TabStop = false;
            richTextEditorRibbonBar1.Text = "Content";
            richTextEditorRibbonBar1.ThemeName = "Fluent";
            // 
            // radRichTextEditor
            // 
            radRichTextEditor.BackColor = SystemColors.ControlLightLight;
            radRichTextEditor.BorderColor = Color.FromArgb(230, 230, 230);
            radRichTextEditor.CommentPaneMinWidth = 978.75D;
            radRichTextEditor.Dock = DockStyle.Fill;
            radRichTextEditor.IsReadOnly = true;
            radRichTextEditor.Location = new Point(29, 29);
            radRichTextEditor.Margin = new Padding(9);
            radRichTextEditor.Name = "radRichTextEditor";
            // 
            // 
            // 
            radRichTextEditor.RootElement.ControlBounds = new Rectangle(29, 29, 200, 200);
            radRichTextEditor.ScaleFactor = new SizeF(1.5F, 1.5F);
            radRichTextEditor.SelectionFill = Color.FromArgb(128, 214, 220, 190);
            radRichTextEditor.SelectionStroke = Color.LightGray;
            radRichTextEditor.Size = new Size(762, 896);
            radRichTextEditor.TabIndex = 0;
            radRichTextEditor.ThemeName = "TelerikMetro";
            // 
            // radRibbonFormBehavior1
            // 
            radRibbonFormBehavior1.Form = null;
            // 
            // radRichTextEditorRuler1
            // 
            radRichTextEditorRuler1.AssociatedRichTextBox = radRichTextEditor;
            radRichTextEditorRuler1.BackColor = SystemColors.ControlLightLight;
            radRichTextEditorRuler1.Controls.Add(radRichTextEditor);
            radRichTextEditorRuler1.Dock = DockStyle.Fill;
            radRichTextEditorRuler1.Location = new Point(4, 170);
            radRichTextEditorRuler1.Margin = new Padding(9);
            radRichTextEditorRuler1.Name = "radRichTextEditorRuler1";
            // 
            // 
            // 
            radRichTextEditorRuler1.RootElement.ControlBounds = new Rectangle(5, 171, 200, 200);
            radRichTextEditorRuler1.Size = new Size(792, 926);
            radRichTextEditorRuler1.TabIndex = 1;
            radRichTextEditorRuler1.ThemeName = "TelerikMetro";
            // 
            // DocumentView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radRichTextEditorRuler1);
            Controls.Add(richTextEditorRibbonBar1);
            Margin = new Padding(0);
            Name = "DocumentView";
            Padding = new Padding(4);
            Size = new Size(800, 1100);
            ((System.ComponentModel.ISupportInitialize)richTextEditorRibbonBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radRichTextEditor).EndInit();
            ((System.ComponentModel.ISupportInitialize)radRichTextEditorRuler1).EndInit();
            radRichTextEditorRuler1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadRichTextEditorRuler radRichTextEditorRuler1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        #endregion
    }
}
