import java.util.Random;
import java.util.Scanner;


public class _06_RandomHandsOfFiveCards {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		Random rnd = new Random();
		String[] face = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
		String[] suit = {"♣", "♦", "♥", "♠"};
		int n = sc.nextInt();
		sc.close();
		for (int i = 0; i < n; i++) {
			int face1 = rnd.nextInt(12);
			int suit1 = rnd.nextInt(3);
			
			int face2 = rnd.nextInt(12);
			int suit2 = rnd.nextInt(3);
			
			int face3 = rnd.nextInt(12);
			int suit3 = rnd.nextInt(3);
			
			int face4 = rnd.nextInt(12);
			int suit4 = rnd.nextInt(3);
			
			int face5 = rnd.nextInt(12);
			int suit5 = rnd.nextInt(3);
			
			System.out.println("" + face[face1] + suit[suit1] +" "+ face[face2] + suit[suit2] +" "+ face[face3] + suit[suit3] +" "+ face[face4] + suit[suit4] +" "+ face[face5] + suit[suit5]);
		
		}
	
	}

}
