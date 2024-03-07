namespace InterfaceFrameworkDemo
{
    public interface IMsbList
    {
        void Ekle(object eleman);// interface üyeleri erişim belirteci almazlar public tir zaten.
        void Sil(int indexNo);
        int ElemanSayisi { get; } //setter da olamaz.
        object this[int index] //içerisinde işlem yapılamaz get ve set in scope ları olamaz
        {
            get;
            set;
        }
    }
}
