namespace Övning_3
{
    public class PhotoBookTest
    {
        public static void Main(string[] args)
        {
            PhotoBook myAlbum1 = new PhotoBook(); 
            Console.WriteLine(myAlbum1.GetNumberPages()); // 16 sidor

            PhotoBook myAlbum2 = new PhotoBook(24);
            Console.WriteLine(myAlbum2.GetNumberPages()); //24 sidor

            SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook(); 
            Console.WriteLine(myBigPhotoAlbum1.GetNumberPages()); //64 sidor

            SuperPhotoBook myBigPhotoAlbum2 = new SuperPhotoBook(128);
            Console.WriteLine(myBigPhotoAlbum2.GetNumberPages()); // 128 sidor
        }
    }
}