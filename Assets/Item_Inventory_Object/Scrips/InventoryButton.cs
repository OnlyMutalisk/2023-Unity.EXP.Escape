using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject InbentoryPanel; // UI �г��� �����ϴ� ����

    // ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void TogglePanel()
    {
        InbentoryPanel.SetActive(!InbentoryPanel.activeSelf); // UI �г��� Ȱ��ȭ/��Ȱ��ȭ ���¸� ���
    }
}
