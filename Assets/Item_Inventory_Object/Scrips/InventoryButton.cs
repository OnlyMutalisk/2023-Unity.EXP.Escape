using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject InbentoryPanel; // UI 패널을 참조하는 변수

    // 버튼 클릭 시 호출되는 메서드
    public void TogglePanel()
    {
        InbentoryPanel.SetActive(!InbentoryPanel.activeSelf); // UI 패널의 활성화/비활성화 상태를 토글
    }
}
