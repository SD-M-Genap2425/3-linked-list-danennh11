using LinkedList.Perpustakaan;
using LinkedList.ManajemenKaryawan;
using LinkedList.Inventori;

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan

        var DaftarBuku = new KoleksiPerpustakaan();
        Buku JJK = new Buku("JJK", "Gojo", 2020);
        Buku OBX = new Buku("Outer Banks", "K.D", 2018);
        Buku Invincible = new Buku("Invincible", "Robert Kirkman", 2003);
        DaftarBuku.TambahBuku(JJK);
        DaftarBuku.TambahBuku(Invincible);
        DaftarBuku.TambahBuku(OBX);
        DaftarBuku.TampilkanKoleksi();
        DaftarBuku.HapusBuku(Invincible.Judul!);
        DaftarBuku.TampilkanKoleksi();
        DaftarBuku.CariBuku("Outer Banks");

        // Soal ManajemenKaryawan
        var DaftarKaryawan = new DaftarKaryawan();
        Karyawan ORG1 = new Karyawan("001", "John Pork", "Manager");
        var ORG2 = new Karyawan("002", "Jane Pirk", "Vice President");
        var ORG3 = new Karyawan("003", "Sigmax", "King");
        DaftarKaryawan.TambahKaryawan(ORG1);
        DaftarKaryawan.TambahKaryawan(ORG2);
        DaftarKaryawan.TambahKaryawan(ORG3);
        DaftarKaryawan.TampilkanDaftar();
        DaftarKaryawan.HapusKaryawan("001");
        DaftarKaryawan.TampilkanDaftar();
        DaftarKaryawan.CariKaryawan("Sigmax");

        
        // Soal Inventori
        var DaftarItem = new ManajemenInventori();
        var barang1 = new Item("Pisang", 3);
        var barang2 = new Item("Potion of Life", 1);
        var barang3 = new Item("HP", 3);
        DaftarItem.TambahItem(barang1);
        DaftarItem.TambahItem(barang2);
        DaftarItem.HapusItem("Pisang");
        DaftarItem.TampilkanInventori();
        DaftarItem.TambahItem(barang3);
        DaftarItem.TampilkanInventori();



    }
}
