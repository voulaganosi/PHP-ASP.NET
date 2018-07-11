<ul>
<?php

$q = 'select * from category';

if($result = $mysqli->query($q)) {
	while($row = $result->fetch_array()) {
		print "<li><a href='index.php?p=showcat&cid=$row[ID]'>$row[Name]</a></li>";
	}
	
	$result->close();
	
}

?>
</ul>