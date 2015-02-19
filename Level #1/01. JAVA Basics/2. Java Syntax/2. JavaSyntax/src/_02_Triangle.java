import java.util.Scanner;


public class _02_Triangle {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		int x1 = sc.nextInt();
		int y1 = sc.nextInt();
		
		int x2 = sc.nextInt();
		int y2 = sc.nextInt();
		
		int x3 = sc.nextInt();
		int y3 = sc.nextInt();

		double a = Math.sqrt(Math.pow((x2-x1), 2) + Math.pow((y2-y1), 2));
		double b = Math.sqrt(Math.pow((x3-x2), 2) + Math.pow((y3-y2), 2));
		double c = Math.sqrt(Math.pow((x1-x3), 2) + Math.pow((y1-y3), 2));
		
		double p = (a+b+c)/2;
		
		double area = Math.sqrt(p*(p-a)*(p-b)*(p-c));
		int exit = (int) Math.round(area);
		System.out.println(exit);
	}

}
