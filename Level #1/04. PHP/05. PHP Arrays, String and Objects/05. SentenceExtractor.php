<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>

	</head>
	<body>
		<form method="post">
			<textarea name="text"></textarea>
			<input type="text" name="str"/>
			<input type="submit" name="submit" value="Submit" />
		</form>
	</body>
</html>
<?php

if (isset($_POST)) {

	$text = trim($_POST['text']);
	$str = trim($_POST['str']);

	preg_match_all("/[^?.!]+/", $text, $matches);
	$sentence = $matches[0];
	
	$newArr = array();
	foreach ($sentence as $k => $v) {
		if (preg_match("/\b$str\b/i", $v)) {
			$newArr[] = $v;
		}
	}
	
	foreach ($newArr as $value) {
		echo "<p>$value</p>";
	}
	
	//Last sentence "Well it is :)" have word "is", but in the example this sentence is not writed;
}
?>