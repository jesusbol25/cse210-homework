using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // La lista que guarda todas las entradas
    public List<Entry> _entries = new List<Entry>();

    // Método para mostrar todo en pantalla
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Método para guardar en JSON
    public void SaveToFile(string filename)
    {
        // Configuramos cómo queremos que se vea el JSON
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true, // Le da un formato bonito y legible (con espacios)
            IncludeFields = true  // Permite que lea tus variables con guion bajo (_)
        };

        // Traduce la lista a texto JSON
        string jsonString = JsonSerializer.Serialize(_entries, options);
        
        // Crea el archivo y guarda el texto
        File.WriteAllText(filename, jsonString);
    }

    // Método para cargar desde JSON
    public void LoadFromFile(string filename)
    {
        // Verifica si el archivo existe para no generar un error
        if (File.Exists(filename))
        {
            // Lee todo el texto del archivo
            string jsonString = File.ReadAllText(filename);
            
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            // Traduce el texto JSON de vuelta a una lista de objetos Entry
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString, options);
        }
        else
        {
            Console.WriteLine("Error: El archivo no existe.");
        }

        
            
    }
}