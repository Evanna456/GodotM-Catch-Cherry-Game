using Godot;
using System;

public class CherryBody : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	 Random rnd = new Random();
	 float position_x = rnd.Next(-1280, 1280);
	 Position = new Vector2(position_x,-720);
	}

	public int movement_speed = 200;
	
	public Vector2 velocity = new Vector2();
	
		private void _on_Area2D_body_entered(object body)
{
	 var player = GetNode<PlayerVariables>("/root/PlayerVariables");
		 player.score = player.score + 20;
		 QueueFree();
}
	
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



