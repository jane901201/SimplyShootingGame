using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndController : MonoBehaviour
{
    SaveData saveData;

    public Text endText, scoreText, timeText;
    private int end, score;
    private float time;

    /*
     * 因為目前想不到怎麼利用同樣的程式碼來改字，只好先在設計一個用來控制最後字串的東西了
     * 類別名子應該要娶得好一點 finalSceneController之類的
     */
    // Start is called before the first frame update
    void Start()
    {
        saveData = GameObject.FindGameObjectWithTag("UIController").GetComponent<SaveData>();
        end = saveData.getEndSave();
        score = saveData.getScoreSave();
        time = saveData.getTimeSave();
        endChoose(end);
        scoreText.text = "分數: " + score;
        timeText.text = "花費時間: " + time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void endChoose(int end)
    {
        switch(end)
        {
            case 1:
                endText.text = "周遭貓們忽然停止了行動，原本籠罩著天空的烏雲打開了一條縫隙，灑落了璀璨的陽光，為邊緣貓鋪上一條道路前往校花貓的身邊...." +
                    "「嗨....我是....」邊緣貓顫抖地說出口，實在難以說出自己的名字。" +
                    "「我都知道喔」校花貓對他拋了媚眼，彷彿眼中飛出了愛心，擊中了邊緣貓，他的毛髮漸漸的從綠色轉變成了紅色。" +
                    "「真可愛」校花貓噗哧的笑了：「以後就叫你亞歷山大吧」，邊緣貓喜極而泣。" +
                    "其他護花使者趕緊衝上前，為兩人獻上祝福「兩位如果有任何問題，可以盡情的使喚我們，我們願意付出身心靈來服侍兩位」\n\n" +
                    "成就：情比「石」堅";
                break;
            case 2:
                endText.text = "校花貓鄙視著倒在水窪中的你，一聲不坑的走了，護花使者們也趕緊跟上。但是，"
                    + "有些護花使者們留了下來，因為被你的邱比特之箭擊中，使他們轉移心念愛上了你。" +
                    "「嘿嘿⋯⋯讓我們就像地面上的水一樣，環繞在你身邊，再注入進你的身心靈吧」\n\n" +
                    "成就達成：無法成為魔法師了";

                break;
            case 3:
                endText.text = "校花貓看著你喃喃自語：「也不過長得如此」，露出了一臉厭惡的表情，看到她表情" +
                    "的你瞬間失去的動力，「我真的這麼沒用嗎」你心中想著。「不！」有貓彷彿聽見你的心聲，大聲" +
                    "回應了，你喜極而泣，發覺在愛情上找到自己心靈伴侶才是最重要的事情了，願意接受他奇怪的嗜好" +
                    "——頭頂上插著邱比特之箭。\n\n" +
                    "成就達成：天涯何處無芳「草」，何必單戀一枝「花」";
                break;
            default:
                endText.text =  "看來程式出bug了";
                break;
                
        }
    }

    
}
