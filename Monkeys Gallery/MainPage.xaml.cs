using Monkeys_Gallery.models;
using System.Collections.ObjectModel;

namespace Monkeys_Gallery;

public partial class MainPage : ContentPage
{
	int count = 0;
    List<Monkey> monkeys  { get; set; }
    private Monkey monkey;
    public Monkey Monkey { get => monkey; set { if (value != monkey) { monkey = value; OnPropertyChanged("Monkey"); } } }



    public MainPage()
	{
        monkeys = new List<Monkey> { };
        monkey = new Monkey("Baboon", "Africa & Asia", "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", 10000);
        monkeys.Add(monkey);
        AddMonkeys();
        InitializeComponent();
        this.BindingContext = this;
    }

    public void AddMonkeys()
    {
        Monkey m1 = new Monkey("Capuchin Monkey", "Central & South America", "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg", 23000);
        monkeys.Add(m1);
        Monkey m2 = new Monkey("Blue Monkey", "Central and East Africa", "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg", 12000);
        monkeys.Add(m2);
        Monkey m3 = new Monkey("Squirrel Monkey", "Central & South America", "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/saimiri.jpg", 11000);
        monkeys.Add(m3);


    }



    private void LeftBtnClicked(object sender, EventArgs e)
    {
        if (count <= 0)
            left.IsEnabled = false;
        else
        {
            count--;
            Monkey = monkeys[count];
            OnPropertyChanged("Monkey");
            right.IsEnabled = true;
            if (count <= 0)
                left.IsEnabled = false;
        }

    }

    private void RightBtnClicked(object sender, EventArgs e)
    {
        if (count >= monkeys.Count - 1)
            right.IsEnabled = false;
        else
        {
            count++;
            Monkey= monkeys[count];
            OnPropertyChanged("Monkey");
            left.IsEnabled = true;
            if (count >= monkeys.Count - 1)
                right.IsEnabled = false;
        }

    }

    private void DetailsClicked(object sender, EventArgs e)
    {
        Button b = sender as Button;
        if (b.Text == "More details")
        {
            details.IsVisible = false;
            hide.IsVisible = true;
            detailsgrid.IsVisible = true;
        }
        else
        {
            details.IsVisible = true;
            hide.IsVisible = false;
            detailsgrid.IsVisible = false;
        }

    }
}

