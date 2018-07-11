<table>
<tr>
<th>Title</th>
<th>Price</th>
</tr>
<?php
$cat = $_REQUEST['cid'];
$q = "select * from product where category=?";
$stmt = $mysqli->prepare($q);
$stmt->bind_param("i",$cat);

if($stmt->execute()) {
	$result = $stmt->get_result();
	while($row = $result->fetch_array()) {
		print "<tr><td><a href ='index.php?p=show&cid=$row[ID]'>$row[Title]</a></td><td>$row[Price]</td></tr>";
	}
	
	$result->close();
	
}

?>
</table>