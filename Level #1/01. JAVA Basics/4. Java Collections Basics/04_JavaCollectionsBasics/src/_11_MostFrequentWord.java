import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;

public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		String input = in.nextLine().toLowerCase();
		String[] words = input.split("\\W+");

		TreeMap<String, Integer> counter = new TreeMap<>();

		for (String word : words) {
			Integer count = counter.get(word);
			if (count == null) {
				count = 0;
			}
			counter.put(word, count + 1);
		}

		int longest = 0;
		for (Object value : counter.values()) {
			if (longest < (int) value) {
				longest = (int) value;
			}
		}

		for (Entry<String, Integer> entry : counter.entrySet()) {
			String word = entry.getKey();
			Integer count = entry.getValue();
			if (entry.getValue() == longest) {
				System.out.printf("%s -> %d times%n", word, count);
			}

		}
		in.close();
	}

}
