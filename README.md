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

## Kurulum

1. Repoyu bilgisayarına klonla:

```bash
git clone https://github.com/kullanici-adin/FinancialCrm.git
```

2. `FinancialCrm.slnx` dosyasını Visual Studio ile aç.

3. NuGet paketlerini geri yükle.

4. SQL Server üzerinde `FinancialCrmDb` isimli veritabanını oluştur.

5. `App.config` içindeki bağlantı cümlesini kendi SQL Server bilgilerine göre düzenle:

```xml
<connectionStrings>
  <add name="FinancialCrmDbEntities"
	   connectionString="..."
	   providerName="System.Data.EntityClient" />
</connectionStrings>
```

6. `Models/Model1.edmx` dosyasında veritabanı modelini güncelle:

   - EDMX dosyasına sağ tıkla.
   - **Update Model from Database** seç.
   - Gerekli tabloları seç.
   - **Finish** butonuna bas.

7. Projeyi derle ve çalıştır.

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

## GitHub'a Yükleme

GitHub üzerinde yeni bir repository oluşturduktan sonra proje klasöründe terminal açıp şu komutları çalıştır:

```bash
git init
git add .
git commit -m "Initial commit"
git branch -M main
git remote add origin https://github.com/kullanici-adin/FinancialCrm.git
git push -u origin main
```

## Dikkat Edilmesi Gerekenler

- `App.config` içinde bilgisayara özel SQL Server adı kullanılmamalıdır.
- GitHub'a yüklemeden önce bağlantı cümlesini kendi bilgisayarına göre düzenle.
- Veritabanı yedeğini almadan tablo silme veya değiştirme işlemi yapma.
- `Bills.BillId` alanı mutlaka Primary Key ve Identity olmalıdır.
- Entity Framework modeli veritabanı değişikliklerinden sonra güncellenmelidir.

## Lisans

Bu proje eğitim ve kişisel geliştirme amacıyla hazırlanmıştır.
