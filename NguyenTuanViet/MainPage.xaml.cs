namespace NguyenTuanViet
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(ViewModel.MainViewModel vm)
        {
            InitializeComponent();
            BindingContext =    vm;
        }

       
    }
}
