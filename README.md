# DoH.NET

DNS over HTTPS

```
WebRequest request = WebRequest.Create($"https://cloudflare-dns.com/dns-query?name={domain}&type={type}");
request.ContentType = "application/dns-json";
request.Method = "POST";
``` 

## Requirements

- Visual Studio 2019
- .NET Core 5
