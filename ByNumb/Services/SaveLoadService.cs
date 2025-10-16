using ByNumb.Entities;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ByNumb.Services
{
    public static class SaveLoadService
    {
        
        // Fields
        private static JsonSerializerOptions option = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
        private static string path = "./eapntgHpktSpip15.byNumb";

        // Methods

        public static void Save(Player player)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(player, option));
            MessageBox.Show("Your in-game achievements have been successfully saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Player Load()
        {                                                                                               
            
            if (!File.Exists(path))
            {
                return new Player("Player");
               
            }
            Player player = JsonSerializer.Deserialize<Player>(File.ReadAllText(path), option) ?? new Player("Player");
            MessageBox.Show($"Your in-game achievements have been successfully loaded, {player.getName()}!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return player;

        } 
    }
}
