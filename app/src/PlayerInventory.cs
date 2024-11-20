using System;

// PlayerInventory berbeda dengan class Player dan bukan merupakan subclassnya
// Digunakan untuk memanage inventory pada player
sealed public class PlayerInventory {
    public static PlayerInventory? instance = null;
    // Jumlah item yang ada pada inventory player
    int capacity = 0;
    // Akan berisi items secara spesifik, dan jumlahnya
    Dictionary<Items, int> items;

    // Implementasi Singleton pada PlayerInventory
    private PlayerInventory() {
        capacity = 0;
        items = new Dictionary<Items, int>();
    }

    public static PlayerInventory Instance() {
        if (instance == null) {
            return new PlayerInventory();
        } else {
            return instance;
        }
    }

    // Akan menghitung ulang jumlah item yang ada pada Inventory secara keseluruhan
    void refreshCapacity() {
        capacity = 0;
        foreach(KeyValuePair<Items, int> entry in items)
        {
            capacity += entry.Value;
        }
    }

    public void addToInventory(Items items, int input) {
        if(items != null) 
        {
            this.items.Add(items, input);
        }
        refreshCapacity();
    }

    // Return reference dari "items" yang isinya dictionary
    public Dictionary<Items, int> getAll() {
        return items;
    }

    // Reset isi dari item
    // Warning!! Semua item di items bakal di replace sama input
    public void setAll(Dictionary<Items, int> input) {
        items.Clear()
        foreach(Dictionary<items, int> item in items) {
            item.add(input);
        }
    }
}