import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

/**
 * Create class Part
 */
public class Part {
	private int x, y;
	private final int WIDTH = 20;
	private final int HEIGHT = 20;

    /**
     * Create constructor on class Part
     * @param part - object ot type part with properties x and y
     */
	public Part(Part part){
		this(part.x, part.y);
	}

    /**
     * Create constructor on class Part
     * @param x - enter x coordinate
     * @param y - enter y coordinate
     */
	public Part(int x, int y){
		this.x = x;
		this.y = y;
	}

    /**
     *  This method return x coordinate
     * @return X coordinate
     */
	public int getX() {
		return x;
	}

    /**
     * This method set x coordinate
     * @param x - enter x coordinate
     */
	public void setX(int x) {
		this.x = x;
	}

    /**
     * This method return y coordinate
     * @return Y coordinate
     */
	public int getY() {
		return y;
	}

    /**
     * This method set y coordinate
     * @param y - enter y coordinate
     */
	public void setY(int y) {
		this.y = y;
	}

    /**
     * This method draw Snake
     * @param draw - accepts an object of type Graphics( object with all settings on screen)
     * @param color - accepts an object of type Color. This parameter set color on snake
     */
	public void drawSnake(Graphics draw, Color color) {
        draw.setColor(Color.BLACK);
        draw.fillRect(x, y, WIDTH, HEIGHT);
        draw.setColor(color);
        draw.fillRect(x + 1, y + 1, WIDTH - 2, HEIGHT-2);
	}

    /**
     * This method retur coordinates to string
     * @return coordinates to string
     */
	public String toString() {
		return "[x=" + x + ",y=" + y + "]";
	}

    /**
     * This method check geiven object is equal on Part
     * @param obj - enter object for check
     * @return boolean
     */
	public boolean equals(Object obj) {
        if (obj instanceof Part) {
            Part Part = (Part)obj;
            return (x == Part.x) && (y == Part.y);
        }
        return false;
    }
}
