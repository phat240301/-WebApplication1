Snamespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int Id { get; set; }

        public String TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}