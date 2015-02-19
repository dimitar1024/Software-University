<?php
$text = $_GET['text'];
$artist = $_GET['artist'];
$property = $_GET['property'];
$order = $_GET['order'];
$table = array();
$lines = preg_split("/\n/", $text);

foreach ($lines as $key => $line) {
	$input = preg_split("/\|/", $line);
	$currentSong = new stdClass();

	$currentSong -> name = trim($input[0]);
	$currentSong -> genre = trim($input[1]);
	$artists = explode(", ", trim($input[2]));
	sort($artists);
	$currentSong -> artists = $artists;
	$currentSong -> downloads = trim($input[3]);
	$currentSong -> rating = floatval(trim($input[4]));

	if (in_array($artist, $artists)) {
		$table[] = $currentSong;
	}
}
usort($table, function($s1, $s2) use ($order, $property) {
	if ($s1 -> $property == $s2 -> $property) {
		return strcmp($s1 -> $name, $s2 -> $name);
	}

	return ($order == "ascending" ^ $s1 -> $property < $s2 -> $property) ? 1 : -1;
});

echo "<table>\n<tr><th>Name</th><th>Genre</th><th>Artists</th><th>Downloads</th><th>Rating</th></tr>\n";
foreach ($table as $value) {
	echo "<tr>";
	$artists = htmlspecialchars(implode(", ", $value -> artists));
	$value -> name = htmlspecialchars($value -> name);
	$value -> genre = htmlspecialchars($value -> genre);

	echo "<td>$value->name</td><td>$value->genre</td><td>$artists</td><td>$value->downloads</td><td>$value->rating</td>";
	echo "</tr>\n";
}
echo "</table>"
?>

