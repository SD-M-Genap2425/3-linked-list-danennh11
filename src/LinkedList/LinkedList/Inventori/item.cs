using System;

namespace LinkedList.Inventori
{
    public class Item
    {
        public string? Nama{get;}
        public int Kuantitas{get;}

        public Item(string Nama, int Kuantitas)
        {
            this.Nama = Nama;
            this.Kuantitas = Kuantitas;
        }
    }
    public class ManajemenInventori
    {
        private LinkedList<Item> ListItem = new LinkedList<Item>(); 
        public void TambahItem(Item ItemBaru)
        {
            ListItem.AddLast(ItemBaru!);
        }
        public bool HapusItem(string Nama)
        {
            var temp = ListItem.First;            
            while(temp != null)
            {
                if(temp.Value.Nama == Nama)
                {
                    ListItem.Remove(temp);
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public string TampilkanInventori()
        {
            List<string> DaftarItem = new List<string>();
            foreach (var item in ListItem)
            {
                DaftarItem.Add($"{item.Nama}; {item.Kuantitas}");
            }
            return string.Join("\n", DaftarItem);
        }
    }
}