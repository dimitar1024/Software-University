import java.util.Scanner;

public class _03_LongestOddEvenSequence {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String[] numStr = input.split("[ ()]+");
		sc.close();
		int[] numbers = new int[numStr.length-1];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(numStr[i+1]);
		}
		
		int len = 0;
		int bestLen = 0;
		boolean odd = (numbers[0] % 2 != 0);
		
		for (int num : numbers) {
			boolean isOdd = num % 2 !=0;
			if (isOdd == odd || num == 0) {
				len++;
			}else {
				odd = isOdd;
				len = 1;
			}
			odd = !odd;
			if (len > bestLen) {
				bestLen = len;
			}
		}
		
		System.out.println(bestLen);
	}
}
