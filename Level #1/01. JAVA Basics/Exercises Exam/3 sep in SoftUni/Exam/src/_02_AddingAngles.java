import java.util.*;


public class _02_AddingAngles {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = Integer.parseInt(sc.nextLine());
		String line = sc.nextLine();
		String[] lineStr = line.split(" ");
		int[] angles = new int[lineStr.length];
		for (int i = 0; i < angles.length; i++) {
			angles[i] = Integer.parseInt(lineStr[i]);
		}
		
		boolean isCircle = false;
		for (int a1 = 0; a1 < angles.length; a1++) {
			for (int a2 = a1 + 1; a2 < angles.length; a2++) {
				for (int a3 = a2 +1; a3 < angles.length; a3++) {
					int sum = angles[a1] + angles[a2] + angles[a3];
					
					if (sum % 360 == 0) {
						System.out.printf("%d + %d + %d = %d degrees",angles[a1],angles[a2],angles[a3],sum);
						System.out.println();
						isCircle = true;
					}
				}
			}
		}
		
		if (!isCircle) {
			System.out.println("No");
		}
	}

}
