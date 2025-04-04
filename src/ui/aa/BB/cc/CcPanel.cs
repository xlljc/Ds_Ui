using Godot;

namespace UI.aa.BB.Cc;

public partial class CcPanel : Cc
{

    public int Index = 0;
    public override void OnCreateUi()
    {
        GD.Print("OnCreateUi: CcPanel " + Index);
    }

    public override void OnDestroyUi()
    {
        GD.Print("OnDestroyUi: CcPanel " + Index);
    }

}
