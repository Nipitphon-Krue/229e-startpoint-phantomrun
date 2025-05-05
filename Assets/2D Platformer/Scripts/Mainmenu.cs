using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game"); // เปลี่ยนเป็นชื่อ Scene เกมของคุณ
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditScene"); // ไปหน้าเครดิต
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // กลับหน้าเมนู
    }
}
