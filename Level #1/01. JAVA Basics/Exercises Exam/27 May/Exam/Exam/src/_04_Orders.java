import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;



public class _04_Orders {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		sc.nextLine();
		LinkedHashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap<>();
		for (int i = 0; i < n; i++) {
			String input = sc.nextLine();
			String[] ord = input.split(" ");
			
			String name = ord[0];
			int count = Integer.parseInt(ord[1]);
			String product = ord[2];
			
			if (!orders.containsKey(product)) {
				TreeMap<String, Integer> users = new TreeMap<>();
				users.put(name, count);
				orders.put(product, users);
				
			}
			else {
				TreeMap<String, Integer> users = orders.get(product);
				if (!users.containsKey(name)) {
					users.put(name, count);
				}
				else {
					int collection = users.get(name);
					collection = collection + count;
					users.put(name, collection);
				}
				orders.put(product, users);
			}
		}
		
		for (Iterator it = orders.entrySet().iterator(); it.hasNext();) {
			Map.Entry order = (Map.Entry) it.next();
			
			String output = order.getKey() + ": ";
			TreeMap users = (TreeMap) order.getValue();
			for (Iterator it2 = users.entrySet().iterator(); it2.hasNext();) {
				Map.Entry user = (Map.Entry) it2.next();
				
				output += user.getKey() + " " + user.getValue() + ", ";
			}
			output = output.substring(0,output.length()-2);
			System.out.println(output);
		}
		
		
		
		
	}

}
