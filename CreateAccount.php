<?php

//unity import
$user = $_POST["Input_user"];
$pass = $_POST["Input_pass"];
$Info = $_POST["Input_Info"];

// mysql�� ���̵�� ��й�ȣ�� �Է����ش�. 
$con = mysql_connect("nplusy0624.cafe24.com","nplusy0624","histovry15") or ("Cannot connect!" .mysql_error());
if(!$con)
	die('Cound not Connect:' . mysql_error());
mysql_select_db("nplusy0624",$con) or die ("could not load the database" .mysql_error());


$check = mysql_query("SELECT * FROM 'Account' WHERE 'user'='".$user."'");  //Account��� ���̺��� ���� �Է��� ID���� ã�ڴ�. 


// Mysql_num_row()�Լ��� �����ͺ��̽����� ������ ������ ���� ���ڵ��� ������ �˾Ƴ��� ����.
// �� 0�� ���Դٴ� ���� ���� ���� ã�� ID���� ���ٴ� ���̴�. 

$numrows = mysql_num_rows($check);    
if ($numrows == 0)
{
	// ������ �������ִ� ������. 
  $Result =  mysql_query("INSERT INTO  Account VALUES ('$user','$pass','$Info') ");
  
if($Result)
  die("Create Success. \n");
else
  die("Create error. \n");

}

else
{

   die("ID does exist. \n");
}

?>