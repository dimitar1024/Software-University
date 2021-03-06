import java.util.*;


public class _03_Biggest3PrimeNumbers {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = sc.nextLine().replace(" ", "");
		String[] lineStr = line.split("[ ()]+");
		sc.close();
		
		TreeSet<Integer> primeNumbers = new TreeSet<>();
		
		
		for (String number : lineStr) {
			
			if (number.equals("")) {
				continue;
			}
			int n = Integer.parseInt(number);
			
			if (isPrime(n)) {
				primeNumbers.add(n);
			}
			
			if (primeNumbers.size() < 3) {
				System.out.println("No");
			}
			else {
				int sum = 0;
				for (int i = 0; i < 3; i++) {
					sum += primeNumbers.last();
					primeNumbers.remove(primeNumbers.last());
					System.out.println(sum);
				}
				
			}
			
			
			
		}
		
		
	}
	
	public static boolean isPrime(Integer n){
		if (n < 2) {
			return false;
		} else if(n==2) {
			return true;
		}
		
		for (int i = 2; i <= Math.sqrt(n); i++) {
			if (n % i == 0) {
				return false;
			}
		}
		
		return true;
		
	}

}
