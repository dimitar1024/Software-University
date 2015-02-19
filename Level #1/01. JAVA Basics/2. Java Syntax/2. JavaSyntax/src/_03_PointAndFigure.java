import java.util.Scanner;


public class _03_PointAndFigure {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);

		double x = sc.nextDouble();
		double y = sc.nextDouble();
		
		if ((x>=12.5 && x<=22.5)&&(y>=6 && y<=8.5)) {
			System.out.println("inside");
		}
		else if((x>=12.5 && x<=17.5)&&(y>=8.5 && y<=13.5)){
			System.out.println("intside");
		}
		else if((x>=20 && x<=22.5)&&(y>=8.5 && y<=13.5)){
			System.out.println("intside");
		}
		else {
			System.out.println("outside");
		}
	}

}
