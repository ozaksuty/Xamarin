# Xamarin
Xamarin Uygulamaları

01/03/2016 Tarihinde Microsoft Türkiye'de gerçekleştirdiğimiz "Xamarin, Ionic ve IoT Development" etkinliğinde canlı
olarak yazdığımız Xamarin.Forms uygulamasının kaynak kodlarını sizlerle paylaşıyorum.

Xamarin'in güçlü sayfa yapılarından olan "CarouselPage" ile etkinlikler arası kullanıcı dostu geçişler yapabildik.
Kategorileri "ListView" kullanarak menü listesi halinde oluşturarak hızlı kategori geçişi esnekliğini sağladık.
"NavigationPage" özelliği ile seçmiş olduğumuz kategori altındaki bir post'un detayına gidebildik.
Visual Studio nuget kullanarak herkesin bildiği "Newtonsoft JsonConvert" ile datalarımızı işleyebildik.
Xamarin.Forms eklentilerinden "Toasts.Forms.Plugin" kullanarak her ortamda çalışabilen kullanıcı dostu pop-up mesajlar çıkarttık.
Aslında sadece C# yazarak IOS, Android ve WinPhone cihazlarında ve sistemlerinde ek bir kod yazmadan çalışan bir uygulama yaptık.

Kullanılan Xamarin.Toast.Plugin icin;

Android tarafinda > MainActiviy.cs
WinPhone tarafinda > MainPage.xaml.cs

icindeki Dependency kisimlarina dikkat etmenizi ve incelemenizi oneririm.
