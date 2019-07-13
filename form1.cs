using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ValkyrieIMS.Models;

namespace Login 
{ 
    public partial class MainForm : Form 
    { 
        public MainForm() 
        { 
            InitializeComponent(); 
            
        } 
        
        Login login = new Login("admin", "1234"); 
         
 
        private void button1_Click(object sender, EventArgs e) 
        { 
           
            string user = nametxtbox.Text; 
            string pass = pwdtxtbox.Text; 
            
            if(login.IsLoggedIn(user,pass)) 
            { 
                MessageBox.Show("You are logged in successfully"); 
            } 
            else 
            { 
                 
                MessageBox.Show("Login Error!"); 
            } 
        } 
 
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        { 
            
            MessageBox.Show("Under development"); 
        } 
 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        { 
           
            MessageBox.Show("Under development"); 
        } 
    } 
} 