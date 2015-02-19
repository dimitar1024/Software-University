<?php
    $text = $_GET['list'];
	$minPrice = floatval($_GET['minPrice']);
	$maxPrice = floatval($_GET['maxPrice']);
	$filter = $_GET['filter'];
	$order = $_GET['order'];
	
	$input = preg_split("/\r?\n/", $text, -1, PREG_SPLIT_NO_EMPTY);
	$products = [];
	$id = 1;
	foreach ($input as $art) {
		$data = preg_split("/\s*[|]\s*/", $art, -1, PREG_SPLIT_NO_EMPTY);
		$price = floatval($data[3]);
		
		if ($price > $minPrice && $price < $maxPrice) {
			$name = $data[0];
			$type = $data[1];
			$components = explode(", ", $data[2]);
			$products[] = [$name, $type, $components,$price, $id];
			
		}
		$id++;
	}
	
	$result = array_filter($products, function($art) use($filter){
		return $filter == $art[1] ? true : ($filter == "all" ? true : false);
	});
	
	usort($result, function($s1, $s2) use ($order) {
    if ($s1[3] == $s2[3]) {
        return $s1[4] - $s2[4];
    }
    return ($order == "ascending" ^ $s1[3] > $s2[3]) ? -1 : 1;
});


foreach ($result as $val) {
	$out = "";
	$out .= "<div class=\"product\" id=\"product" . $val[4] . "\">";
	$out .= "<h2>". htmlspecialchars($val[0])."</h2>";
	$out .= "<ul>";
	foreach ($val[2] as $el) {
		$out .= "<li class=\"component\">" . htmlspecialchars($el) . "</li>";
	}
	$out .= "</ul>";
	$out .= "<span class=\"price\">" . number_format($val[3], 2, '.', '') . "</span>";
	$out .= "</div>";
	echo $out;
}
	
?>