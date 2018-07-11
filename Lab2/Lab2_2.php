<html>
  <head>
     <title>My first php</title>
   </head>
   <body>
   	
   <table style="width: 100%">
   		<?php
   		$rows = 10;
   		$cols = 10;
			for($i=0; $i<$rows; $i++){
				
				print "<tr>";
				for($j=0; $j<$cols; $j++){
					$x = rand(1,10);
				if($x<5){
					$color = 'red';
				} else {
					$color = 'green';
				}
					print "<td style='background-color:$color;'>$x";
					print "</td>";					
				}
				print "</tr>";
			}
	
		?>
   </table>
   	
   </body>
</html>