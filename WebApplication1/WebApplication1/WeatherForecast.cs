namespace WebApplication1
{
    public class WeatherForecast
    {
        //public DateTime Date { get; set; }
        public String Id { get; set; }

        public String TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

       ///xóa flie
    }
}