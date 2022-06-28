﻿using E_Commerce.Models.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace E_Commerce.Models.Services
{
    public class EmailService : IEmail
    {
        public string CartCookie { get; set; }
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendMail(string email, List<Product> products)
        {
            SendGridClient client = new SendGridClient(_configuration.GetConnectionString("APIKEY"));
            SendGridMessage msg = new SendGridMessage();
            msg.SetFrom("21028869@student.ltuc.com", "IT Team");
            msg.AddTo(email);
            msg.SetSubject("Purchase Recite");
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine(string.Format("Name: {0}\n", product.Name));
                sb.AppendLine(string.Format("Price: {0}\n", product.Price));
                sb.AppendLine(string.Format("Email: {0}\n", product.InStock));
                sb.AppendLine(string.Format("--------------------"));

            }
            string body = sb.ToString();
            msg.AddContent(MimeType.Html, $"Thank you for your purchase! \n {body}");
            

            SendGridMessage msgSales = new SendGridMessage();
            msgSales.SetFrom("21028869@student.ltuc.com", "IT Team");
            msgSales.AddTo("laithalamat4@gmail.com");
            msgSales.SetSubject("Sales Recite");
            msgSales.AddContent(MimeType.Html, $"Customer Recite \n {body}");

            SendGridMessage msgWarehouse = new SendGridMessage();
            msgWarehouse.SetFrom("21028869@student.ltuc.com", "IT Team");
            msgWarehouse.AddTo("osama.alzaghal@gmail.com");
            msgWarehouse.SetSubject("WareHouse Recite");
            msgWarehouse.AddContent(MimeType.Html, $"Customer Order \n {body}");


            await client.SendEmailAsync(msg);
            await client.SendEmailAsync(msgSales);
            await client.SendEmailAsync(msgWarehouse);

        }

        public async Task WelcomeMail(string email)
        {
            SendGridClient client = new SendGridClient(_configuration.GetConnectionString("APIKEY"));
            SendGridMessage msg = new SendGridMessage();
            msg.SetFrom("21028869@student.ltuc.com", "Store Team");
            msg.AddTo(email);
            msg.SetSubject("Welcome to our store!");
            msg.AddContent(MimeType.Html, "You have successfully registered an account to our store, Welcome!");
            await client.SendEmailAsync(msg);
        }
    }
}
