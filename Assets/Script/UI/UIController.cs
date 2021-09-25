using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    /*
     * 控制按鈕的畫面
     * 暫停遊戲
     * 控制標題的畫面
     * 控制對話的
     * 控制血量圖片的出現
     * 控制結局的畫面跟儲存數字
     * 重新開始遊戲
     * 關閉遊戲
     * 
     */

    public GameObject startButton, stopButton, dialogBox;
    public Text dialogBoxText;
    private int[] ends = {1, 2, 3};//1:攻略成功   2:被打死 3: 時間到
    private int finalEnd = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameStart() //開始遊戲
    {
        SceneManager.LoadScene("GameScene");       
    }

    public void gameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void startTimeButton()
    {
        startTime();
        startButton.SetActive(false);
        stopButton.SetActive(true);
    }

    public void stopTimeButton()
    {
        stopTime();
        startButton.SetActive(true);
        stopButton.SetActive(false);
    }

    public void stopTime()
    {
        Time.timeScale = 0f;
    }

    public void startTime()
    {
        Time.timeScale = 1f;
    }

    public void showDialogBox() //之後會用switch
    {       
        stopTime();
        dialogBox.SetActive(true);    
        dialogBoxText.text = "令人心動的校花貓（粉）就在你（黃）的面前了\n" +
            "如果不快點使她心動的話，護花使者（藍、黑）會不斷的出現，\n" +
            "來打擊你，甚至會有莫名其妙的發展（？";                        
    }

    public void showCommentary()
    {
        dialogBox.SetActive(true);
        dialogBoxText.text = "使用ＷＳＡＤ作為上下左右移動\n" +
            "按下空白鍵可以發射邱比特之箭，使校花貓對你有好感，或是擊倒護花使者。\n" +
            "正上方的血條是校花貓對你的厭煩程度，歸零的話則被你徹底攻陷。\n"+
            "左下角的圖案為你的血量，不要被打倒囉！\n"+
            "必須在時間之內達成目標，否則校花貓會沒有耐心，期間會掉落增加秒數的幸運包裹，來讓校花貓可以對你多看幾眼喔！";
    }

    public void showBossHalf()
    {
        dialogBox.SetActive(true);
        dialogBoxText.text = "校花貓撇見有位莫名其妙的貓，雖然他很努力的在追求，可是不能輕易接受，不然會被當作太隨便了，得讓護花使者更加賣力地驅逐他了⋯⋯";
    }

    public void hideDialogBox()
    {
        dialogBox.SetActive(false);
        startTime();
    }

    public void hideEndBox()
    {
        dialogBox.SetActive(false);
    }

    public void quitGame() //QuitButton的功能

    {
        Application.Quit(); //離開應用程式

    }

    public void resetGame() //RestartButton的功能

    {
        SceneManager.LoadScene("GameScene");//讀取關卡(已讀取的關卡)
    }

    public int getEnd(int i)
    {
        return ends[i];
    }
}
