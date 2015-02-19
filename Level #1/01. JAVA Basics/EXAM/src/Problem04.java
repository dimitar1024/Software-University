import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class Problem04 {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		int n = in.nextInt();
		in.nextLine();
		TreeMap<String, LinkedHashMap<String, Integer>> orderNuts = new TreeMap<>();
		
		for (int i = 0; i < n; i++) {
			String line = in.nextLine().replace("kg","");
			String[] data = line.split(" ");
			String nameCompany = data[0];
			String nut = data[1];
			int amount = Integer.parseInt(data[2]);
			
			
			if (!orderNuts.containsKey(nameCompany)) {
				orderNuts.put(nameCompany, new LinkedHashMap<String, Integer>());
			}
			LinkedHashMap<String, Integer> amounts = orderNuts.get(nameCompany);
			int oldAmount = 0;
			if (amounts.containsKey(nut)) {
				oldAmount = amounts.get(nut);
			}
			amounts.put(nut, oldAmount + amount);
		}
		
		
		for (String nameCompany : orderNuts.keySet()) {
			System.out.print(nameCompany + ": ");
			LinkedHashMap<String, Integer> amounts = orderNuts.get(nameCompany);
			boolean first = true;
			for (Map.Entry<String, Integer> pair : amounts.entrySet()) {
				if (!first) {
					System.out.print(", ");
				}
				first = false;
				String customer = pair.getKey();
				int amount = pair.getValue();
				System.out.print(customer + "-" + amount+"kg");
			}
			System.out.println();
		}
		in.close();
	}

}
