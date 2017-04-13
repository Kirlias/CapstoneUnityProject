using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Weapon : Item{

    //different types of weapons
    private string[] types = {"Sword", "Spear", "Dagger"};


    //different names ordered from best multiplier to worst
    private string[] swords = {"Broken Blade", "Iron Sword", "Sharpened Sabre" };
    private string[] spears = { "Cracked Poker", "Lead Tipped Pole", "Spiked Stabber" };
    private string[] daggers = {"Butter Knife", "Steel Dagger", "Silent Slicer" };

    //base damage for the weapon
    public int damage { get; set; }

    //bonus based on index of name in its lst
    public int bonus { get; set; }

    //random thing
    System.Random rand = new System.Random();


    /// <summary>
    /// Constructor for the weapon calss
    /// </summary>
    Weapon()
    {
        //generate a random number from 0-2
        int weapontype = rand.Next(3);

        //get the weapon type fromt he list
        this.type = types[weapontype];

        //if its a sword
        if (this.type.Equals("Sword"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = swords[name];
            damage = name + 10;
            bonus = name * 3;
            this.id = "00" + weapontype.ToString() + name.ToString();
        }
        //if its a spear
        if (this.type.Equals("Spear"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = spears[name];
            damage = name + 10;
            bonus = name * 3;
            this.id = "00" + weapontype.ToString() + name.ToString();
        }
        //if its a dagger
        if (this.type.Equals("Dagger"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = daggers[name];
            damage = name + 10;
            bonus = name * 3;
            this.id = "00" + weapontype.ToString() + name.ToString();
        }
    }


}
