namespace MediaPlayApp
{
    public class VideoItem : MediaItem
    {
        public string? Resolution { get; set; }

        public override void Play()
        {
            // Video play implementation
        }

        public override void Pause()
        {
            // Video pause implementation
        }

        public override void Stop()
        {
            // Video stop implementation
        }

        public override string GetMediaInfo()
        {
            return base.GetMediaInfo() + $" [Video - {Resolution}]";
        }
    }
}
