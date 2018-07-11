<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<?php
	session_start();
?>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
<style>
#menu {
	width:100%;
	background-color:blue;
	color:white;
}
#menua{
	color:white;
}

#leftmenu {
	widows:20em;
	height:20em;
	background-color:red;
}
</style>
</head>

<body>
<div id="menu">
<a href="index.php?p=index">Arxiki</a>
<a href="?p=shopinfo">Katastima</a>
<a href="?p=products">Proionta</a>
<a href="?p=login">Login</a>
<?php
	if(!isset($_SESSION['username'])) {
		$_SESSION['username']='?';
	}
	print "User: $_SESSION[username]";
?>
<div id="leftmenu">

</div>

<div id="contents">
<?php
	if(!isset($_REQUEST['p'])) { $_REQUEST['p']='index';}
	switch ($_REQUEST['p']) {
	case 'index': print "Arxiki";
		break;
	case 'shopinfo': print "ShopInfo";
		break;
	case 'login': require "login.php";
		break;
	case 'dologin' : require "dologin.php";
		break;
	default : print "Den to ftiaksame";	
	}
?>
</div>
</body>

</html>
