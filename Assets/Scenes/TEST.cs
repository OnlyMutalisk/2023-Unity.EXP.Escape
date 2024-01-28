using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    public Inventory inventory;

    public void Start()
    {
        Items.Add();
    }


    public void Test()
    {
        inventory.AddItem("헤어핀");
        inventory.AddItem("드릴");
        inventory.AddItem("망치");

    }
}
