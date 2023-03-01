using Monkeys_Gallery.models;

namespace Monkeys_Gallery;

public partial class MainPage : ContentPage
{
	int count = 0;
    List<Monkey> monkeys = new List<Monkey> { };
    Monkey m;


    public MainPage()
	{
        
        
        AddMonkeys();
        m = monkeys[0];
        this.BindingContext = m;
        InitializeComponent();
	}

    public void AddMonkeys()
    {
        Monkey m1 = new Monkey("Baboon", "Africa & Asia", "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", 10000);
        monkeys.Add(m1);
        Monkey m2 = new Monkey("BaBoon", "Africa & Asia", "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", 10000);
        monkeys.Add(m2);


    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
    }

    private void LeftBtnClicked(object sender, EventArgs e)
    {
        if (count <= 0)
            left.IsEnabled = false;
        else
        {
            count--;
            m = monkeys[count];
            right.IsEnabled = true;
        }

    }

    private void RightBtnClicked(object sender, EventArgs e)
    {
        if (count >= monkeys.Count - 1)
            right.IsEnabled = false;
        else
        {
            count++;
            m = monkeys[count];
            left.IsEnabled = true;
        }

    }
}

