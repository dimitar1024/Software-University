import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

@SuppressWarnings("serial")
public class Game extends Canvas implements Runnable {
	public static Snake snake;
	public static Appele apple;
	static int score;
	
	private Graphics globalGraphics;
	private Thread runThread;
	public static final int WIDTH = 600;
	public static final int HEIGHT = 600;
	private final Dimension gameSize = new Dimension(WIDTH, height);
	
	static boolean gameRunning = false;
	
	public void paint(Graphics draw){
		this.setPreferredSize(gameSize);
		globalGraphics = draw.create();
		to4ki = 0;
		
		if(runThread == null){
			runThread = new Thread(this);
			runThread.start();
			gameRunning = true;
		}
	}
	
	public void run(){
		while(gameRunning){
			snake.tick();
			render(globalGraphics);
			try {
				Thread.sleep(100);
			} catch (Exception e) {
                System.out.print("Error. Restart game");
            }
		}
	}
	
	public Game(){
		snake = new Snake();
		apple = new Apple(snake);
	}
		
	public void render(Graphics draw){
        draw.clearRect(0, 0, WIDTH, HEIGHT + 25);

        draw.drawRect(0, 0, WIDTH, HEIGHT);
		snake.drawSnake(draw);
		apple.drawApple(draw);
        draw.drawString("score= " + score, 10, HEIGHT + 25);
	}
}

