using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    private string[] prompts = {
        "¿Por qué estás agradecido hoy?",
        "¿Qué fue lo más importante que aprendiste hoy?",
        "Describe un momento que te hizo sonreír hoy.",
        "¿Qué podrías haber hecho mejor hoy?",
        "¿Cuál es tu meta para mañana?"
    };

    public void AddEntry()
    {
        var random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();
            foreach (string line in lines)
            {
                Entry entry = Entry.FromFileFormat(line);
                entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
