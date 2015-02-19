import java.util.Scanner;


public class _08_CountOfEqualBitsPairs {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		int n = sc.nextInt();
		
		int count =0;
		int previousBit = n & 1;
		
		while (n > 0) {
		n>>=1;
		int nextBit = n & 1;
		if (nextBit == previousBit) {
			count++;
		}
		previousBit = nextBit;
		}
		
		System.out.println(count);
		
		
		
		/*int numberOne = number;
		int numberTwo = number;
		
		int count = 0;
		int maskFirst = 0;
		int maskSecond = 0;
		
		while (numberTwo > 0)
        {
			maskFirst = (numberOne & 1);
            maskSecond = (numberTwo & 1);
			if (number == numberOne) {
				
	            numberTwo >>= 1;
			}
			else {
				numberOne >>=1;
	            numberTwo >>= 1;
			}
            
            if (maskFirst == maskSecond) {
				count++;
			}
            
        }
        System.out.println(count);*/

	}

}