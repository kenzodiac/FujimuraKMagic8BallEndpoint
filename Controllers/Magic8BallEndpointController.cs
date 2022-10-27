//Kenneth Fujimura
//Last Revised: 10-27-2022
//Magic 8-Ball Endpoint
//This is a web API program that's designed to emulate the Unity project of the same name that we completed during the coding combine. This program takes in a user's question, and then uses a random number generator to give users one of twenty predetermined respones, just like a real Magic 8-Ball would.
//Peer Reviewed By: Pedro Castaneda - I like the use of the switch statement and that you can see what question you asked in the postman console. Great work! Your program works well.

using Microsoft.AspNetCore.Mvc;

namespace FujimuraKMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallEndpointController : ControllerBase
{
    [HttpGet]
    [Route("Magic8Ball/{question}")]

    public string Magic8Ball(string question){
        Random rnd = new Random();
        int num = rnd.Next(1,21);
        string fortune = "";

        switch(num){
            case 1:
                fortune = "It is certain.";
                break;
            case 2:
                fortune = "It is decidedly so.";
                break;
            case 3:
                fortune = "Without a doubt.";
                break;
            case 4:
                fortune = "Yes definitely.";
                break;
            case 5:
                fortune = "You may rely on it.";
                break;
            case 6:
                fortune = "As I see it, yes.";
                break;
            case 7:
                fortune = "Most likely.";
                break;
            case 8:
                fortune = "Outlook good.";
                break;
            case 9:
                fortune = "Yes.";
                break;
            case 10:
                fortune = "Signs point to yes.";
                break;
            case 11:
                fortune = "Reply hazy, try again.";
                break;
            case 12:
                fortune = "Ask again later.";
                break;
            case 13:
                fortune = "Better not tell you now.";
                break;
            case 14:
                fortune = "Cannot predict now.";
                break;
            case 15:
                fortune = "Concentrate and ask again.";
                break;
            case 16:
                fortune = "Don't count on it.";
                break;
            case 17:
                fortune = "My reply is no.";
                break;
            case 18:
                fortune = "My sources say no.";
                break;
            case 19:
                fortune = "Outlook not so good.";
                break;
            case 20:
                fortune = "Very doubtful.";
                break;
            default:
                break;
        }
        return $"You asked: \"{question}\"\n\nThe Magic 8 Ball replies: \"{fortune}\"";
    }
}
