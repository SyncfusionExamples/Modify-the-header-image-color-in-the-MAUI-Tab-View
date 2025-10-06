using Syncfusion.Maui.Toolkit.TabView;

namespace TabViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSelectionChanged(object sender, TabSelectionChangedEventArgs e)
        {
            if (e.NewIndex >= 0 && e.OldIndex >= 0)
            {
                viewModel.TabItems[e.OldIndex].SelectedColor = Colors.Gray;
                viewModel.TabItems[e.NewIndex].SelectedColor = Colors.Red;
            }
        }
    }
}
