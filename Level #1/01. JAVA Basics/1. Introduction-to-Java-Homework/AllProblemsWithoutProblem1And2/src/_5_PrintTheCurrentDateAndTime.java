import java.util.Date;


public class _5_PrintTheCurrentDateAndTime {

	public static void main(String[] args) {
		Date timeNow = new Date(System.currentTimeMillis());
		System.out.println(timeNow);
	}

}
