# ReverseTextApi

A simple .NET 6 Web API that reverses a text string sent in a POST request.

## Features

- POST `/api/reverse` endpoint  
- Accepts JSON `{ "text": "hello world" }`  
- Returns JSON `{ "reversedText": "dlrow olleh" }`  
- Validates input and returns HTTP 400 with error message if text is missing or empty  
- Includes unit tests for reversal logic

## Requirements

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)  
- (Optional) Postman, curl, or any HTTP client for testing the API

## Setup & Run

1. Clone the repository  
2. Restore dependencies and run the API:

```bash
dotnet restore
dotnet run

The API will be available at:
https://localhost:5001/api/reverse

Usage
Request:
{
  "text": "hello world"
}
Response:
{
  "reversedText": "dlrow olleh"
}
Error Example (HTTP 400):
{
  "error": "Text cannot be empty."
}
Testing
Run unit tests with:
dotnet test
