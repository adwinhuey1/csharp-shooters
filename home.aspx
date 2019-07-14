<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Valkyrie IMS</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="grid">
        <!-- 100% wide -->
     </div>
    
    
        <header>
            <div class="title">
                <div class="col-2-3">
                    <center><h1> Header </h1></center>
                </div>
        </header>
    
        <style>
                * {
                  box-sizing: border-box;
                }
                
                .column {
                  float: left;
                  padding: 10px;
                  height: 300px; 
                }
                
                .left {
                  width: 25%;
                  height: 1000px;
                }
                
                .right {
                  width: 75%;
                  height: 1000px;
                }
                
                .row:after {
                  content: "";
                  display: table;
                  clear: both;
                }
                </style>
    <div class="row">
            <div class="column left" style="background-color:#2E64FE;">
              <h2>Navigation</h2>
              <p>Info</p>
            </div>
            <div class="column right" style="background-color:#F781F3;">
              <h2>Content</h2>
              <p>Info</p>
            </div>
          </div>
    
    
    <style>
      .footer {
        position: fixed;
        left: 0;
        bottom: 0;
        width: 100%;
        background-color: rgb(0, 0, 0);
        color: white;
        text-align: center;
      }
    </style>
            
            <div class="footer">
              <p></p><h2>Footer</h2></p>
            </div>
        </div>
    </form>
</body>
</html>
