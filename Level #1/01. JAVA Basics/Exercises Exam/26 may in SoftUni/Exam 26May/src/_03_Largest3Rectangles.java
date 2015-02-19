import java.util.*;


public class _03_Largest3Rectangles {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] numbers = input.split("\\D+");
		int[] areas = new int[(numbers.length)/2];
		for (int i = 1; i < numbers.length-1; i+=2) {
			int sideA = Integer.parseInt(numbers[i]);
			int sideB = Integer.parseInt(numbers[i+1]);
			int area = sideA * sideB;
			areas[i/2] = area;
		}
		int maxSum = Integer.MIN_VALUE;
		
		for (int i = 0; i < areas.length-2; i++) {
			int sum = areas[i] + areas[i+1] + areas[i+2];
			if (maxSum < sum) {
				maxSum = sum;
			}
		}
		
		System.out.println(maxSum);
	}

}
