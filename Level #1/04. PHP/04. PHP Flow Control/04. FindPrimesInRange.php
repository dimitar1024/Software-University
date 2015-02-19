<!DOCTYPE html>

<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<style>
			.bold {
				font-weight: bold;
			}
		</style>
	</head>

	<body>
		<form  method="post">
			<label for="year">Starting index: </label>
			<input type="text" id="year"name="start" placeholder="Enter start index" />
			<label for="year">End: </label>
			<input type="text" id="year"name="end" placeholder="Enter end index" />
			<input type="submit" name="submit" value="Submit" />
		</form>
		<?php
		function isPrime($n) {
			$i = 2;
			if ($n == 2) {
				return true;
			}
			while ($i < $n) {
				if ($n % $i == 0) {
					return false;
				}
				$i++;
			}
			return true;
		}

		if (isset($_POST)) {
			$start = $_POST['start'];
			$end = $_POST['end'];

			for ($i = $start; $i <= $end; $i++) {
				if (isPrime($i)) {
					echo "<span class='bold'>$i, </span>";
				} else {
					echo "<span>$i, </span>";
				}
			}

		}
		?>
	</body>
</html>