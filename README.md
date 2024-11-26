# QR Kodlu Sipariş Yönetimi Sistemi  

Bu proje, bir restoran için QR kod tabanlı sipariş yönetim sistemi geliştirmek amacıyla **Asp.Net Core 6.0** kullanılarak oluşturulmuştur. Proje, **SignalR** kütüphanesini kullanarak gerçek zamanlı bildirimler, mesajlaşma, sepet yönetimi gibi işlevler sunar. Ayrıca proje, **SOLID prensipleri**, **Clean Code** standartları ve katmanlı mimari (N-Tier Architecture) gibi yazılım geliştirme ilkelerine uygun olarak tasarlanmıştır.

## 📜 Proje Açıklaması  

**QR Kodlu Sipariş Yönetimi Sistemi** şu bileşenlerden oluşmaktadır:  
- **Admin Paneli**: Siparişlerin, kullanıcıların ve restoran operasyonlarının yönetimi.  
- **Vitrin Paneli**: Kullanıcıların rezervasyon, sipariş ve ödeme işlemlerini yapabilecekleri arayüz.  
- **Backend API**: Uygulamanın temel iş mantığı ve veri yönetimi için API katmanı.  
- **Gerçek Zamanlı İşlevsellik**: SignalR ile anlık bildirimler, mesajlaşma ve istatistik takibi.  

## 🛠️ Kullanılan Teknolojiler  

Proje kapsamında aşağıdaki teknolojiler ve araçlar kullanılmıştır:  

- **Asp.Net Core 6.0**  
- **Asp.Net Core API**  
- **SignalR**  
- **Swagger**  
- **N-Tier Architecture**  
- **MSSQL**  
- **Entity Framework Core (EF Core)**  
- **LINQ**  
- **HTML, CSS, Bootstrap**  
- **JavaScript ve AJAX**  
- **Dto (Data Transfer Objects)**  
- **Alert Yönetimi**  
- **Mail Gönderme İşlemleri**  
- **Real-Time Mesajlaşma, Bildirim ve İstatistikler**  

## 🚀 Özellikler  

- **Gerçek Zamanlı Sipariş Yönetimi**: Sipariş oluşturma, düzenleme ve takip.  
- **QR Kod ile Hızlı Sipariş**: Kullanıcıların masaya özel QR kodu taratarak sipariş vermesi.  
- **Anlık Bildirim ve Mesajlaşma**: SignalR kullanılarak restoran yönetimi ve müşteri iletişimi.  
- **Rezervasyon Sistemi**: Kullanıcılar için mail ile rezervasyon doğrulama.  
- **Güçlü Admin Paneli**: Siparişler, kullanıcılar ve restoran yönetimi için gelişmiş araçlar.  
- **Modern UI ve Responsive Tasarım**: Kullanıcı deneyimini ön planda tutan arayüz.  

## 📂 Proje Yapısı  

```plaintext
QROrderManagement/
├── Admin/
│   ├── Controllers/
│   ├── Views/
│   ├── wwwroot/
├── API/
│   ├── Controllers/
│   ├── Models/
│   ├── DTOs/
│   ├── SignalR/
├── Vitrine/
│   ├── Controllers/
│   ├── Views/
│   ├── wwwroot/
├── DataAccess/
│   ├── Context/
│   ├── Repositories/
├── Domain/
│   ├── Entities/
├── Tests/
├── README.md
