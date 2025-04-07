namespace LuckyNumberApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckyNumbers(object sender, EventArgs e)
	{
		AppName.IsVisible = false;
		LuckyNumberContainer.IsVisible = true;
		SortedSet<int> luckyNumbers = GenerateLuckyNumbers();
		LuckyNumber01.Text = luckyNumbers.ElementAt(0).ToString("D2");
		LuckyNumber02.Text = luckyNumbers.ElementAt(1).ToString("D2");
        LuckyNumber03.Text = luckyNumbers.ElementAt(2).ToString("D2");
        LuckyNumber04.Text = luckyNumbers.ElementAt(3).ToString("D2");
        LuckyNumber05.Text = luckyNumbers.ElementAt(4).ToString("D2");
        LuckyNumber06.Text = luckyNumbers.ElementAt(5).ToString("D2");
    }

	private static SortedSet<int> GenerateLuckyNumbers()
	{
		SortedSet<int> luckyNumbers = [];
		while (luckyNumbers.Count < 6)
		{
			luckyNumbers.Add(Random.Shared.Next(1, 60));
		}
		return luckyNumbers;
	}
}