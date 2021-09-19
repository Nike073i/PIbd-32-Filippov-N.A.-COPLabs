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
        private ErrorSaveXMLMessage errorMessage = ErrorSaveXMLMessage.Ошибок_нет;
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
            if (dataList == null)
            {
                errorMessage = ErrorSaveXMLMessage.Данные_не_указаны;
                return false;
            }
            if (string.IsNullOrEmpty(path))
            {
                errorMessage = ErrorSaveXMLMessage.Не_указан_путь;
                return false;
            }
            T objectT = new T();
            if (objectT.GetType().GetCustomAttribute(typeof(SerializableAttribute)) == null)
            {
                errorMessage = ErrorSaveXMLMessage.У_данных_не_настроена_сериализация_XML;
                return false;
            }
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
            return true;
        }
    }
}
