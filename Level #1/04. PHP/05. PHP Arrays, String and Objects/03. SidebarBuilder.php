<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style>
        div {
        	background: #d2dfed; /* Old browsers */
			background: -moz-linear-gradient(top,  #d2dfed 0%, #c8d7eb 26%, #bed0ea 51%, #a6c0e3 51%, #afc7e8 62%, #bad0ef 75%, #99b5db 88%, #799bc8 100%); /* FF3.6+ */
			background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#d2dfed), color-stop(26%,#c8d7eb), color-stop(51%,#bed0ea), color-stop(51%,#a6c0e3), color-stop(62%,#afc7e8), color-stop(75%,#bad0ef), color-stop(88%,#99b5db), color-stop(100%,#799bc8)); /* Chrome,Safari4+ */
			background: -webkit-linear-gradient(top,  #d2dfed 0%,#c8d7eb 26%,#bed0ea 51%,#a6c0e3 51%,#afc7e8 62%,#bad0ef 75%,#99b5db 88%,#799bc8 100%); /* Chrome10+,Safari5.1+ */
			background: -o-linear-gradient(top,  #d2dfed 0%,#c8d7eb 26%,#bed0ea 51%,#a6c0e3 51%,#afc7e8 62%,#bad0ef 75%,#99b5db 88%,#799bc8 100%); /* Opera 11.10+ */
			background: -ms-linear-gradient(top,  #d2dfed 0%,#c8d7eb 26%,#bed0ea 51%,#a6c0e3 51%,#afc7e8 62%,#bad0ef 75%,#99b5db 88%,#799bc8 100%); /* IE10+ */
			background: linear-gradient(to bottom,  #d2dfed 0%,#c8d7eb 26%,#bed0ea 51%,#a6c0e3 51%,#afc7e8 62%,#bad0ef 75%,#99b5db 88%,#799bc8 100%); /* W3C */
			filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#d2dfed', endColorstr='#799bc8',GradientType=0 ); /* IE6-9 */

        	width: 150px;
            border: 1px solid black;
            border-radius: 30px;
            margin: 30px;
        }
        h2 {
        	margin: 0;
            margin-left: 10px;
            margin-top: 20px;
        }
        hr{
        	1px solid black;
        	margin-left: 15px;
        }
    </style>
</head>
<body>
    <form method="post">
    	<label for="categ">Categories:</label>
        <input type="text" id="categ" name="categories" placeholder="enter categories:" /><br/>
    	<label for="tags">Tags:</label>
        <input type="text" id="tags" name="tags" placeholder="enter tags:" /><br/>
    	<label for="months">Months:</label>
        <input type="text" id="months" name="months" placeholder="enter months:" /><br/>
        <input type="submit" value="Submit"/>
    </form>
	
	<?php
	
		if (isset($_POST)) {
			$categories = $_POST['categories'];
			$tags = $_POST['tags'];
			$months = $_POST['months'];
			
			$categoriesArr = explode(", ", $categories);
			$tagsArr = explode(", ", $tags);
			$monthsArr = explode(", ", $months);
		}
	
	?>
    <div>
        <h2>Categories</h2>
        <hr/>
        <ul>
            <?php
            	foreach ($categoriesArr as $value) {
					echo "<li>$value</li>";
				}
            ?>
        </ul>
    </div>

    <div>
        <h2>Tags</h2>
        <hr/>
        <ul>
            <?php
            	foreach ($tagsArr as $val) {
					echo "<li>$val</li>";
				}
            ?>
        </ul>
    </div>

    <div>
        <h2>Months</h2>
        <hr/>
        <ul>
            <?php
            	foreach ($monthsArr as $v) {
					echo "<li>$v</li>";
				}
            ?>
        </ul>
    </div>
</body>
</html>