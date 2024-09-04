using System.Collections.ObjectModel;
using ImageAdder.Models;
using ImageAdder.Data;
namespace ImageAdder;

public partial class MainPage : ContentPage
{
	public string _imagePath;
	public ObservableCollection<ImageInfo> Images { get  ; set; }
	public MainPage()
	{
		InitializeComponent();
		Images = new ObservableCollection<ImageInfo>();
		BindingContext = this;
	}


	private async void OnSelectClicked(object sender, EventArgs e)
	{
		var image = await FilePicker.Default.PickAsync(new PickOptions
			{
    	PickerTitle = "Pick Image",
    	FileTypes = FilePickerFileType.Images
			});

if (image != null)
{
    _imagePath = image.FullPath.ToString();
    SelectedImage.Source = _imagePath;
}

	}

	private void OnAddClicked(object sender, EventArgs e)
	{
		ImageInfo NewImage = new ImageInfo()
		{
			Path_ = _imagePath,
			Title = ImageTitle.Text,
			Description = ImageDescription.Text
		};
		Images.Add(NewImage);

		_imagePath = string.Empty;
		ImageDescription.Text = string.Empty;
		ImageTitle.Text = string.Empty;
	}
}

