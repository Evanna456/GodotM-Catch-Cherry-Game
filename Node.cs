using Godot;
using System;
using System.Threading.Tasks;

public class Node : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{		
		var Evanna = GD.Load<PackedScene>("res://characters/Evanna.tscn");
		var evanna_instance = Evanna.Instance();
		AddChild(evanna_instance);
		
		generateFire();
		generateCherry();
	}
	
	
	public async Task generateFire()
{
	
   while (true)
   {
	  var delayTask = Task.Delay(300);
	  	 var scene = GD.Load<PackedScene>("res://Fire.tscn");
		var instance = scene.Instance();
		AddChild(instance);
	  await delayTask;
   }
}

	public async Task generateCherry()
{
	
   while (true)
   {
	  var delayTask = Task.Delay(400);
	  	 var Cherry = GD.Load<PackedScene>("res://objects/Cherry.tscn");
		var cherry_instance = Cherry.Instance();
		AddChild(cherry_instance);
	  await delayTask; 
   }
}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
