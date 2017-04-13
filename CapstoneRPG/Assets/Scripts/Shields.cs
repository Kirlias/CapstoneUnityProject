using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Shields : Item {

    //different types of weapons
    private string[] types = { "Wood", "Sqr", "Kite" };


    //different names ordered from best multiplier to worst
    private string[] wood= { "Charred Wheel", "Wooden Shield", "Trimmed Round Shield" };
    private string[] squares = { "Light Square Shield", "Iron Square Shield", "Reinforced Square Shield" };
    private string[] kites = { "Lead Kite Shield", "Tempered Iron Kite Shield", "The Wall" };


    public int defense { get; set; }

    public int bonus { get; set; }

    System.Random rand = new System.Random();
    
    Shields()
    {
        int shieldtype = rand.Next(3);

        this.type = types[shieldtype];

        if (this.type.Equals("Wood"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = wood[name];
            defense = name + 10;
            bonus = name * 3;
            this.id = "02" + shieldtype.ToString() + name.ToString();
        }
        if (this.type.Equals("Sqr"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = squares[name];
            defense = name + 10;
            bonus = name * 3;
            this.id = "02" + shieldtype.ToString() + name.ToString();
        }
        if (this.type.Equals("Kite"))
        {
            //generate a random name
            int name = rand.Next(3);
            //give it the name
            this.title = kites[name];
            defense = name + 10;
            bonus = name * 3;
            this.id = "02" + shieldtype.ToString() + name.ToString();
        }

    }
}
