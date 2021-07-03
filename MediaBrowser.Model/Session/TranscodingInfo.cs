#nullable disable
#pragma warning disable CS1591

using System;

namespace MediaBrowser.Model.Session
{
    public class TranscodingInfo
    {
        public TranscodingInfo()
        {
            TranscodeReasons = Array.Empty<TranscodeReason>();
        }

        public string AudioCodec { get; set; }

        public string VideoCodec { get; set; }

        public string Container { get; set; }

        public bool IsVideoDirect { get; set; }

        public bool IsAudioDirect { get; set; }

        public int? Bitrate { get; set; }

        public float? Framerate { get; set; }

        public double? CompletionPercentage { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public int? AudioChannels { get; set; }

        public string HardwareAccelerationType { get; set; }

        public TranscodeReason[] TranscodeReasons { get; set; }
    }
}
