using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Setting
{
    public string Name { get; set; }
    public string Value { get; set; }


}

public static class SettingName
{
    public const string MoveForward = "move_forward";
    public const string MoveBack = "move_backward";
    public const string MoveLeft = "move_left";
    public const string MoveRight = "move_right";
    public const string Jump = "jump";
    public const string PrimaryAttack = "attack1";
}

public class Settings
{
    private List<Setting> settings = new List<Setting>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    List<Setting> ReadSettings()
    {
        string dataPath = $"{System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData)}/SpaceRL/";
        string settingsPath = $"{dataPath}settings.cfg";
        if (!Directory.Exists(dataPath)) {
            Directory.CreateDirectory(dataPath);
        }
        if (!File.Exists(settingsPath))
        {
            File.Create(settingsPath);
        }

        //Read the settings file to a list
        using (StreamReader sr = new StreamReader(settingsPath))
        {
            string line;
            while((line = sr.ReadLine()) != null)
            {
                Setting s = new Setting();
                string[] sa = line.Split('=');
                if(sa.Length != 2)
                {
                    Exception CorruptFileException = new Exception();
                    throw CorruptFileException;
                }
                s.Name = sa[0].Trim();
                s.Value = sa[1].Trim();
                if (!settings.Contains(s))
                {
                    settings.Add(s);
                }
            }
        }
        return settings;
    }

    public List<Setting> GetAll()
    {
        return ReadSettings();
    }

    public Setting Get(string setting)
    {
        if (settings.Count == 0) settings = ReadSettings();
        return settings.FirstOrDefault(x => x.Name == setting);
    }

}
