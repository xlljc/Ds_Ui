namespace UI.aa.Baba.Aaa;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Aaa : UiBase
{
    /// <summary>
    /// 节点路径: Aaa.Label
    /// </summary>
    public Label L_Label
    {
        get
        {
            if (_L_Label == null) _L_Label = new Label((AaaPanel)this, GetNode<Godot.Label>("Label"));
            return _L_Label;
        }
    }
    private Label _L_Label;

    /// <summary>
    /// 节点路径: Aaa.Cc
    /// </summary>
    public Cc L_Cc
    {
        get
        {
            if (_L_Cc == null) _L_Cc = new Cc((AaaPanel)this, GetNode<UI.aa.BB.Cc.CcPanel>("Cc"));
            return _L_Cc;
        }
    }
    private Cc _L_Cc;


    public Aaa() : base(nameof(Aaa))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 路径: Aaa.Label
    /// </summary>
    public class Label : UiNode<AaaPanel, Godot.Label, Label>
    {
        public Label(AaaPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Aaa.Cc.Label
    /// </summary>
    public class Label_1 : UiNode<AaaPanel, Godot.Label, Label_1>
    {
        public Label_1(AaaPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_1 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Aaa.Cc
    /// </summary>
    public class Cc : UiNode<AaaPanel, UI.aa.BB.Cc.CcPanel, Cc>
    {
        /// <summary>
        /// 节点路径: Aaa.Label
        /// </summary>
        public Label_1 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_1(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_1 _L_Label;

        public Cc(AaaPanel uiPanel, UI.aa.BB.Cc.CcPanel node) : base(uiPanel, node) {  }
        public override Cc Clone() => new (UiPanel, (UI.aa.BB.Cc.CcPanel)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Aaa.Cc
    /// </summary>
    public Cc S_Cc => L_Cc;

}
