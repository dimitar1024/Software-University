import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;


public class Problem03 {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String line = in.nextLine();
		String[] input = line.split("[ \\(\\)\\|\\\\ \\//]+");
		
		StringBuilder data = new StringBuilder();
		for (String string : input) {
			data.append(string);
		}
		String dataInfo = data.toString();
		
		String[] words = dataInfo.split("\\W+");
		
		ArrayList<Integer> numbers = new ArrayList<>();
		
		char[] word1 = words[0].toCharArray();
		int sumV = 0;
		
		
		for (int i = 0; i < words.length; i++) {
			char[] word = words[i].toCharArray();
			int sumChar = 0;
			for (int j = 0; j < word.length; j++) {
				int value = 0;
				if (word[j] >= 65 && word[j] <= 90) {
					value = word[j] - 64;
				}
				else if(word[j] >= 97 && word[j] <= 122) {
					value = word[j] - 96;
				}
				sumChar = sumChar + value;
				
			}
			numbers.add(sumChar);
			
		}
		int[] sums = new int[numbers.size()-1];
		for (int i = 1; i < numbers.size(); i++) {
			int a = numbers.get(i-1);
			int b = numbers.get(i);
			sums[i-1] = a+b;
		}
		
		int largest = sums[0], index = 0;
		for (int i = 1; i < sums.length; i++) {
		  if ( sums[i] > largest ) {
		      largest = sums[i];
		      index = i;
		   }
		}
		
		
		System.out.println(words[index-1]);
		System.out.println(words[index]);
		
	}

}