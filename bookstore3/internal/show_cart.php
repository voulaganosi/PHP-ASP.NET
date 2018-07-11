<table class='table table-striped'>
<tr>
<th>Τίτλος</th>
<th>Τιμή</th>
<th>Τεμάχια</th>
<th>Συνολική Τιμή</th>
</tr>
<?php
/// Εδώ είναι σημαντική η χρήση prepared statements
$sql = "select * from product where id=?";
if(! isset($_SESSION['cart']) || ! is_array($_SESSION['cart'])) {
	print "Το καλάθι είναι άδειο";
} elseif( $stmt = $mysqli->prepare($sql) ) {
	$sum=0;
	foreach($_SESSION['cart'] as $k=>$v) {
		$stmt->bind_param("i", $k);
		$stmt->execute();
		$result = $stmt->get_result();
		$row = $result->fetch_assoc();
		$result->free_result();
		print "<tr><td>$row[Title]</td>";
		print "<td>$row[Price]</td>";
		print "<td>$v</td>";
		$price=$row['Price']* $v;
		$sum += $price;
		print "<td>$price</td>";
		print "</tr>";
	}
	print "<tr><th colspan='3'>Συνολο</th><th>$sum</th></tr>";

}
?>
</table>
