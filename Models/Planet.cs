namespace MauiPlanets.Models
{
    public class Planet
    {
        public string Name { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string HeroImage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Color AccentColorStart { get; set; } = Colors.Transparent;
        public Color AccentColorEnd { get; set; } = Colors.Transparent;
        public List<string> Images { get; set; } = new List<string>();

        public Brush Background
        {
            get
            {
                var gradientStops = new GradientStopCollection();
                gradientStops.Add(new GradientStop(AccentColorStart, 0.0f));
                gradientStops.Add(new GradientStop(AccentColorEnd, 1.0f));

                var bgBrush = new LinearGradientBrush(
                    gradientStops,
                    new Point(0.0, 0.0),
                    new Point(1.0, 1.0));

                return bgBrush;
            }
        }
    }
}