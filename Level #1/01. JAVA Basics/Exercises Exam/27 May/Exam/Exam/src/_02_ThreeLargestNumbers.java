import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class _02_ThreeLargestNumbers {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int n = sc.nextInt();
		sc.nextLine();
		ArrayList<BigDecimal> numbers = new ArrayList<BigDecimal>();
		
		for (int i = 0; i < n; i++) {
			BigDecimal num = sc.nextBigDecimal();
			numbers.add(num);

		}
		
		Collections.sort(numbers);
		Collections.reverse(numbers);
		
		for (int i = 0; i < 3; i++) {
			System.out.println(numbers.get(i).toPlainString());
		}
		sc.close();
	}

}
