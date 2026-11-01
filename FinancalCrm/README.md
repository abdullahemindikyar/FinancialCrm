# FinancialCrm

FinancialCrm, banka hesaplarını, banka hareketlerini, faturaları ve harcamaları yönetmek için hazırlanmış Windows Forms uygulamasıdır.

## Özellikler

- Banka hesaplarını ve bakiyelerini görüntüleme
- Banka hareketlerini listeleme
- Son banka hareketlerini gösterme
- Fatura ekleme, listeleme, bulma, güncelleme ve silme
- Fatura kayıtlarını DataGridView üzerinde görüntüleme
- Dashboard üzerinde banka bakiyelerini grafik olarak gösterme
- Dashboard üzerinde fatura tutarlarını grafik olarak gösterme
- Faturaları dashboard üzerinde sırayla gösterme
- Dashboard, Bankalar ve Faturalar formları arasında geçiş
- Çıkış yapma
- Ayarlar ekranı
- Gündüz ve gece tema seçenekleri
- Yazı boyutunu büyütme ve küçültme
- Uygulamanın açık kalma süresini gösterme

## Kullanılan Teknolojiler

- C#
- Windows Forms
- .NET Framework 4.7.2
- Entity Framework 6.2
- SQL Server
- Entity Framework Database First
- Visual Studio

## Proje Yapısı

```text
FinancalCrm/
├── FrmDashboard.cs              Dashboard ekranı
├── FrmBanks.cs                  Banka yönetimi ekranı
├── FrmBilling.cs                Fatura yönetimi ekranı
├── FrmSettings.cs               Ayarlar ekranı
├── Models/                      Entity Framework modelleri
│   ├── Banks.cs
│   ├── BankProcesses.cs
│   ├── Bills.cs
│   ├── Categories.cs
│   ├── Spendings.cs
│   ├── Users.cs
│   └── Model1.edmx
├── App.config                   Veritabanı bağlantı ayarları
└── FinancialCrm.slnx            Visual Studio çözüm dosyası
```

## Veritabanı Tabloları

Uygulama aşağıdaki tabloları kullanır:

- `Banks`
- `BankProcesses`
- `Bills`
- `Categories`
- `Spendings`
- `Users`

### Bills Tablosu

`Bills` tablosu aşağıdaki alanlara sahip olmalıdır:

| Alan | Tip | Açıklama |
|---|---|---|
| `BillId` | `int` | Primary Key, Identity |
| `BillTitle` | `nvarchar(50)` | Fatura başlığı |
| `BillAmount` | `decimal(18,2)` | Fatura tutarı |
| `BillPeriod` | `nvarchar(50)` | Fatura dönemi |

Örnek tablo oluşturma sorgusu:

```sql
CREATE TABLE dbo.Bills
(
	BillId INT IDENTITY(1,1) NOT NULL,
	BillTitle NVARCHAR(50) NULL,
	BillAmount DECIMAL(18,2) NULL,
	BillPeriod NVARCHAR(50) NULL,
	CONSTRAINT PK_Bills PRIMARY KEY (BillId)
);
```

## Fatura CRUD İşlemleri

`FrmBilling` ekranında aşağıdaki işlemler bulunur:

- Yeni ödeme ekleme
- Ödeme listesini yenileme
- `BillId` değerine göre ödeme bulma
- Ödeme güncelleme
- Ödeme silme

Ödeme listesi `paymentsDataGridView` kontrolünde gösterilir.

## Form Geçişleri

Mevcut formlar arasında aşağıdaki geçişler kullanılabilir:

- Dashboard → Bankalar
- Dashboard → Faturalar
- Dashboard → Ayarlar
- Bankalar → Dashboard
- Bankalar → Faturalar
- Bankalar → Ayarlar
- Faturalar → Dashboard
- Faturalar → Bankalar
- Faturalar → Ayarlar
- Çıkış Yap → Mevcut formu kapatır
