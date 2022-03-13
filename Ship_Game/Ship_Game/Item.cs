using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class Item
    {
        public int ID;
        public string Sys_Name;
        public string Name;
        public int dmgMAX;
        public int dmgMIN;
        public int ID_Spesabl;
        public int Heal_count;
        public int count;
        public string Type;
        public int level_spawn;
        public bool equiped;

        public void get_item()
        {
            if(ID == 0)
            {
                Sys_Name = "empty";
                Name = "<EMPTY>    ";
                Type = "nothing";
                dmgMAX = 0;
                dmgMIN = 0;
                ID_Spesabl = 0;
                
            }
            if(ID == 1)
            {
                Sys_Name = "short_sword";
                Name = "Short sword";
                Type = "weapon";
                dmgMAX = 5;
                dmgMIN = 0;
                level_spawn = 1;
            }
            else if(ID == 2)
            {
                Sys_Name = "long_sword";
                Name = "Long sword ";
                Type = "weapon";
                dmgMAX = 8;
                dmgMIN = 2;
                level_spawn = 1;
                
            }
            else if (ID == 3)
            {
                Sys_Name = "dagger";
                Name = "Dagger     ";
                Type = "weapon";
                dmgMAX = 3;
                dmgMIN = 0;
                level_spawn = 1;
                
            }
            else if (ID == 4)
            {
                Sys_Name = "RND_short_sword";
                Name = "***";
                Type = "weapon";
                dmgMAX = 3;
                dmgMIN = 0;
                
            }
            else if (ID == 5)
            {
                Sys_Name = "RND_long_sword";
                Name = "***";
                Type = "weapon";
                dmgMAX = 3;
                dmgMIN = 0;
                
            }
            else if (ID == 6)
            {
                Sys_Name = "RND_dagger";
                Name = "***";
                Type = "weapon";
                dmgMAX = 3;
                dmgMIN = 0;
                
            }
            else if (ID == 7)
            {
                Sys_Name = "claw";
                Name = "Claw";
                Type = "weapon";
                dmgMAX = 4;
                dmgMIN = 1;
                
            }
            else if (ID == 8)
            {
                Sys_Name = "robo_claw";
                Name = "Robo claw";
                Type = "weapon";
                dmgMAX = 6;
                dmgMIN = 0;
                
            }
            else if (ID == 9)
            {
                Sys_Name = "bread";
                Name = "Bread("+count+")   ";
                Type = "healing_using_item";
                Heal_count = 3;
            }
            else if (ID == 10)
            {
                Sys_Name = "admin_weapon";
                Name = "???";
                Type = "weapon";
                dmgMAX = 250;
                dmgMIN = 2;
            }
            else if (ID == 11)
            {
                Sys_Name = "healing_potion";
                Name = "Healing potion(" + count + ")   ";
                Type = "healing_using_item";
                count = 1;
                level_spawn = 2;
                Heal_count = 8;
            }
            else if (ID == 12)
            {
                Sys_Name = "knuckleduster";
                Name = "Knuckleduster";
                Type = "weapon";
                level_spawn = 1;
                dmgMAX = 4;
                dmgMIN = 2;
            }
            else if (ID == 13)
            {
                Sys_Name = "quarterstaff";
                Name = "Quarterstaff";
                Type = "weapon";
                level_spawn = 2;
                dmgMAX = 5;
                dmgMIN = 3;
            }
            else if (ID == 14)
            {
                Sys_Name = "spear";
                Name = "Spear";
                Type = "weapon";
                level_spawn = 2;
                dmgMAX = 6;
                dmgMIN = 2;
            }
            else if (ID == 15)
            {
                Sys_Name = "mace";
                Name = "Mace";
                Type = "weapon";
                level_spawn = 3;
                dmgMAX = 7;
                dmgMIN = 1;
            }
            else if (ID == 16)
            {
                Sys_Name = "battle_axe";
                Name = "Spear";
                Type = "weapon";
                level_spawn = 3;
                dmgMAX = 10;
                dmgMIN = 3;
            }
            else if (ID == 17)
            {
                Sys_Name = "war_hammer";
                Name = "War hammer";
                Type = "weapon";
                level_spawn = 3;
                dmgMAX = 10;
                dmgMIN = 4;
            }
            else if (ID == 18)
            {
                Sys_Name = "glaive";
                Name = "Glaive";
                Type = "weapon";
                level_spawn = 4;
                dmgMAX = 12;
                dmgMIN = 5;
            }
            else if (ID == 19)
            {
                Sys_Name = "leather_armour";
                Name = "Leather Armor";
                Type = "armor";
                level_spawn = 1;
            }
            else if (ID == 20)
            {
                Sys_Name = "iron_armour";
                Name = "Iron Armor";
                Type = "armor";
                level_spawn = 2;
            }
            else if (ID == 21)
            {
                Sys_Name = "mystic_armour";
                Name = "Mystic Armor";
                Type = "armor";
                level_spawn = 4;
            }
            else if (ID == 22)
            {
                Sys_Name = "obsidian_armour";
                Name = "Obsidian Armor";
                Type = "armor";
                level_spawn = 5;
            }
        }
        public static int get_level(int id, int level)
        {
            return level;
        }
        
    }
}
