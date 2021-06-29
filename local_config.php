<?php 
	# DATABASE credential
	$host = "ec2-54-91-188-254.compute-1.amazonaws.com";
	$db_name = "d2ng1prokac0gc";
	$db_user = "kfhmeqvuzdwmip";
	$db_pwd = "cfd1beb886d10c49708ea11fa188b5c48c6a1afe3d8d0a5a874dc25b9807f29f";
	# Create connection to Heroku Postgres
	$conn_string = "host=$host port=5432 dbname=$db_name user=$db_user password=$db_pwd";		
?>