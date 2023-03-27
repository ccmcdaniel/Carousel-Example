using System.Collections.ObjectModel;

namespace Carousel_Example;

public partial class MainPage : ContentPage
{
	ObservableCollection<Monkey> Monkeys;
	public MainPage()
	{
		InitializeComponent();

		Monkeys = new ObservableCollection<Monkey>();

		Monkeys.Add(new Monkey 
		{ 
			Name = "Gorilla", 
			Location = "Africa", 
			Details = "Largest Living Primate!", 
			ImageUrl = "https://1.bp.blogspot.com/-aryflSrrJMU/XpUlIDxT4LI/AAAAAAAAQkQ/B9CdOynttLk413xu8NQdjjlDxSoASOFcACLcBGAsYHQ/s1600/gorillagrinning%2B%25282%2529.jpg" 
		});

		Monkeys.Add(new Monkey
		{
			Name = "Spider Monkey",
			Location = "Central and South America",
			Details = "Tiny little monkeys that can climb real well!",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Ateles_fusciceps_Colombia.JPG/330px-Ateles_fusciceps_Colombia.JPG"
		});

		Monkeys.Add(new Monkey
		{
			Name = "Orangutans",
			Location = "Indonesia and Malaysia",
			Details = "The orange Primate!",
			ImageUrl = "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSz2bHS0TH5_SeqWGt-w0y5V6G8sjptMnuuGWutJVz3Wlo1IdiNXPYKCEQG27z9FrPc_gDu_pYw00LuMmo"
		});

		Monkeys.Add(new Monkey
		{
			Name = "Chimpanzee",
			Location = "Indonesia and Malaysia",
			Details = "Everyone's favorite primate!",
			ImageUrl = "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcQePH8FuS_BidCVsH_NTUz1YRALIk7YSB6kWVF6OCi_3zFDDp_hSbLFG6-OOuqXD11TnC01pfvYumCUUvo"
		});

        Monkeys.Add(new Monkey
        {
            Name = "Mandrill",
            Location = "West Africa",
            Details = "“You’re a baboon, and I’m not.”",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Mandrill_Albert_September_2015_Zoo_Berlin_%282%29.jpg/800px-Mandrill_Albert_September_2015_Zoo_Berlin_%282%29.jpg"
        });

        layoutMonkeys.ItemsSource = Monkeys;

	}

}

