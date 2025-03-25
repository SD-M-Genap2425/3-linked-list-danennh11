using System;

namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string? Judul {get;}
        public string? Penulis{get;}
        public int Tahun{get;}
        public Buku(string Judul, string Penulis, int Tahun)
        {
            this.Judul = Judul;
            this.Penulis = Penulis;
            this.Tahun = Tahun;
        }
    }
    public class BukuNode
    {
        public Buku? Data;//disini ada "?", kalau error, coba hapus
        public BukuNode? Next;
        public BukuNode(Buku Data)
        {
            this.Data = Data;
            Next = null;
        }
    }
    public class KoleksiPerpustakaan
    {
        private BukuNode? head;
        public KoleksiPerpustakaan()
        {
            head = null;
        }
        public void TambahBuku(Buku bukuBaru)
        {
            BukuNode newNode = new BukuNode(bukuBaru);
            if(head == null) head = newNode;
            else 
            {
                BukuNode temp = head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public bool HapusBuku(string Judul)
        {
            if (head == null) return false;

            if (head.Data!.Judul == Judul)
            {
                head = head.Next;
                return true;
            }
            BukuNode temp = head;
            while(temp.Next != null && temp.Next.Data!.Judul != Judul)
            {
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                return false;
            }
            temp.Next = temp.Next.Next;
            return true;
        }
        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasil = new List<Buku>();
            BukuNode? temp = head;
            while (temp != null)
            {
                if (temp.Data!.Judul!.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasil.Add(temp.Data!);
                }
                temp = temp.Next;
            }
            return hasil.ToArray();
        }
        public string TampilkanKoleksi()
        {
            BukuNode? temp = head!;
            List<string> DaftarBuku = new List<string>();
            while(temp != null)
            {
                DaftarBuku.Add($"\"{temp.Data!.Judul}\"; {temp.Data.Penulis}; {temp.Data.Tahun}");
                temp = temp.Next;
            }
            return string.Join("\n", DaftarBuku);
        }
    }

}