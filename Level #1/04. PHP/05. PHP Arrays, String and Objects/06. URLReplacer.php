<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title></title>
	</head>
	<body>
		<form method="post">
			<textarea name="text" placeholder="Enter text"></textarea>
			<input type="submit" name="submit" value="Submit" />
		</form>

		<?php

		if (isset($_POST)) {

			$text = trim($_POST['text']);
			
				$pattern = "/<\/a>/"; // replace close A tag
				$replacement = "[/URL]";
				
				$text = preg_replace($pattern, $replacement, $text);
				
				$pattern = "/<a href=\"/"; // replace start open A tag
				$replacement = "[URL=";
				
				$text = preg_replace($pattern, $replacement, $text);
				
				$pattern = "/[URL=[^>]*\">/"; // replace end open A tag
				$replacement = "]";
				
				$text = preg_replace($pattern, $replacement, $text);
				
			echo "$text";
		}
		?>
	</body>
</html>
