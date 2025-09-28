# MY.ChatAppAI

.NET 8 ile geliştirilmiş, OpenAI tabanlı bir konsol sohbet uygulaması.  
Kullanıcıdan aldığı metin girdilerini OpenAI API ile işleyip yanıt veren bir AI sohbet uygulamasıdır.

---

## Özellikler

- Microsoft.Extensions.AI kullanarak yapay zeka soyutlaması
- OpenAI API ile gerçek zamanlı sohbet
- ChatHistory takibi: System, User ve Assistant rolleri
- Streaming cevap desteği

---

## Önkoşullar

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) veya üstü
- OpenAI API Key
- Visual Studio Code veya başka bir C# geliştirme ortamı

---

## Kurulum

1. Projeyi klonla:

```bash
git clone 
cd MY.ChatAppAI

dotnet add package OpenAI
dotnet add package Microsoft.Extensions.AI.OpenAI --prerelease
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.UserSecrets

dotnet user-secrets init
dotnet user-secrets set OpenAIKey <your-openai-key>
dotnet user-secrets set ModelName <your-model-name>

dotnet run

Your prompt:
Hangi kitapları önerirsin?

AI Response:
Merhaba! Hangi türde kitaplar ilginizi çekiyor ve okumak istediğiniz yoğunluk nedir?

