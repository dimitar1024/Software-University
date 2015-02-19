import java.util.Scanner;


public class _06_FormattingNumbers {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		
		int a = sc.nextInt();
		double b = sc.nextDouble();
		double c = sc.nextDouble();
		String aStr = Integer.toString(a, 2);
		
		System.out.printf("|%-10x|%10s|%10.2f|%10.3f|",a,aStr,b,c);
	}

}
