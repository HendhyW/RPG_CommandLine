# RPG_CommandLine

## Sistem Karakter:
- Buat karakter utama dengan atribut dasar: nama, health, level, dan attack power.
- Contoh Programming Pattern: Terapkan Singleton Pattern untuk memastikan hanya ada satu instance karakter utama.
- Contoh Implementasi: Singleton digunakan untuk memastikan bahwa seluruh sistem dalam game (seperti pertarungan dan inventori) mengakses instance karakter utama yang sama.

## Sistem Musuh:
- Buat beberapa jenis musuh dengan atribut: nama, health, dan attack power.
- Contoh Programming Pattern: Gunakan Factory Pattern untuk menciptakan musuh dengan karakteristik yang berbeda.
- Contoh Implementasi: Factory Pattern digunakan untuk menciptakan tipe musuh seperti "Goblin" dan "Troll" yang memiliki atribut berbeda.

## Sistem Pertarungan:
- Pertarungan berbasis teks dengan opsi seperti serang atau bertahan.
- Contoh Programming Pattern: Gunakan Strategy Pattern untuk menyediakan beberapa strategi serangan, seperti serangan kuat dan serangan biasa.
- Contoh Implementasi: Player dapat memilih strategi yang berbeda, dan setiap strategi memiliki efek yang berbeda pada musuh.

## Sistem Inventori:
- Tambahkan inventori sederhana untuk menyimpan item seperti potion atau senjata.
- Contoh Programming Pattern: Terapkan Decorator Pattern untuk menambahkan efek atau atribut pada item (misalnya, potion yang menambah health atau attack power).
- Contoh Implementasi: Potion yang memiliki efek tambahan bisa dibuat dengan menggunakan dekorator yang menambah health saat digunakan.

## Sistem Level Up:
- Karakter utama dapat naik level setelah mengalahkan musuh, meningkatkan atribut seperti health dan attack power.
- Contoh Implementasi: Setiap kali karakter naik level, atributnya ditingkatkan, dan level tercatat untuk menyesuaikan kesulitan musuh.

## Sistem Pengaturan Game:
- Fitur untuk menyimpan dan melanjutkan permainan, serta menampilkan status karakter dan inventori.
- Contoh Implementasi: Gunakan metode sederhana untuk menyimpan dan melanjutkan state game.
