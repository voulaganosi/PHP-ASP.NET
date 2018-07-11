<?php
if(! isset($_SESSION['cart']) || ! is_array($_SESSION['cart'])) {
	$_SESSION['cart']=array();
}
$cart= &$_SESSION['cart'];
$p = intval($_REQUEST['prod_id']);
$a = intval($_REQUEST['posotita']);

if(!isset($cart["$p"])) { $cart["$p"]=0;}
$cart["$p"]+=$a;

print "Ξ ΟΞΏΟƒΟ„Ξ­ΞΈΞ·ΞΊΞ±Ξ½ $a Ο„ΞµΞΌΞ¬Ο‡ΞΉΞ± ΟƒΟ„ΞΏ ΞΊΞ±Ξ»Ξ¬ΞΈΞΉ ΟƒΞ±Ο‚";

?>
