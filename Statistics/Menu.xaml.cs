namespace Statistics;

public partial class Menu : ContentPage
{
	public Menu()
	{
		StatisticsViewModel.ClearAll();
		this.BindingContext = this;
		InitializeComponent();
	}

	private void AbsoluteFrequencyButtonClicked(object sender, EventArgs e)
    {
		AbsoluteFrequency newPage = new AbsoluteFrequency();
		(App.Current.MainPage as NavigationPage).PushAsync(newPage);
	}

	private void RelativeFrequencyButtonClicked(object sender, EventArgs e)
	{
		RelativeFrequency newPage = new RelativeFrequency();
		(App.Current.MainPage as NavigationPage).PushAsync(newPage);
	}

	private void MedianButtonClicked(object sender, EventArgs e)
    {
		if (StatisticsViewModel.Median == StatisticsViewModel.NOT_INITIALIZED)
        {
			StatisticsViewModel.LoadMedian();
        }
		ResultLabel.Text = StatisticsViewModel.Median.ToString();
		ResultLabel.IsVisible = true;
	}

	private void ModeButtonClicked(object sender, EventArgs e)
    {
		Mode newPage = new Mode();
		(App.Current.MainPage as NavigationPage).PushAsync(newPage);
	}

	private void AverageButtonClicked(object sender, EventArgs e)
	{
		if (StatisticsViewModel.Average == StatisticsViewModel.NOT_INITIALIZED)
        {
			StatisticsViewModel.LoadAverage();
        }
		ResultLabel.Text = StatisticsViewModel.Average.ToString();
		ResultLabel.IsVisible = true;
	}

	private void DispersionButtonClicked(object sender, EventArgs e)
	{
		if (StatisticsViewModel.Dispersion == StatisticsViewModel.NOT_INITIALIZED)
		{
			StatisticsViewModel.LoadDispersion();
		}
		ResultLabel.Text = StatisticsViewModel.Dispersion.ToString();
		ResultLabel.IsVisible = true;
	}

	private void StandardDeviationButtonClicked(object sender, EventArgs e)
	{
		if (StatisticsViewModel.StandardDeviation == StatisticsViewModel.NOT_INITIALIZED)
		{
			StatisticsViewModel.LoadStandardDeviation();
		}
		ResultLabel.Text = StatisticsViewModel.StandardDeviation.ToString();
		ResultLabel.IsVisible = true;
	}

	private void SwingButtonClicked(object sender, EventArgs e)
	{
		if (StatisticsViewModel.Swing == StatisticsViewModel.NOT_INITIALIZED)
		{
			StatisticsViewModel.LoadSwing();
		}
		ResultLabel.Text = StatisticsViewModel.Swing.ToString();
		ResultLabel.IsVisible = true;
	}

	private void CorrelationButtonClicked(object sender, EventArgs e)
    {
		if (StatisticsViewModel.Correlation == StatisticsViewModel.NOT_INITIALIZED)
        {
			StatisticsViewModel.LoadCorrelation();
        }
		ResultLabel.Text = StatisticsViewModel.Correlation.ToString();
		ResultLabel.IsVisible = true;
	}

	private void SummaryButtonClicked(object sender, EventArgs e)
	{
		DataSummary newPage = new DataSummary();
		(App.Current.MainPage as NavigationPage).PushAsync(newPage);
	}
}