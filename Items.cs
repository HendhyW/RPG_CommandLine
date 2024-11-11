using System;

// Akan menggunakan decorator pattern untuk mengaplikasikan berbagai stats terhadap item
// Pada kasus ini, class Item akan menjadi superclass dari berbagai jenis item (e.g. Equipments, Consummables)
public class Items {
    // Quantity tidak akan bisa bernilai negatif
    // Paling sedikit bernilai 0
    int quantity;
    string name;
    // Rarity akan berada pada range 1-3, dimana 3 paling rare dan 1 paling common
    int rarity;

    public Items() {
        rarity = 1;
        quantity = 1;
        name = null;
    }

    public Items(int rareIn) {
        rarity = rareIn;
        quantity = 1;
        name = null;
    }

    public Items(int rareIn, int quanIn) {
        rarity = rareIn;
        quantity = quanIn;
        name = null;
    }
    

    public Items(int rareIn, int quanIn, string nameIn) {
        rarity = rareIn;
        quantity = quanIn;
        name = nameIn;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int input) {
        if(input > 0) {
            quantity = input;
        } else {
            // Error handling sederhana, bisa dikembangkan
            quantity = 0;
        }
    }

    public void addQuantity(int input) {
        quantity += input;
    }

    public void subQuantity(int input) {
        quantity -= input;
        if (quantity-input < 0) {
            // Error handling sederhana, bisa dikembangkan
            quantity = 0;
        }
    }

    public string getName() {
        return name;
    }
    
    // Jangan dipakai sering-sering, hanya bila sangat perlu
    public void changeName(string input) {
        name = input;
    }

    public int getRarity() {
        return rarity;
    }
    public void setRarity(int input) {
        if(input > 0 && input < 4) {
            // Error handling sederhana, bisa dikembangkan
            rarity = input;
        }
    }
}