import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Scanner;


public class _04_StraightFlush {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		String input = sc.nextLine();
		String[] cardsInput = input.split("\\W+");
		
		HashSet<String> cards = new HashSet<>();
		cards.addAll(Arrays.asList(cardsInput));
		int count = 0 ;
		
		for (String startCard : cards) {
			String cardFace = startCard.substring(0,startCard.length()-1);
			String cardSuit = startCard.substring(startCard.length()-1);
			ArrayList<String> straightFlash = new ArrayList<>();
			for (int i = 0; i < 5; i++) {
				straightFlash.add(cardFace + cardSuit);
				cardFace = getNextCard(cardFace);
				
			}
			
			if (cards.containsAll(straightFlash)) {
				System.out.println(straightFlash);
				count++;
			}
		}
		
		if (count ==0) {
			System.out.println("No Straight Flushes");
		}
		

	}
	
	public static String getNextCard(String cardFace){
		String[] cardFaces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		for (int i = 1; i < cardFaces.length; i++) {
			if (cardFaces[i-1].equals(cardFace)) {
				return cardFaces[i];
			}
		}
		return null;
	}
	
	

}
