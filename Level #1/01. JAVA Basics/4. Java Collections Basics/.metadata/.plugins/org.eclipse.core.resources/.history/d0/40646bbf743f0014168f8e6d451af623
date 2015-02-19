import java.util.Scanner;

public class _01_StuckNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		int n = in.nextInt();
		int[] numbers = new int[n];
		for (int i = 0; i < n; i++) {
			numbers[i] = in.nextInt();
		}
		int count = 0;

		for (int w1 = 0; w1 < numbers.length; w1++) {
			for (int w2 = 0; w2 < numbers.length; w2++) {
				for (int w3 = 0; w3 < numbers.length; w3++) {
					for (int w4 = 0; w4 < numbers.length; w4++) {
						int a = numbers[w1];
						int b = numbers[w2];
						int c = numbers[w3];
						int d = numbers[w4];

						if (a != b && a != c && a != d && b != c && b != d
								&& c != d) {
							String left = "" + a + b;
							String right = "" + c + d;
							if (left.equals(right)) {
								System.out.println(a+"|"+b+"="+c+"|"+d);
								count++;
							}
						}
					}
				}
			}
		}

		if (count == 0) {
			System.out.println("No");
		}
		in.close();
	}
}
