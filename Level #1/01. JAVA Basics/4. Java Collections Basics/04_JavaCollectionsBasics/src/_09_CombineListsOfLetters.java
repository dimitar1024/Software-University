import java.util.*;


public class _09_CombineListsOfLetters {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner in = new Scanner(System.in);
		
		ArrayList<String> lattersGroup = new ArrayList<String>();
		ArrayList<String> firstInput = new ArrayList<String>();
		
		String input1 = in.nextLine();
		String[] firstGroup = input1.split(" ");
		
		for (String el : firstGroup) {
			lattersGroup.add(el);
			firstInput.add(el);
		}
		
		String input2 = in.nextLine();
		String[] secondGroup = input2.split(" ");
		
		for (String el : secondGroup) {
			
			if (!firstInput.contains(el)) {
				lattersGroup.add(el);
			}
		}
		
		for (String latter : lattersGroup) {
			System.out.print(latter + " ");
		}
		
	}

}
