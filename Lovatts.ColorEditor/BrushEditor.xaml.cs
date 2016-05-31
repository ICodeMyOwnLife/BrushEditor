using System.Windows.Controls;
using BrushEditor;

namespace Lovatts.ColorEditor
{
    /// <summary>
    /// Interaction logic for BrushEditor.xaml
    /// </summary>
    public partial class BrushEditor : UserControl
    {
        private BrushEditorViewModel _brushEditorViewModel;

        public BrushEditor()
        {
            InitializeComponent();
            
            BrushEditorViewModel = new BrushEditorViewModel();
            BrushEditorViewModel.ColorEditorViewModel = colorEditor.ColorEditorViewModel;            
        }

        public BrushEditorViewModel BrushEditorViewModel
        {
            get { return _brushEditorViewModel; }
            set { 
                _brushEditorViewModel = value;

                this.DataContext = _brushEditorViewModel;

                // Should probably implement INotifyPropertyChanged
            }
        }
    }
}