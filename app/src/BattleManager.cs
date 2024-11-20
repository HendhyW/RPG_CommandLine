using System;

// Class ini bertanggung jawab untuk mengatur pertarungan antara player dan musuh
public class BattleManager {
  //fields
  public static BattleManager? instance = null;
  //constructor

  //methods
  public void startBattle() {
    // Kode untuk memulai pertarungan
    // Menampilkan battle UI
    int choice = UI.Instance().showBattleUI();
    do
    {
      switch (choice)
      {
        case 1:
          // Basic Attack, mengurangi HP musuh sesuai dengan damage dari player
          break;
        case 2:
          // Skill, mengurangi HP musuh sesuai dengan damage dari skill yang dipilih
          break;
        case 3:
          // Access Inventory, menampilkan inventory player
          break;
        case 4:
          // Run, player mencoba untuk lari dari pertarungan
          break;
        default:
          break;
      }
    }
    while(choice != 4 && Player.Instance().getHealth() > 0 && Enemy.Instance().enemyHealth > 0);

    if (Player.Instance().getHealth() <= 0) {
      // Jika player mati, maka game over
      UI.Instance().showGameOver();
    } else {
      // Jika musuh mati, maka player mendapatkan EXP dan item
      // Player akan mendapatkan Exp, dan kemungkinan item dari musuh
      // Player akan kembali ke mode eksplorasi
    }


  }
}