<!DOCTYPE html>

<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<style>
			input[type=text] {
				background-color: #FFFF99;
			}
			table, td, tr, th {
				border: 1px solid black;
				width: 50px;
				
			}
			td,th{
				padding : 3px;
			}
		</style>
	</head>

	<body>
		<form  method="post">
			<input type="text" name="cars" placeholder="Enter cars" />
			<input type="submit" name="submit" value="Show result" />
		</form>
		<?php
			if (isset($_POST)) {
				$input = $_POST['cars'];
				
				$cars = explode(', ', $input); 
				$colors = array("black", "blue", "cyan","gold","gray","green","magenta","pink","red","violet","white","yellow");
		echo "<table>";
		echo "<tr><th>Car</th><th>Color</th><th>Count</th></tr>";
		foreach ($cars as $car) {
			$rand_col = $colors[array_rand($colors)];
			$rand_count = rand(0, 5);
			echo "<tr><td>$car</td><td>$rand_col</td><td>$rand_count</td></tr>";
		}
		echo "</table>";
		}
		?>
	</body>
</html>