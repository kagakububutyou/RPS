using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHand : MonoBehaviour {

    [SerializeField]
    Text txt;

    // Use this for initialization
    void Start()
    {
        txt.text = "変更したいテキスト";
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void PushButton()
    {
        txt.text = "＼(^O^)／";
    }
}
