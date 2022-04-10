# IF3210-2022-Unity-29

Tugas Besar Unity, IF3210 Pengembangan Aplikasi pada Platform Khusus

## Deskripsi Aplikasi

Dalam tugas besar kali ini, mahasiswa diminta untuk membangun sebuah game pada platform Unity. Game tersebut bernama Survival Shooter: Extended yang merupakan game ekstensi Survival Shooter dari Unity Learn.

## Cara kerja

1. Atribut
Pemain memiliki atribut power, speed, dan health. Power terpaut pada script shooting, speed pada movement, dan health pada health.
Nilai ketiga atribut tersebut ditampilkan di pojok kiri bawah layar dengan simbol yang sesuai.
2. Orbs
Ketiga atribut diatas dapat ditingkatkan dengan mengambil orb yang ter-spawn secara acak dalam peta. Orb hijau untuk health, merah untuk power, dan kuning untuk speed.
3. Mobs
Terdapat 3 mob tambahan:
- Skeleton: Bergerak dengan lambat (hingga terlihat tidak bergerak) dan menembakkan proyektil.
- Bomber: Bergerak dengan cepat untuk meledakkan dirinya, jarak ledakan terlihat dengan linkaran merah dibawahnya.
- Boss: Hellephant yang bermutasi menjadi lebih besar, cepat, dan kuat.
4. Game Modes
Terdapat 2 game modes:
- Zen mode: Bertahan selama mungkin, musuh di-spawn secara acak, skor didapatkan dari bertahan lebih lama.
- Wave mode: Bertahan melawan musuh yang datang secara periodik. Setiap wave akan semakin sulit dengan setiap 3 wave memunculkan boss.
5. Weapon Upgrades
Terdapat 2 weapon upgrades:
- Diagonal weapon menambahkan tembakan pada kanan dan kiri, batasnya adalah 5 tembakan sekaligus.
- Faster weapon mempercepat rate of fire senjata.
Pada zen mode, upgrade didapatkan setelah bertahan selama beberapa waktu, sedangkan pada wave mode didapatkan setiap akhir wave.
6. Scoreboard
Scoreboard menampilkan nama dan skor pemain terurut dari yang terbaik untuk kedua game modes. Scoreboard dapat diakses di main menu.
7. Main Menu
Menjadi tampilan pertama. Terdapat pilihan untuk keluar game (hanya bekerja setelah game nya di-build), melihat scoreboard, dan main. Jika memilih main, ditampilkan 2 pilihan mode (dan 1 pilihan rahasia). Setelah memilih mode, pemain memasukkan nama sebelum mulai bermain.
8. Bonus
- Mode first person shooter di peta rahasia dapat diakses melalui pilihan rahasia pada tampilan pilihan mode.
- Beberapa kebijakan desain:
. Animasi transisi scene
. Tampilan main menu
. Balance dari game mode
. Tampilan musuh dan serangannya (untuk mob baru)
. Pemberian lampu untuk player
. Tampilan UI

## Library

- TextMeshPro: Supaya beberapa teks ter-render dengan lebih baik
- Unity Particle Pack: Memberikan efek ledakan pada musuh bomber
- 2D Weapon Pack: Untuk sprite senjata pada UI

## Screenshots

- 

## Pembagian kerja

1. Mahameru Ds
- Orbs mechanic
- Faster weapon
2. Ilyasa Salafi Putra Jamal
- Main Menu
- Scoreboard
- Mobs
- Tampilan atribut
- First person mode
- New secret map
3. Imam Nurul Hukmi
- Game modes
- Game over screen
- Diagonal weapon

