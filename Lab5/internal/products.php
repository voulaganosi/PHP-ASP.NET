<h1>Προιοντα</h1>
<ol>
<?php

$q = 'select * from product order by Title';

if($result = $mysqli->query($q)) {
	while($row = $result->fetch_array()) {
		print "<li><a href='index.php?p=showcat&cid=$row[ID]'>$row[Name]</a></li>";
	}
	
	$result->close();
	
}

?>
</ol>