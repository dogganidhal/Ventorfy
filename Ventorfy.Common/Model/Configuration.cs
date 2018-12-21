using System.IO;
using System.Xml.Serialization;

namespace Ventorfy.Common.Model
{
	public class Configuration
	{
		
		public string DbConnectionString { get; set; }
		// TODO: Add other config stuff here

		private static Configuration _Instance;
		public static Configuration Instance
		{
			get
			{
				if (_Instance == null)
				{
					var serializer = new XmlSerializer(typeof(Configuration));
					var reader = new StreamReader("./Resources/config.xml");
					_Instance = (Configuration)serializer.Deserialize(reader);
					reader.Close();	
				}
				return _Instance;
			}
		}
	}
}