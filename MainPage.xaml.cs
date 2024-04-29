namespace Application1;

public partial class MainPage : ContentPage
{
	public List<NameSurname> NameSurnameList = new List<NameSurname>();

	public MainPage()
	{
		InitializeComponent();
	}


    private void Add_Button_Clicked(object sender, EventArgs e)
    {
       
        NameSurnameList.Add(new NameSurname(StuName.Text, StuSurname.Text, PhoneNum.Text));
    }

    private void Show_Button_Clicked(object sender, EventArgs e)
    {
        Name_Surname_View.ItemsSource = null;

        Name_Surname_View.ItemsSource = NameSurnameList;
    }
}

