<?php
    $recipient = htmlspecialchars($_GET['recipient']);
	$subject = htmlspecialchars($_GET['subject']);
	$body = htmlspecialchars(trim($_GET['body']));
	$key = $_GET['key'];
	
	$result="<p class='recipient'>$recipient</p>".
			"<p class='subject'>$subject</p>".
			"<p class='message'>$body</p>";
	echo "$result";
	$cryptEmail = encrypt($result, $key);
	echo "$cryptEmail";
	
	function encrypt($result, $key){
		$textLen = strlen($result);
		$keyLen = strlen($key);
		$out = "|";
		for ($i=0; $i < $textLen; $i++) { 
			$char = ord($result[$i]) * ord($key[$i % $keyLen]);
			$out .= dechex($char). "|";
		}
		
		return $out;
	}
?>