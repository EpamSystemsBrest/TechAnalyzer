using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace DownloadService.ServiseState
{
    public enum ServiseStatus
    {
        Running = 1,
        Pause = 2,
        Done = 3,
        Stop = 4,
        Shutdown = 5,
        Resume = 6
    }

    public class ServiceStateSerializer
    {
        private static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public static void SerializeServiceStateToXml(Statistics statistics)
        {
            using (var file = new FileStream(baseDirectory + "save.xml", FileMode.OpenOrCreate))
            {
                var serializer = new DataContractSerializer(typeof (Statistics));
                serializer.WriteObject(file, statistics);
            }

        }

        public static Statistics DeserializeServiceState()
        {
            var path = baseDirectory + "save.xml";
            if (new FileInfo(path).Length == 0) return new Statistics();

            var dataContractSerializer = new DataContractSerializer(typeof (Statistics));
            using (var file = new FileStream(path, FileMode.Open))
            using (var reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas()))
            {
                var statistic = (Statistics) dataContractSerializer.ReadObject(reader);
                statistic.CurrentUrl = new ConcurrentBag<string>();
                return statistic;
            }
        }

        public static void ServiseStateClear()
        {
            File.WriteAllText(baseDirectory + "save.xml", string.Empty);
        }
    }
}
