using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

public class HPView : MonoBehaviour
{
    [SerializeField] private Image hpStatus;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private HPImage hpSO;
    
    public void SetUp(int hp)
    {
        hpText.text = hp.ToString();
        hpStatus.sprite = hpSO.hpImages[hp];
    }
}
