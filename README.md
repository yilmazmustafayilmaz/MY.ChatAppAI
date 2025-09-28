# MY.ChatAppAI

A console chat application built with .NET 9 using OpenAI.
It processes text input from the user and provides responses using the OpenAI API.

## Features:
- AI abstraction using Microsoft.Extensions.AI
- Real-time chat with OpenAI API
- Chat history tracking: System, User, and Assistant roles
- Streaming response support

## Prerequisites:
- .NET 8 SDK or higher
- OpenAI API Key
- Visual Studio Code or any C# development environment

## Setup:
### 1. Clone the project:
   git clone https://github.com/<your-username>/MY.ChatAppAI.git
   cd MY.ChatAppAI

### 2. Install required NuGet packages:
  - dotnet add package OpenAI
  - dotnet add package Microsoft.Extensions.AI.OpenAI --prerelease
  - dotnet add package Microsoft.Extensions.Configuration
  - dotnet add package Microsoft.Extensions.Configuration.UserSecrets

### 3. Add OpenAI credentials using User Secrets:
  - dotnet user-secrets init
  - dotnet user-secrets set OpenAIKey <your-openai-key>
  - dotnet user-secrets set ModelName <your-model-name>

## Running the application:
   dotnet run
Type your questions in the terminal to get AI responses.

### Example Chat Flow:
Your prompt:
Which books would you recommend?

AI Response:
Hello! What genre are you interested in, and what reading intensity are you looking for?
