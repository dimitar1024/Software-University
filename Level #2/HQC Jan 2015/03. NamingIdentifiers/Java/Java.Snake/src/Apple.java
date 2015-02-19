import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class Apple {
	public static Random rnd;
	private Part apple;
	private Color snakeColor;
	
	public Apple(Snake snake) {
		apple = createApple(snake);
		snakeColor = Color.RED;		
	}
	
	private To4ka createApple(Snake snake) {
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
	
	public void drawApple(Graphics draw){
		apple.drawSnake(draw, snakeColor);
	}	
	
	public Part getPoint(){
		return apple;
	}
}
