<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<?php
session_start();
if( ! isset($_SESSION['username'])) {
	$_SESSION['username']='?';
}
?>

<?php
	require_once 'internal/dbconnect.php';
?>

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
<link href="layout.css" rel="stylesheet" type="text/css" />
</head>

<body>
<div id="top">
<a href="index.php?p=start">Αρχική</a>
<a href="?p=shopinfo">Κατάστημα</a>
<a href="?p=products">Προϊόντα</a>
<a href="?p=show_cart">Καλάθι Αγορών</a>
<a href="?p=contact">Επικοινωνία</a>
<a href="?p=login">Login</a>
</div>
<div id="left">
<?php
	print "<p>This is user: $_SESSION[username]</p>";
	if($_SESSION['username']=='admin') {
		print "<h2>Admin MENU</h2>";
	}
?>
<?php
	if($_SESSION['username']!=='' and $_SESSION['username']!=='?' and $_SESSION['username']!=='admin'){
		print "<a href="."?p=myorders".">Εμφάνιση παραγγελιών</a>";
		print "<br/>";
		print "<a href="."?p=mydetails".">Στοιχεία πελάτη</a>";
		print "<br/>";
		print "<a href="."?p=logout".">Logout</a>";
	}

?>

<?php
	if($_SESSION['username']=='admin'){
		print "<a href="."?p=customers".">Λίστα πελατών</a>";
		print "<br/>";
		print "<a href="."?p=orders".">Λίστα παραγγελιών</a>";
		print "<br/>";
		print "<a href="."?p=prod".">Προιοντα</a>";
		print "<br/>";

		print "<a href="."?p=logout".">Logout</a>";
	}
?>

<?php
	require "internal/menuleft.php";
?>
</div>
<div id="content">
<?php
if( ! isset($_REQUEST['p'])) {
	$_REQUEST['p']='start';
}
$p = $_REQUEST['p'];
print "must require page: internal/$p";
switch ($p){
case "start" :		require "internal/start.php";
					break;
case "shopinfo": 	require "internal/shopinfo.php";
					break;
case "login" :		require "internal/login.php";
					break;
case 'do_login':	require "internal/do_login.php";
					break;
case 'logout':		require "internal/logout.php";
					break;
case 'showcat':		require "internal/showcat.php";
					break;
case 'show':		require "internal/prod_info.php";
					break;
case 'buy':			require "internal/buy.php";
					break;

//case 'show':		require "internal/show.php";
					//break;
case 'add_cart':	require "internal/add_cart.php";
case 'show_cart':	require "internal/show_cart.php";
					break;
case 'prod':		require "internal/products.php";
					break;
case 'pedit':		require "internal/pedit.php";
					break;
default: 
	print "Η σελίδα δεν υπάρχει";
}
?>
</div>
<div id="footer"></div>
</body>
</html>
