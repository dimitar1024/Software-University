import java.applet.Applet;
import java.awt.Dimension;
import java.awt.Graphics;

/**
 * Create class GameApplet
 */
@SuppressWarnings("serial")
public class GameApplet extends Applet {
	private Game game;
	Controller controller;

    /**
     *  This method create init settings on game
     */
	public void init(){
		game = new Game();
		game.setPreferredSize(new Dimension(800, 650));
		game.setVisible(true);
		game.setFocusable(true);
		this.add(game);
		this.setVisible(true);
		this.setSize(new Dimension(800, 650));
		controller = new Controller(game);
	}

    /**
     * This method draw game with given graphics settings
     * @param g - accepts an object of type Graphics( object with all settings on screen)
     */
	public void paint(Graphics g)
    {
		this.setSize(new Dimension(800, 650));
	}

}
