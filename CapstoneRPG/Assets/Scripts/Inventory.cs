public class Inventory {
   private List<Item> _inventory = new List<Item>();
    
   public void add_to_inventory(Item new_item) {
      _inventory.Add(new_item);
   }
   public Item getItem(int index) {
      return _inventory[index];
   }  


}
