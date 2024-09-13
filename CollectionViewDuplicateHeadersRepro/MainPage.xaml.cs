namespace CollectionViewDuplicateHeadersRepro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        if(MyCollectionView.Margin.Bottom != 0)
            MyCollectionView.Margin = new Thickness(0, 0, 0, 0);
        else
            MyCollectionView.Margin = new Thickness(0, 0, 0, 200);
    }
}