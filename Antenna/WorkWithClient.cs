
using System.Management;

namespace Antenna
{
    class WorkWithClient
    {
        public string getProcessorId()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string idproc = "";
            foreach (ManagementObject mo in mbsList)
            {
                idproc = mo["ProcessorID"].ToString();
            }

            return idproc;
        }
    }
}
