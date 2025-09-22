using DsUi;

namespace UI.Setting;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Setting : UiBase
{
    /// <summary>
    /// 节点路径: Setting.Back
    /// </summary>
    public Back L_Back
    {
        get
        {
            if (_L_Back == null) _L_Back = new Back((SettingPanel)this, GetNode<Godot.Button>("Back"));
            return _L_Back;
        }
    }
    private Back _L_Back;

    /// <summary>
    /// 节点路径: Setting.CenterContainer
    /// </summary>
    public CenterContainer L_CenterContainer
    {
        get
        {
            if (_L_CenterContainer == null) _L_CenterContainer = new CenterContainer((SettingPanel)this, GetNode<Godot.CenterContainer>("CenterContainer"));
            return _L_CenterContainer;
        }
    }
    private CenterContainer _L_CenterContainer;


    public Setting() : base(UiManager.UiName.Setting)
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 路径: Setting.Back
    /// </summary>
    public class Back : UiNode<SettingPanel, Godot.Button, Back>
    {
        public Back(SettingPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Back Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer.Setting1Name
    /// </summary>
    public class Setting1Name : UiNode<SettingPanel, Godot.Label, Setting1Name>
    {
        public Setting1Name(SettingPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Setting1Name Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer.SettingValue1
    /// </summary>
    public class SettingValue1 : UiNode<SettingPanel, Godot.HSlider, SettingValue1>
    {
        public SettingValue1(SettingPanel uiPanel, Godot.HSlider node) : base(uiPanel, node) {  }
        public override SettingValue1 Clone() => new (UiPanel, (Godot.HSlider)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<SettingPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 节点路径: Setting.CenterContainer.VBoxContainer.Setting1Name
        /// </summary>
        public Setting1Name L_Setting1Name
        {
            get
            {
                if (_L_Setting1Name == null) _L_Setting1Name = new Setting1Name(UiPanel, Instance.GetNode<Godot.Label>("Setting1Name"));
                return _L_Setting1Name;
            }
        }
        private Setting1Name _L_Setting1Name;

        /// <summary>
        /// 节点路径: Setting.CenterContainer.VBoxContainer.SettingValue1
        /// </summary>
        public SettingValue1 L_SettingValue1
        {
            get
            {
                if (_L_SettingValue1 == null) _L_SettingValue1 = new SettingValue1(UiPanel, Instance.GetNode<Godot.HSlider>("SettingValue1"));
                return _L_SettingValue1;
            }
        }
        private SettingValue1 _L_SettingValue1;

        public HBoxContainer(SettingPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer2.Setting2Name
    /// </summary>
    public class Setting2Name : UiNode<SettingPanel, Godot.Label, Setting2Name>
    {
        public Setting2Name(SettingPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Setting2Name Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer2.SettingValue2
    /// </summary>
    public class SettingValue2 : UiNode<SettingPanel, Godot.OptionButton, SettingValue2>
    {
        public SettingValue2(SettingPanel uiPanel, Godot.OptionButton node) : base(uiPanel, node) {  }
        public override SettingValue2 Clone() => new (UiPanel, (Godot.OptionButton)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer2
    /// </summary>
    public class HBoxContainer2 : UiNode<SettingPanel, Godot.HBoxContainer, HBoxContainer2>
    {
        /// <summary>
        /// 节点路径: Setting.CenterContainer.VBoxContainer.Setting2Name
        /// </summary>
        public Setting2Name L_Setting2Name
        {
            get
            {
                if (_L_Setting2Name == null) _L_Setting2Name = new Setting2Name(UiPanel, Instance.GetNode<Godot.Label>("Setting2Name"));
                return _L_Setting2Name;
            }
        }
        private Setting2Name _L_Setting2Name;

        /// <summary>
        /// 节点路径: Setting.CenterContainer.VBoxContainer.SettingValue2
        /// </summary>
        public SettingValue2 L_SettingValue2
        {
            get
            {
                if (_L_SettingValue2 == null) _L_SettingValue2 = new SettingValue2(UiPanel, Instance.GetNode<Godot.OptionButton>("SettingValue2"));
                return _L_SettingValue2;
            }
        }
        private SettingValue2 _L_SettingValue2;

        public HBoxContainer2(SettingPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer3.Setting3Name
    /// </summary>
    public class Setting3Name : UiNode<SettingPanel, Godot.Label, Setting3Name>
    {
        public Setting3Name(SettingPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Setting3Name Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer3.SettingValue3
    /// </summary>
    public class SettingValue3 : UiNode<SettingPanel, Godot.SpinBox, SettingValue3>
    {
        public SettingValue3(SettingPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override SettingValue3 Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.HBoxContainer3
    /// </summary>
    public class HBoxContainer3 : UiNode<SettingPanel, Godot.HBoxContainer, HBoxContainer3>
    {
        /// <summary>
        /// 节点路径: Setting.CenterContainer.VBoxContainer.Setting3Name
        /// </summary>
        public Setting3Name L_Setting3Name
        {
            get
            {
                if (_L_Setting3Name == null) _L_Setting3Name = new Setting3Name(UiPanel, Instance.GetNode<Godot.Label>("Setting3Name"));
                return _L_Setting3Name;
            }
        }
        private Setting3Name _L_Setting3Name;

        /// <summary>
        /// 节点路径: Setting.CenterContainer.VBoxContainer.SettingValue3
        /// </summary>
        public SettingValue3 L_SettingValue3
        {
            get
            {
                if (_L_SettingValue3 == null) _L_SettingValue3 = new SettingValue3(UiPanel, Instance.GetNode<Godot.SpinBox>("SettingValue3"));
                return _L_SettingValue3;
            }
        }
        private SettingValue3 _L_SettingValue3;

        public HBoxContainer3(SettingPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer3 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer.Apply
    /// </summary>
    public class Apply : UiNode<SettingPanel, Godot.Button, Apply>
    {
        public Apply(SettingPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Apply Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<SettingPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 节点路径: Setting.CenterContainer.HBoxContainer
        /// </summary>
        public HBoxContainer L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer _L_HBoxContainer;

        /// <summary>
        /// 节点路径: Setting.CenterContainer.HBoxContainer2
        /// </summary>
        public HBoxContainer2 L_HBoxContainer2
        {
            get
            {
                if (_L_HBoxContainer2 == null) _L_HBoxContainer2 = new HBoxContainer2(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer2"));
                return _L_HBoxContainer2;
            }
        }
        private HBoxContainer2 _L_HBoxContainer2;

        /// <summary>
        /// 节点路径: Setting.CenterContainer.HBoxContainer3
        /// </summary>
        public HBoxContainer3 L_HBoxContainer3
        {
            get
            {
                if (_L_HBoxContainer3 == null) _L_HBoxContainer3 = new HBoxContainer3(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer3"));
                return _L_HBoxContainer3;
            }
        }
        private HBoxContainer3 _L_HBoxContainer3;

        /// <summary>
        /// 节点路径: Setting.CenterContainer.Apply
        /// </summary>
        public Apply L_Apply
        {
            get
            {
                if (_L_Apply == null) _L_Apply = new Apply(UiPanel, Instance.GetNode<Godot.Button>("Apply"));
                return _L_Apply;
            }
        }
        private Apply _L_Apply;

        public VBoxContainer(SettingPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Setting.CenterContainer
    /// </summary>
    public class CenterContainer : UiNode<SettingPanel, Godot.CenterContainer, CenterContainer>
    {
        /// <summary>
        /// 节点路径: Setting.VBoxContainer
        /// </summary>
        public VBoxContainer L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer _L_VBoxContainer;

        public CenterContainer(SettingPanel uiPanel, Godot.CenterContainer node) : base(uiPanel, node) {  }
        public override CenterContainer Clone() => new (UiPanel, (Godot.CenterContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.Back
    /// </summary>
    public Back S_Back => L_Back;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer.Setting1Name
    /// </summary>
    public Setting1Name S_Setting1Name => L_CenterContainer.L_VBoxContainer.L_HBoxContainer.L_Setting1Name;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer.SettingValue1
    /// </summary>
    public SettingValue1 S_SettingValue1 => L_CenterContainer.L_VBoxContainer.L_HBoxContainer.L_SettingValue1;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_CenterContainer.L_VBoxContainer.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer2.Setting2Name
    /// </summary>
    public Setting2Name S_Setting2Name => L_CenterContainer.L_VBoxContainer.L_HBoxContainer2.L_Setting2Name;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer2.SettingValue2
    /// </summary>
    public SettingValue2 S_SettingValue2 => L_CenterContainer.L_VBoxContainer.L_HBoxContainer2.L_SettingValue2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer2
    /// </summary>
    public HBoxContainer2 S_HBoxContainer2 => L_CenterContainer.L_VBoxContainer.L_HBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer3.Setting3Name
    /// </summary>
    public Setting3Name S_Setting3Name => L_CenterContainer.L_VBoxContainer.L_HBoxContainer3.L_Setting3Name;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer3.SettingValue3
    /// </summary>
    public SettingValue3 S_SettingValue3 => L_CenterContainer.L_VBoxContainer.L_HBoxContainer3.L_SettingValue3;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.HBoxContainer3
    /// </summary>
    public HBoxContainer3 S_HBoxContainer3 => L_CenterContainer.L_VBoxContainer.L_HBoxContainer3;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer.Apply
    /// </summary>
    public Apply S_Apply => L_CenterContainer.L_VBoxContainer.L_Apply;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_CenterContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Setting.CenterContainer
    /// </summary>
    public CenterContainer S_CenterContainer => L_CenterContainer;

}
