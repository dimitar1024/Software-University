import java.util.HashMap;
import java.util.HashSet;
import java.util.LinkedHashMap;
import java.util.Scanner;


public class _04_CouplesFrequency {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] numbersStr = input.split(" ");
		int[] numbers = new int[numbersStr.length];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(numbersStr[i]);
		}
		
		HashMap<String, Integer> counts = new HashMap<>();
		for (int i = 1; i < numbers.length; i++) {
			int first = numbers[i-1];
			int second = numbers[i];
			
			String key = first + " " + second;
			Integer count = counts.get(key);
			if (count == null) {
				count = 0;
			}
			count++;
			counts.put(key, count);
		}
		
		HashSet<String> print = new HashSet<>();
		for (int i = 1; i < numbers.length; i++) {
			int first = numbers[i-1];
			int second = numbers[i];
			String key = first + " " + second;
			if (!print.contains(key)) {
				int count = counts.get(key);
				float percent = (float)count / (numbers.length-1);
				System.out.printf("%s->%.2f%%\n", key,percent*100);
				print.add(key);
			}
		}
		
		
		
	}

}
