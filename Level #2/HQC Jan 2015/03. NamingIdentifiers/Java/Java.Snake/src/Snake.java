import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

public class Snake{
	LinkedList<Part> snakeBody = new LinkedList<Part>();
	private Color snakeColor;
	private int speedX, speedY;
	
	public Snake() {
		snakeColor = Color.GREEN;
		snakeBody.add(new Part(300, 100)); 
		snakeBody.add(new Part(280, 100)); 
		snakeBody.add(new Part(260, 100)); 
		snakeBody.add(new Part(240, 100)); 
		snakeBody.add(new Part(220, 100)); 
		snakeBody.add(new Part(200, 100)); 
		snakeBody.add(new Part(180, 100));
		snakeBody.add(new Part(160, 100));
		snakeBody.add(new Part(140, 100));
		snakeBody.add(new Part(120, 100));

		speedX = 20;
		speedY = 0;
	}
	
	public void drawSnake(Graphics draw) {
		for (Part point : this.snakeBody) {
			point.drawSnake(draw, snakeColor);
		}
	}
	
	public void tick() {
		Part newPartPosition = new Part((snakeBody.get(0).getX() + speedX), (snakeBody.get(0).getY() + speedY));
		
		if (newPartPosition.getX() > Game.WIDTH - 20) {
		 	Game.gameRunning = false;
		} else if (newPartPosition.getX() < 0) {
			Game.gameRunning = false;
		} else if (newPartPosition.getY() < 0) {
			Game.gameRunning = false;
		} else if (newPartPosition.getY() > Game.height - 20) {
			Game.gameRunning = false;
		} else if (Game.apple.getPart().equals(newPartPosition)) {
			snakeBody.add(Game.apple.getPart());
			Game.apple = new Apple(this);
			Game.score += 50;
		} else if (snakeBody.contains(newPartPosition)) {
			Game.gameRunning = false;
			System.out.println("You ate yourself");
		}	
		
		for (int i = snakeBody.size()-1; i > 0; i--) {
			snakeBody.set(i, new Part(snakeBody.get(i-1)));
		}	
		snakeBody.set(0, newPartPosition);
	}

	public int getVelX() {
		return speedX;
	}

	public void setVelX(int speedX) {
		this.speedX = speedX;
	}

	public int getVelY() {
		return speedY;
	}

	public void setVelY(int speedY) {
		this.speedY = speedY;
	}
}
