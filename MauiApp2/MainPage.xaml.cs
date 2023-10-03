namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        List<Fruit> list = new List<Fruit>()
            {
                new Fruit(){ Name="Apple", Image ="apple.png",Description="This is an apple"},
                new Fruit(){ Name="Orange", Image ="orange.png",Description="This is an Orange"},
                new Fruit(){ Name="Banana", Image ="banana.png",Description="This is a Banana"},
                new Fruit(){ Name="Kiwi", Image ="kiwi.png",Description="This is a Kiwi"},
                new Fruit(){ Name="Strawberry", Image ="strawberry.png",Description="This is a Strawberry"},
                new Fruit(){ Name="Pineapple", Image ="pineapple.png",Description="This is a Pineapple"},
                new Fruit(){ Name="Watermelon", Image ="watermelon.png",Description="This is a Watermelon"},
                new Fruit(){ Name="Grapes", Image ="grape.png",Description="These are Grapes"},
                new Fruit(){ Name="Apricot", Image ="apricot.png",Description="This is an Apricot"},
                new Fruit(){ Name="Coconut", Image ="coconut.png",Description="This is a Coconut"},
                new Fruit(){ Name="Guava", Image ="guava.png",Description="This is a Guava"},
                new Fruit(){ Name="Mango", Image ="mango.png",Description="This is a Mango"},
            };
        public MainPage()
        { 
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }
        private void FruitListView_ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.Image, selectedItem.Description));
        }
        
    }
}