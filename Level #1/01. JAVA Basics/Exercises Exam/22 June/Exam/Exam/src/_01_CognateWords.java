import java.util.HashSet;
import java.util.Scanner;

public class _01_CognateWords {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] words = input.split("[^a-zA-Z]+");
		int count = 0;
		sc.close();
		
		HashSet<String> margeWords = new HashSet<>();
		for (int w1 = 0; w1 < words.length; w1++) {
			for (int w2 = 0; w2 < words.length; w2++) {
				for (int w3 = 0; w3 < words.length; w3++) {
					String a = words[w1];
					String b = words[w2];
					String c = words[w3];
					if (a != b) {
						String left = "" + a + b;
						if (left.equals(c)) {
							String word = "" + a + "|" + b + "=" + c;  
							margeWords.add(word);
							count++;
						}
					}
				}
			}
		}

		if (count == 0) {
			System.out.println("No");
		}
		
		for (String w : margeWords) {
			System.out.println(w);
		}
	}

}
