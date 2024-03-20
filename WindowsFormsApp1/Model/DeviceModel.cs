namespace HealthcareManagement.Model
{
    class DeviceModel
    {
        public string DeviceName;
        public string IP;

        public DeviceModel() { }

        public DeviceModel(string DeviceName, string IP)
        {
            this.DeviceName = DeviceName;
            this.IP = IP;
        }

    }
}
