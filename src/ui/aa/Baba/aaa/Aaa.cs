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

    /// <summary>
    /// 节点路径: Aaa.Control
    /// </summary>
    public Control L_Control
    {
        get
        {
            if (_L_Control == null) _L_Control = new Control((AaaPanel)this, GetNode<Godot.Control>("Control"));
            return _L_Control;
        }
    }
    private Control _L_Control;


    public Aaa() : base(nameof(Aaa))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = this;
        RecordNestedUi(inst1.L_Cc.Instance, null, UiManager.RecordType.Open);
        inst1.L_Cc.Instance.OnCreateUi();
        inst1.L_Cc.Instance.OnInitNestedUi();

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
    /// 路径: Aaa.Cc
    /// </summary>
    public class Cc : UiNode<AaaPanel, UI.aa.BB.Cc.CcPanel, Cc>
    {
        public Cc(AaaPanel uiPanel, UI.aa.BB.Cc.CcPanel node) : base(uiPanel, node) {  }
        public override Cc Clone()
        {
            var uiNode = new Cc(UiPanel, (UI.aa.BB.Cc.CcPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 路径: Aaa.Control
    /// </summary>
    public class Control : UiNode<AaaPanel, Godot.Control, Control>
    {
        public Control(AaaPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Aaa.Label
    /// </summary>
    public Label S_Label => L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Aaa.Cc
    /// </summary>
    public Cc S_Cc => L_Cc;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Aaa.Control
    /// </summary>
    public Control S_Control => L_Control;

}
