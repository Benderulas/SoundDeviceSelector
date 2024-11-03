using System.Collections.Generic;

namespace SoundDeviceSelector.src
{
    internal interface ISoundDeviceManager
    {
        public ICollection<SoundDevice> GetAllDevices();
        public void SetDefaultDevice(string deviceId);
    }
}
