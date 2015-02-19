<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>

    <body>
        <form method="get">
            <label for="amount">Enter Amount</label>
            <input type="text" id="amount"name="amount" placeholder="Enter amount" /><br />
            <label for="usd">USD</label>
            <input type="radio" id="usd" name="currency" value="usd" />
            <label for="eur">EUR</label>
            <input type="radio" id="eur" name="currency" value="eur" />
            <label for="bgn">BGN</label>
            <input type="radio" id="bgn" name="currency" value="lv" /><br />
            
            <label for="cia">Compound Interest Amount</label>
            <input type="text" id="cia" name="cia" placeholder="Enter amount" /><br />
            <select name="months">
                <option value="6">6 Months</option>
                <option value="12">1 Year</option>
                <option value="24">2 Years</option>
                <option value="60">5 Years</option>
            </select>
            <input type="submit" name="submit" value="Calculate" />
        </form>
        <?php
        	if (isset($_GET)) {
				$amount = (float)$_GET['amount'];
				$currency = floatval(str_replace(',', '.', $_GET['currency']));
				$cia = floatval(str_replace(',', '.', $_GET['cia']));
				$months = (int)$_GET['months'];
				
				$interest = 100 + ($cia/12);
				
				$sum = $amount;
				
				for ($i=0; $i < $months; $i++) { 
					$sum*= $interest/100;
				}
				
				$sum = number_format($sum, 2, '.','');
				
				
				if ($currency == "usd") {
					echo '$ '. $sum;
				}
				else if ($currency == "eur") {
					echo $sum.' € ';
				}
				else if ($currency == "lv") {
					echo $sum. 'lv ';
				}
			}
        ?>
    </body>
</html>