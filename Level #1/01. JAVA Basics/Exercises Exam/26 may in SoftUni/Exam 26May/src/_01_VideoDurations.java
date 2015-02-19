import java.util.Scanner;


public class _01_VideoDurations {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int totalHours = 0;
		int totalMinutes = 0;
		while (true) {
			String input = sc.nextLine();
			if (input.equals("End")) {
				break;
			}
			String[] parts = input.split(":");
			int hours = Integer.parseInt(parts[0]);
			int min = Integer.parseInt(parts[1]);
			totalHours += hours;
			totalMinutes += min;
		}
			
		totalHours += totalMinutes / 60;
		totalMinutes %= totalMinutes;
		
		System.out.printf("%d:%02d",totalHours,totalMinutes);

	}

}
