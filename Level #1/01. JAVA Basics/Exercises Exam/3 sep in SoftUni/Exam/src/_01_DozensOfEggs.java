import java.util.*;


public class _01_DozensOfEggs {

	public static void main(String[] args) {
		Scanner sc  = new Scanner(System.in);
		int sum = 0;
		for (int i = 0; i < 7; i++) {
			String line = sc.nextLine();
			String[] input = line.split(" ");
			int egg = Integer.parseInt(input[0]);
			String value = input[1];
			
			if (value.equals("eggs")) {
				sum = sum + egg;
			}
			else{
				sum = sum + egg*12;
			}
		}
		
		int dozines = sum / 12;
		int egg = sum % 12;
		System.out.printf("%d dozens + %d eggs",dozines,egg);
	}

}
