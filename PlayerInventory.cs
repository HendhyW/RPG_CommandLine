using System;

// PlayerInventory berbeda dengan class Player dan bukan merupakan subclassnya
// Digunakan untuk memanage inventory pada player
sealed public class PlayerInventory {
    int capacity = 0;
    // Item stats, quantity
    Dictionary<Items, int> items;
}