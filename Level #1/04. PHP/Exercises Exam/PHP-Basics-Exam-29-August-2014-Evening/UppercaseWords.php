<?php
$text = $_GET['text'];

$newText = '';
$buffer = '';
for ($i=0; $i < strlen($text); $i++) {
    $ch = $text[$i];
    if (ctype_alpha($ch)) {
        $buffer .= $ch;
    } else {
        $newText .= processWord($buffer);
        $buffer = '';
        $newText .= $ch;
    }
}
$newText .= processWord($buffer);

echo '<p>' . htmlspecialchars($newText) . '</p>';

function processWord($word) {
    if (ctype_upper($word)) {
        $reversed = strrev($word);
        if ($reversed == $word) {
        	$result ='';
			for ($i = 0; $i < strlen($word); $i++) {
        $result .= $word[$i] . $word[$i];
    }
			
            return result;
        } else {
            return $reversed;
        }
    }
    return $word;
}

/*
function reverseWord($word) {
    $reversed = strrev($word);
    for ($i = strlen($word)-1; $i >= 0; $i--) {
        $reversed .= $word[$i];
    }
    return $reversed;
}*/


/*
function doubleLetters($word) {
    $result = "";
    for ($i = 0; $i < strlen($word); $i++) {
        $result .= $word[$i] . $word[$i];
    }
    return $result;
}*/
