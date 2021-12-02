using Newtonsoft.Json;
using WebApp.Image.JSON;

namespace WebApp.Image.ExtendMagic
{
    public partial class GenerationDetails
    {
        public int AppName { get; set; }
        public PictureGenerationStage Stage { get; set; }
    }

    public enum PictureGenerationStage
    {
        Started, Processed, Finished
    }
}
