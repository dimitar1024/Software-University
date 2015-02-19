import java.util.*;


public class _04_ActivityTracker {

	public static void main(String[] args) {
		Scanner sc  = new Scanner(System.in);
		
		int n = Integer.parseInt(sc.nextLine());
		
		TreeMap<Integer, TreeMap<String, Float>> mounthActivity = new TreeMap<>();
		
		int temp = 0;
		
		for (int i = 0; i < n; i++) {
			String[] activity = sc.nextLine().split(" ");
			String[] date = activity[0].split("/");
			
			int mounth = Integer.parseInt(date[1]);
			String name = activity[1];
			float distance = Float.parseFloat(activity[2]);
			
			TreeMap<String, Float> users = new TreeMap<String, Float>();
			
			if (mounthActivity.containsKey(mounth)) {
				if (mounthActivity.get(mounth).containsKey(name)) {
					distance += mounthActivity.get(mounth).get(name);
				}
				
				mounthActivity.put(mounth, users);
				
			}
			
			users.put(name, distance);
			
			
		}
		
		System.out.println(mounthActivity);

	}

}
