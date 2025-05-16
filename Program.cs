using OpenAI.Responses;
using dotenv.net;

DotEnv.Load();

var img = new Uri("");

ResponseItem request = ResponseItem.CreateUserMessageItem([
    ResponseContentPart.CreateInputTextPart(""),
    ResponseContentPart.CreateInputImagePart(img, "auto")            
]);

OpenAIResponseClient client = new(apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"), model: "gpt-4o");

OpenAIResponse response = await client.CreateResponseAsync(
    new[] { request },
    new ResponseCreationOptions()
    {
        Temperature = 0,
        Instructions = "",
    }
);

foreach (ResponseItem item in response.OutputItems)
{
    if (item is MessageResponseItem msg &&
        msg.Content?.Count > 0)
    {
        Console.WriteLine($"[{msg.Role}] {msg.Content[0].Text}");
    }
}
