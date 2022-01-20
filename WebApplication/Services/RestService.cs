using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using Newtonsoft.Json;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class RestService
    {
        HttpClient _client;
        private readonly EmployeeContext _context;
     


        public RestService(EmployeeContext context)
        {
            _context = context;
            _client = new HttpClient();

        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            WeatherData weatherData = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                    SaveWeatherData(weatherData);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            

            return weatherData;
        }
        public void SaveWeatherData(WeatherData weatherData)
        {
            string Country = weatherData.City.Name.ToString();
            string WdataDAYONE = weatherData.WeatherDataInfo[0].Weather[0].Description.ToString();
            string WdataDAYTWO = weatherData.WeatherDataInfo[1].Weather[0].Description.ToString();
            string WdataDAYTHREE = weatherData.WeatherDataInfo[2].Weather[0].Description.ToString();
            string WdataDAYFOUR = weatherData.WeatherDataInfo[3].Weather[0].Description.ToString();
            string WdataDAYFIVE = weatherData.WeatherDataInfo[4].Weather[0].Description.ToString();

            string WdataOne= " Day 1 = " + WdataDAYONE;
            string WdataTwo = "Day 2 = " + WdataDAYTWO;
            string WdataThree = "Day 3 = " + WdataDAYTHREE;
            string WdataFour = "Day 4 = " + WdataDAYFOUR;
            string WdataFIVE = "Day 5 =" + WdataDAYFIVE;

            string Day_one = WeatherDecision(WdataDAYONE);
            string Day_two = WeatherDecision(WdataDAYTWO);
            string Day_three = WeatherDecision(WdataDAYTHREE);
            string Day_four = WeatherDecision(WdataDAYFOUR);
            string Day_five = WeatherDecision(WdataDAYFIVE);






            string MailBody = "<!DOCTYPE html>" +
                             "<html> " +
                                 "<body style=\"background -color:#ff7f26;text-align:center;\"> " +
                                 "<h1 style=\"color:#051a80;\">Welcome to Weather Application</h1> " +
                                 "<h2 style=\"color:#000000;\">The Weather for Day 1 .</h2> " +
                                 @WdataOne +
                                 @Day_one+
                                "<h2 style=\"color:#000000;\">The Weather for Day 2 .</h2> " +
                                 @WdataTwo +
                                 @Day_two+
                                "<h2 style=\"color:#000000;\">The Weather for Day 3 .</h2> " +
                                 @WdataThree +
                                 Day_three+
                                 "<h2 style=\"color:#000000;\">The Weather for Day 4 .</h2> " +
                                 @WdataFour +
                                 @Day_four+
                                 "<h2 style=\"color:#000000;\">The Weather for Day 5 .</h2> " +
                                 @WdataFIVE +
                                 @Day_five+
                                 "</body> " +
                             "</html>";
            string subject = "The Weather forecast for the next 5 days for " + Country;
            string mailTitle = "KraceGennedy Weather Forecast";
            string fromEmail = "gavingrant691xyz@gmail.com";
            string fromEmailPassword = "Postaltekken1234567890@";

            string toEmail = "gavingrant691@gmail.com";
            //Email & Content 
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail));
            message.Subject = subject;
            message.Body = MailBody;
            message.IsBodyHtml = true;


            //Server Details
            SmtpClient smtp = new SmtpClient();
            //Outlook ports - 465 (SSL) or 587 (TLS)
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            //Credentials
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();

            credentials.UserName = fromEmail;
            credentials.Password = fromEmailPassword;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credentials;

            smtp.Send(message);

        }
        public string WeatherDecision(string emailmessagetodisplay)
        {
           
            var messagedisplay = "";

            if (emailmessagetodisplay == "clear sky")
            {
                messagedisplay = "The weather is clear sky, you will be working 8 hours |";
            }

            else if (emailmessagetodisplay == "few clouds")
            {
                messagedisplay = "The Weather is Few Clouds, you will be working 8 hours|";
            }
            else if (emailmessagetodisplay == "overcast clouds")
            {
                messagedisplay = "The weather is overcast Clouds, you will be working 8 hours|";
            }
            else if (emailmessagetodisplay == "broken clouds")
            {
                messagedisplay = "The weather is broken clouds, you will be working 8 hours|";
            }
            else if (emailmessagetodisplay == "scattered clouds:")
            {
                messagedisplay = "The weather is broken clouds, you will be working 8 hours|";
            }

            else if (emailmessagetodisplay == "shower rain")
            {
                messagedisplay = "The weather is thunderstorm, dont hit the streets|";
            }
            else if (emailmessagetodisplay == "rain")
            {
                messagedisplay = "The weather is thunderstorm, dont hit the streets|";
            }

            else if (emailmessagetodisplay == "thunderstorm")
            {
                messagedisplay = "The weather is thunderstorm, dont hit the streets|";
            }
            else if (emailmessagetodisplay == "snow")
            {
                messagedisplay = "The weather is going to snow, you will be working 4 hours";
            }
            else
            {
                messagedisplay = "There seems to be bad weather you are allowed to work for 4 hours";
            }
            return messagedisplay;
        }
    }
}

