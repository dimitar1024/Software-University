<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
		<style>
			table,tr,td {
				border: 1px solid black;
				background-color: gray;
			}
		</style>
	</head>
	<body>
		<form method="post">
			<textarea name="text"></textarea>
			<input type="submit" name="submit" value="Submit" />
		</form>
	</body>
</html>
<?php
	error_reporting(0);
	// логично да изкарва нотиси като проверява с ифа дали има този елемент. Но за да не те дразни съм ги спрял с предходния ред!
	if (isset($_POST)) {
	
		$text = trim(strtolower($_POST['text']));
		$words = preg_split("/\W+/", $text);
	
		$array = array();
	
		for ($i = 0; $i < count($words)-1; $i++) {
			$current = $words[$i];	
			if (!$array[$current]) {
				$array[$current] = 1;
			}
			else {
				$array[$current]++;
			}
		}
		
		echo "<table>";
		foreach ($array as $key => $value) {
			if($key == '')
		    {
		        unset($key);
		    }
			echo "<tr>";
			echo "<td>$key</td><td>$value</td>";
			echo "</tr>";
		}
		echo "</table>";
	}
?>