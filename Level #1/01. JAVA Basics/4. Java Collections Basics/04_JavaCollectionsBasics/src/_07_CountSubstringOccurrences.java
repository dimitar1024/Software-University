import java.util.Scanner;


public class _07_CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = sc.nextLine().toLowerCase();
		String word = sc.next();
		int count = 0;
		
		sc.close();
		int index = line.indexOf(word);
		while (index !=-1) {
			count++;
			index = line.indexOf(word, index+1);			
		}
		
		System.out.println(count);

	}

}
