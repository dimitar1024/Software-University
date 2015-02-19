import java.util.Scanner;


public class _07_CountOfBitsOne {

	private static Scanner sc;

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		int number = sc.nextInt();
		
		int count = 0;
		while (number > 0)
        {
            count += (number & 1);
            number >>= 1;
        }
        System.out.println(count);

	}

}
