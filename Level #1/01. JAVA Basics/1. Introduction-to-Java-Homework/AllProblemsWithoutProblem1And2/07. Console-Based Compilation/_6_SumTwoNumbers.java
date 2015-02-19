import java.util.Scanner;


public class _6_SumTwoNumbers {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		int firstNumber = sc.nextInt();
		int secondNumber = sc.nextInt();
		int result = firstNumber+secondNumber;
		System.out.println(result);
	}

}
