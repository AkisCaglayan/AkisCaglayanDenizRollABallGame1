Roll A Ball Game - Akış Çağlayan Deniz

Geliştirme Süreci ve Öğrenilenler
Bu projede Unity'de temel fizik bileşenlerini (Rigidbody ve Collider) kullanarak bir top toplama oyunu geliştirdim. Klasör yapısını (Scripts, Scenes, Materials) düzenli tutmayı öğrendim.

Karşılaşılan Hatalar ve Çözümleri
1. **Input System Hatası:** Unity'de eski Input sistemi yerine yeni sistemin aktif olması nedeniyle kodlar çalışmıyordu. `Project Settings > Player` altından "Active Input Handling" seçeneğini "Both" yaparak çözdüm.
2. **Karakterin Düşmesi/Havada Kalması:** Karakterin bir Collider'ı yoktu ve zeminle çarpışmıyordu. `Capsule Collider` ekledim ve `Height: 2`, `Center Y: 1` ayarlarını yaparak karakterin tam zemine basmasını sağladım.
3. **Zemin Çarpışma Kutusu:** Ground objesinin Box Collider'ı görselden daha kalındı. `Size Y` değerini `0.1` yaparak görselle eşitledim.
