using System;

namespace Ch07;

class WaterHeater
{
    protected int temperature;

    public void SetTemperature(int temperature)
    {
        if (temperature < -5 || temperature > 42)
        {
            throw new Exception("Out of temperature range");
        }
        this.temperature = temperature;
    }

    internal void TurnOnWater()
    {
        Console.WriteLine(temperature);
    }
}
internal class AccessModifier
{
    static void MainAccessModifier(string[] args)
    {
        try
        {
            WaterHeater water = new();
            water.SetTemperature(20);
            water.TurnOnWater();

            water.SetTemperature(-2);
            water.TurnOnWater();

            water.SetTemperature(50);
            water.TurnOnWater();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
