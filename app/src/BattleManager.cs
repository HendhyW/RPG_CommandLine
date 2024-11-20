using System;

// Class ini bertanggung jawab untuk mengatur pertarungan antara player dan musuh
public class BattleManager {
  //fields
  public Enemy? enemy;
  public static BattleManager? instance = null;
  //constructor

  //methods
  public void startBattle() {
    EnemySpawner enemySpawner = new EnemySpawner();
    enemy = enemySpawner.spawnCommonPhysical();
    // Kode untuk memulai pertarungan
    // Menampilkan battle UI
    int choice = 0;
    do
    {
      if(Player.Instance().getSpeed() > enemy.getSpeed())
      {
        PlayerTurn(choice, enemy);
        enemy.Attack();
      }
      else
      {
        enemy.Attack();
        PlayerTurn(choice, enemy);
      }
    }
    while(choice != 4 && Player.Instance().getHealth() > 0 || enemy.getHealth() > 0);

    if (Player.Instance().getHealth() <= 0) {
      // Jika player mati, maka game over
      UI.showGameOver();
    } else {
      // Jika musuh mati, maka player mendapatkan EXP dan item
      // Player akan mendapatkan Exp, dan kemungkinan item dari musuh
      // Player akan kembali ke mode eksplorasi
      Console.WriteLine("Player wins");
    }
  }

  public void PlayerTurn(int choice, Enemy enemy) {
    // Method ini digunakan untuk menentukan turn player
    // Player akan melakukan action sesuai pilihan
      switch (choice)
      {
        case 1:
          Player.Instance().Attack(enemy);
          // Basic Attack, mengurangi HP musuh sesuai dengan damage dari player
          break;
        case 2:
          // Skill, mengurangi HP musuh sesuai dengan damage dari skill yang dipilih
          break;
        case 3:
          enemy.EnemyStats();
          // Menampilkan Status dari musuh
          break;
        case 4:
          // Access Inventory, menampilkan inventory player
          break;
        case 5:
          // Run, player mencoba untuk lari dari pertarungan
          Random random = new Random();
          int chance = random.Next(0, 99);
          if (chance < 50)
          {
            // Player berhasil lari dari pertarungan
            break;
          }
          else
          {
            // Player gagal lari dari pertarungan
            break;
          }
        default:
          break;
      }
  }
}