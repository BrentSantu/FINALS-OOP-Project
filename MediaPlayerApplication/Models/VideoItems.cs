namespace MediaPlayApp
{
    public class VideoItem : MediaItem
    {
        public string? Resolution { get; set; }

        public override void Play()
        {
            
        }

        public override void Pause()
        {
            
        }

        public override void Stop()
        {
            
        }

        public override string GetMediaInfo()
        {
            return base.GetMediaInfo() + $" [Video - {Resolution}]";
        }
    }
}
