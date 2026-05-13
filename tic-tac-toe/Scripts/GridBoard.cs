using Godot;
using System;
using System.Data;

public partial class GridBoard : Control
{
	[Export] public Button button1 { get; set; }
	[Export] public Button button2 { get; set; }
	[Export] public Button button3 { get; set; }
	[Export] public Button button4 { get; set; }
	[Export] public Button button5 { get; set; }
	[Export] public Button button6 { get; set; }
	[Export] public Button button7 { get; set; }
	[Export] public Button button8 { get; set; }
	[Export] public Button button9 { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();

		var table = new DataTable("Grid_Positions");
		table.Columns.Add("Position_Number", typeof(int));
		table.Columns.Add("Button", typeof(Button));
		table.Columns.Add("Player_Symbol", typeof(string));

		table.Rows.Add(1, button1, null);
		table.Rows.Add(2, button2, null);
		table.Rows.Add(3, button3, null);
		table.Rows.Add(4, button4, null);
		table.Rows.Add(5, button5, null);
		table.Rows.Add(6, button6, null);
		table.Rows.Add(7, button7, null);
		table.Rows.Add(8, button8, null);
		table.Rows.Add(9, button9, null);

		foreach (DataRow row in table.Rows)
		{
			Console.WriteLine(row["Position_Number"] + " " + row["Button"] + " " + row["Player_Symbol"]);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
