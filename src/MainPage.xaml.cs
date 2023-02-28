using CommunityToolkit.Maui.Core.Primitives;

namespace MauiMediaElementTesting;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPositionChanged(object sender, MediaPositionChangedEventArgs e)
	{
		var ePos = e.Position;
		var mediaPos = TheMediaElement.Position;
		var mediaDur = TheMediaElement.Duration;

		PosChangedEPosition.Text = $"{ePos.TotalSeconds} seconds";
		PosChangedMPosition.Text = $"{mediaPos.TotalSeconds} seconds";
		PosChangedMDuration.Text = $"{mediaDur.TotalSeconds} seconds";
	}

	private void OnStateChanged(object sender, MediaStateChangedEventArgs e)
	{
		var mediaPos = TheMediaElement.Position;
		var mediaDur = TheMediaElement.Duration;

		StateChangedMPosition.Text = $"{mediaPos.TotalSeconds} seconds";
		StateChangedMDuration.Text = $"{mediaDur.TotalSeconds} seconds";
	}

	private void OnContentPageUnloaded(object sender, EventArgs e)
	{
		TheMediaElement?.Handler?.DisconnectHandler();
	}
}

