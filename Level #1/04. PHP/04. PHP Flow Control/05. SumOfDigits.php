<!DOCTYPE html>

<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<style>
			table{
				margin: 10px;
			}
			table, td, tr, th {
				border: 1px solid black;
				
			}
			td, th {
				padding: 3px;
			}
		</style>
	</head>

	<body>
		<form method="post">
        <input type="text" name="numbers" />
        <input type="submit" value="Submit" />
    </form>
		<?php
		if (isset($_POST)) {
			$input = $_POST['numbers'];

			$numbers = explode(', ', $input);

			echo "<table>";
			foreach ($numbers as $num) {
				$num_exit = $num;
				$sum = 0;
				do {
					$sum += $num % 10;
				} while ($num = (int) $num / 10);
				
				if ($sum > 0 ) {
					echo "<tr><td>$num_exit</td><td class='long'>$sum</td></tr>";
				}
				else {
					echo "<tr><td>$num_exit</td><td class='long'>I cannot sum that</td></tr>";
				}
				
			}
			echo "</table>";
		}
		?>
	</body>
</html>