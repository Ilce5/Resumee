using System.Collections.Generic;
using UnityEngine;
public enum ProgrammingLang{
        Default,
        Python,
        CPP,
        Java,
        JavaScript,
        CSharp
    }
    public class CFC{
        public static readonly string blue = "blue";
        public static readonly string red = "red";
        public static readonly string green = "green";

        public static readonly Dictionary<string, string> TypeFillColorJava = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red},
            {":", CFC.green},
            {"for", CFC.green},
            {"public", CFC.green},
            {"static", CFC.green},
            {"return", CFC.green},
            {"if", CFC.green},
            {"else", CFC.green},
            {"void", CFC.green},
            {"double", CFC.green},
            {"new", CFC.green},
            {"switch", CFC.green},
        };
        public static readonly Dictionary<string, string> TypeFillColor = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red}
        };
    
        public static readonly Dictionary<string, string> TypeFillColorPython = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red},
            {":", CFC.green}
        };
        public static readonly Dictionary<string, string> TypeFillColorCPlus = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red},
            {":", CFC.green}
        };
      
        public static readonly Dictionary<string, string> TypeFillColorCSharp = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red},
            {":", CFC.green}
        };
        public static readonly Dictionary<string, string> TypeFillColorJavaScript = new Dictionary<string, string> {
            {"const", CFC.blue},
            {"console", CFC.blue},
            {"let", CFC.red},
            {"Math", CFC.green},
            {"if", CFC.green},
            {"else", CFC.green},
            {"map", CFC.green},
            {"var", CFC.green},
            {"for", CFC.green}
        };
        public static readonly Dictionary<string, string> TypeFillColorPascal = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red},
            {":", CFC.green}
        };

        public static readonly Dictionary<string, string> TypeFillColorHtml = new Dictionary<string, string> {
            {"int", CFC.blue},
            {"float", CFC.blue},
            {"class", CFC.red},
            {":", CFC.green}
        };

    
        // Poseben

        public static readonly Dictionary<ProgrammingLang, Dictionary<string, string>> languageMap =
            new Dictionary<ProgrammingLang, Dictionary<string, string>> {
                {ProgrammingLang.Python, TypeFillColorPython},
                {ProgrammingLang.Default, TypeFillColor},
                {ProgrammingLang.Java,TypeFillColorJava},
                {ProgrammingLang.JavaScript,TypeFillColorJavaScript}
            };
    
        public static string GetFillColor(string type, ProgrammingLang language) {
            if (!languageMap.ContainsKey(language)){
                Debug.LogError($"LANGUAGE NOT FOUND! {language}");
                return "white";
            }
            if (languageMap[language].ContainsKey(type)) return languageMap[language][type];
            return "white";
        }
    }
