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
                T objectT = new T();
                if (objectT.GetType().GetCustomAttribute(typeof(SerializableAttribute)) != null)
                {
                    string objectTShortName = objectT.GetType().Name;
                    string dirPath = string.Concat(path, "/", objectTShortName);
                    Directory.CreateDirectory(dirPath);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    string fileStreamPath = string.Concat(dirPath, "/", objectTShortName, ".xml");
                    using (FileStream fileStream = new FileStream(fileStreamPath, FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fileStream, dataList);
                    }
                    string[] shortDateString = new string[] { dirPath, ".", DateTime.Now.ToShortDateString(), ".zip" };
                    ZipFile.CreateFromDirectory(string.Concat(dirPath, "/"), string.Concat(shortDateString));
                    Directory.Delete(dirPath, true);
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
