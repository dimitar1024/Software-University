import java.util.*;

public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		String input = in.nextLine().toLowerCase();
		String[] words = input.split("\\W+");

		ArrayList<String> sortWords = new ArrayList<String>();

		for (String word : words) {
			if (!sortWords.contains(word)) {
				sortWords.add(word);

			}
		}

		Collections.sort(sortWords);

		
		for (String word : sortWords) {
			System.out.print(word + " ");
		}
		in.close();
	}

}
