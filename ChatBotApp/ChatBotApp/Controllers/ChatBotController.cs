using ChatBotApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChatBotApp.Controllers
{
    public class ChatBotController : Controller
    {

        private readonly string apiKeyGemini = "AIzaSyCJDHQMRkiFgKncpgt1U8evCFKXO6pEwL8";

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ChatMessage());
        }

        [HttpPost]
        public async Task<ActionResult> Index(ChatMessage chat)
        {
            if (!string.IsNullOrEmpty(chat.UserMessage))
            {
                chat.BotResponse = await FetchGeminiResponse(chat.UserMessage);
            }
            return View(chat);
        }

        private async Task<string>FetchGeminiResponse(string userInput)
        {
            string apiUrl = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key={apiKeyGemini}";
            var requestPayload = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new{text = userInput }
                        }
                    }
                }
            };
            var responseString = await SendHttpPostRequest(apiUrl, requestPayload);

            if (!string.IsNullOrEmpty(responseString))
            {
                dynamic responseObject = JsonConvert.DeserializeObject(responseString);
                return responseObject.candidates[0].content.parts[0].text.ToString();
            }

            return "Sorry, I couldn't process your request. Please try again later.";
        }

        private async Task<string> SendHttpPostRequest(string url, object payload)
        {
            using(var httpClint = new HttpClient())
            {
                try
                {
                    var jsonContent = new StringContent(JsonConvert.SerializeObject(payload), System.Text.Encoding.UTF8, "application/jsom");
                    var responce = await httpClint.PostAsync(url, jsonContent);
                    if(responce.IsSuccessStatusCode)
                    {
                        return await responce.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return "failed to get anyting";
                    }
                }
                catch (HttpRequestException ex)
                {

                    return $"Error:{ex.Message}";
                }
            }
        }
    }
}
