using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/// <summary>
/// JSON 파일 관리를 위한 클래스 입니다.
/// 요구 패키지 Newtonsoft.Json
/// </summary>
public class JSON : MonoBehaviour
{
    // 매개 변수 경로에 txt 파일 생성
    public void CreateJSON(string path)
    {
        if (!File.Exists(path))
        {
            using (File.Create(path))
            {
                return;
            }
        }
        else
        {
            return;
        }
    }

    // JSON 파일에 정보 입력
    public void InputJSON(string key, JToken value)
    {
        json.Add(key, value);
    }

    // 경로에 있는 txt 파일에 JSON 정보 덮어 씌우기
    public void WriteJSON(string path)
    {
        File.WriteAllText(path, json.ToString());
    }

    // JSON 파일 불러오기
    public JObject ReadJSON(string path)
    {
        using (StreamReader text = File.OpenText(path))
        using (JsonTextReader reader = new JsonTextReader(text))
        {
            JObject read = (JObject)JToken.ReadFrom(reader);
            return read;
        }
    }

    #region 내부구현 (private)

    private JObject json = new JObject();

    #endregion
}
