ReverseTextApi
A simple .NET 6 Web API that reverses a text string sent in a POST request.

Features
POST /api/reverse endpoint

Accepts JSON { "text": "hello world" }

Returns JSON { "reversedText": "dlrow olleh" }

Validates input and returns HTTP 400 with error message if text is missing or empty

Includes unit tests for reversal logic

Requirements
.NET 6 SDK or later

(Optional) Postman, curl, or any HTTP client for testing the API

Setup & Run
Clone the repository

Restore dependencies and run the API:

dotnet restore
dotnet run
The API will be available at:
https://localhost:5001/api/reverse

Usage
Send a POST request with JSON body:

{
  "text": "hello world"
}
Example response:

{
  "reversedText": "dlrow olleh"
}
If the text property is missing, empty, or null, the API responds with HTTP 400:

{
  "error": "Text cannot be empty."
}

Testing
Run unit tests using:
dotnet test
