using EditForm.Data;

namespace EditForm.Services
{
    public class WeatherForecastService
    {
        public WeatherForecastService()
        {
                
        }

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {

            // Simulate asynchronous loading to demonstrate a loading indicator
            await Task.Delay(500);

            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();
        }
    }
}
