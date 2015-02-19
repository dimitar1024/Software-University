import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.LineNumberReader;
import java.math.BigDecimal;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;

public class _10_OrderOfProducts {

	public static void main(String[] args) throws IOException {
		Locale.setDefault(Locale.ROOT);
		Scanner fileReader = null;
		String productsFile = "Products.txt";
		String orderFile = "Orders.txt";
		String outputFile = "Output10.txt";
		
		LineNumberReader lnr = new LineNumberReader(new FileReader(new File("Products.txt")));
		lnr.skip(Long.MAX_VALUE);
		int sizeProdFile = lnr.getLineNumber();
		lnr.close();
		
		LineNumberReader lnra = new LineNumberReader(new FileReader(new File("Orders.txt")));
		lnra.skip(Long.MAX_VALUE);
		int sizeOrderFile = lnra.getLineNumber();
		lnra.close();
		
		
		
		try {
			fileReader = new Scanner(new File(productsFile));
			System.out.println("The file " + productsFile + " is opened.");
			TreeMap<String,BigDecimal> products = new TreeMap<>();
			HashMap<String,BigDecimal> orders= new HashMap<>();
			while (fileReader.hasNextLine()) {
				for (int i = 0; i <= sizeProdFile; i++) {
					String line = fileReader.nextLine();
					String[] inputDataToArr = line.split(" ");
					String name = inputDataToArr[0];
					BigDecimal price = new BigDecimal(inputDataToArr[1]);
					BigDecimal oldPrice = products.get(name);
					if (oldPrice == null) {
						oldPrice = new BigDecimal(0);
					}
					products.put(name, price);
				}
			}
			fileReader.close();
			
			fileReader = new Scanner(new File(orderFile));
			System.out.println("The file " + orderFile + " is opened.");
			while (fileReader.hasNextLine()) {
				for (int i = 0; i <= sizeOrderFile; i++) {
					String line = fileReader.nextLine();
					String[] inputDataToArr = line.split(" ");
					String name = inputDataToArr[1];
					BigDecimal col = new BigDecimal(inputDataToArr[0]);
					BigDecimal oldcol = orders.get(name);
					if (oldcol == null) {
						oldcol = new BigDecimal(0);
					}
					orders.put(name, col);
				}
			}
			fileReader.close();
			BigDecimal sum = new BigDecimal(0);
			
			
			for (Entry<String, BigDecimal> prods : products.entrySet()) {
				String name = prods.getKey();
				BigDecimal price = prods.getValue();
				
				for (Entry<String, BigDecimal> ord : orders.entrySet()) {
					String nameOrd = ord.getKey();
					BigDecimal col = ord.getValue();
					
					if (name.equals(nameOrd)) {
						BigDecimal number = col.multiply(price);
						sum = sum.add(number);
					}
				}
			}
			
			
			BufferedWriter fw = null;
			System.out.println("Writing file...");
			fw = new BufferedWriter(new FileWriter(outputFile));
			fw.write("" + sum);
			fw.newLine();
			fw.close();
			System.out.println("The file" + outputFile + " is created!");
			System.out.println("sum is: " + sum);
			
		} catch (Exception e) {
			// TODO: handle exception
		}
		

	}
}



