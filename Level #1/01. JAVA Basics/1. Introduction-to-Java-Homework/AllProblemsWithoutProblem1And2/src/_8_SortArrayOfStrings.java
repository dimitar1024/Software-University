import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;


public class _8_SortArrayOfStrings {

	private static Scanner in;

	public static void main(String[] args) throws IOException {
		in = new Scanner(System.in);
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("Print number of your list with cities:");
		int n = in.nextInt();
		ArrayList<String> cities = new ArrayList<String>();
		for (int i = 0; i < n ; i++) {
			String city = br.readLine();
			cities.add(city);
		}
		Collections.sort(cities); 
		 	for (String el : cities) {
					System.out.println(el); 
			}
	}

}
