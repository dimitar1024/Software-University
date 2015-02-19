<?php
date_default_timezone_set('Europe/Sofia');
	$text = $_GET['text'];
	$minPrice = floatval($_GET['min-price']);
	$maxPrice = floatval($_GET['max-price']);
	$property = $_GET['sort'];
	if ($_GET['sort'] == "publish-date") {
		$property = "date";
	}
	
	
	$order = $_GET['order'];
	$books = array();
	$lines = preg_split("/\r?\n/", $text, -1, PREG_SPLIT_NO_EMPTY);
	
	foreach ($lines as $key => $line) {
			$input = explode("/", $line);
			$price = floatval($input[3]);
			if ($price >= $minPrice && $price <= $maxPrice) {
				$book = new stdClass();
				$book ->author = trim($input[0]);
				$book ->name = trim($input[1]);
				$book ->genre = trim($input[2]);
				$book ->price = floatval($input[3]);
				$book ->date = date(strtotime($input[4]));
				$book ->info = trim($input[5]);
				$books[] = $book;
			}
		
		}
	usort($books, function($s1, $s2) use ($order, $property) {
	if ($s1 -> $property == $s2 -> $property) {
		return strcmp($s1 -> author, $s2 -> author);
	}

	return ($order == "ascending" ^ $s1 -> $property < $s2 -> $property) ? 1 : -1;
});
	
	foreach ($books as $book) {
			echo "<div>";
				echo "<p>". htmlspecialchars($book->name)."</p>";
				echo "<ul>";
					echo "<li>". htmlspecialchars($book->author)."</li>";
					echo "<li>". htmlspecialchars($book->genre)."</li>";
					echo "<li>". number_format($book->price, 2, '.', '')."</li>";
					echo "<li>". date("Y-m-d",$book->date)."</li>";
					echo "<li>". htmlspecialchars($book->info)."</li>";
				echo "</ul>";
			echo "</div>";
		}
	
	 
	
?>