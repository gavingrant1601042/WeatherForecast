using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
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
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            SaveWeatherData(weatherData);

            return weatherData;
        }
        public void SaveWeatherData(WeatherData wdata)
        {
            //var EmailId = "";
            //var password = "";
            //var firstname = "";
            //var Lastname = "";

            //var employeeData = _context.Employee.FirstOrDefault(c => c.EmailId == c.EmailId);
          
           // if (employeeData != null)
            {
                Console.Write("Error");
            }
            {
               // EmailId = employeeData.EmailId.ToString();
               // password = employeeData.password.ToString();
               // firstname = employeeData.FirstName.ToString();  
               // Lastname = employeeData.Lastname.ToString();
            }

            //var emailmessagetodisplay = wdata.Weather[0].Description;

            //var convertmessage = messagedisplay.ToString();

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("WeatherAPP", "weather.org.com"));

            //message.To.Add(MailboxAddress.Parse(EmailId));
           // message.Subject = emailmessagetodisplay;
            message.Body = new TextPart("plain")
            {
               // Text = firstname + "  " + Lastname + "  " + convertmessage 
            };
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
               // client.Authenticate(EmailId, password);
                client.Send(message);
                Console.WriteLine("Email Sent!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }

        }

    }
}

