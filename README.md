# 1Task- Product API

Bu proje, **.NET 6+ (ASP.NET Core)** kullanılarak geliştirilmiş basit bir Product API uygulamasıdır.  
Proje, temel **CRUD işlemleri**, **Katmanlı Mimari (Controller-Service-Repository)**, **Entity Framework Core ile PostgreSQL/MSSQL** entegrasyonu ve **Swagger API dokümantasyonu** içermektedir.

---

## Özellikler

- Ürün ekleme (POST)
- Ürün listeleme (GET)
- Ürün detay (GET by Id)
- Ürün silme (DELETE)
- Katmanlı mimari (Controller – Service – Repository)
- SOLID prensiplerine uygun yapı
- Asenkron programlama (`async/await`)
- Veritabanı migration yönetimi (`dotnet ef migrations`)
- Global exception handling
- Swagger ile API dokümantasyonu

---

## Teknolojiler

- .NET 6+ (ASP.NET Core Web API)
- C#
- PostgreSQL veya MSSQL
- Entity Framework Core
- Swagger (Swashbuckle.AspNetCore)

---

## Kurulum

1. Projeyi klonlayın:

bash
git clone <repository-url>
cd 1.Task-ProductApi
---

## Gerekli NuGet paketlerini yükleyin:

- .NET 6+ (ASP.NET Core Web API)
- C#
- PostgreSQL veya MSSQL
- Entity Framework Core
- Swagger (Swashbuckle.AspNetCore)

---

## Veritabanı bağlantısını yapılandırın:

appsettings.json dosyasını açın ve bağlantı stringinizi güncelleyin:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=product_db;Username=postgres;Password=****"
}

---

##Migration ve veritabanı güncelleme:

dotnet ef migrations add InitialCreate
dotnet ef database update
---

##Çalıştırma

Visual Studio üzerinden:

Projeyi açın

1.Task-ProductApi projesini startup project yapın

F5 veya Ctrl+F5 ile çalıştırın

Terminal üzerinden:
dotnet run --project 1.Task-ProductApi

---

##Swagger API Dokümantasyonu

Swagger UI ile API endpoint’lerini inceleyebilir ve test edebilirsiniz:

URL: https://localhost:7035/swagger

Swagger JSON dosyası: Docs/swagger.json (GitHub deposunda)







