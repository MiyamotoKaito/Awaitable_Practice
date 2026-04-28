using UnityEngine;

public class LoadMaterialDemo : MonoBehaviour
{
    async void Start()
    {
        await LoadMaterial();
    }
    async Awaitable LoadMaterial()
    {
        Debug.Log("マテリアルをロード開始");
        var op = Resources.LoadAsync<Material>("SampleMaterial");
        Debug.Log("マテリアルをロード中");

        await op;

        var material = op.asset as Material;
        Debug.Log(material == null ? "マテリアルが読み込めませんでした" : "マテリアルのロード完了");

        this.gameObject.GetComponent<MeshRenderer>().material = material;
    }
}
