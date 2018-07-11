<form action='' method='get'>
<input type='hidden' name='p' value='add_cart'/>
<table>
<tr>
<th>Titlos</th>
<th width='35%'>ΞΒ ΞΒµΞΒΞΞ‰ΞΒ³ΞΒΞΒ±Ξβ€ ΞΒ®</th>
<th>ΞΒ¤ΞΞ‰ΞΞΞΒ®</th>
<th>ΞΒ ΞΞΞΖ’ΞΒΞβ€ΞΒ·Ξβ€ΞΒ±</th>
<th>ΞΒ ΞΒΞΞΞΖ’ΞΞΞΒ®ΞΞΞΒ·</th>
</tr>
<?php
$id = $_REQUEST['cid'];
$sql = "select * from product where id=?";
//print "<pre>DEBUG:: cat = $cat</pre>";
print "<pre>DEBUG:: sql = $sql</pre>";

if( $stmt = $mysqli->prepare($sql) ) {
	$stmt->bind_param("i", $id);
	$stmt->execute();
	$result = $stmt->get_result();
	while ($row = $result->fetch_assoc()) {

		print "<tr><td>$row[Title]</td>";
		print "<td>$row[Description]</td>";
		print "<td>$row[Price]</td>";
		print "<td><input type='number' name='posotita' value='1'/></td>";
		print "<input type='hidden' name='prod_id' value='{$row['ID']}'/>";
		print "<td><input type='submit' name='submit' value='Προσθηκη στο Καλαθι'></td>";
		print "</tr>";
	}

}
?>
</table>
</form>
