namespace UI.aa.BB.Cc;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Cc : UiBase
{
    /// <summary>
    /// 节点路径: Cc.Label
    /// </summary>
    public Label L_Label
    {
        get
        {
            if (_L_Label == null) _L_Label = new Label((CcPanel)this, GetNode<Godot.Label>("Label"));
            return _L_Label;
        }
    }
    private Label _L_Label;


    public Cc() : base(nameof(Cc))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 路径: Cc.Label
    /// </summary>
    public class Label : UiNode<CcPanel, Godot.Label, Label>
    {
        public Label(CcPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Cc.Label
    /// </summary>
    public Label S_Label => L_Label;

}
