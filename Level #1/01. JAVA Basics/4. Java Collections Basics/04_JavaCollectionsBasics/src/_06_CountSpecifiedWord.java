import java.util.Scanner;


public class _06_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String input = in.nextLine().toLowerCase();
		String[] word = input.split("\\W+");
		String find = in.nextLine();
		int count = 0;
		
		for (int i = 0; i < word.length; i++) {
			if (word[i].equals(find)) {
				count++;
			}
		}
		
		System.out.println(count);
		in.close();
	}
	
}
