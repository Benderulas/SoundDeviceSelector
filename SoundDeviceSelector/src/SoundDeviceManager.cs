using System.Collections.Generic;
using System.Linq;
using AudioSwitcher.AudioApi.CoreAudio;

namespace SoundDeviceSelector.src
{
    internal class SoundDeviceManager : ISoundDeviceManager
    {
        private readonly CoreAudioController _audioController = new();

        public ICollection<SoundDevice> GetAllDevices() => _audioController.GetDevices().Select(device => new SoundDevice(device)).ToList();
        public void SetDefaultDevice(string deviceId) => GetInitialDevice(deviceId).SetAsDefault();
        private CoreAudioDevice GetInitialDevice(string deviceId) => _audioController.GetDevice(new System.Guid(deviceId));
    }
}
