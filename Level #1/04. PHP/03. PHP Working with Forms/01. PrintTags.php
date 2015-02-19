<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>

	<body>
		<form method="post">
			<input type="text" name="array" placeholder="Enter array with separator ', '" />
			<input type="submit" name="submit" value="Submit" />
		</form>

		<?php
			$arr = $_POST['array'];
			$arr = explode(", ", $arr);
	
				foreach ($arr as $key => $value) {
					echo $key . " : " . $value . "<br/>";
				}
		?>
	</body>
</html>

