<?php
    $text = $_GET['text'];
	$blacklist = preg_split("/\r?\n/", $_GET['blacklist'], -1, PREG_SPLIT_NO_EMPTY);
	$pattern = "/[a-zA-Z0-9_+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+/";
	preg_match_all($pattern, $text, $matches);
	$parts = $matches[0];
	
	foreach ($parts as $part) {
		$replace = replace($part, $blacklist);
		$text = str_replace($part, $replace, $text);
	}
	
	function replace($part, $blacklist){
		preg_match("/(\..*)/", $part, $domain);
		$dom = "*" . $domain[0];
		
		if (in_array($dom, $blacklist)) {
			return str_pad('', strlen($part), '*');
		}
		else {
			return "<a href=\"mailto:" . $part . "\">$part</a>";
		}
	}
	
	echo "$text";
?>