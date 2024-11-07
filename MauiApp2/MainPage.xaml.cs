using Microsoft.Maui.Graphics.Text;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private Color _color;
        private string _hexValue;

        public MainPage()
        {
            InitializeComponent();
            _color = Colors.Black;
            Container.BackgroundColor = _color;
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = (int)(RedSlider.Value * 255);
            var green = (int)(GreenSlider.Value * 255);
            var blue = (int)(BlueSlider.Value * 255);
            _color = Color.FromRgb(red, green, blue);
            _hexValue = _color.ToHex();
            Container.BackgroundColor = _color;
            RedValueLabel.Text = $"{(float)(RedSlider.Value * 100)}";
            GreenValueLabel.Text = $"{(float)(GreenSlider.Value * 100)}";
            BlueValueLabel.Text = $"{(float)(BlueSlider.Value * 100)}";
        }

        private async void OnCopyClick(object sender, EventArgs e)
        {
            var red = (int)(RedSlider.Value * 255);
            var green = (int)(GreenSlider.Value * 255);
            var blue = (int)(BlueSlider.Value * 255);
            _color = Color.FromRgb(red, green, blue);
            _hexValue = _color.ToHex();
            ColorMaker.TextColor = _color;
            await Clipboard.SetTextAsync(_hexValue);
        }
    }
}
