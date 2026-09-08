using System.Runtime.CompilerServices;
using HoboEngine.Graphics;
using Silk.NET.OpenGL;

namespace HoboEngine;

public class Engine
{
    public static void Main()
    {
        Window window = new Window("Hobo Engine", 1280, 720);
        Renderer renderer = null;

        window.OnLoad(gl =>
        {
            renderer = new Renderer(gl);
        });

        window.OnRender(deltaTime =>
        {
            if (renderer != null)
            {
                renderer.Clear();
            }
        });

        window.Run();        
    }
}
