<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
		<style>
			table,tr,td {
				border: 1px solid black;
				background-color: gray;
			}
			.red{
				color: red;
			}
			.blue{
				color: blue;
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
	
	if (isset($_POST)) {
	
		$text = trim($_POST['text']);
		
		$text = preg_replace("/ /", "", $text);
		
		
		for ($i=0; $i < strlen($text); $i++) {
				$current = ord($text[$i]); 
			if ($current %2 == 0) {
				echo "<span class='red'>$text[$i] </span>";
			}
			else{
				echo "<span class='blue'>$text[$i] </span>";
			}
		}
	}
?>