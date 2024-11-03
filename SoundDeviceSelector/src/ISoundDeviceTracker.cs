namespace SoundDeviceSelector.src
{
    internal interface ISoundDeviceTracker
    {
        public void TrackDevice(string deviceIds);
        public void UntrackDevice(string deviceIds);
        public bool DeviceTracked(string deviceId);
    }
}
