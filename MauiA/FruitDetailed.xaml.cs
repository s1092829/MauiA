namespace MauiA;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string fruitName,string fruitImage, string fruitDescription)
	{
		InitializeComponent();
		showName.Text = fruitName;
		showImg.Source = fruitImage;
		showDescription.Text = fruitDescription;

	}
}