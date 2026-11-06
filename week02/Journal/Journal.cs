using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // the list of entries in the journal
    public List<Entry> _entries = new List<Entry>();

    // display all entries in the journal
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // method to save json to a file
    public void SaveToFile(string filename)
    {
        // Configuramos cómo queremos que se vea el JSON
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true, // give a visual indentation to the JSON
            IncludeFields = true  // allow to read variable with (_)
        };

        // Translate the  list to a JOSON text
        string jsonString = JsonSerializer.Serialize(_entries, options);
        
        // Create a file and write the JSON text into it
        File.WriteAllText(filename, jsonString);
    }

    // method to load from JSON
    public void LoadFromFile(string filename)
    {
        // Verify if the file exists before trying to read it
        if (File.Exists(filename))
        {
            // Lee todo el texto del archivo
            string jsonString = File.ReadAllText(filename);
            
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            // Translate the JSON text back to a list of Entry objects
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString, options);
        }
        else
        {
            Console.WriteLine("Error: The file does not exist.");
        }

        
            
    }
}