import java.util.Scanner;


public class Problem01 {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String input1 = in.nextLine();
		String[] data1 = input1.split(":");
		String input2 = in.nextLine();
		String[] data2 = input2.split(":");
		long data1Hours = Long.parseLong(data1[0]);
		long data1Minutes = Long.parseLong(data1[1]);
		long data1Secundes = Long.parseLong(data1[2]);
		
		long totalTimes1 = data1Hours*3600;
		totalTimes1 += data1Minutes*60;
		totalTimes1 += data1Secundes;
		
		long data2Hours = Long.parseLong(data2[0]);
		long data2Minutes = Long.parseLong(data2[1]);
		long data2Secundes = Long.parseLong(data2[2]);
		
		long totalTimes2 = data2Hours*3600;
		totalTimes2 += data2Minutes*60;
		totalTimes2 += data2Secundes;
		
		
		long endTimes = totalTimes1-totalTimes2;
		
		long hours = endTimes/3600;
		
		long minutes = (endTimes/60)%60;
		
		long secundes = endTimes%60;
		
		System.out.printf("%d:%02d:%02d",hours,minutes,secundes);
		
		
		in.close();
	}

}
