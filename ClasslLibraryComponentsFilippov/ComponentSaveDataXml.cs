using ClasslLibraryComponentsFilippov.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Xml.Serialization;

namespace ClasslLibraryComponentsFilippov
{
    public partial class ComponentSaveDataXml : Component
    {
        private ErrorMessage errorMessage = ErrorMessage.Ошибок_нет;
        public string ErrorMessageString { get => errorMessage.ToString(); }
        public ComponentSaveDataXml()
        {
            InitializeComponent();
        }

        public ComponentSaveDataXml(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public bool SaveData<T>(string path, List<T> dataList)
        where T : class, new()
        {
            bool result;
            if (!string.IsNullOrEmpty(path))
            {
                T objectT = Activator.CreateInstance<T>();
                if (objectT.GetType().GetCustomAttribute(typeof(SerializableAttribute)) != null)
                {
                    Directory.CreateDirectory(string.Concat(path, "/", objectT.GetType().Name));
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    using (FileStream fileStream = new FileStream(string.Concat(new string[] { path, "/", objectT.GetType().Name, "/", objectT.GetType().Name, ".xml" }), FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fileStream, dataList);
                    }
                    string str = string.Concat(path, "/", objectT.GetType().Name, "/");
                    string[] shortDateString = new string[] { path, "/", objectT.GetType().Name, ".", null, null };
                    shortDateString[4] = DateTime.Now.ToShortDateString();
                    shortDateString[5] = ".zip";
                    ZipFile.CreateFromDirectory(str, string.Concat(shortDateString));
                    Directory.Delete(string.Concat(path, "/", objectT.GetType().Name), true);
                    result = true;
                }
                else
                {
                    errorMessage = ErrorMessage.У_данных_не_настроена_сериализация_XML;
                    result = false;
                }
            }
            else
            {
                errorMessage = ErrorMessage.Не_указан_путь;
                result = false;
            }
            return result;
        }
    }
}
