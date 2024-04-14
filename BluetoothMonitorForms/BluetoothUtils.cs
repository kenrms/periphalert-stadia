using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace BluetoothMonitorForms
{
    public static partial class BluetoothUtils
    {
        public const string stadiaDeviceName = "StadiaJSFM-375d";

        public static DeviceBatteryInfo GetStadiaBatteryLevel()
        {
            var deviceInfo = new DeviceBatteryInfo();

            try
            {
                string scriptText = @"
                    $targetDeviceName = ""StadiaJSFM-375d""

                    $bluetoothDevices = Get-PnpDevice -Class Bluetooth | Where-Object { $_.FriendlyName -eq $targetDeviceName }

                    if ($bluetoothDevices) {
                      $batteryLevel = Get-PnpDeviceProperty -InstanceId $bluetoothDevices.InstanceId -KeyName '{104EA319-6EE2-4701-BD47-8DDBF425BBE5} 2'
                    }

                    $batteryLevel.Data
                ";

                InitialSessionState runspaceConfiguration = InitialSessionState.CreateDefault2();
                runspaceConfiguration.ExecutionPolicy = Microsoft.PowerShell.ExecutionPolicy.Bypass;

                using (Runspace runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration))
                {
                    runspace.Open();

                    using (PowerShell invoker = PowerShell.Create(runspace))
                    {
                        invoker.Commands.AddScript(scriptText);
                        var result = invoker.Invoke().FirstOrDefault();

                        if (result != null)
                        {
                            deviceInfo.Name = stadiaDeviceName;
                            deviceInfo.BatteryLevel = (byte)result.BaseObject;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., PowerShell errors)
                Console.WriteLine("Error executing script: " + ex.Message);
                throw ex;
            }

            return deviceInfo;
        }
    }
}