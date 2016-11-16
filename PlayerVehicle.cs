using System;
using SwinGameSDK;

namespace MyGame
{
	public class PlayerVehicle
	{
		private double _x, _y;
		private double lastposX, lastposY;
		private bool jumping;

		public PlayerVehicle(double x,double y)
		{
			_x = x;
			_y = y;
			lastposX = x;
			lastposY = y;
			jumping = false;
		}

		public void Jump () {
			this.lastposX = X;
			this.lastposY = Y;
			this.X = 900;
			jumping = true;
		}

		public void UnJump () {
			this.X = lastposX;
			this.Y = lastposY;
			jumping = false;
		}

		public void NavigateForward () 
		{
			if (this.Y > 20)
			{
				this.Y -= 95;
			}
		}

		public void NavigateBackwards () 
		{
			if (this.Y < 570)
			{
				this.Y += 95;
			}
		}

		public void NavigateLeft ()
		{
			if (this.X > 400)
			{
				this.X -= 95;
			}
		}

		public void NavigateRight ()
		{
			if (this.X < 480)
			{
				this.X += 95;
			}
		}
			

		//public void SlowDown ()
		//{
			//this.Y -= 40;
		//}

		public void Draw ()
		{
			if (jumping)
			{
				SwinGame.DrawRectangle (Color.Transparent, (float)lastposX, (float)lastposY, 100, 100);
				SwinGame.DrawBitmap ("jump.png", (float)lastposX, (float)lastposY);
			}
			else
			{
				SwinGame.DrawRectangle (Color.Transparent, (float)X, (float)Y, 80, 80);
				SwinGame.DrawBitmap ("player.png", (float)X, (float)Y);
			}
		}
			

		public double X
		{
			get{ return _x; }
			set{ _x = value; }

		}

		public double Y
		{
			get{ return _y; }
			set{ _y = value; }

		}

		public bool Jumping
		{
			get
			{
				return jumping;
			}
			set
			{
				jumping = value;
			}
		}
	}
}

