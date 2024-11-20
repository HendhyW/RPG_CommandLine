using System;
using System.IO;

public class SaveManager {
    public static void Save(int select) {
        player = Player.Instance();
        using (StreamReader sr = File.OpenText("save"+select+".txt")) {
            // stats player
            sr.WriteLine("Player:");
            sr.WriteLine(playe.getPlayerName());
            sr.WriteLine(playe.getPlayerLevel());
            sr.WriteLine(playe.getPlayerPower());
            sr.WriteLine(playe.getHealth());
            sr.WriteLine(playe.getDef());
            sr.WriteLine(playe.getBaseATK());
            sr.WriteLine(playe.getSpeed());
            sr.WriteLine(playe.getStatusEffect());
            // items dari inventory
            items = PlayerInventory.Instance().getAll();
            // foreach(Dictionary<Items, int> item in items) {
            //     sr.WriteLine(item);
            // }
        }
    }

    public static void Load(int select) {
        player = Player.Instance();
        using (StreamReader sr = File.OpenText("save"+select+".txt")) {
            // stats player using (StreamReader sr = File.OpenText(path))
            player.setPlayerName(sr.ReadLine());
            player.setPlayerLevel(sr.ReadLine());
            player.setPlayerPower(sr.ReadLine());
            player.setHealth(sr.ReadLine());
            player.setDef(sr.ReadLine());
            player.setBaseATK(sr.ReadLine());
            player.setSpeed(sr.ReadLine());
            player.setStatusEffect(sr.ReadLine());
        }
    }
}