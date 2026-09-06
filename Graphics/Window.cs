using Silk.NET.Windowing;
using Silk.NET.Maths;

namespace HoboEngine.Graphics;

public class Window
{
    private IWindow window;

    public Window(string title, int width, int height)
    {
        WindowOptions options = WindowOptions.Default;

        options.Title = title;
        options.Size = new Vector2D<int>(width, height);

        window = Silk.NET.Windowing.Window.Create(options);
    }

    public void Run()
    {
        window.Run();
    }

    public void Close()
    {
        window.Close();
    }
}