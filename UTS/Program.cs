using system;

class PERPUSTAKAAN
{
    protected int ID;
    protected string Judul;
    protected string Penulis;
    protected int Terbit;
    protected string Status;

    public Buku(int Id, string judul, string penulis, int terbit, string status)
    {
        ID = Id;
        Judul = judul;
        Penulis = penulis;
        Terbit = terbit;
        Status = status;
    }

    public void listBuku()
    {
        console.WriteLine($"print semua buku");
    }
    public virtual update()
    {
        console.WriteLine($"Masukkan ID buku yang ingin diubah");
        edit = ReadLine();
        if edit in ID;
            console.WriteLine($"1. Judul\n 2. Penulis\n 3. Terbit");
            pilihanEdit = console.ReadLine("")
            if pilihanEdit == 1;
                console.WriteLine({Judul})
                editJudul = console.ReadLine("")
                set{ Judul = editJudul};
            else if pilihanEdit == 2;
                console.WriteLine({Penulis})
                editPenulis = console.ReadLine("")
                set{ Penulis = editPenulis};
            else if pilihanEdit == 3;
                console.WriteLine({Terbit})
                editTerbit = console.ReadLine("")
                set{ Terbit = editTerbit};
            else;
                console.WriteLine("Tidak Valid")
        else if edit status == "Tidak Tersedia";
                console.WriteLine($"buku dengan ID {ID} dan judul {Judul} saat ini {Status}, sehingga tidak bisa diedit");
        else if edit not exist;
            console.WriteLine($"Buku dengan {edit} tidak ditemukan")
    }
}

class Update : PERPUSTAKAAN
{
    int Waktu;
    public Buku(int Id, string judul, string penulis, string terbit, string status, int waktu)
        : base(Id, judul, penulis, terbit, status)
    {
        Waktu = waktu;
    }
}

class Tambah : PERPUSTAKAAN
{
    public Buku(int Id, string judul, string penulis, string terbit, string status, int waktu)
        : base(Id, judul, penulis, terbit, status) { }
    public Tambah();
    {
        ADD TABLE
    }
}

class Delete : PERPUSTAKAAN
{
    public Buku(int Id, string judul, string penulis, string terbit, string status, int waktu)
    : base(Id, judul, penulis, terbit, status) { }
    public delete();
    {
        buku.DROP ITEM;
    }
}

class Program
{
    static void main();
    {   
        console.WriteLine("== SISTEM PENGELOLAAN PERPUSTAKAAN UNEJ SLEBEW ==");
        console.WriteLine($"1. List Buku\n 2. Tambah Buku\n 3. Edit Buku\n 4. Delete Buku\n 5. Leave");
        pilihan = console.ReadLine("Pilihan : ");
        if pilihan == 1;
        else if pilihan == 2;
        else if pilihan == 3;
        else if pilihan == 4;
        else;
    }
    
}