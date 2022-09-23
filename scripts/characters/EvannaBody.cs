using Godot;
using System;

public class EvannaBody : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	 Position = new Vector2(0,280);
	}
	
	public int movement_speed = 200;

	public Vector2 velocity = new Vector2();

	
	   public void GetInput()
	   {
		velocity = new Vector2();

		if (Input.IsActionPressed("ui_right") == true){
			GetNode<Sprite>("/root/Node2D/Evanna/EvannaBody/Sprite").Texture = ResourceLoader.Load("res://assets/Evanna.png") as Texture;
			velocity.x = velocity.x + 1;
		}

		if (Input.IsActionPressed("ui_left") == true){
		   GetNode<Sprite>("/root/Node2D/Evanna/EvannaBody/Sprite").Texture = ResourceLoader.Load("res://assets/Evanna_Inverted.png") as Texture;
			velocity.x = velocity.x - 1;

		}

		velocity = velocity.Normalized() * movement_speed;
	
		
	}
	
	 public override void _PhysicsProcess(float delta)
	{
		GetInput();
		velocity = MoveAndSlide(velocity);

	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
