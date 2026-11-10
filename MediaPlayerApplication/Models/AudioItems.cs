namespace MediaPlayApp
{
    public class AudioItem : MediaItem
    {
        public int Bitrate { get; set; }

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
            return base.GetMediaInfo() + $" [Audio - {Bitrate}kbps]";
        }
    }
}
