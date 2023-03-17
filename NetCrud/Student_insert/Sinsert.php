<?php
class FB{
    public $link='';
    //function __construct($id,$fname,$mname,$lame,$std,$email,$prn,$sub,$marks,$intrest)
    function __construct($id,$fname,$mname,$lame,$std,$email,$prn,$sub,$marks,$intrest){
        $this->connect();
        //$this->storeInDB($id,$fname,$mname,$lame,$std,$email,$prn,$sub,$marks,$intrest);
        $this->storeInDB($id,$fname,$mname,$lame,$std,$email,$prn,$sub,$marks,$intrest);
    }
    function connect(){
        $this->link = mysqli_connect('182.50.133.77','prabudh','Prabudh@123') or die('Cannot connect to the DB');
        mysqli_select_db($this->link,'prabudhbharat') or die('Cannot select the DB');
       }
//function storeInDB($id,$fname,$mname,$lame,$std,$email,$prn,$sub,$marks,$intrest){
    function storeInDB($id,$fname,$mname,$lame,$std,$email,$prn,$sub,$marks,$intrest){
    //$query="INSERT INTO Student_Info(ID,First_Name,Middle_Name,Last_Name,Std,Email,PRN,Subject,Marks,Intrest) VALUES ('$id','$fname','$mname','$lame','$std','$email','$prn','$sub','$marks','$intrest')";
    $query="INSERT INTO Student_Info(ID,First_Name,Middle_Name,Last_Name,Std,Email,PRN,Subject,Marks,Intrest) VALUES ('$id','$fname','$mname','$lame','$std','$email','$prn','$sub','$marks','$intrest')";
    $result = mysqli_query($this->link,$query) or die('Errant query:  '.$query);
    if($result===true)
    {
        echo "Registration Success";
    }
    
   

  }
  
 
}
//if($_GET['id'] != ''and $_GET['fname'] != '' and $_GET['mname'] !='' and $_GET['lame'] != ''and $_GET['std'] != '' and $_GET['email'] !='' and $_GET['prn'] != ''and $_GET['sub'] != '' and $_GET['marks'] !='' and $_GET['intrest'] != ''){
 	//$FB=new FB($_GET['id'],$_GET['fname'],$_GET['mname'],$_GET['lame'],$_GET['std'],$_GET['email'],$_GET['prn'],$_GET['sub'],$_GET['marks'],$_GET['intrest']);
     if($_GET['id'] != ''and $_GET['fname'] != '' and $_GET['mname'] != ''and $_GET['lame'] != '' and $_GET['std'] != '' and $_GET['email'] !='' and $_GET['prn'] != ''and $_GET['sub'] != '' and $_GET['marks'] !='' and $_GET['intrest'] != ''){
        $FB=new FB($_GET['id'],$_GET['fname'],$_GET['mname'],$_GET['lame'],$_GET['std'],$_GET['email'],$_GET['prn'],$_GET['sub'],$_GET['marks'],$_GET['intrest']);
    
}
?>
