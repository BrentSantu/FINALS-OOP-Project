namespace MediaPlayApp
{
    public class AudioItem : MediaItem
    {
        public int Bitrate { get; set; }

        public override void Play()
        {
            // Audio play implementation
        }

        public override void Pause()
        {
            // Audio pause implementation
        }

        public override void Stop()
        {
            // Audio stop implementation
        }

        public override string GetMediaInfo()
        {
            return base.GetMediaInfo() + $" [Audio - {Bitrate}kbps]";
        }
    }
}
