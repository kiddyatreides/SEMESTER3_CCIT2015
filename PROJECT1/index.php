 <!DOCTYPE html>
 <html lang="en">
<head>
  <title>Rekrutmen Pegawai</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">

  <link rel="stylesheet" href="css/bootstrap.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
</head>
<body>
<!--navbar atasasdsadsa-->
<nav class="navbar navbar-default">
  <div class="container-fluid">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="#">Brand</a>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
        <li class="active"><a href="index.php">Home <span class="sr-only">(current)</span></a></li>
        <li><a href="#">About</a></li>
        <li><a href="#">Vacancy</a></li>
        <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Help <span class="caret"></span></a>
          <ul class="dropdown-menu">
            <li><a href="#">F.A.Q</a></li>
            <li><a href="#">How to register</a></li>
            <li><a href="#">How to apply job</a></li>
          </ul>
        </li>
        <li><a href="#">Contact Us</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
        <form class="navbar-form navbar-left">
          <div class="form-group">
            <input type="text" class="form-control" placeholder="Search" required="">
          </div>
          <button type="submit" class="btn btn-default">Submit</button>
        </form>
        <li><a href="#"data-toggle="modal" data-target="#myModal">Login</a></li>
        <!--<li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Dropdown <span class="caret"></span></a>
          <ul class="dropdown-menu">
            <li><a href="#">Action</a></li>
            <li><a href="#">Another action</a></li>
            <li><a href="#">Something else here</a></li>
            <li role="separator" class="divider"></li>
            <li><a href="#">Separated link</a></li>
          </ul>
        </li>-->
        <!-- Trigger the modal with a button -->

      </ul>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>
<!--navbar end-->

<!--content start-->
<div class="container">
<div id="myCarousel" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
    <li data-target="#myCarousel" data-slide-to="3"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
      <img src="images/23236.jpg" alt="Chania">
    </div>

    <div class="item">
      <img src="images/23236.jpg" alt="Chania">
    </div>

    <div class="item">
      <img src="images/23236.jpg" alt="Flower">
    </div>

    <div class="item">
      <img src="images/23236.jpg" alt="Flower">
    </div>
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
</div>


<div class="container">
	<div class="jumbotron">
	  <center><h1>Welcome to Jobfield Recruitment</h1></center>
	  <center><p>You can apply the job below. Make sure you are suitable for the job recruitment, choose the best jobdesk which suit for you to work at the company.</p></center>
	  <!--<p><a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a></p>-->
	</div>
</div>

<div class="container">
  <center> <h1>Berita Lowongan</h1></center>
  <div class="row">
  <!--Berita-->
  <?php
// untuk meload data xml (buku.xml) dengan cara SimpleXML 
$news = new SimpleXMLElement('berita.xml', null, true);
 
// menampilkan data ke XML ke dalam tabel HTML
 // melakukan looping penampilan data buku
foreach($news as $berita)
{
  echo "
  <div class='col-sm-6 col-md-4'>
    <div class='thumbnail'>
      <br>
      <img src='images/briefcase.png' width='150px'; height='150px';>
      <div class='caption'>
        <center><h3>{$berita->judul}</h3></center>
        <br>
        <center><p>{$berita->isi}<br><br> <a href='vacancy.html'>Lihat Selengkapnya Disini</a></p></center>

      </div>
    </div>
  </div>";
}?>
  <!--berita end-->

  
</div>

<div class="clearfix"></div>

<!--content end-->

<footer class="footer">
<br>
<br>
  <div class="container">
    <center><p class="text-muted">Copyright 2016. Rekrutmen Pegawai Online.<br> Created by <a href="http://id.linkedin.com/in/4eekid">M Hudya Ramadhana</a> & Mutia Ayu Dianita</p></center> 
  </div>



<!-- Modal -->
<div id="myModal" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <center><h4 class="modal-title">Login</h4></center>
      </div>
      <div class="modal-body">
        <form class="form-horizontal">
  <div class="form-group">
    <label class="control-label col-sm-2" for="email">Username </label>
    <div class="col-sm-10">
      <input type="text" class="form-control" id="username" placeholder="Enter username" required="Please enter your username">
    </div>
  </div>
  <div class="form-group">
    <label class="control-label col-sm-2" for="pwd">Password:</label>
    <div class="col-sm-10">
      <input type="password" class="form-control" id="pwd" placeholder="Enter password" required="Please enter your password">
    </div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
      <div class="checkbox">
        <label><input type="checkbox"> Remember me</label>
      </div>
    </div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
      <button type="submit" class="btn btn-default">Login</button
    </div>
    <br><br>
    <div>
      <p>Forget Password ? Click <a href="#"> here</a></p>
    </div>
  </div>
</form>

      </div>
      <div class="modal-footer">
        <p> New Account ? Register <a href="http://www.facebook.com">here</a> </p>
      </div>
    </div>

  </div>
</div>
<!--modal end-->

</footer>
</body>
</html>