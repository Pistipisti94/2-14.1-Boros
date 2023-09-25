<body>
<h1>Welcome</h1>
<div class="container">
    <?php echo require_once("menu.php"); 
    switch ($menuItem) {
        case 'home':
            require_once("home.php");
            break;
        
        case 'termekek':
            require_once("termekek.php");
            break;
        
        case 'login':
            require_once("login.php");
            break;
        
        default:
        echo("Szia Lajos!");
            break;
    }
    
    ?>
    <div class="row">
        <div class="col-6 bg-info">b</div>
        <div class="col-6 bg-warning">a</div>
    </div>

</div>
</body>
</html>