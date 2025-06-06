using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using DSLApp1.Dsl;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Pidgin;

namespace DslCheckerFunction;

public class CheckDslSyntax
{
    private readonly ILogger _logger;

    public CheckDslSyntax(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<CheckDslSyntax>();
    }

    private class DslRequest
    {
        public string Dsl { get; set; } = string.Empty;
    }

    [Function("CheckDslSyntax")]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req,
        FunctionContext context)
    {
        var response = req.CreateResponse();

        try
        {
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            var input = JsonSerializer.Deserialize<DslRequest>(body);

            if (input == null || string.IsNullOrWhiteSpace(input.Dsl))
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                await response.WriteStringAsync("Missing or empty 'dsl' field in request.");
                return response;
            }

            var tokens = DslTokenizer.Tokenize(input.Dsl);
            var result = DslParsers.AbilityParser.Parse(tokens);

            if (result.Success)
            {
                response.StatusCode = HttpStatusCode.OK;
                await response.WriteStringAsync("Syntax OK");
            }
            else
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                await response.WriteStringAsync($"Syntax Error: {result.Error}");
            }

            return response;
        }
        catch (JsonException ex)
        {
            response.StatusCode = HttpStatusCode.BadRequest;
            await response.WriteStringAsync($"JSON Parse Error: {ex.Message}");
            return response;
        }
        catch (Exception ex)
        {
            response.StatusCode = HttpStatusCode.BadRequest;
            await response.WriteStringAsync($"Parsing Exception: {ex.Message}");
            return response;
        }
    }
}

