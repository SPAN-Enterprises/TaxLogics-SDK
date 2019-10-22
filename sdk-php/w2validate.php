<!DOCTYPE html>
<html>

<meta http-equiv="content-type" content="text/html;charset=utf-8" />
<head>

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>FormW2 Return</title>

    <script src="http://apiclient.taxvari.com/bundles/jquery?v=MRjVrMuK9DXe6nW0tFmw9cj1pT5oo4Jf-eJQmGfwEF01"></script>

    <script src="http://apiclient.taxvari.com/bundles/bootstrap?v=-g7cxTWQV6ve_iRyKtg7LoBytQltgj_w8zTNeaLaBc41"></script>

    <link href="http://apiclient.taxvari.com/Content/css?v=LUJ4d8snobbjVqJ-k1JMBOZdx-2KR1NmgrIYGvdx8YA1" rel="stylesheet"/>

    <script src="http://apiclient.taxvari.com/bundles/modernizr?v=w9fZKPSiHtN4N4FRqV7jn-3kGoQY5hHpkwFv5TfMrus1"></script>

    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/font-awesome.css" rel="stylesheet" />
    <link href="Content/toastr.html" rel="stylesheet" />
    <script src="Scripts/toastr.js"></script>
	
    <link rel="icon" href="http://apiclient.taxvari.com/Content/Images/favicon.ico" type="image/x-icon">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,800italic,800,700italic' rel='stylesheet' type='text/css'>

</head>
<body>
    <header class="navbar navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <div class="row">
                    <div class="col-md-4">
                        <img src="Content/Images/logoHead.png" />
                    </div>
                    <div class="col-md-8 floatR">
                        <a href="tel:7046844751" class="linkText floatR">
                            <img src="Content/Images/phone_icon.png" alt="" title="" />
                            704.684.4751
                        </a>
                        <ul class="nav navbar-nav nav_menu floatR">
                            <li id="liformw2return"><a href="index.php">Create Return</a></li>
							<li  class="active" id="liformw2return"><a href="w2validate.php">Validate & Transmit Return </a></li>                           
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </header>
    <div class="clearfix"></div>
    <div class="clearfix"></div>
    <div class="body-content container">
		
		<br><br><br><br><br><br>
		<form action="validateReturn.php" method="post"> 
		
			<table class="responsive">
				<tr>
					<td class="labelName"><label class="control-label">Submission Id:</label></td><td>&nbsp;&nbsp;</td>
					<td class="fieldName"><input class="form-control" name="SubmissionId" type="text" placeholder="SubmissionId" /></td>
					<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
					<td>
						<input type="submit" value="Validate" class="btn btn_primary"/>
					</td>
				</tr>
			</table>
		</form>
		<br><br><br><br>
		<form action="transmit.php" method="post"> 

			<table class="responsive">
				<tr>
					<td class="labelName"><label class="control-label">Submission Id:</label></td><td>&nbsp;&nbsp;</td>
					<td class="fieldName"><input class="form-control" name="SubmissionId" type="text" placeholder="SubmissionId" /></td>
					<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
					<td>
						<input type="submit" value="Trasnmit" class="btn btn_primary"/>
					</td>
				</tr>
			</table>
		</form>
    </div>
    <footer></footer>
</body>
</html>
