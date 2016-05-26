using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace Localizator
{
    public partial class Form1 : Form
    {
        string configPath
        {
            get { return Environment.CurrentDirectory + "/config.ini"; }
        }
        List<LocalizedString> filteredItems = new List<LocalizedString>();
        string jsonFilePath;

        StringLocalizator DeserializeJSON(string json)
        {
            var serializer = new JavaScriptSerializer();
            StringLocalizator serializedResult = serializer.Deserialize<StringLocalizator>(json);
            return serializedResult;
        }
       
        string SerializeJSON()
        {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(localizatror);
            return json;
        }
        StringLocalizator localizatror;

        public Form1()
        {
            InitializeComponent();
        }
        void Init()
        {
            if (File.Exists(configPath))
            {
                var config = File.OpenText(configPath);
                jsonFilePath = config.ReadToEnd();
                if (File.Exists(jsonFilePath))
                {
                    var jsonText = File.OpenText(jsonFilePath);
                    OpenLocalizator(DeserializeJSON(jsonText.ReadToEnd()));
                    jsonText.Close();
                }
                config.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            langSelector.DataSource = Enum.GetNames(typeof(StringLocalizator.Language));
            Init();
            addTranslation_button.Hide();
            translationBox.TextChanged += translationBox_textChanged;
        }
        void OpenLocalizator(StringLocalizator local)
        {
            Console.WriteLine(local);
            filteredItems = local.list;
            itemsList.DataSource = filteredItems;
            localizatror = local;
            UpdateTranslationBox();
        }
        void SaveConfig(string path)
        {
            jsonFilePath = path;
            var fs = File.Create(configPath);
            fs.Close();
            File.WriteAllText(configPath, path);
        }
        private void selectJSON_click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            Stream myStream = null;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var sr = new StreamReader(myStream);
                            var res = DeserializeJSON(sr.ReadToEnd());
                            sr.Close();
                            myStream.Close();
                            OpenLocalizator(res);
                            SaveConfig(ofd.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        void UpdateTranslationBox()
        {
            if (localizatror != null && itemsList.SelectedIndex >= 0 && itemsList.SelectedIndex < filteredItems.Count)
            {
                var selectedLanguage = langSelector.SelectedIndex;
                var translations = filteredItems[itemsList.SelectedIndex].translations;
                originalTextBox.Text = filteredItems[itemsList.SelectedIndex].original;
                if (selectedLanguage < translations.Count)
                {
                    translationBox.Enabled = true;
                    addTranslation_button.Hide();
                    translationBox.Text = translations[selectedLanguage].text;
                }
                else
                {
                    translationBox.Enabled = false;
                    translationBox.Text = "NOT TRANSLATED";
                    addTranslation_button.Show();
                }
            }

        }
        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTranslationBox();
        }

        private void translationBox_textChanged(object sender, EventArgs e)
        {
            if (localizatror != null)
            {
                
                var translations = filteredItems[itemsList.SelectedIndex].translations;
                var selectedLanguage = langSelector.SelectedIndex;
                if(selectedLanguage < translations.Count)
                {
                    translations[selectedLanguage].text = translationBox.Text;
                }
               
            }
        }

        private void lanSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTranslationBox();
        }

        private void addTranslation_click(object sender, EventArgs e)
        {
            if (localizatror != null)
            {
                filteredItems[itemsList.SelectedIndex].translations.Add(new Translation() { lang = (StringLocalizator.Language)langSelector.SelectedIndex, text = "" });
                translationBox.Text = "";
                translationBox.Enabled = true;
                addTranslation_button.Hide();
            }
        }

        private void saveChanges_click(object sender, EventArgs e)
        {
            UpdateList();
            var json = SerializeJSON();
            File.WriteAllText(jsonFilePath, json);
        }


        private void addItem_click(object sender, EventArgs e)
        {
            if (localizatror != null)
            {
                localizatror.list.Add(new LocalizedString() { original = "New Item", translations = new List<Translation>() });
             
                filteredItems = localizatror.list;
                UpdateList();
                itemsList.SetSelected(filteredItems.Count - 1, true);
            }

        }

        private void deleteItem_button_Click(object sender, EventArgs e)
        {
            if(localizatror != null)
            {
                var item = itemsList.Items[itemsList.SelectedIndex] as LocalizedString;
                DialogResult result = MessageBox.Show(string.Format("Are you sure you want to delete '{0}'?", item.original), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var i = itemsList.SelectedIndex;
                    localizatror.list.Remove(item);
                    UpdateList();
                    var next = i - 1;
                    if (next < 0)
                        next = 0; 

                    itemsList.SetSelected(next, true);
                    if(filteredItems.Contains(item))
                    {
                        searchBox_TextChanged(null, null);
                    }
                }
            }
        }

        private void originalTextBox_TextChanged(object sender, EventArgs e)
        {
            if(localizatror != null)
            {
                var translations = filteredItems[itemsList.SelectedIndex];
                translations.original = originalTextBox.Text;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 1)
                filteredItems = localizatror.list.FindAll(f => f.original.ToLower().StartsWith(searchBox.Text.ToLower()));
            else if (searchBox.Text.Length > 1)
                filteredItems = localizatror.list.FindAll(f => f.original.ToLower().Contains(searchBox.Text.ToLower()));
            else filteredItems = localizatror.list;
            if(itemsList.Items.Count > 0)
                 itemsList.SetSelected(0, true);
            UpdateList();
        }

        void UpdateList()
        {
            itemsList.DataSource = null;
            itemsList.DataSource = filteredItems;
        }
    }



    public class StringLocalizator
    {
        public enum Language
        {
            RU = 0,
            EN = 1,
            ES = 2
        }
        public List<LocalizedString> list;
        Dictionary<string, LocalizedString> _dict;
        public Dictionary<string, LocalizedString> dict
        {
            get
            {
                if (_dict == null)
                {
                    _dict = new Dictionary<string, LocalizedString>(list.Count);
                    foreach (var item in list)
                    {
                        dict.Add(item.original.ToLower(), item);
                    }
                }
                return _dict;
            }
        }
        public void UpdateDictionary()
        {
            _dict = new Dictionary<string, LocalizedString>(list.Count);
            foreach (var item in list)
            {
                dict.Add(item.original.ToLower(), item);
            }
        }
    }
    [System.Serializable]
    public class LocalizationJSON
    {
        public List<LocalizedString> list;

        public LocalizationJSON(List<LocalizedString> list)
        {
            this.list = list;
        }
    }

    [System.Serializable]
    public class LocalizedString
    {
        public string original;
        public List<Translation> translations;
        public override string ToString()
        {
            return original;
        }
    }

    [System.Serializable]
    public class Translation
    {
        public string text;
        public StringLocalizator.Language lang;
    }
}
