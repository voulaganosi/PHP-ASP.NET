<?php
	if($_REQUEST['username']=='admin' && $_REQUEST['pass']=='123') {
		print "welcome admin";
		$_SESSION['username'] = 'admin';
	}elseif($_REQUEST['username']=='asidirop' && $_REQUEST['pass']=='123'){
		print "welcome asidirop";
		$_SESSION['username'] = 'asidirop';
	}else {
		print "Unknown user";
	}
	
?>