using Godot;
using System;
using System.Collections.Generic;

public partial class GridBoard : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();

		Dictionary<int, string> grid_positions = new Dictionary<int, string>();

		grid_positions.Add(1, "open");
		grid_positions.Add(2, "open");
		grid_positions.Add(3, "open");
		grid_positions.Add(4, "open");
		grid_positions.Add(5, "open");
		grid_positions.Add(6, "open");
		grid_positions.Add(7, "open");
		grid_positions.Add(8, "open");
		grid_positions.Add(9, "open");

		foreach (var position in grid_positions)
		{
			GD.Print("Key: " + position.Key + " - Value: " + position.Value);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
