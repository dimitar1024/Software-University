import java.util.ArrayList;
import java.util.Scanner;

public class Problem02 {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		long divider = Integer.parseInt(in.nextLine());
		ArrayList<Long> numbers = new ArrayList<>();
		long count = 0;
		while (true) {
			String line = in.nextLine();
			if (line.equals("End")) {
				break;
			}
			long parse = Long.parseLong(line);
			numbers.add(parse);
			
		}
	
		
		long bigA = numbers.get(0);
		long bigB = numbers.get(0);
		long bigC = numbers.get(0);
		long bigSum = Integer.MIN_VALUE;

		for (int n1 = 0; n1 < numbers.size(); n1++) {
			for (int n2 = 0; n2 < numbers.size(); n2++) {
				for (int n3 = 0; n3 < numbers.size(); n3++) {
					long a = numbers.get(n1);
					long b = numbers.get(n2);
					long c = numbers.get(n3);
					long sum =0;
					if (a!=b && b!=c && a!=c) {
						sum = a+b+c;
					
					
						long result = (a + b + c) % divider;
					if (result == 0) {
						if (sum > bigSum) {
							bigSum = sum;
							bigA = a;
							bigB = b;
							bigC = c;
							count++;
						}

					}
					}
				}
			}
		}
		if (count != 0) {
			System.out.printf("(%d + %d + %d) %% %d = 0%n", bigA, bigB, bigC,
					divider);
		}

		if (count == 0) {
			System.out.println("No");
		}
	}

}
