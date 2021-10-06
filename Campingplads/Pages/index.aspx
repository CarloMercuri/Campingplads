<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Campingplads.Pages.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Camp Den Blå And</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="/css/main.css" rel="stylesheet" />
    <link rel="icon" type="image/png" href="/images/blue_duck.png" />
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm bg-navcolor navbar-dark fixed-top">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
        <img src="/images/blue_duck.png" alt="Blue Duck Logo" style="width:40px;" /> 
    </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="#">Om Pladsen</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Bestil</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Kontakt</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
<main>
    <div class="row">
            <img class="image-test" src="../Images/camping_main_page3.jpg" alt="View over Camp"/>            
    </div>
    <div class="row">
        <div class="col-2"></div>
        <div class="col-8 content">

            <h1>Velkommen til Camp Den Blå And</h1>
            <h3>Hos os finder du alt det du drømmer om når du holder ferie, om det er nærvær, hygge og sjove oplevelser eller at kommer helt telt på naturen.</h3>
           
        </div>
        <div class="col-2"></div>
    </div>
    <br />
    <br />
    <div class="row"> 
<div class="col-3"></div>
        <div class="col-6">
            
             <div class="order-buttons">
               <asp:ImageButton ID="OrderButtonCabin" runat="server" CssClass="button-style" OnClick="TypeButtonClick"/>
                <asp:ImageButton ID="OrderButtonTent" runat="server" CssClass="button-style" OnClick="TypeButtonClick"/>
                <asp:ImageButton ID="OrderButtonWagon" runat="server" CssClass="button-style" OnClick="TypeButtonClick"/>
                <asp:ImageButton ID="ButtonAdventure" runat="server" CssClass="button-style" />
                <asp:ImageButton ID="OrderButton" runat="server" CssClass="button-style" />
                <asp:ImageButton ID="OrderButtonOffer" runat="server" CssClass="button-style" />
           </div>
        </div>
        <div class="col-3"></div>
    </div>

   
</main>       
    </form>
</body>
</html>
