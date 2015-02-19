import java.util.Scanner;


public class _04_TheSmallestOfThreeNumbers {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		double min = 0;
		for (int i = 0; i < 3; i++) {
			double num = sc.nextDouble();
			
			if (i==0) {
				min = num;
			}
			if (min > num) {
				min = num;
			}
		}
		System.out.println(min);
	}

}
