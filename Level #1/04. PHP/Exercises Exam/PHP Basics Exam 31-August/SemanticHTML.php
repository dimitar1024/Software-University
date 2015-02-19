<?php
    $text = $_GET['html'];
	$tags = ['main', 'header', 'nav', 'article', 'section', 'aside', 'footer'];
	$pattern = '/<div.*?\b((id|class)\s*=\s*"(.*?)").*?>/';
	preg_match_all($pattern, $text, $matches);
	
	foreach ($matches[0] as $key => $value) {
		$attrName = $matches[1][$key];
		$attrVal = $matches[3][$key];
		
		if (in_array($attrVal, $tags)) {
			$replaceTag = str_replace('div', $attrVal, $value);
			$replaceTag = str_replace($attrName, '', $replaceTag);
			$replaceTag = preg_replace("/\s*>/", ">", $replaceTag);
			$replaceTag = preg_replace("/\s{2, }/", ' ', $replaceTag);
			$text = str_replace($value, $replaceTag, $text);
		}
		
	}
	
	$closePattern = '/<\/div>\s.*?(\w+)\s*-->/';
	preg_match_all($closePattern, $text, $closingTags);
	
	foreach ($closingTags[0] as $key => $value) {
		$comment = $closingTags[1][$key];
		if (in_array($comment, $tags)) {
			$text = str_replace($value, "</$comment>", $text);
		}
	}
	
	echo "$text";
?>