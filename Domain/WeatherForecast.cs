namespace Domain;

public class WeatherForecast
{
    public int Id { get; set;}

    public DateOnly Date { get; set;}

    public int TemperaturC { get; set;}

    public int TemperaturF => 32 + (int)(TemperaturC / 0.5556); 

    public string? Summary { get; set;}
}