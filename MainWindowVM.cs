using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichNoteCore
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _documentTitle = "<<new document>>";

        public string DocumentTitle
        {
            get => _documentTitle;
            set
            {
                _documentTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DocumentTitle)));
            }
        }
    }
}
