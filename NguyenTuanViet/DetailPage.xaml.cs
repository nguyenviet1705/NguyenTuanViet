namespace NguyenTuanViet;

public partial class DetailPage : ContentPage
{
	public DetailPage(ViewModel.DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}