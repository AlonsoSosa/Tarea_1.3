namespace Tarea_1._3.Views;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listemple.ItemsSource = await App.DatabasePerson.ListaPersonas();
    }

    private async void tooladd_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }

    private async void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Models.Persona person = (Models.Persona)e.CurrentSelection.FirstOrDefault();

        Modificar pag = new Modificar();
        pag.BindingContext = person;
        await Navigation.PushAsync(pag);
    }
}
