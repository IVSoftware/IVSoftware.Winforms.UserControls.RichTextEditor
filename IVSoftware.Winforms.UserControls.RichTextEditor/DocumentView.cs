// IVSoftware Proprietary
// Copyright © 2023 IVSoftware, LLC and Thomas C. Gregor all rights reserved.
using IVSoftware.Winforms.UserControls.RichTextEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace IVSoftware.Winforms
{
    public partial class DocumentView : UserControl, IDocumentView, INotifyPropertyChanged
    {
        public DocumentView()
        {
            InitializeComponent();
            BackColor = ReadOnlyBackColor;
        }

        public Color ReadOnlyBackColor => Color.DarkSlateGray;
        public Color EditingBackColor => Color.GreenYellow;

        public bool IsReadOnly
        {
            get => radRichTextEditor.IsReadOnly;
            set
            {
                if (!Equals(radRichTextEditor.IsReadOnly, value))
                {
                    radRichTextEditor.IsReadOnly = value;
                    OnPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            switch (propertyName)
            {
                case nameof(IsReadOnly):
                    OnIsReadOnlyChanged();
                    break;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnIsReadOnlyChanged()
        {
            BackColor = IsReadOnly ? ReadOnlyBackColor : EditingBackColor;
        }

        bool IDocumentView.SelectionBullet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IDocumentView.IsEmpty => throw new NotImplementedException();
        ICommand IDocumentView.AddHyperlinkCommand => throw new NotImplementedException();
        ICommand IDocumentView.CopyCommand => throw new NotImplementedException();
        ICommand IDocumentView.FocusCommand => throw new NotImplementedException();
        ICommand IDocumentView.PasteCommand => throw new NotImplementedException();
        ICommand IDocumentView.RevertCommand => throw new NotImplementedException();
        ICommand IDocumentView.SaveCommand => throw new NotImplementedException();
        ICommand IDocumentView.SelectAllCommand => throw new NotImplementedException();
        void IDocumentView.CreateNewDocument() => throw new NotImplementedException();
        Task IDocumentView.LoadQdrAsync(Record record, bool reload) => throw new NotImplementedException();
    }
}
