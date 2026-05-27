using Godot;
using System;

public partial class PlayerController : Node2D
{

	public Vector2 lastMousePosition;
    public Vector2 currentMousePosition;
	public Color mouseCircleColor = new Color(1, 0, 0, 1);
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
		lastMousePosition = GetGlobalMousePosition();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		base._Process(delta);
		currentMousePosition = GetGlobalMousePosition();
		if (lastMousePosition != currentMousePosition)
		{
			lastMousePosition = currentMousePosition;
			QueueRedraw();
		}
	}

	public void _Draw()
	{
		base._Draw();
		DrawCircle(lastMousePosition, 10, mouseCircleColor);
	}

    public override void _UnhandledInput(InputEvent inputEvent)
    {
        base._UnhandledInput(inputEvent);
        if (inputEvent is InputEventMouseButton mouseButtonEvent && mouseButtonEvent.ButtonIndex == MouseButton.Left)
        {
            mouseCircleColor = new Color(0, 1, 0, 1);
            QueueRedraw();
        }
        else 
        {
            mouseCircleColor = new Color(1, 0, 0, 1);
            QueueRedraw();
        }
    }
}
