using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TaskManagement.Models;
using TaskManagement.Views.DB;

namespace TaskManagement.Services
{
    public class DBHelper : BaseNotification
    {
        static string _saveFilePath = "../../../Data/DB/";
        public ObservableCollection<TreeViewElement> items { get; set; }
         public ObservableCollection<TreeViewElement> Items

        {
            get { return items; }
            set
            {
                items = value;
                NotifyPropertyChanged("Items");
            }
        }
        public DBHelper(ObservableCollection<TreeViewElement> items)
        {
            Items = items;
        }

        public void SaveToDB(TreeViewElement element)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter some text", "Input Box");
            string filePath = _saveFilePath + input + ".json";
            string jsonString = JsonSerializer.Serialize(Items);
            File.AppendAllText(filePath, jsonString);
        }

        public void LoadFromDB(string fileName)
        {
            string jsonString = File.ReadAllText(_saveFilePath + fileName);
            //MessageBox.Show(jsonString);
            var list = JsonSerializer.Deserialize<ObservableCollection<TreeViewElement>>(jsonString).ToList();
            foreach (var item in list)
            {
                Items.Add(item);
            }
          
        }

        public static List<string> GetSavedFiles()
        {
            string[] dir = Directory.GetFiles(_saveFilePath);
            List<string> fileNames = new List<string>();
            foreach (string path in dir)
            {
                string fileName = Path.GetFileName(path);
                fileNames.Add(fileName);
            }
            return fileNames;
        }

        public void OpenDB(TreeViewElement element)
        {
            OpenDB openDB = new OpenDB(this);   
            openDB.ShowDialog();
        }
    }
}
