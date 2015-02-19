import java.util.*;


public class _02_PythagoreanNumbers {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		boolean hasResult = false;
		int[] nums = new int[n];
		for (int i = 0; i < n ; i++) {
			nums[i] = sc.nextInt();
		}
		
		for (int n1 = 0; n1 < nums.length; n1++) {
			for (int n2 = 0; n2 < nums.length; n2++) {
				for (int n3 = 0; n3 < nums.length; n3++) {
					int a = nums[n1];
					int b = nums[n2];
					int c = nums[n3];
					
					if (a<=b && a*a + b*b == c*c) {
						System.out.printf("%d*%d + %d*%d = %d*%d",a,a,b,b,c,c);
						System.out.println();
						hasResult = true;
					}
				}
			}
		}
		
		if (!hasResult) {
			System.out.println("No");
		}

	}

}
