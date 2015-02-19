import java.util.*;

public class _01_CountBeers {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int sum = 0;
		while (true) {
			String line = sc.nextLine();
			if (line.equals("End")) {
				break;
			}
			String[] lineStr = line.toLowerCase().split(" ");
			int number = Integer.parseInt(lineStr[0]);
			String beer = lineStr[1];
			if (beer.equals("beers")) {
				sum += number;
			}else if (beer.equals("stacks")) {
				sum = sum + (number*20);
			}
		}
		sc.close();
		int stacks = sum / 20;
		int beers = sum % 20;

		System.out.printf("%d stacks + %d beers", stacks, beers);

	}

}
