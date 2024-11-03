using System.Collections.Generic;

namespace SoundDeviceSelector.src
{
    internal class SoundDeviceTracker : ISoundDeviceTracker
    {
        private readonly string _filePath;
        private readonly List<string> _tracked_ids;

        public SoundDeviceTracker(string filePath) {
            _filePath = filePath;
            _tracked_ids = LoadFromFile();
        }

        public void TrackDevice(string deviceId)
        {
            _tracked_ids.Add(deviceId);
            SaveToFile();
        }
        public void UntrackDevice(string deviceId)
        {
            _tracked_ids.Remove(deviceId);
            SaveToFile();
        }

        public bool DeviceTracked(string deviceId) => _tracked_ids.Contains(deviceId);
        private List<string> LoadFromFile() => throw new System.NotImplementedException();
        private void SaveToFile() => throw new System.NotImplementedException();
    }
}
