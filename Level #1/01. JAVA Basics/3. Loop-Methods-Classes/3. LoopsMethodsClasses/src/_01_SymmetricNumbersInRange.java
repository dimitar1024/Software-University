import java.util.Scanner;


public class _01_SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int start = sc.nextInt();
		int end = sc.nextInt();
		sc.close();
		
		SymmetricNumbers(start,end);

	}
	
	public static void SymmetricNumbers(int start, int end){
		if (end <=100) {
			for (int i = start; i <= end; i++) {
				System.out.print(i + " ");
			}
		}
		if (!(end <=100)) {
			for (int i = start; i <= end; i++) {
				
				
				int startFirst = (i/100)%10;
				int startThird = (i/1)%10;
				
				
				
				if ((startFirst == startThird)) {
					System.out.print(i + " ");
				}
			}
		}
	}

}