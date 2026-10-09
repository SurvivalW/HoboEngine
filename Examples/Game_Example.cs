namespace HoboEngine;

class Game_Example
{
    static public void Main(string[] args)
    {
        HoboEngine engine = new HoboEngine("Game Example", 1280, 720);

        engine.Start = () =>
        {
            
        };


        engine.Update = (deltaTime) =>
        {
            
        };


        engine.Render = () =>
        {
            
        };

        engine.Run();
    }
}