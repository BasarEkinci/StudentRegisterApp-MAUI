using StudentApp.Persons;

namespace StudentApp;

public partial class MainPage : ContentPage
{
    public List<Child> ChildList = new List<Child>();

    private string? gender;
    private string? team;

    public MainPage()
    {
        InitializeComponent();
        ChildListView.ItemsSource = ChildList;
    }


    private void AddButton_Clicked(object sender, EventArgs e)
    {
        if (FemaleRadioButton.IsChecked)
        {
            gender = "Female";
        }
        else if (MaleRadioButton.IsChecked)
        {
            gender = "Male";
        }

        if (BallRadioButton.IsChecked)
        {
            team = "Football";
        }
        else if (BoatRadioButton.IsChecked)
        {
            team = "Boat";
        }

        ChildList.Add(new Child(NameEntry.Text,SurnameEntry.Text,gender,team));
    }

    private void ShowButton_Clicked(object sender, EventArgs e)
    {
        ChildListView.ItemsSource = null;
        ChildListView.ItemsSource = ChildList;
    }

    private async void ChildListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var Child = e.Item as Child;
        await DisplayAlert("Selected Student Information: ",$"Student Name: {Child.FullName}","OK");
    }
}