<table class='table table-striped'>
<form action='' method='get'>
<input type='hidden' name='p' value='buy'/>

<tr><th>Τίτλος</th><th>Τιμή</th><th>Τεμάχια</th><th>Συνολική Τιμή</th></tr>
<?php
/// Ξ•Ξ΄Ο ΞµΞ―Ξ½Ξ±ΞΉ ΟƒΞ·ΞΌΞ±Ξ½Ο„ΞΉΞΊΞ® Ξ· Ο‡ΟΞ®ΟƒΞ· prepared statements
$sql = "select * from product where id=?";
if(! isset($_SESSION['cart']) || ! is_array($_SESSION['cart'])) {
	print "Ξ¤ΞΏ ΞΊΞ±Ξ»Ξ¬ΞΈΞΉ ΞµΞ―Ξ½Ξ±ΞΉ Ξ¬Ξ΄ΞµΞΉΞΏ";
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
		print "<td>$price</td></tr>";
	}
	print "<tr><th colspan='3'>Συνολο</th><th>$sum</th></tr>";
} else {print "Ξ­Ξ³ΞΉΞ½Ξµ ΟƒΟ†Ξ¬Ξ»ΞΌΞ±";}
print "<td><input type='submit' name='submit' value='Αγορα'></td>";
   ?>
</form>
</table>
