// See https://aka.ms/new-console-template for more information

using Builder;
var request = RequestBuilder.Request("https://localhost:51241")
    .WithHeader("age", "17")
    .WithHeader("Name", "Abolfazl")
    .AddBody()
        .WithBody(new
        {
            FirstName = "Abolfazl",
            LastName = "AliJafari",

        })
        .Build();
Console.WriteLine(request);