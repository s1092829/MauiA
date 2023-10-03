namespace MauiA
{
    public partial class MainPage : ContentPage
    {
        List<Fruit> list = new List<Fruit>()
            {
                new Fruit() { Name="Apple", Image="apple.png", Description="This is an apple"},
                new Fruit() { Name="Apricot", Image="apricot.png", Description="This is an Apricot"},
                new Fruit() { Name="Banana", Image="banana.png", Description="This is a Banana"},
                new Fruit() { Name="Coconut", Image="coconut.png", Description="This is a Coconut"},
                new Fruit() { Name="Grape", Image="grape.png", Description="This is a Grape"},
                new Fruit() { Name="Guava", Image="guava.png", Description="This is a Guava"},
                new Fruit() { Name="Kiwi", Image="kiwi.png", Description="This is a Kiwi"},
                new Fruit() { Name="Mango", Image="mango.png", Description="This is a Mango"},
                new Fruit() { Name="Melon", Image="Melon.png", Description="This is a Melon"},
                new Fruit() { Name="Orange", Image="orange.png", Description="This is an Orange"},
                new Fruit() { Name="Peach", Image="Peach.png", Description="This is a Peach"},
                new Fruit() { Name="Pear", Image="pear.png", Description="This is a Pear"},
                new Fruit() { Name="Pineapple", Image="pineapple.png", Description="This is a Pineapple"},
                new Fruit() { Name="Plum", Image="plum.png", Description="This is a Plum"},
                new Fruit() { Name="Pomegranate", Image="pomegranate.png", Description="This is a Pomegranate"},
                new Fruit() { Name="Strawbarry", Image="strawbarry.png", Description="This is a Strawbarry"},
                new Fruit() { Name="Watermelon", Image="watermelon.png", Description="This is a Watermelon"},
            };
        public MainPage()
        {
            
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;

            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.Image, selectedItem.Description));
            //DisplayAlert("Selected", selectedItem.Name, "OK");
            //((ListView)sender).SelectedItem = null;


        }
    }
}