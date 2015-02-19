import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

/**
 * Create class Apple
 */
public class Apple {
	public static Random rnd;
	private Part apple;
	private Color snakeColor;

    /**
     * Create constructor Apple
     * @param snake - accepts an object of type Snake
     */
	public Apple(Snake snake) {
		apple = createApple(snake);
		snakeColor = Color.RED;		
	}

    /**
     * This method create apple on random position
     * @param snake - accepts an object of type Snake
     * @return object of type Part
     */
	private Part createApple(Snake snake) {
		rnd = new Random();
		int x = rnd.nextInt(30) * 20; 
		int y = rnd.nextInt(30) * 20;
		for (Part snakePoint : snake.body) {
			if (x == snakePoint.getX() || y == snakePoint.getY()) {
				return createApple(snake);
			}
		}
		return new Part(x, y);
	}

    /**
     * This method draw apple on screen
     * @param draw - accepts an object of type Graphics( object with all settings on screen)
     */
	public void drawApple(Graphics draw){
		apple.drawSnake(draw, snakeColor);
	}

    /**
     * This method return object of type Apple
     * @return - object of type Apple
     */
	public Part getPoint(){
		return apple;
	}
}
