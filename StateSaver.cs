using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Newtonsoft.Json;

namespace ClickerGame {
    public static class StateSaver {
        private static readonly string JSON_PATH = "./GameInstance.json";

        public static void SaveGameInstance() {     
            string json = JsonConvert.SerializeObject(Game.Instance);
            // TODO: Error handling
            File.WriteAllText(JSON_PATH, json);           
        }

        public static void LoadGameInstance() {
            if (ProgramArgumentParser.Option(ProgramArgumentParser.OPTIONS.NO_SAVE)) {
                return;
            }

            // TODO: Make this not
            if (!File.Exists(JSON_PATH)) {
                Log.Write($"Can't open saved game data from path '{JSON_PATH}'");
                return;
            }
            Game des = JsonConvert.DeserializeObject<Game>(File.ReadAllText(JSON_PATH), new JsonSerializerSettings() { ObjectCreationHandling = ObjectCreationHandling.Replace });
            Game.Instance = des;
            Form1.Instance.UpdatePoints();
        }        

        public static void EraseSavedInstance() {
            // TODO: Implement this method
        }
    }
}
