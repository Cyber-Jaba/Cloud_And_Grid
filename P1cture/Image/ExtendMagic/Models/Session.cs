using Newtonsoft.Json;
using P1cture.Image.JSON;

namespace P1cture.Image.ExtendMagic
{
    public partial class Session
    {
        public int Text { get; set; }
        public PictureGeneartionStage Stage { get; set; }
    }

    public enum PictureGeneartionStage
    {
        Text, Processing, Result
    }
}
