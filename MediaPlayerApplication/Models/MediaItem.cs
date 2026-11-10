using System;

namespace MediaPlayApp
{
    public abstract class MediaItem : IMediaControls
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? FilePath { get; set; }
        public TimeSpan Duration { get; set; }

        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();

        public virtual string GetMediaInfo()
        {
            return $"{Title} - {Artist} ({Duration:mm\\:ss})";
        }
    }
}
