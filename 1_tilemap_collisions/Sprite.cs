// A Sprite class for keeping track of image and position data for our player.

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ytgame;

public class Sprite {

	public Texture2D texture;
	public Rectangle rect;
	public Rectangle srect;
	public Vector2 velocity;

	public Sprite(
		Texture2D texture,
		Rectangle rect,
		Rectangle srect
	) {
		this.texture = texture;
		this.rect = rect;
		this.srect = srect;
		velocity = new();
	}

	public void Update(KeyboardState keystate) {
		velocity = Vector2.Zero;
		velocity.Y = 5.0f;

		if (keystate.IsKeyDown(Keys.Right)) {
			velocity.X = 5;
		}
		if (keystate.IsKeyDown(Keys.Left)) {
			velocity.X = -5;
		}
		if (keystate.IsKeyDown(Keys.Up)) {
			velocity.Y = -5;
		}
		if (keystate.IsKeyDown(Keys.Down)) {
			velocity.Y = 5;
		}
	}

	public void Draw(SpriteBatch spriteBatch) {
		spriteBatch.Draw(
			texture,
			rect,
			srect,
			Color.White
		);
	}
}