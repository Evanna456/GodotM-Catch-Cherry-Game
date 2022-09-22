using Godot;
using System;

public class FireBody : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	 Position = new Vector2(0,0);
	}

	public int movement_speed = 200;

	public Vector2 velocity = new Vector2();

	public override void _PhysicsProcess(float delta)
	{
		if (Position.y > 720){
			velocity.x = velocity.x + 1;
		  QueueFree();
		}
		
	   velocity = new Vector2();
	   velocity.y = velocity.y + 1;
	   velocity = velocity.Normalized() * movement_speed;
	   velocity = MoveAndSlide(velocity);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
