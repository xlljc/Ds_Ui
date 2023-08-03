using DsUi;

namespace UI.Setting;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Setting : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: Setting.Back
    /// </summary>
    public Back L_Back
    {
        get
        {
            if (_L_Back == null) _L_Back = new Back(this, GetNodeOrNull<Godot.Button>("Back"));
            return _L_Back;
        }
    }
    private Back _L_Back;


    public Setting() : base(nameof(Setting))
    {
    }

    public sealed override void OnInitNestedUi()
    {
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: Setting.Back
    /// </summary>
    public class Back : UiNode<Setting, Godot.Button, Back>
    {
        public Back(Setting uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Back Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: Setting.Back
    /// </summary>
    public Back S_Back => L_Back;

}
