namespace api.Services;

public interface IWeatherForecastService1 {
    // string[] summaries;
    bool GetWeatherForecast1();
    // prolly missing stuff in here
}

class WeatherForecastService1 : IWeatherForecastService1 
{
#region comments
// from above: 

// add imports
// import { useState } from 'react';

// namespace api.Services;

// refactor to move logic from program.cs lines 31-49 to its own file
// full file commented out due to errors

    // public summaries: string[]

    // constructor(summaries: string[]) {
    //     this.summaries = summaries;
    // }

    // public main init function
    //     call populateSummaries()
    //     call getWeatherForecast()

    // private populateSummaries() {
    //     this.summaries.concat
    //         ("Freezing", "Bracing", "Chilly", "Cool", 
    //             "Mild", "Warm", "Balmy", "Hot", "Sweltering", 
    //             "Scorching");
    // }
#endregion 
    
    // public summaries = new string[] {"Freezing", "Bracing", "Chilly", "Cool", 
    //             "Mild", "Warm", "Balmy", "Hot", "Sweltering", 
    //             "Scorching"};
    
    //TODO: figure out return type
    public bool GetWeatherForecast1() {  
        // this.summaries.concat
        var summaries = new string[] {"Freezing", "Bracing", "Chilly", "Cool", 
                "Mild", "Warm", "Balmy", "Hot", "Sweltering", 
                "Scorching"};

        var forecast =  Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray();
        // return forecast;
        if (forecast != null) {
            return true;
        } else {
            return false;
        }
    }
}

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}