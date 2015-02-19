import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

public class Part {
	private int x, y;
	private final int WIDTH = 20;
	private final int HEIGHT = 20;

	public Part(Part part){
		this(part.x, part.y);
	}

	public Part(int x, int y){
		this.x = x;
		this.y = y;
	}

	public int getX() {
		return x;
	}
	public void setX(int x) {
		this.x = x;
	}
	public int getY() {
		return y;
	}
	public void setY(int y) {
		this.y = y;
	}

	public void drawSnake(Graphics draw, Color color) {
        draw.setColor(Color.BLACK);
        draw.fillRect(x, y, WIDTH, HEIGHT);
        draw.setColor(color);
        draw.fillRect(x + 1, y + 1, WIDTH - 2, HEIGHT-2);
	}

	public String toString() {
		return "[x=" + x + ",y=" + y + "]";
	}

	public boolean equals(Object obj) {
        if (obj instanceof Part) {
            Part Part = (Part)obj;
            return (x == Part.x) && (y == Part.y);
        }
        return false;
    }
}
