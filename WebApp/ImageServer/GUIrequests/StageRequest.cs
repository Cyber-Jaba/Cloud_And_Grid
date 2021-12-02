using Newtonsoft.Json;
using WebApp.Image.ExtendMagic;
using WebApp.Image.Globals;

namespace WebApp.Image.GUIrequests
{
    public class StageRequest
    {
        public bool IsStartStage()
        {
            var session = SessionExample.GetSession.Get(Key.Get);
            if (session == null || session.Length == 0)
                return true;
            else
                return false;
        }

        public bool IsProcessingPage()
        {
            var session = SessionExample.GetSession.Get(Key.Get);
            if (session == null || session.Length == 0)
                return false;
            else
                return JsonConvert.DeserializeObject<GenerationDetails>(session.FromByteArray()).Stage == PictureGenerationStage.Started;
        }
    }
}
