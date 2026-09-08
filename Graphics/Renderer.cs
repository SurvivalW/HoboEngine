using Silk.NET.OpenGL;

namespace HoboEngine.Graphics;

public class Renderer
{
    private GL gl;

    public Renderer(GL gl)
    {
        this.gl = gl;
    }

    public void Clear()
    {
        gl.ClearColor(0.5f, 0.0f, 0.5f, 1.0f);
        gl.Clear(ClearBufferMask.ColorBufferBit);
    }
}