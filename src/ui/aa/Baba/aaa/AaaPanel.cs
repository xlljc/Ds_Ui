using Godot;

namespace UI.aa.Baba.Aaa;

public partial class AaaPanel : Aaa
{

    public override void OnCreateUi()
    {
        S_Cc.L_Label.Instance.Text += "++++";
    }

    public override void OnDestroyUi()
    {
        
    }

}
