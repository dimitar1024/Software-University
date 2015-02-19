import java.util.Arrays;
import java.util.Scanner;


public class _03_LargestThreeRectangles {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] numbs = input.split("\\D+");
		int[] areas = new int[numbs.length/2];
		for (int i = 1; i < numbs.length-1; i+=2) {
			int sideA = Integer.parseInt(numbs[i]);
			int sideB = Integer.parseInt(numbs[i+1]);
			int area = sideA * sideB;
			areas[i/2] = area;
		}
		
		int max = 0;
		for (int i = 0; i < areas.length-2; i++) {
			int sum = areas[i] + areas[i+1] +areas[i+2];
			if (sum > max) {
				max = sum;
			}
		}
		
		System.out.println(max);

	}

}
