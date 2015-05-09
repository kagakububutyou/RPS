using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PushButton : MonoBehaviour {

    [SerializeField]
    Button button;

    private EnemyHand txt;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(ShowLog);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowLog()
    {
        Debug.Log(button.name);

        txt = GetComponent<EnemyHand>();
        txt.PushButton();
    }
}
