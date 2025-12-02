using System;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    [Header("View")]
    [SerializeField] private HPView hpView;

    [Header("Buttons")]
    [SerializeField] private Button damageButton;
    [SerializeField] private Button healButton;

    private HPStatus hpStatus;

    private void Awake()
    {
        hpStatus = new HPStatus();
    }

    void OnEnable()
    {
        damageButton.onClick.AddListener(OnClickDamage);
        healButton.onClick.AddListener(OnClickHeal);
    }

    private void OnDisable()
    {
        damageButton.onClick.RemoveListener(OnClickDamage);
        healButton.onClick.RemoveListener(OnClickHeal);
    }


    private void OnClickDamage()
    {
        hpStatus.Damage();
        RefreshView();
    }

    private void OnClickHeal()
    {
        hpStatus.Heal();
        RefreshView();
    }

    private void RefreshView()
    {
        hpView.SetUp(hpStatus.Hp);
    }
}

