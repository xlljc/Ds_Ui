using DsUi;
using Godot;
using UI.aa.BB.Cc;

namespace UI.aa.Baba.Aaa;

public partial class AaaPanel : Aaa
{

    public override void OnCreateUi()
    {
        S_Cc.Instance.L_Label.Instance.Text += "++++";
        
        var t = CreateTween();
        t.TweenInterval(1d);
        t.TweenCallback(Callable.From(() =>
        {
            S_Control.OpenNestedUi<CcPanel>(UiManager.UiName.Aa_BB_Cc).Index = 1;
        }));
    }

    public override void OnDestroyUi()
    {
        GD.Print("OnDestroyUi: AaaPanel");
    }

}
