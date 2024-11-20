using System;
using System.IO;

public class SaveManager {
    public static void Save(int select) {
        using (StreamReader sr = File.OpenText("save"+select+".txt")) {
            // stats Player.Instance()
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
        using (StreamReader sr = File.OpenText("save"+select+".txt")) {
            // stats Player.Instance() using (StreamReader sr = File.OpenText(path))
            Player.Instance().setPlayerName(sr.ReadLine());
            Player.Instance().setPlayerLevel(sr.ReadLine());
            Player.Instance().setPlayerPower(sr.ReadLine());
            Player.Instance().setHealth(sr.ReadLine());
            Player.Instance().setDef(sr.ReadLine());
            Player.Instance().setBaseATK(sr.ReadLine());
            Player.Instance().setSpeed(sr.ReadLine());
            Player.Instance().setStatusEffect(sr.ReadLine());
        }
    }
}