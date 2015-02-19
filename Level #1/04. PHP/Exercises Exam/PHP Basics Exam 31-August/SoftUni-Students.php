<?php
    $column = $_GET['column'];
	$order = $_GET['order'];
	$text = $_GET['students'];
	$table = array();
	$lines = preg_split("/\r?\n/", $text, -1, PREG_SPLIT_NO_EMPTY);
	$id = 1;
	foreach ($lines as $line) {
		$data = explode(", ", $line);
		
		$student = new stdClass();
		$student -> id = trim($id);
		$student -> username = trim($data[0]);
		$student -> email = trim($data[1]);
		$student -> type = trim($data[2]);
		$student -> result = intval(trim($data[3]));
		$table[] = $student;
		$id++;
	}
	usort($table, function($s1, $s2) use ($order, $column) {
	if ($s1 -> $column == $s2 -> $column) {
		return strcmp($s1 -> username, $s2 -> username);
	}

	return ($order == "ascending" ^ $s1 -> $column < $s2 -> $column) ? 1 : -1;
});
	
	$result = "<table><thead><tr><th>Id</th><th>Username</th><th>Email</th><th>Type</th><th>Result</th></tr></thead>";
	foreach ($table as $st) {
		$result.="<tr><td>$st->id</td><td>".htmlspecialchars($st->username)."</td><td>".htmlspecialchars($st->email)."</td><td>".htmlspecialchars($st->type)."</td><td>".htmlspecialchars($st->result)."</td></tr>";
	}
	$result.="</table>";
	
	echo $result;
?>