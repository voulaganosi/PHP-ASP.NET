<table>
<tr>
<th>Title</th>
<th>Desc</th>
</tr>
<?php
$cat = $_REQUEST['cid'];
$q = "select * from product where id=?";
$stmt = $mysqli->prepare($q);
$stmt->bind_param("i",$cat);

if($stmt->execute()) {
	$result = $stmt->get_result();
	while($row = $result->fetch_array()) {
		print "<tr><td>$row[Title]</td><td>$row[Description]</td></tr>";
	}
	
	$result->close();
	
}

?>
</table>