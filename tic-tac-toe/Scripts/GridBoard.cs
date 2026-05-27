using Godot;
using System;
using System.Collections.Generic;

public partial class GridBoard : Control
{

	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	public Button button6;
	public Button button7;
	public Button button8;
	public Button button9;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();

		button1 = GetNode<Button>("Panel/GridContainer/Button1");
		button1.Pressed += OnButtonPressed;
		button2 = GetNode<Button>("Panel/GridContainer/Button2");
		button3 = GetNode<Button>("Panel/GridContainer/Button3");
		button4 = GetNode<Button>("Panel/GridContainer/Button4");
		button5 = GetNode<Button>("Panel/GridContainer/Button5");
		button6 = GetNode<Button>("Panel/GridContainer/Button6");
		button7 = GetNode<Button>("Panel/GridContainer/Button7");
		button8 = GetNode<Button>("Panel/GridContainer/Button8");
		button9 = GetNode<Button>("Panel/GridContainer/Button9");

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
/*
		foreach (var position in grid_positions)
		{
			GD.Print("Key: " + position.Key + " - Value: " + position.Value);
		}
*/
	}

	private void OnButtonPressed()
	{
		GD.Print("Button pressed");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
