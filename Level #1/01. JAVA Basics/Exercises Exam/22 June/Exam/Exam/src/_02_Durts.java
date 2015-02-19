import java.util.Scanner;

public class _02_Durts {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int xC = sc.nextInt();
		int yC = sc.nextInt();

		int radius = sc.nextInt();
		int n = sc.nextInt();

		// Разделяме фигурата мислено на 2 правоъгълника.
		// Кръщаваме ги за по-лесно вертикален и хоризонтален
		// Подготвяме променливи за проверката. Радиуса се дели на 2
		// защото правоъгълника е с страни 2*r и 2*(r/2)

		double verticalRecMinX = xC - (0.5 * radius);
		double verticalRecMaxX = xC + (0.5 * radius);
		double verticalRecMinY = yC - radius;
		double verticalRecMaxY = yC + radius;

		double horizontalRecMinX = xC - radius;
		double horizontalRecMaxX = xC + radius;
		double horizontalRecMinY = yC - (0.5 * radius);
		double horizontalRecMaxY = yC + (0.5 * radius);

		for (int i = 0; i < n; i++) {
			int x = sc.nextInt();
			int y = sc.nextInt();

			boolean check = insideInFigure(x, y, verticalRecMinX,
					verticalRecMaxX, verticalRecMinY, verticalRecMaxY)
					|| insideInFigure(x, y, horizontalRecMinX,
							horizontalRecMaxX, horizontalRecMinY,
							horizontalRecMaxY);
			if (check) {
				System.out.println("yes");
			}else {
				System.out.println("no");
			}
		}
		sc.close();
	}

	public static boolean insideInFigure(int x, int y, double minX,
			double maxX, double minY, double maxY) {
		boolean inside = (x >= minX) && (x <= maxX) && (y >= minY)
				&& (y <= maxX);
		return inside;
	}
}
