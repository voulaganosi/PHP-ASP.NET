<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>
	<?php
		$photos = array("http://php.net/manual/en/images/c0d23d2d6769e53e24a1b3136c064577-php_logo.png",
		 "http://www.atlantasky.com/wp-content/uploads/2013/08/PHP-Mysql.png",
		  "https://www.neovera.com/wp-content/uploads/2015/04/php-elephant.png",
		  "http://www.itvedant.com/wp-content/uploads/2013/03/php.jpg",
		  "https://wpbits.files.wordpress.com/2007/08/top_of_install_php.png");
		  
		  $x = rand(0,4);
		  echo "<img src = $photos[$x]>";
	?> 
</body>

</html>
