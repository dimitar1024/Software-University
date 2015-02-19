<?php
    $text = $_GET['priceList'];
	$pattern = "/<td>\s*(.*?)\s*<\/td>\s*<td>\s*(.*?)\s*<\/td>\s*<td>\s*(.*?)\s*<\/td>\s*<td>\s*(.*?)\s*<\/td>/";
	preg_match_all($pattern, $text, $matches, PREG_SET_ORDER);
	$result = array();
	
	foreach ($matches as $value) {
		$category = html_entity_decode($value[2]);
		$item = [
			'product' => html_entity_decode($value[1]),
			'price' => html_entity_decode($value[3]),
			'currency' => html_entity_decode($value[4])
		];
		
		if (!isset($result[$category])) {
			$result[$category] = [];
		}
		
		array_push($result[$category], $item);
	}
	
	ksort($result);
	
	foreach ($result as $key => $val) {
		usort($val, function($a,$b){
			return strcmp($a['product'], $b['product']);
		} );
		
		$result[$category] = $val;
	}
	
	echo json_encode($result);
?>