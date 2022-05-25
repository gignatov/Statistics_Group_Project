using ExelReader;

namespace Statistics;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		this.BindingContext = this;
		InitializeComponent();
	}

	private void OnFileButtonClicked(object sender, EventArgs e)
	{
		InvalidPathLabel.IsVisible = false;

		try
        {
			StatisticsViewModel.PathToLogs = LogsEditor.Text;
			StatisticsViewModel.PathToResults = ResultsEditor.Text;
			StatisticsViewModel.PathToStudentResults = StudentResultsEditor.Text;
			StatisticsViewModel statisticsViewModel = new StatisticsViewModel();
			Menu newPage = new Menu();
			(App.Current.MainPage as NavigationPage).PushAsync(newPage);
		}
		catch (Exception ex)
		{
			if (ex is IOException || ex is ArgumentNullException)
			{
				InvalidPathLabel.IsVisible = true;
			}
			else
			{
				InvalidPathLabel.Text = "Невалидни данни";
				InvalidPathLabel.IsVisible = true;
			}
		}
	}
}

