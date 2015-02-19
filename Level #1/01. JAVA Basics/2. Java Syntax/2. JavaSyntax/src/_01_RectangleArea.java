import java.util.Scanner;


public class _01_RectangleArea {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		int a = sc.nextInt();
		int b = sc.nextInt();
		
		int area = a*b;
		
		System.out.println(area);
	}

}
