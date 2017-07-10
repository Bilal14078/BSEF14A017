<%-- 
    Document   : results
    Created on : Jan 21, 2017, 2:39:55 AM
    Author     : bilal_000
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import="java.sql.*" import="DBHandler.DBHandler" import="inserted.functions" %>
<!DOCTYPE html>
<!DOCTYPE html>
<html lang="en">

<?php

include("functions/functions.php");

?>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>PS4USED</title>

    <link href="css/bootstrap.min.css" rel="stylesheet">
	<link href="css/mystyle.css" rel="stylesheet">
</head>

<body>
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation" id="topnavc">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
	            <a class="navbar-brand" href="index.php"><img src="img/logo.png" height=100% /></a>
            </div>
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
					<li><a href="#">About</a></li>
                    <li><a href="products.jsp">Products</a></li>
                    <li><a href="#">Contact</a></li>                </ul>
				<div id="searchbar">
				<form method="get" action="results.jsp" enctype="multipart/form-data">
				<input type="text" name="search" placeholder="Search"></input>
				<input type="submit" name="subsearch" value="Go"></input>
				</form>
				</div>
            </div>
		</div>
    </nav>
	
			<div class="container">
                           
                               <h1>Results</h1>
                                <?php searchyeild(); 
				
				?>

                         </div>

    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>

</body>

</html>

