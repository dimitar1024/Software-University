<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
	</head>
	<body>
		<form method="post">
			<textarea name="text"></textarea>
			<input type="text" name="banlist" />
			<input type="submit" name="submit" value="Submit" />
		</form>
	
<?php
	
	if (isset($_POST)) {
	
		$text = trim($_POST['text']);
		$banlist = explode(", ",$_POST['banlist']);
		
		
		foreach ($banlist as $word) {
			$replace = str_repeat("*", strlen($word));
			$text = str_replace($word, $replace, $text);
		}
		
		
		echo "$text";
	}
	
	
		
?>
