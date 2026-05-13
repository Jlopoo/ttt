using Godot;
using System;
using System.Dynamic;

public partial class GameState : Node
{
	public static GameState Instance {get; private set;} = null!;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
		Instance = this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
