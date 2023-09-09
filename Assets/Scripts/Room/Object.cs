using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    #region 내부구현

    public CutScene cutScene;
    public Print print;
    public Monologue monologue_or_Dialogue;
    public Inventory inventory;
    public Image itemImage;
    public GameObject monologuePanel;
    public GameObject dialoguePanel;

    // 침실문 & 안방 창문 딜레이를 위한 플래그 입니다.
    public static bool lockedFlag = false;

    // 씬을 옮기면 플래그를 초기화 해 줍니다.
    private void Start()
    {
        lockedFlag = false;
    }

    // 지정한 사운드 파일을 재생한 후 대사를 출력합니다.
    public IEnumerator WaitForSounds(string messageName, string soundName)
    {
        // 사운드를 재생합니다.
        Room.SFX_재생(soundName);

        if (lockedFlag == true)
        {
            yield break;
        }

        lockedFlag = true;

        // 사운드 파일의 길이만큼 기다립니다.
        AudioClip audioClip = Resources.Load<AudioClip>("Sounds/SFX/" + soundName);
        float waitSeconds = audioClip.length;
        yield return new WaitForSeconds(waitSeconds);

        // 대사를 출력시킵니다.
        monologue_or_Dialogue.PrintMonologue(messageName);

        lockedFlag = false;
    }

    #endregion

    public void 아이템_획득(string itemName)
    {
        // 독백 & 대화 패널이 닫혀있을 때만 작동
        if (monologuePanel.active == false && dialoguePanel.active == false)
        {
            // 출력용 이미지를 현재 아이템의 이미지로 변경합니다. 아이템 리스트를 순회하여 찾습니다.
            foreach (var item in Item.items)
            {
                if (item.name == itemName)
                {
                    itemImage.sprite = item.sprite;
                }
            }

            // 아이템 이미지를 N초 동안 출력합니다.
            print.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            cutScene.PopUpDownImage(0, 1.5f);

            // 아이템 획득 시 대사를 출력합니다.

            print.ObjectPrint(gameObject.name);

            // 인벤토리에 아이템을 추가합니다.
            inventory.AddItem(itemName);
        }
    }

    public void 대사_출력(string messageName)
    {
        // 독백 & 대화 패널이 닫혀있을 때만 작동
        if (monologuePanel.active == false && dialoguePanel.active == false)
        {
            // 침실문 or 안방 창문일 경우, 사운드 출력 후 작동
            if (messageName == "map0_N08_침실문" || messageName == "map0_N04_침실창문")
            {
                StartCoroutine(WaitForSounds(messageName, "locked_door"));

                return;
            }

            monologue_or_Dialogue.PrintMonologue(messageName);
        }
    }
}
