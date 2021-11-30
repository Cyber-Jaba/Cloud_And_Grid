namespace P1cture.Image.JSON
{
    using DeepAI; // Add this line to the top of your file
    using P1cture.Image.Pixelate;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Net;

    public class ImageGenerator
    {
        public Uri GenerateAndGetImagePath(string description)
        {

            DeepAI_API api = new DeepAI_API(apiKey: "3d333b4f-848e-42fe-a7dd-6a0c60bbe5f0");

            StandardApiResponse resp = api.callStandardApi("text2img", new
            {
                text = description,
            });
            var json =api.objectAsJsonString(resp);
            var responce = Responce.FromJson(json);
            return responce.OutputUrl;
        }
        public string GetBase64PixalatedImage(Uri uri)
        {
            Bitmap bImage = GetImageFromURI(uri);  //Your Bitmap Image
            Size imageSize = bImage.Size;
            NormalPixelate.ApplyNormalPixelate(ref bImage,new Size(15,15));
            bImage=new Bitmap(bImage,imageSize);
            
            MemoryStream ms = new MemoryStream();
            bImage.Save(ms, ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            return Convert.ToBase64String(byteImage); //Get Base64
        }
		public Bitmap GetImageFromURI(Uri uri)
        {
            WebClient wc = new();
            byte[] bytes = wc.DownloadData(uri);
            MemoryStream ms = new MemoryStream(bytes);
            using (Image img = Image.FromStream(ms))
            {
                return new Bitmap(img);
            }
        }

    }
}
