import java.util.HashMap;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;

public class _17_LogsAggregator {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		int n = in.nextInt();
		in.nextLine();

		TreeMap<String, Integer> enters = new TreeMap<String, Integer>();
		HashMap<String, TreeSet<String>> ipAddresses = new HashMap<>();

		for (int i = 0; i < n; i++) {
			String line = in.nextLine();
			String[] data = line.split(" ");
			String ip = data[0];
			String name = data[1];
			int logs = Integer.parseInt(data[2]);

			Integer oldLogs = enters.get(name);
			if (oldLogs == null) {
				oldLogs = 0;
			}
			enters.put(name, oldLogs + logs);

			TreeSet<String> ipSet = ipAddresses.get(name);
			if (ipSet == null) {
				ipSet = new TreeSet<>();
			}
			ipSet.add(ip);
			ipAddresses.put(name, ipSet);

		}

		for (Entry<String, Integer> logins : enters.entrySet()) {
			String user = logins.getKey();
			Integer logs = logins.getValue();
			TreeSet<String> ips = ipAddresses.get(user);
			System.out.println(user + ": " + logs + " " + ips);
		}
		in.close();
	}

}
