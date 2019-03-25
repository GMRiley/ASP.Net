<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="Lab_2.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class ="container" style="margin-top:2%;">
         <div class="jumbotron-fluid">
             <h1 class="display-4">Hey my man!</h1>
             <p class="lead">This is apparently called a jumbotron, and I think it looks great for about pages</p>
             <hr class="my-4"/>
             <p>Something relating to bootstrap here</p>
             <p>
                 <a class="btn btn-primary" data-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample">Slidey button
                 </a>
            </p>
            <div class="collapse" id="collapseExample">
                 <div class="card card-body">
                     This is called a card, and that's neat too!
                     <img src="App_Themes/images/index.jpg" class ="img-fluid rounded embed-responsive" style ="width: 70%; margin-left: 15%" />
                 </div>
             </div>

         </div>
    </div>
   
</asp:Content>
