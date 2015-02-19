import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;


public class _07_DaysBetweenTwoDates {

	public static void main(String[] args) throws IOException{
		Scanner reader = new Scanner(System.in);
		 
        DateFormat df = new SimpleDateFormat("dd-MM-yyyy");
        try {
            Date startDate = df.parse(reader.nextLine());
            Calendar startCalendar = Calendar.getInstance();
            startCalendar.setTime(startDate);
 
            Date endDate = df.parse(reader.nextLine());
            Calendar endCalendar = Calendar.getInstance();
            endCalendar.setTime(endDate);
 
            long days = calculateDays(startCalendar,endCalendar);
            System.out.println(days);
            reader.close();
        } catch (ParseException e) {
            System.out.println("Error");
        }
		
	}
	
	public static long calculateDays(Calendar startDate,Calendar endDate){
		long end = endDate.getTimeInMillis();
		long start = startDate.getTimeInMillis();
		long diff = TimeUnit.MILLISECONDS.toDays(Math.abs(end-start));
		return diff;
	}

}
