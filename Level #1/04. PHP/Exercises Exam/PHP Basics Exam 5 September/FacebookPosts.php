<?php
error_reporting(0);
$text = $_GET['text'];
$matches = preg_split("/\r?\n/", $text, -1, PREG_SPLIT_NO_EMPTY);

$lines = array();

$table = array();
foreach ($matches as $string) {
	if (trim($string)) {
		$lines[] = trim($string);
	}
}

foreach ($matches as $line) {
	$data = explode(";", $line);
	$input = array();

	foreach ($data as $word) {
		if (trim($word)) {
			$input[] = trim($word);
		}
	}
	
	$date = strtotime($input[1]);
	$table[$date] = article($input);
	
	
}

krsort($posts);
echo implode("", $table);


function  article($input){
	$result = '';
	$name = htmlspecialchars($input[0]);
	$date = date("j F Y", strtotime($input[1]));
	$post = htmlspecialchars($input[2]);
	$likes = htmlspecialchars($input[3]);
	$result .= "<article>";
    $result .= "<header><span>$name</span><time>$date</time></header>";
    $result .= "<main><p>$post</p></main>";
    $result .= "<footer><div class=\"likes\">$likes people like this</div>";
	if (isset($input[4])) {
		$comments = explode("/", $input[4]);
		$result .= "<div class=\"comments\">";
		foreach($comments as $value) {
            $comment = htmlspecialchars(trim($value));
            $result .= "<p>$comment</p>";
        }
		$result .= "</div>";
	}
	$result .= "</footer>";
    $result .= "</article>";
    return $result;
	
}
?>