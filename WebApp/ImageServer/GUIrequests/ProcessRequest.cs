using Newtonsoft.Json;
using WebApp.Image.ExtendMagic;
using WebApp.Image.Globals;
using WebApp.Image.JSON;

namespace WebApp.Image.GUIrequests
{
    public class ProcessRequest
    {
        public bool Finished { get; set; }

        public string PixelatedImageSource { get; set; }
        public void StartWork(string text)
        {
            Started = true;
            Task.Run(() =>
            {

            });
            if (!Finished)
            {
                ImageGenerator imageGenerator = new();
                var s = imageGenerator.GenerateAndGetImagePath(text);
                PixelatedImageSource = imageGenerator.GetBase64PixalatedImage(s);
            }
            Finished = true;

        }

        public bool Started { get; set; }
        /* public bool IsStartStage()
         {
             var session = SessionExample.GetSession.Get(Key.GetText);
             if (session == null || session.Length == 0)
                 return true;
             else
                 return false;
         }

         public bool IsProcessingPage()
         {
             var session = SessionExample.GetSession.Get(Key.GetText);
             if (session == null || session.Length == 0)
                 return false;
             else
                 return JsonConvert.DeserializeObject<GenerationDetails>(session.FromByteArray()).Stage == PictureGenerationStage.Started;
         }
         public bool IsResultPage()
         {

             var session = SessionExample.GetSession.Get(Key.GetText);
             if (session == null || session.Length == 0)
                 return false;
             else
                 return JsonConvert.DeserializeObject<GenerationDetails>(session.FromByteArray()).Stage == PictureGenerationStage.Processed;
         }*/
    }
}
