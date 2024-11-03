using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi;

namespace SoundDeviceSelector.src
{
    public readonly struct SoundDevice(CoreAudioDevice device)
    {
        public readonly string Id = device.Id.ToString();
        public readonly string Name = device.FullName;
        public readonly bool IsDefault = device.IsDefaultDevice;
        public readonly bool Active = device.State.Equals(DeviceState.Active);
    }
}
