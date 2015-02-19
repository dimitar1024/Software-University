import java.io.*;
import java.util.Locale;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.io.File;

public class _09_ListOfProducts {
	

	public static void main(String[] args) throws IOException {
		Locale.setDefault(Locale.ROOT);
		Scanner fileReader = null;
		String input = "input9.txt";
		String output = "output9.txt";
		
		// size input document
		LineNumberReader lnr = new LineNumberReader(new FileReader(new File("input9.txt")));
		lnr.skip(Long.MAX_VALUE);
		int size = lnr.getLineNumber();
		lnr.close();
		
		
		try {
			fileReader = new Scanner(new File(input));
			System.out.println("File " + input + " opened.");
			
			
			Map<Double, String> sort = new TreeMap<Double, String>();
			while (fileReader.hasNextLine()) {
				String line = fileReader.nextLine();
				for (int i = 0; i <=size; i++) {
					
					String[] inputProduct = line.split(" ");
					double price = Double.parseDouble(inputProduct[1]);
					String name = inputProduct[0].toString();
					String oldName = sort.get(price);
					if (oldName == null) {
						oldName = "";
					}
					sort.put(price,name);
				}
				
			}
			
			
			printSortArray(sort,output);
			
		} catch (Exception e) {
			System.out.println("Error");
		}
	}
	
	
	private static void printSortArray(Map<Double, String> sort, String output) throws IOException {

		BufferedWriter fw = null;
		fw = new BufferedWriter(new FileWriter(output));
		for (Map.Entry<Double, String> sorting: sort.entrySet()) {
		fw.write("" + sorting.getKey() + " " + sorting.getValue());
		System.out.println(sorting.getKey() + " " + sorting.getValue());
		fw.newLine();
		}
		fw.close();
		System.out.println("Done");
	}
}