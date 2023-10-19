using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IVSoftware.Winforms.UserControls.RichTextEditor
{
    interface IDocumentView
    {
        void CreateNewDocument();
        Task LoadQdrAsync(Record record, bool reload);
        bool SelectionBullet { get; set; }
        bool IsReadOnly { get; set; }
        bool IsEmpty { get; }
        ICommand AddHyperlinkCommand { get; }
        ICommand CopyCommand { get; }
        ICommand FocusCommand { get; }
        ICommand PasteCommand { get; }
        ICommand RevertCommand { get; }
        ICommand SaveCommand { get; }
        ICommand SelectAllCommand { get; }
    }
}
