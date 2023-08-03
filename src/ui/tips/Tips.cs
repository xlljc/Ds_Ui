using DsUi;

namespace UI.Tips;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Tips : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.AcceptDialog"/>, 节点路径: Tips.AcceptDialog
    /// </summary>
    public AcceptDialog L_AcceptDialog
    {
        get
        {
            if (_L_AcceptDialog == null) _L_AcceptDialog = new AcceptDialog(this, GetNodeOrNull<Godot.AcceptDialog>("AcceptDialog"));
            return _L_AcceptDialog;
        }
    }
    private AcceptDialog _L_AcceptDialog;


    public Tips() : base(nameof(Tips))
    {
    }

    public sealed override void OnInitNestedUi()
    {
    }

    /// <summary>
    /// 类型: <see cref="Godot.AcceptDialog"/>, 路径: Tips.AcceptDialog
    /// </summary>
    public class AcceptDialog : UiNode<Tips, Godot.AcceptDialog, AcceptDialog>
    {
        public AcceptDialog(Tips uiPanel, Godot.AcceptDialog node) : base(uiPanel, node) {  }
        public override AcceptDialog Clone() => new (UiPanel, (Godot.AcceptDialog)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.AcceptDialog"/>, 节点路径: Tips.AcceptDialog
    /// </summary>
    public AcceptDialog S_AcceptDialog => L_AcceptDialog;

}
