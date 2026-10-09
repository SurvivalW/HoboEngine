using HoboEngine.Graphics;
using Silk.NET.OpenGL;

namespace HoboEngine;

public class HoboEngine
{
    private Window window;
    private Renderer? renderer;


    private string title;
    private int width;
    private int height;


    // Methods
    public Action? Start;
    public Action<double>? Update;
    public Action? FixedUpdate;
    public Action? LateUpdate;
    public Action? Render;


    // Fixed Update variables
    private double accumulator = 0.0;
    private double FixedTimeStep =  1.0 / 50.0;


    public HoboEngine(string title, int width, int height)
    {
        this.title = title;
        this.width = width;
        this.height = height;

        window = new Window(title, width, height);

        // ----- Setup and core loop -----
        window.OnLoad(gl =>
        {
            renderer = new Renderer(gl);
            Start?.Invoke();
        });

        window.OnUpdate(deltaTime =>
        {
            // -- Update --
            Update?.Invoke(deltaTime);

            // -- Fixed Update --
            accumulator += deltaTime;
            while(accumulator >= FixedTimeStep)
            {
                FixedUpdate?.Invoke();
                accumulator -= FixedTimeStep;
            }

            // -- Late Update --
            LateUpdate?.Invoke();
        });

        window.OnRender(deltaTime =>
        {
            if (renderer != null)
            {
                renderer.Clear();
                Render?.Invoke();
            }
        });  
    }
        //--------------------------------


    public void Run()
    {
        window.Run(); 
    }


}
