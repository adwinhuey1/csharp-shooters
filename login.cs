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
    class Login 
    { 
       
        public string Username { get; set; } 
        public string Userpassword { get; set; } 
         
      
        public Login(string user, string pass) 
        { 
            this.Username = user; 
            this.Userpassword = pass; 
        } 
       
        private bool StringValidator(string input) 
        { 
            string pattern = "[^a-zA-Z]"; 
            if(Regex.IsMatch(input,pattern)) 
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            } 
        } 
    
        private bool IntegerValidator(string input) 
        { 
            string pattern = "[^0-9]"; 
            if(Regex.IsMatch(input,pattern)) 
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            } 
        } 
       
        private void ClearTexts(string user, string pass) 
        { 
            user = String.Empty; 
            pass = String.Empty; 
        } 
     
        internal bool IsLoggedIn(string user, string pass) 
        { 
         
            if (string.IsNullOrEmpty(user)) 
            { 
                MessageBox.Show("Enter the user name!"); 
                return false; 
 
            } 
           
            else if (StringValidator(user) == true) 
            { 
                MessageBox.Show("Enter only text here"); 
                ClearTexts(user,pass); 
                return false; 
            } 
            
            else 
            { 
                if (Username != user) 
                { 
                    MessageBox.Show("User name is incorrect!"); 
                    ClearTexts(user,pass); 
                    return false; 
                } 
   
                else 
                { 
                    if (string.IsNullOrEmpty(pass)) 
                    { 
                        MessageBox.Show("Enter the passowrd!"); 
                        return false; 
                    } 
 
                    else if (IntegerValidator(pass) == true) 
                    { 
                        MessageBox.Show("Enter only integer here"); 
                        return false; 
                    } 

                    else if(Userpassword!=pass) 
                    { 
                        MessageBox.Show("Password is incorrect"); 
                        return false; 
                    } 
                    else 
                    { 
                        return true; 
                    } 
                } 
            } 
        } 
    } 
} 