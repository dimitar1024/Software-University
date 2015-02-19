<!DOCTYPE html>
// 18:53 6.12.2014
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta charset="utf-8" />
		<title></title>
	</head>

	<body>
		<form method="post">
			<p>
				Enter HTML tags:
			</p>
			<input type="text" name="tag" placeholder="Enter tag" />

			<input type="submit" name="submit" value="Submit" />
		</form>
		<?php
		$allTags = ['html', 'head', 'body', 'div', 'span', 'title', 'link', 'meta', 'style', 'p', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'strong', 'em', 'abbr', 'acronym', 'address', 'bdo', 'blockquote', 'cite',
		 'q', 'code', 'ins', 'del', 'pre', 'i', 'samp', 'br', 'a', 'img', 'area', 'ul', 'ol', 'li', 'dl', 'dt', 'dd', 'table', 'tr', 'td', 'th', 'tbody', 'thead', 'tfoot', 'caption', 'form', 'input', 'textarea', 
		 'select', 'option', 'button', 'label', 'legend', 'script', 'hr', 'b', ];
		$_SESSION['count'] = 0;
		$score = 0;
		if (isset($_POST['tag'])) {
			session_start();
			$tag = $_POST['tag'];
			if (in_array($tag, $allTags)) {
				$_SESSION['count']++;
				$score = $_SESSION['count'];
				echo "<h1>Valid HTML tag! </h1><h2> Score: $score</h2>";
			} else {
				$score = $_SESSION['count'];
				echo "<h1>Invalid HTML tag! </h1><h2> Score: $score</h2>";
			}
		}
		?>
	</body>
</html>