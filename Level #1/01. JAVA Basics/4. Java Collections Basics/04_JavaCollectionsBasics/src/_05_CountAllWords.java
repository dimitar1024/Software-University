import java.util.Scanner;


public class _05_CountAllWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] words = input.split("\\W+");
		
		int count = words.length;
		System.out.println(count);
		in.close();
	}

}
