import java.util.Scanner;


public class _02_Generate3LetterWords {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		sc.close();
		
		char[] latters = input.toCharArray();
		
		PrintThreeElement (latters);
		
		
	}
	
	public static void PrintThreeElement (char[] latters) {
		
		for (int el1 = 0; el1 < latters.length; el1++) {
			for (int el2 = 0; el2 < latters.length; el2++) {
				for (int el3 = 0; el3 < latters.length; el3++) {
					System.out.print("" + latters[el1]+latters[el2]+latters[el3]+ " ");	
				}
			}
		}
	}

}
