using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Armour : Item {

    //different types of weapons
    private string[] types = { "Leather", "Chain", "Plate" };


    //different names ordered from best multiplier to worst
    private string[] leather = { "PatchWork Armour", "Padded Armour", "Hardened Armour" };
    private string[] chain = { "Damaged ChainMail", "Iron ChainMail", "Tempered Chains" };
    private string[] plate = { "Dented Mail", "Steel Plate", "Gilded PlateMail of the Gods" };

    public int defense { get; set; }

    public int bonus { get; set; }

    System.Random rand = new System.Random();

    /// <summary>
    /// Contructor for the amrour item class
    /// </summary>
    Armour()
    {
        int armourtype = rand.Next(3);

        this.type = types[armourtype];

        if (this.type.Equals("Leather"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = leather[name];
            defense = name + 10;
            bonus = name * 3;
            this.id = "01" + armourtype.ToString() + name.ToString();
        }
        if (this.type.Equals("Chain"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = chain[name];
            defense = name + 10;
            bonus = name * 3;
            this.id = "01" + armourtype.ToString() + name.ToString();
        }
        if (this.type.Equals("Plate"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = plate[name];
            defense = name + 10;
            bonus = name * 3;
            this.id = "01" + armourtype.ToString() + name.ToString();
        }

    }
}
