using System.Collections.Generic;
using System.IO;

namespace SoundDeviceSelector.src
{
    internal class SoundDeviceTracker : ISoundDeviceTracker
    {
        private readonly string _filePath;
        private readonly List<string> _tracked_ids;

        public SoundDeviceTracker(string filePath) {
            _filePath = filePath;
            _tracked_ids = ReadFormFile();
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
        private List<string> ReadFormFile()
        {
            List<string> trackedIds = [];
            using (var fileStream = new StreamReader(_filePath))
            {
                string line;
                while ((line = fileStream.ReadLine()) != null)
                {
                    trackedIds.Add(line);
                }
            }

            return trackedIds;
        }

        private void SaveToFile()
        {
            using (var fileStream = new StreamWriter(_filePath))
            {
                foreach (var id in _tracked_ids)
                {
                    fileStream.WriteLine(id);
                }
            }
        }
    }
}
