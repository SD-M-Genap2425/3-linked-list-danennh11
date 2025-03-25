using System;
using LinkedList.Perpustakaan;

namespace LinkedList.ManajemenKaryawan
{
    public class Karyawan
    {
        public string? NomorKaryawan{get;}
        public string? Nama{get;}
        public string? Posisi{get;}
        public Karyawan(string NomorKaryawan, string Nama, string Posisi)
        {
            this.NomorKaryawan = NomorKaryawan;
            this.Nama = Nama;
            this.Posisi = Posisi;
        }
    }
    public class KaryawanNode
    {
        public Karyawan? Karyawan{get;}
        public Karyawan Data;
        public KaryawanNode? Next;
        public KaryawanNode? Prev;
        public KaryawanNode(Karyawan Data)
        {
            this.Data = Data!;
            Next = null;
            Prev = null;
        }
    }
    public class DaftarKaryawan
    {
        private KaryawanNode? head;
        private KaryawanNode? tail;

        public DaftarKaryawan()
        {
            head =null;
            tail = null;
        }
        public void TambahKaryawan(Karyawan karyawanBaru)//push head
        {
            KaryawanNode newNode = new KaryawanNode(karyawanBaru);
            newNode.Next = head;
            newNode.Prev = null;

            if(head != null)
            {
                head.Prev = newNode;
            }
            head = newNode;
            if(tail == null)
            {
                tail = newNode;
            }
        }
        public bool HapusKaryawan(string nomorKaryawan)
        {
            if(head == null) return false;

            KaryawanNode? temp = head;//ada "?" klo error, hapus

            while(temp != null)
            {
                if(temp.Data!.NomorKaryawan == nomorKaryawan)
                {
                    if (temp.Prev != null)
                    {
                        temp.Prev.Next = temp.Next;
                    }
                    else 
                    {
                        head = temp.Next;
                    }
                    if(temp.Next != null)
                    {
                        temp.Next.Prev = temp.Prev;
                    }
                    else 
                    {
                        tail = temp.Prev;
                    }
                    if(head == null)
                    {
                        tail = null;
                    }
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public Karyawan[] CariKaryawan(string kataKunci)
        {
            List<Karyawan> hasil = new List<Karyawan>();
            KaryawanNode? temp = head;
            while(temp != null)
            {
                if(temp.Data!.Nama!.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) || temp.Data!.Posisi!.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasil.Add(temp.Data);
                }
                temp = temp.Next;
            }
            return hasil.ToArray();
        }
        public string TampilkanDaftar()
        {
            KaryawanNode? temp = tail;
            List<string> DaftarKaryawan = new List<string>();

            while(temp != null)
            {
                DaftarKaryawan.Add($"{temp.Data!.NomorKaryawan!}; {temp.Data!.Nama}; {temp.Data!.Posisi!}");
                temp = temp.Prev;
            }
            return string.Join("\n", DaftarKaryawan).Trim();
        }
    }
}