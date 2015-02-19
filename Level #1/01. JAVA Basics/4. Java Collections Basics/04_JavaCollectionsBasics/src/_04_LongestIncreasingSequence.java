import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] words = input.split(" ");

		LinkedHashMap<ArrayList<String>, Integer> sequences = new LinkedHashMap<>();

		ArrayList<String> currentSequence = new ArrayList<String>();

		int lastNum = Integer.MIN_VALUE;
		int count = 0;

		for (String word : words) {
			int currentNum = Integer.parseInt(word);
			if (currentNum > lastNum) {
				currentSequence.add(word);
				count++;
			} else {
				ArrayList<String> newList = new ArrayList<>();
				for (String string : currentSequence) {
					newList.add(string);
				}

				Integer check = sequences.get(newList);
				while (check != null) {
					newList.add("");
					check = sequences.get(newList);
				}

				sequences.put(newList, count);
				count = 1;
				currentSequence.clear();
				currentSequence.add(word);
			}

			lastNum = currentNum;
		}

		Integer check = sequences.get(currentSequence);
		while (check != null) {
			currentSequence.add("");
			check = sequences.get(currentSequence);
		}
		sequences.put(currentSequence, count);

		ArrayList<String> longestSecuance = new ArrayList<>();
		Integer longestValue = 0;
		
		for (Map.Entry<ArrayList<String>, Integer> entry : sequences.entrySet()) {
			ArrayList<String> key = entry.getKey();
			Integer value = entry.getValue();
			
			
			if (value > longestValue) {
				longestValue = value;
				longestSecuance = key;
			}
			
			for (String number : key) {
				System.out.print(number + " ");
			}
			System.out.println();
		}
		
		System.out.println("Longest Sequence: ");
		for (int i = 0; i < longestSecuance.size(); i++) {
			System.out.print(longestSecuance.get(i) + " ");
		}
		in.close();
	}

}
