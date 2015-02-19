import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

/**
 * Create class Snake
 */
public class Snake{
	LinkedList<Part> snakeBody = new LinkedList<Part>();
	private Color snakeColor;
	private int speedX, speedY;

    /**
     * Create constructor on class Snake
     */
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

    /**
     * This method draw snake on screnn
     * @param draw - accepts an object of type Graphics( object with all settings on screen)
     */
	public void drawSnake(Graphics draw) {
		for (Part point : this.snakeBody) {
			point.drawSnake(draw, snakeColor);
		}
	}

    /**
     * This method checks for the end of the game
     */
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

    /**
     * This method return speed on coordinate X in game
     * @return speed on coordinate X in game to int
     */
	public int getVelX() {
		return speedX;
	}

    /**
     * This method set speed on coordinate X in game
     * @param speedX - enter speed on coordinate X in game
     */
	public void setVelX(int speedX) {
		this.speedX = speedX;
	}

    /**
     * This method return speed on coordinate Y in game
     * @return speed on coordinate Y in game to int
     */
	public int getVelY() {
		return speedY;
	}

    /**
     * This method set speed on coordinate Y in game
     * @param speedY - enter speed on coordinate y in game
     */
	public void setVelY(int speedY) {
		this.speedY = speedY;
	}
}
