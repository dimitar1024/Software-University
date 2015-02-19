import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class Controller implements KeyListener{
	
	public Controller(Game game){
		game.addKeyListener(this);
	}
	
	public void keyPressed(KeyEvent e) {
		int key = e.getKeyCode();
		
		if (key == KeyEvent.VK_W || key == KeyEvent.VK_UP) {
			if(Game.moitaZmia.getVelY() != 20){
				Game.moitaZmia.setVelX(0);
				Game.moitaZmia.setVelY(-20);
			}
		}
		if (key == KeyEvent.VK_S || key == KeyEvent.VK_DOWN) {
			if(Game.moitaZmia.getVelY() != -20){
				Game.moitaZmia.setVelX(0);
				Game.moitaZmia.setVelY(20);
			}
		}
		if (key == KeyEvent.VK_D || key == KeyEvent.VK_RIGHT) {
			if(Game.moitaZmia.getVelX() != -20){
			Game.moitaZmia.setVelX(20);
			Game.moitaZmia.setVelY(0);
			}
		}
		if (key == KeyEvent.VK_A || key == KeyEvent.VK_LEFT) {
			if(Game.moitaZmia.getVelX() != 20){
				Game.moitaZmia.setVelX(-20);
				Game.moitaZmia.setVelY(0);
			}
		}
		//Other controls
		if (key == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}

}
