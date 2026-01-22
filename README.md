# 🧑‍🎓 Windows Forms Öğrenci Kayıt Uygulaması

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş basit bir
**öğrenci kayıt ve yönetim uygulamasıdır**.\
Uygulama, öğrencilerin **numara, ad, soyad ve not ortalaması**
bilgilerini `DataGridView` üzerinde listelemeyi ve yönetmeyi sağlar.

------------------------------------------------------------------------

## 🚀 Özellikler

-   Öğrenci listesini `DataGridView` üzerinde görüntüleme
-   Yeni öğrenci ekleme
-   Seçilen öğrencinin bilgilerini değiştirme
-   Öğrenci silme
-   Satır seçimine göre TextBox'ların otomatik doldurulması
-   Kayıt sayısı ve aktif kayıt göstergesi
-   Boş alan kontrolü (hata yakalama)

------------------------------------------------------------------------

## 🧠 Kullanılan Teknolojiler

  Teknoloji        Açıklama
  ---------------- -------------------------
  C#               Programlama dili
  .NET Framework   Windows Forms altyapısı
  Windows Forms    Grafik arayüz
  DataGridView     Tablo görünümü
  ArrayList        Veri saklama

------------------------------------------------------------------------

## 📂 Proje Yapısı

    📁 WindowsFormsApplication6
     ├── Form1.cs
     ├── Form1.Designer.cs
     ├── Program.cs

------------------------------------------------------------------------

## 🧩 Kullanılan Veri Yapıları

Uygulama başlangıcında öğrenciler **ArrayList** yapıları ile tanımlanır:

-   `no` → Öğrenci numarası
-   `ad` → Öğrenci adı
-   `soyad` → Öğrenci soyadı
-   `ort` → Not ortalaması

Bu veriler form yüklenirken `DataGridView` içine aktarılır.

------------------------------------------------------------------------

## ▶️ Çalışma Mantığı

1.  Form açıldığında:
    -   DataGridView oluşturulur
    -   Varsayılan öğrenci listesi yüklenir
2.  Kullanıcı:
    -   **Ekle** → Yeni satır ekler
    -   **Değiştir** → Seçili satırı günceller
    -   **Sil** → Seçili satırı kaldırır
3.  DataGridView satırına tıklanınca:
    -   Bilgiler TextBox'lara otomatik aktarılır
4.  Kayıt konumu:
    -   `X / Y` formatında ekranda gösterilir

------------------------------------------------------------------------

## ⚠️ Kontroller ve Kısıtlar

-   Boş alan bırakılırsa işlem yapılmaz
-   Aynı anda sadece **tek satır** seçilebilir
-   Veri kalıcı değildir (veritabanı yoktur)
-   Program kapatıldığında veriler sıfırlanır

------------------------------------------------------------------------

## 🔧 Geliştirme Önerileri

-   ArrayList yerine **List`<T>`{=html} veya sınıf yapısı**
-   Veritabanı entegrasyonu (SQL Server / SQLite)
-   Arama ve filtreleme
-   Not ortalamasına göre renkli satırlar
-   Dosyaya kaydet / dosyadan yükle
-   Öğrenci sınıfı (`Student.cs`) oluşturma

------------------------------------------------------------------------

## 👤 Geliştirici

**Murathan Arat**\
Bilgisayar Mühendisliği Öğrencisi\
C# • Windows Forms • Masaüstü Uygulamaları
