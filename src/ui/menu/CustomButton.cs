using DsUi;
using Godot;

namespace UI.Menu;

/// <summary>
/// 自定义脚本获取当前节点所属的 DsUi 节点实例
/// </summary>
public partial class CustomButton : Button, IUiNodeScript
{
    public void SetUiNode(IUiNode uiNode)
    {
        var node = (Menu.Custom)uiNode;
        GD.Print("初始化Node: " + node.Instance.Name);
    }

    public void OnDestroy()
    {
        GD.Print("销毁Node");
    }
}